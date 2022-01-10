using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LXYYY.RootDTO
{
    public class UserRoleInfoShowDTO : AuditedEntityDto<int>
    {
        public int UserId { get; set; }//用户id
        public int RoleId { get; set; }//角色id
        public Guid? UserGUID { get; set; }//用户guid
        public Guid? RoleGUID { get; set; }//角色guid
        public DateTime UserRoleTime { get; set; } = DateTime.Now;//创建时间
        public string UserRolePerple { get; set; }//创建人
    }
}
