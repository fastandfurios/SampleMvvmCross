using System.Windows.Input;
using Xamarin.Forms;

namespace TestMvvmCross.Graphic
{
	public class GradientButton : Frame
	{

		public GradientButton()
		{
			CornerRadius = 25;
			HeightRequest = 50;
			WidthRequest = 300;
			HorizontalOptions = LayoutOptions.Center;
			IsClippedToBounds = true;
			Padding = 0;
			var button = new Button();
			Content = new Grid
			{
				Children = { new Rectangle() },
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
		}
	}
}
