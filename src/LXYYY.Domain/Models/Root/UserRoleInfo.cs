using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXYYY.Models.Root
{
    public class UserRoleInfo : Volo.Abp.Domain.Entities.BasicAggregateRoot<int>//用户角色表
    {
        public int UserId { get; set; }//用户id
        public int RoleId { get; set; }//角色id
        public Guid? UserGUID { get; set; }//用户guid
        public Guid? RoleGUID { get; set; }//角色guid
        public DateTime UserRoleTime { get; set; } = DateTime.Now;//创建时间
        public string UserRolePerple { get; set; }//创建人
    }
}
