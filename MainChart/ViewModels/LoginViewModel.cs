using MainChart.DataModels;
using MainChart.Security;
using MainChart.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace MainChart.ViewModels;

public class LoginViewModel:BaseViewModel
{

    #region Public Properties

    public string Email { get; set; }

    public bool LoginIsRunning { get; set; }

    #endregion

    #region Commands
    public ICommand LoginCommand { get; set; }
    public ICommand RegisterCommand { get; set; }

    #endregion

    #region Constructors

    public LoginViewModel()
    {

        LoginCommand = new RelayParameterizedCommand(async (parameter) => await LoginAsync(parameter));
        RegisterCommand = new RelayCommand(async () => await RegisterAsync());

    }
    #endregion

    public async Task LoginAsync(object parameter)
    {

        await RunCommand(() => this.LoginIsRunning, async () =>
        {
            await Task.Delay(1000);

            var email = this.Email;

            // never store unsecure password in a variable like this
            var pass = (parameter as IHavePassword).SecurePassword.Unsecure();

        });
    }
    public async Task RegisterAsync()
    {
        // Go to register page
        ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.RegisterPage;
        await Task.Delay(1000);
    }
}