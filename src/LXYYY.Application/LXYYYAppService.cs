using System;
using System.Collections.Generic;
using System.Text;
using LXYYY.Localization;
using Volo.Abp.Application.Services;

namespace LXYYY
{
    /* Inherit your application services from this class.
     */
    public abstract class LXYYYAppService : ApplicationService
    {
        protected LXYYYAppService()
        {
            LocalizationResource = typeof(LXYYYResource);
        }
    }
}
