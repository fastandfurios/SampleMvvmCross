using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace TestMvvmCross.ViewModels
{
	public class ThreeViewModel : MvxNavigationViewModel
	{
		public ThreeViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService)
			: base(logProvider, navigationService)
		{
		}
	}
}
