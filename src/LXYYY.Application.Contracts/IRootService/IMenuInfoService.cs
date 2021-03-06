using LXYYY.RootDTO;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace LXYYY.IRootService
{
    public interface IMenuInfoService : ICrudAppService<MenuInfoShowDTO, int, PagedAndSortedResultRequestDto, MenuInfoAddDTO>
    {
    }
}
