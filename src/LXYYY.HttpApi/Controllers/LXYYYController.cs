using LXYYY.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LXYYY.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class LXYYYController : AbpController
    {
        protected LXYYYController()
        {
            LocalizationResource = typeof(LXYYYResource);
        }
    }
}