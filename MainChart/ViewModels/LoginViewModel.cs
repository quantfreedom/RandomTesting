using MainChart.Security;
using MainChart.ViewModels.Base;
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

    #endregion

    #region Constructors

    public LoginViewModel()
    {

        LoginCommand = new RelayParameterizedCommand(async (parameter) => await Login(parameter));

    }
    #endregion

    public async Task Login(object parameter)
    {

        await RunCommand(() => this.LoginIsRunning, async () =>
        {
            await Task.Delay(500);

            var email = this.Email;

            var pass = (parameter as IHavePassword).SecurePassword.Unsecure();

        });
    }
}