using LXYYY.EntityFrameworkCore;
using LXYYY.IRootService;
using LXYYY.JWT;
using LXYYY.Models.Root;
using LXYYY.RootDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace LXYYY.RootService
{
    public class RbacService : ApplicationService, IRbacService
    {
        private readonly LXYYYDbContext pp;
        private readonly IRepository<MenuInfo, int> _menuInfos; 
        private readonly IRepository<UserInfo, int> _UserInfos;
        public RbacService(IRepository<MenuInfo, int> menuInfos, LXYYYDbContext _pp, IRepository<UserInfo, int> UserInfos)
        {
            _menuInfos = menuInfos;
            _UserInfos = UserInfos;
            pp = _pp;
        }
        //菜单
        public  List<CreateMenuView> MenuShoow(int pid)
        {
            var list = pp.MenuInfo.ToList();
            return DiGui(list, pid);
        }
        private List<CreateMenuView> DiGui(List<MenuInfo> powers, int id)
        {
            var list = pp.MenuInfo.ToList();
            var _list = list.Where(x => x.PId == id).ToList();
            List<CreateMenuView> menuDTO = new List<CreateMenuView>();
            _list.ForEach(x =>
            {

                menuDTO.Add(new CreateMenuView()
                {
                    Id = x.Id.ToString(),
                    PId = x.PId,
                    MenuName = x.MenuName,
                    MenuCreateTime = x.MenuCreateTime,
                    MenuGUID = x.MenuGUID,
                    MenuStata = x.MenuStata,
                    MenuPerple = x.MenuPerple,
                    CreateMenu = DiGui(powers, x.Id)
                });
            });
            return menuDTO;
        }
        //private async List<CreateMenuView> GetMenuTree(List<MenuInfo> menuInfos, int pid)
        //{
        //    var menulist = await _menuInfos.GetListAsync();
        //    menulist = menulist.Where(x => x.PId == pid).ToList();
        //    List<CreateMenuView> tree = new List<CreateMenuView>();
        //    menulist.ForEach( x =>
        //    {
        //        CreateMenuView menuView = new CreateMenuView();
        //        menuView.PId = x.PId;
        //        menuView.Id = x.Id.ToString();
        //        menuView.MenuName = x.MenuName;
        //        menuView.MenuStata = x.MenuStata;
        //        menuView.MenuGUID = x.MenuGUID;
        //        menuView.CreateMenu =  GetMenuTree(menuInfos,x.Id);
        //        tree.Add(menuView);
        //    });
        //    return tree;
        //}
        /// <summary>
        /// 角色分配权限
        /// </summary>
        /// <param name="rid"></param>
        /// <param name="mid"></param>
        /// <returns></returns>
        public string RoleMenF(int rid, string mid)
        {
            var list = pp.RoleMenuInfo.ToList().Where(x => x.RoleId == rid).ToList();
            var spid = mid.Split(',');
            List<RoleMenuInfoShowDTO> rps = new List<RoleMenuInfoShowDTO>();
            spid.ToList().ForEach(x =>
            {
                rps.Add(new RoleMenuInfoShowDTO()
                {
                    RoleId = rid,
                    MenuId = Convert.ToInt32(x)
                });
            });
            var s= pp.SaveChanges();
            if (s>0)
            {
                return s.ToString();
            }
            else
            {
                return s.ToString();
            }
        }
        /// <summary>
        /// 用户分配角色
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="rid"></param>
        /// <returns></returns>
        public string UserRoleF(int uid, string rid)
        {
            var list = pp.UserRoleInfo.ToList().Where(x => x.UserId == uid).ToList();
            var spid = rid.Split(',');
            List<UserRoleInfoShowDTO> rps = new List<UserRoleInfoShowDTO>();
            spid.ToList().ForEach(x =>
            {
                rps.Add(new UserRoleInfoShowDTO()
                {
                    UserId = uid,
                    RoleId = Convert.ToInt32(x)
                });
            });
            var s = pp.SaveChanges();
            if (s > 0)
            {
                return s.ToString();
            }
            else
            {
                return s.ToString();
            }
        }
        //登录
        public async Task<TokenDto> UserLogin(UserLoginDTO userLoginDTO)
        {
            var slist = await _UserInfos.GetListAsync();
            var list = slist.Where(x => x.LoginName == userLoginDTO.UserName && x.LoginPwd == userLoginDTO.UserPwd).FirstOrDefault();
            if (list != null)
            {
                return new TokenDto
                {
                    Msg = "成功",
                    state = true,
                    token = JWT.JwtToten.CreateToken(userLoginDTO.UserName)
                };
            }
            else
            {
                return new TokenDto { Msg = "失败", state = false };
            }
        }
    }
}
