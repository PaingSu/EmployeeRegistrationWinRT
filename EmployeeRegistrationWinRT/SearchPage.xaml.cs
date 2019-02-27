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
    public sealed partial class SearchPage : Page
    {
        public SearchPage()
        {
            this.InitializeComponent();
        }

        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                return Name;
            }
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void btnResetAll_Click(object sender, RoutedEventArgs e)
        {
            txtName.Text = "";
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string Name = txtName.Text.ToString();
            for (int i = 0; i < StoreData.EName.Length; i++)
            {
                if (StoreData.EName[i] == Name)
                {
                    txtResult.Text = StoreData.EName[i] + "," + StoreData.Nrc[i] + "," + StoreData.Gender[i] + "," + StoreData.Department[i] + "," + StoreData.Team[i] + "," + StoreData.Position[i] + "," + StoreData.Phone[i] + "," + StoreData.Address[i] + "," + StoreData.Salary[i];
                }
                else
                    txtResult.Text = " ";
            }
        }
    }
}
