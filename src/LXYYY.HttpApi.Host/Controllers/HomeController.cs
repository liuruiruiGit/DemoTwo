using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Mail;
using Volo.Abp.AspNetCore.Mvc;

namespace LXYYY.Controllers
{
    public class HomeController : AbpController
    {
        public ActionResult Index()
        {
            return Redirect("~/swagger");
        }
        [HttpPost, Route("wh/Email")]
        public ActionResult Email()
        {
            //要发送邮箱的地址
            MailMessage msg = new MailMessage();
            msg.To.Add("2691980190@qq.com");

            msg.From = new MailAddress("525806383@qq.com", "QQ官方", System.Text.Encoding.UTF8);

            msg.Subject = "QQ官方：您的账号密码已被更改";//邮件标题 
            msg.SubjectEncoding = System.Text.Encoding.UTF8;//邮件标题编码 
            msg.Body = "您的账号密码已被更改，请前往  https://user.qzone.qq.com/2691980190?source=aiostar  进行更改";//邮件内容 
            msg.BodyEncoding = System.Text.Encoding.UTF8;//邮件内容编码 
            msg.IsBodyHtml = false;//是否是HTML邮件 
            msg.Priority = MailPriority.High;//邮件优先级

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("525806383@qq.com", "kfjqwerorfljbhjh");
            //注册的邮箱和密码 
            client.Host = "smtp.qq.com";
            object userState = msg;
            try
            {
                client.SendAsync(msg, userState);
                return Ok("发送成功");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Ok("发送失败");
            }

        }
    }
}
