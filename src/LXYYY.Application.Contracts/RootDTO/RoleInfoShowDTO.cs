using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LXYYY.RootDTO
{
    public class RoleInfoShowDTO : AuditedEntityDto<int>
    {
        public Guid RoleGUID { get; set; }//guid
        public string RoleName { get; set; }//角色名称
        public string RoleMessage { get; set; }//角色介绍
        public bool RoleStata { get; set; } = false;//角色状态  false 不可用 true禁用  
        public string RoleCreatePerple { get; set; }//创建人
        public DateTime RoleCreateTime { get; set; } = DateTime.Now;//创建时间
    }
}
