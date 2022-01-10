using AutoMapper;
using LXYYY.Models.Root;
using LXYYY.RootDTO;

namespace LXYYY
{
    public class LXYYYApplicationAutoMapperProfile : Profile
    {
        public LXYYYApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<MenuInfo, MenuInfoShowDTO>();
            CreateMap<MenuInfoAddDTO,MenuInfo>();

            CreateMap<RoleInfo, RoleInfoShowDTO>();
            CreateMap<RoleInfoAddDTO,RoleInfo>();

            CreateMap<RoleMenuInfo, RoleMenuInfoShowDTO>();
            CreateMap<RoleMenuInfoAddDTO,RoleMenuInfo>();

            CreateMap<SysLog, SysLogShowDTO>();
            CreateMap<SysLogAddDTO,SysLog>();

            CreateMap<UserInfo, UserInfoShowDTO>();
            CreateMap<UserInfoAddDTO,UserInfo>();

            CreateMap<UserRoleInfo, UserRoleInfoShowDTO>();
            CreateMap<UserRoleInfoAddDTO,UserRoleInfo>();
        }
    }
}
