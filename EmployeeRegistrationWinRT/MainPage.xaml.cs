using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace EmployeeRegistrationWinRT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        static public string[] username = { "Moon", "Ruby" };
        static public string[] password = { "123", "1234" };
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Register));
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SearchPage));
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string UserName = txtUserName.Text;
            string Pass = txtPassword.Text;
            if (UserName == username[0])
            {
                if(Pass == password[0])
                {
                    this.Frame.Navigate(typeof(LoginPage));
                }
            }
            else if (UserName == username[1])
            {
                if (Pass == password[1])
                {
                    this.Frame.Navigate(typeof(LoginPage));
                }
            }
            else { }
        }
    }
}
