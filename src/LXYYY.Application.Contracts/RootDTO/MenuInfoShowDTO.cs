using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LXYYY.RootDTO
{
   public class MenuInfoShowDTO : AuditedEntityDto<int>
    {
        public Guid MenuGUID { get; set; }//guid
        public string MenuName { get; set; }//菜单名称
        public bool MenuStata { get; set; } = false;//菜单状态
        public string LikeType { get; set; }//样式类型----
        public int PId { get; set; }//上级编号
        public DateTime MenuCreateTime { get; set; } = DateTime.Now;//创建时间
        public string MenuPerple { get; set; }//创建人
    }
}
