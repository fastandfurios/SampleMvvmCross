using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace TestMvvmCross.Graphic
{
	public class NewRectangle : SKCanvasView
	{
		public NewRectangle()
		{
			PaintSurface += NewRectangle_PaintSurface;
		}

		private void NewRectangle_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
		{
			SKImageInfo info = e.Info;
			SKSurface surface = e.Surface;
			SKCanvas canvas = surface.Canvas;

			canvas.Clear();

			using (var paint = new SKPaint())
			{
				paint.Shader = SKShader.CreateLinearGradient(
					new SKPoint(0,0),
					new SKPoint(info.Width, info.Height),
					new SKColor[]
					{
						new SKColor(0,0,0, 51),
						new SKColor(0,0,0,51),
						new SKColor(160,150,142,153), 
					},
					null,
					SKShaderTileMode.Mirror);

				canvas.DrawRect(info.Rect, paint);
			}
		}
	}
}
