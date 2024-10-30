using MainChart.DataModels;
using MainChart.Pages;
using System.Globalization;

namespace MainChart.ValueConverters;

public class ApplicationPageValueConverter:BaseValueConverter<ApplicationPageValueConverter>
{
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        switch ((ApplicationPage)value)
        {
            case ApplicationPage.LoginPage:
                return new LoginPage();
            case ApplicationPage.MainChartPage:
                return new MainChartPage();
            case ApplicationPage.ChatPage:
                return new ChatPage();
            default:
                return new LoginPage();
        }
    }

    public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}