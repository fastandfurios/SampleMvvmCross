using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace TestMvvmCross.ViewModels
{
	public class MainViewModel : MvxNavigationViewModel
	{
		private MvxCommand _openSubPageCommand;
		private MvxCommand _openThreePageCommand;

		public MainViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService)
			: base(logProvider, navigationService)
		{
		}

		public IMvxCommand OpenSubPageCommand
		{
			get
			{
				_openSubPageCommand = _openSubPageCommand ??
									  new MvxCommand(() =>
									  {
										  NavigationService.Navigate<SubViewModel>();
									  });
				return _openSubPageCommand;
			}
		}

		public IMvxCommand OpenThreePageCommand
		{
			get
			{
				_openThreePageCommand = _openThreePageCommand ??
									  new MvxCommand(() =>
									  {
										  NavigationService.Navigate<ThreeViewModel>();
									  });
				return _openThreePageCommand;
			}
		}
	}
}
