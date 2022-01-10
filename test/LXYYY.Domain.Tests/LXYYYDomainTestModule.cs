using LXYYY.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LXYYY
{
    [DependsOn(
        typeof(LXYYYEntityFrameworkCoreTestModule)
        )]
    public class LXYYYDomainTestModule : AbpModule
    {

    }
}