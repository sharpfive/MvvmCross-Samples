using Foundation;
using XPlatformMenus.Core.ViewModels;
using MvvmCross.iOS.Support.XamarinSidebar;

namespace XPlatformMenus.Touch.Views
{
    [Register("MainView")]
	[MvxSidebarPresentation(MvxPanelEnum.Center, MvxPanelHintType.ResetRoot, true)]
    public class MainView : BaseViewController<MainViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ViewModel.ShowMenu();
        }
    }   
}