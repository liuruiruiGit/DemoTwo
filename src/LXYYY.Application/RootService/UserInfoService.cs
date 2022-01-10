using LXYYY.IRootService;
using LXYYY.Models.Root;
using LXYYY.RootDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace LXYYY.RootService
{
   public class UserInfoService : CrudAppService<UserInfo, UserInfoShowDTO, int, PagedAndSortedResultRequestDto, UserInfoAddDTO>, IUserInfoService
    {
        public UserInfoService(IRepository<UserInfo,int> userInfos):base(userInfos)
        {

        }
    }
}
