using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LXYYY.RootDTO
{
    public class UserInfoShowDTO : AuditedEntityDto<int>
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
