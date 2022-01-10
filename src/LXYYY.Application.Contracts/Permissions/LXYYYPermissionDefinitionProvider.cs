using LXYYY.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LXYYY.Permissions
{
    public class LXYYYPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(LXYYYPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(LXYYYPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<LXYYYResource>(name);
        }
    }
}
