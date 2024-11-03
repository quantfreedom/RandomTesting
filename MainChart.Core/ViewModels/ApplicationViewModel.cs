using MainChart.Core.DataModels;
using MainChart.Core.ViewModels.Base;

namespace MainChart.Core.ViewModels;

public class ApplicationViewModel:BaseViewModel
{
    public ApplicationPage CurrentPage { get; set; } = ApplicationPage.LoginPage;

}