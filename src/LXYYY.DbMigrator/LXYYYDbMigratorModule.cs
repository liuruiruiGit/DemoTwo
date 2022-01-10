using LXYYY.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace LXYYY.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(LXYYYEntityFrameworkCoreModule),
        typeof(LXYYYApplicationContractsModule)
        )]
    public class LXYYYDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
