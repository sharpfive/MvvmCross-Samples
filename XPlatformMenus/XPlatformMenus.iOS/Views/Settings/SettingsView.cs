using Foundation;
using XPlatformMenus.Core.ViewModels;
using MvvmCross.iOS.Support.XamarinSidebar;

namespace XPlatformMenus.Touch.Views
{
    [Register("SettingsView")]
	[MvxSidebarPresentation(MvxPanelEnum.Center, MvxPanelHintType.ResetRoot, true)]
    public class SettingsView : BaseViewController<SettingsViewModel>
    {
        public override void ViewWillAppear(bool animated)
        {
            Title = "Settings View";
            base.ViewWillAppear(animated);
        }
    }
}
