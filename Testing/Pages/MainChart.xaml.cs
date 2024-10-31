using ScottPlot;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Testing.ViewModel;

namespace Testing.Pages;
/// <summary>
/// Interaction logic for MainChart.xaml
/// </summary>
public partial class MainChart:Page
{
    public MainChart()
    {
        InitializeComponent();
        var modalWindow = new ModalWindowViewModel();
        this.DataContext = modalWindow;
        GenerateChart();
        CustomModalDialog.MouseDown += (s, e) =>
        {
            var mousePosition = Mouse.GetPosition(CustomModalDialog);
            var windowX = CustomModalDialog.ActualWidth + mousePosition.X;
            var windowY = CustomModalDialog.ActualHeight + mousePosition.Y;

            if (modalWindow.ModalVisible == true)
            {
                
            }

        };
    }

    private void GenerateChart()
    {
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
