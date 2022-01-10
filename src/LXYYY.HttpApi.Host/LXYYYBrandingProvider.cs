using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace LXYYY
{
    [Dependency(ReplaceServices = true)]
    public class LXYYYBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "LXYYY";
    }
}
