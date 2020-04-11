using MvvmCross.Forms.Views;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using TestMvvmCross.Graphic;
using TestMvvmCross.ViewModels;
using Xamarin.Forms.Xaml;

namespace TestMvvmCross.Core.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SubPage : MvxContentPage<SubViewModel>
	{
		public SubPage()
		{
			InitializeComponent();
		}
	}
}