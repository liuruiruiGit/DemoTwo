using System;
using System.Collections.Generic;
using System.Text;

namespace LXYYY.RootDTO
{
    public class SysLogAddDTO
    {
        public Guid LogGUID { get; set; }//guid
        public string Content { get; set; }//日志内容
        public string TypeName { get; set; }//分类名称
        public int TypeId { get; set; }//分类id
        public string Href { get; set; }//操作所属模块地址
        public DateTime CreateTime { get; set; }//记录时间
        public int CreateId { get; set; }//操作人id
        public string CreateName { get; set; }//操作人
        public string Ip { get; set; }//IP地址
        public int Result { get; set; }//操作结果
        public string Application { get; set; }//所属应用
    }
}
