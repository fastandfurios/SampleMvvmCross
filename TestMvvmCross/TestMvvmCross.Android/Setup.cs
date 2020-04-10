using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.ViewModels;
using Application = Xamarin.Forms.Application;

namespace TestMvvmCross.Droid
{
	public class Setup : MvxFormsAndroidSetup<CoreApp, App>
	{
		protected override IMvxApplication CreateApp() => new CoreApp();

		protected override Application CreateFormsApplication() => new App();
	}
}