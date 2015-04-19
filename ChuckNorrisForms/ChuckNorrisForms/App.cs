using System;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.Xamarin.Forms;
using Xamarin.Forms;

namespace ChuckNorrisForms
{
    public class App : Application
    {
        public App()
        {
            MainPage = GetTabbedPage();
        }

        public static Page GetTabbedPage()
        {
            return new TabbedPage()
            {
                Children = { GetQuotePage(), GetGraphPage() }
            };
        }

        public static Page GetQuotePage()
        {
            return new QuotePage();
        }

        public static Page GetGraphPage()
        {
            var plotModel = new PlotModel
            {
                Title = "Chuck Norris Performance",
                Subtitle = "",
                PlotType = PlotType.Cartesian,
                Background = OxyColors.White,
            };

            plotModel.Series.Add(new FunctionSeries(Math.Log, -10, 10, 0.1) {Color = OxyColors.Green});

            var xAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Years",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.None,
            };

            plotModel.Axes.Add(xAxis);

            var yAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Kicks per Second",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.None,
            };

            plotModel.Axes.Add(yAxis);

            return new ContentPage()
            {
                Title = "Graph Page",
                Content = new PlotView()
                {
                    Model = plotModel,
                    VerticalOptions = LayoutOptions.Fill,
                    HorizontalOptions = LayoutOptions.Fill
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
