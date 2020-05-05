using Microcharts;
using MvvmCross.Forms.Views;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using TestMvvmCross.Graphic;
using TestMvvmCross.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.Entry;

namespace TestMvvmCross.Core.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SubPage : MvxContentPage<SubViewModel>
	{
		public SubPage()
		{
			InitializeComponent();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var entriesColumn1 = new[]
            {
                new Entry(30)
                {
                    Color = SKColor.Parse("#cc2084")
                },
                new Entry(19)
                {
                    Color = SKColor.Parse("#482d86")
                }
            };
            var entriesColumn2 = new[]
            {
                new Entry(50)
                {
                    Color = SKColor.Parse("#cc2084")
                },
                new Entry(63)
                {
                    Color = SKColor.Parse("#482d86")
                }
            };
            var entriesColumn3 = new[]
            {
                new Entry(75)
                {
                    Color = SKColor.Parse("#cc2084")
                },
                 new Entry(84)
                {
                    Color = SKColor.Parse("#482d86")
                }
            };
            var entriesColumn4 = new[]
            {
                new Entry(81)
                {
                    Color = SKColor.Parse("#cc2084")
                },
                new Entry(97)
                {
                    Color = SKColor.Parse("#482d86")
                }
            };
            var entriesColumn5 = new[]
            {

                new Entry(77)
                {
                    Color = SKColor.Parse("#cc2084")
                },
                new Entry(69)
                {
                    Color = SKColor.Parse("#482d86")
                }
            };
            var entriesColumn6 = new []
            {
                new Entry(59)
                {
                    Color = SKColor.Parse("#cc2084")
                },
                new Entry(42)
                {
                    Color = SKColor.Parse("#482d86")
                }
            };
            var chart1 = new BarChart
            {
                Entries = entriesColumn1,
                BackgroundColor = SKColor.Empty,
                Margin = 0,
                MaxValue = 100,
                MinValue = 0
            };
            var chart2 = new BarChart
            {
                Entries = entriesColumn2,
                BackgroundColor = SKColor.Empty,
                Margin = 0,
                MaxValue = 100,
                MinValue = 0
            };
            var chart3 = new BarChart
            {
                Entries = entriesColumn3,
                BackgroundColor = SKColor.Empty,
                Margin = 0,
                MaxValue = 100,
                MinValue = 0
            };
            var chart4 = new BarChart
            {
                Entries = entriesColumn4,
                BackgroundColor = SKColor.Empty,
                Margin = 0,
                MaxValue = 100,
                MinValue = 0
            };
            var chart5 = new BarChart
            {
                Entries = entriesColumn5,
                BackgroundColor = SKColor.Empty,
                Margin = 0,
                MaxValue = 100,
                MinValue = 0
            };

            var chart6 = new BarChart
            {
                Entries = entriesColumn6,
                BackgroundColor = SKColor.Empty,
                Margin = 0,
                MaxValue = 100,
                MinValue = 0
            };

            this.chartView1.Chart = chart1;
            this.chartView2.Chart = chart2;
            this.chartView3.Chart = chart3;
            this.chartView4.Chart = chart4;
            this.chartView5.Chart = chart5;
            this.chartView6.Chart = chart6;

            var cirleDiagramm = new[]
            {
                new Entry(80)
                {
                    Color = SKColor.Parse("#482d86")
                },
                new Entry(8)
                {
                    Color = SKColor.Parse("#cc2084")
                },
                new Entry(8)
                {
                    Color = SKColor.Parse("#f28f25")
                },
                new Entry(4)
                {
                    Color = SKColor.Parse("#26921d")
                }
            };

            var chartCircle = new DonutChart
            {
                MaxValue = 100,
                MinValue = 0,
                Entries = cirleDiagramm,
                HoleRadius = 0.3f,
                BackgroundColor = SKColor.Empty
            };

            this.chartCircle.Chart = chartCircle;
        }
    }
} 