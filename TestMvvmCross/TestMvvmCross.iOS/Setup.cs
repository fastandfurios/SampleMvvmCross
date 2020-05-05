using System;
using MvvmCross.Forms.Platforms.Ios.Core;
using MvvmCross.ViewModels;

namespace TestMvvmCross.iOS
{
    public class Setup : MvxFormsIosSetup<CoreApp, App>
    {
        protected override IMvxApplication CreateApp() => new CoreApp();

        protected override Xamarin.Forms.Application CreateFormsApplication() => new App();
    }
}
