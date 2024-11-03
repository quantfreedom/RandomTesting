﻿using MainChart.ViewModels;
using MainChart.ViewModels.Base;
using System.Security;

namespace MainChart.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class RegisterPage:BasePage<LoginViewModel>, IHavePassword
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        public SecureString SecurePassword => PasswordText.SecurePassword;

        
    }
}
