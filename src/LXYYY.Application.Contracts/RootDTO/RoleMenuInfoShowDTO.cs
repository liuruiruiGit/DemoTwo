using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LXYYY.RootDTO
{
    public class RoleMenuInfoShowDTO : AuditedEntityDto<int>
    {
        public int RoleId { get; set; }//角色id
        public int MenuId { get; set; }//菜单id
        public Guid? RoleGUID { get; set; }//角色guid
        public Guid? MenuGUID { get; set; }//用户guid
        public DateTime RoleMenuTime { get; set; } = DateTime.Now;//创建时间
        public string RoleMenuPerple { get; set; }//创建人
    }
}
