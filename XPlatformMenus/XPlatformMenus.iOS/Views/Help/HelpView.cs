using Foundation;
using XPlatformMenus.Core.ViewModels;
using MvvmCross.iOS.Support.XamarinSidebar;

namespace XPlatformMenus.Touch.Views
{
    [Register("HelpView")]
    [MvxSidebarPresentation(MvxPanelEnum.Center, MvxPanelHintType.ResetRoot, true)]
    public class HelpView : BaseViewController<HelpAndFeedbackViewModel>
    {
        public override void ViewWillAppear(bool animated)
        {
            Title = "Help View";
            base.ViewWillAppear(animated);
        }
    }
}
