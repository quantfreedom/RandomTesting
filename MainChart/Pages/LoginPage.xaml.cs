using MainChart.ViewModels;
using MainChart.ViewModels.Base;
using System.Security;

namespace MainChart.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage:BasePage<LoginViewModel>, IHavePassword
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public SecureString SecurePassword => PasswordText.SecurePassword;

        
    }
}
