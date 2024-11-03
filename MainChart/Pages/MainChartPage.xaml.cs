using MainChart.Core.ViewModels;
using ScottPlot;

namespace MainChart.Pages
{
    /// <summary>
    /// Interaction logic for MainChartPage.xaml
    /// </summary>
    public partial class MainChartPage:BasePage<MainChartPageViewModel>
    {
        public MainChartPage()
        {
            InitializeComponent();
            DateTime timeOpen = new(1985, 09, 24, 9, 30, 0); // 9:30 AM
            DateTime timeClose = new(1985, 09, 24, 16, 0, 0); // 4:00 PM
            TimeSpan timeSpan = TimeSpan.FromMinutes(10); // 10 minute bins

            List<OHLC> prices = new();
            for (DateTime dt = timeOpen; dt <= timeClose; dt += timeSpan)
            {
                double open = Generate.RandomNumber(20, 40) + prices.Count;
                double close = Generate.RandomNumber(20, 40) + prices.Count;
                double high = Math.Max(open, close) + Generate.RandomNumber(5);
                double low = Math.Min(open, close) - Generate.RandomNumber(5);
                prices.Add(new OHLC(open, high, low, close, dt, timeSpan));
            }

            var candles = WpfPlot1.Plot.Add.Candlestick(prices);
            candles.Axes.YAxis = WpfPlot1.Plot.Axes.Right;
            WpfPlot1.Plot.Axes.DateTimeTicksBottom();
            WpfPlot1.Refresh();
        }
    }
}
