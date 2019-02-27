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
    public sealed partial class Register : Page
    {

        public Register()
        {
            this.InitializeComponent();
            cboDept.Items.Add(new Item("IT", 1));
            cboDept.Items.Add(new Item("ICT", 2));

            cboTeam.Items.Add(new Item("Xuni", 1));
            cboTeam.Items.Add(new Item("Win Forms", 2));
            cboTeam.Items.Add(new Item("XAML", 3));
            cboTeam.Items.Add(new Item("Wijmo5", 4));
            cboTeam.Items.Add(new Item("Rhino", 5));
            cboTeam.Items.Add(new Item("IT-Admin", 6));
            cboTeam.Items.Add(new Item("C1-QA", 7));
            cboTeam.Items.Add(new Item("Traniee", 8));

            cboDept.SelectedIndex = 0;
            cboTeam.SelectedIndex = 0;
        }

        private class Item
        {
            public string cboName;
            public int Value;
            public Item(string name, int value)
            {
                cboName = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return cboName;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            StoreData.name = txtName.Text;
            StoreData.nrc = txtNrc.Text;
            StoreData.birthdate = dateTimeBD.Date.Day.ToString();
            if (radMale.IsChecked == true)
            {
                StoreData.gender = radMale.Content.ToString();
            }
            else
            {
                StoreData.gender = radFemale.Content.ToString();
            }
            StoreData.joindate = dateTimeJoinDate.DayFormat;
            StoreData.joinmonth = dateTimeJoinDate.MonthFormat;
            StoreData.joinyear = dateTimeJoinDate.YearFormat;
            StoreData.department = cboDept.Items[cboDept.SelectedIndex].ToString();
            StoreData.team = cboTeam.Items[cboTeam.SelectedIndex].ToString();
            StoreData.position = txtPosition.Text;
            StoreData.phone = txtPhno.Text;
            StoreData.address = txtAddress.Text;
            StoreData.salary = txtSalary.Text;

            StoreData.Add();
        }


        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }
    }
}