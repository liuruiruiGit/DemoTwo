using Volo.Abp.Modularity;

namespace LXYYY
{
    [DependsOn(
        typeof(LXYYYApplicationModule),
        typeof(LXYYYDomainTestModule)
        )]
    public class LXYYYApplicationTestModule : AbpModule
    {

    }
}