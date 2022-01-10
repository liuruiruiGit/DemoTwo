using LXYYY.RootDTO;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace LXYYY.IRootService
{
   public interface IRbacService: IApplicationService
    {
        public List<CreateMenuView> MenuShoow(int pid);//显示菜单
        //用户分配角色
        string UserRoleF(int uid, string rid);
        //角色分配权限
        string RoleMenF(int rid, string mid);
    }
}
