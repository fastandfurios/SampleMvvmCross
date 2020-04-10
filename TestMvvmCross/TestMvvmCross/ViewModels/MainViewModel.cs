using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace TestMvvmCross.ViewModels
{
	public class MainViewModel : MvxNavigationViewModel
	{
		private MvxCommand _openSubPageCommand;

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
	}
}
