using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace TestMvvmCross.Graphic
{
	public class Rectangle : SKCanvasView
	{
		public Rectangle()
		{
			PaintSurface += CanvasViewPaintSurface;
		}

		private void CanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
		{
			SKImageInfo info = e.Info;
			SKSurface surface = e.Surface;
			SKCanvas canvas = surface.Canvas;

			canvas.Clear();

			using (var paint = new SKPaint())
			{
				var rect = new SKRect(0,0,info.Width, info.Size.Height);

				paint.Shader = SKShader.CreateLinearGradient(
					new SKPoint(rect.Left, rect.MidY),
					new SKPoint(rect.Right, rect.MidY),
					new SKColor[] { SKColor.Parse("#ada49e"), SKColor.Parse("#7b726c") },
					new float[] { 0, 1 },
					SKShaderTileMode.Repeat);

				canvas.DrawRect(rect, paint);
			}
		}
	}
}
