using System.Threading.Tasks;

namespace LXYYY.Data
{
    public interface ILXYYYDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
