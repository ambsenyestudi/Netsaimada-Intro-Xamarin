using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace XamIntro.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExpenseChartView : ContentPage
	{
		public ExpenseChartView ()
		{
			InitializeComponent ();
		}
        private void OnPainting(object sender, SKPaintSurfaceEventArgs e)
        {
            // we get the current surface from the event args
            var surface = e.Surface;
            // then we get the canvas that we can draw on
            var canvas = surface.Canvas;
            // clear the canvas / view
            canvas.Clear(SKColors.White);
            // create the paint for the path
            DrawChartAxis(canvas);
            DrawFakeChart(canvas);
            DrawAscentionChart(canvas);
        }
        
        private void DrawChartAxis(SKCanvas canvas)
        {
            using (var paint = new SKPaint())
            {
                paint.IsAntialias = true;
                paint.Color = SKColors.Black;
                paint.StrokeWidth = 7;
                paint.Style = SKPaintStyle.Stroke;

                // create the Xamagon path
                using (var path = new SKPath())
                {
                    path.MoveTo(10, 150);
                    path.LineTo(10, 750);
                    path.LineTo(750, 750);
                    canvas.DrawPath(path, paint);
                }
            }
        }
        private void DrawFakeChart(SKCanvas canvas)
        {
            using (var paint = new SKPaint())
            {
                paint.IsAntialias = true;
                paint.Color = SKColors.Orange;
                paint.StrokeWidth = 5;
                paint.Style = SKPaintStyle.Stroke;

                // create the Xamagon path
                using (var path = new SKPath())
                {
                    path.MoveTo(50, 600);
                    path.LineTo(150, 400);
                    path.LineTo(250, 650);
                    path.LineTo(350, 300);
                    path.LineTo(550, 260);
                    canvas.DrawPath(path, paint);
                }
            }
        }
        private void DrawAscentionChart(SKCanvas canvas)
        {
            using (var paint = new SKPaint())
            {
                paint.IsAntialias = true;
                paint.Color = SKColors.Green;
                paint.StrokeWidth = 5;
                paint.Style = SKPaintStyle.Stroke;

                // create the Xamagon path
                using (var path = new SKPath())
                {
                    path.MoveTo(50, 740);
                    path.LineTo(150, 730);
                    path.LineTo(250, 700);
                    path.LineTo(350, 650);
                    path.LineTo(550, 400);
                    canvas.DrawPath(path, paint);
                }
            }
        }
    }
}