using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LXYYY.Data
{
    /* This is used if database provider does't define
     * ILXYYYDbSchemaMigrator implementation.
     */
    public class NullLXYYYDbSchemaMigrator : ILXYYYDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}