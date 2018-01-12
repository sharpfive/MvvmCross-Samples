using System;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace XPlatformMenus.Core.ViewModels
{
	public class HomeViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public HomeViewModel(IMvxNavigationService navigationService) 
        {
            Recycler = new RecyclerViewModel();
            _navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));
        }

        /// <summary>Gets the recycler.</summary>
        /// <value>The recycler.</value>
        public RecyclerViewModel Recycler { get; private set; }

	    public MvxCommand GoToInfoCommand
	    {            
	        get { return new MvxCommand(() => ShowViewModel<InfoViewModel>());}
	    }
    }
}