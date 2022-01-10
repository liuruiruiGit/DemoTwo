using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LXYYY.Data;
using Volo.Abp.DependencyInjection;

namespace LXYYY.EntityFrameworkCore
{
    public class EntityFrameworkCoreLXYYYDbSchemaMigrator
        : ILXYYYDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreLXYYYDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the LXYYYDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<LXYYYDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
