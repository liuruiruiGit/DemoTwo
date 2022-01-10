using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXYYY.Models.Root
{
    public class UserInfo : Volo.Abp.Domain.Entities.BasicAggregateRoot<int>//用户表
    {
        public Guid GuIdId { get; set; }//GUID
        public string UserName { get; set; }//用户名
        public string LoginName { get; set; }//登录名
        public string LoginPwd { get; set; }//密码
        public bool Sex { get; set; }//性别
        public bool UserStata { get; set; } = false;//用户状态
        public DateTime UserCreateTime { get; set; } = DateTime.Now;//创建注册时间
        public string KeyApp { get; set; }//访问APP
        public string Token { get; set; }//token
    }
}
