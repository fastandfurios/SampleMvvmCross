using MvvmCross.ViewModels;
using TestMvvmCross.ViewModels;

namespace TestMvvmCross
{
	public class CoreApp : MvxApplication
	{
		/// <summary>
		/// Any initialization steps that can be done in the background
		/// </summary>
		public override void Initialize()
		{
			RegisterAppStart<MainViewModel>();
		}
	}
}
