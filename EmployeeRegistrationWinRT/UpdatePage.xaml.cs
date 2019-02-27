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
    public sealed partial class UpdatePage : Page
    {
        public UpdatePage()
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
                // Generates the text shown in the combo box
                return Name;
            }
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtEName.Text = "";
            txtName.Text = "";
            txtNrc.Text = "";
            radMale.IsChecked = true;
            cboDept.SelectedIndex = 0;
            cboTeam.SelectedIndex = 0;
            txtPosition.Text = "";
            txtPhno.Text = "";
            txtAddress.Text = "";
            txtSalary.Text = "";
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string Name = txtEName.Text.ToString();
            for (int i = 0; i < StoreData.EName.Length; i++)
            {
                if (StoreData.EName[i] == Name)
                {
                    txtResultUp.Text = StoreData.EName[i] + "," + StoreData.Nrc[i] + "," + StoreData.BDDay[i] + "," + StoreData.Gender[i] + "," + StoreData.Department[i] + "," + StoreData.Team[i] + "," + StoreData.Position[i] + "," + StoreData.Phone[i] + "," + StoreData.Address[i] + "," + StoreData.Salary[i];
                    txtName.Text = StoreData.EName[i];
                    txtNrc.Text = StoreData.Nrc[i];
                    //dateTimeBD.Date. = StoreData.BDDay[i];
                    if (StoreData.Gender[i] == "Male")
                    {
                        radMale.IsChecked = true;
                    }
                    else
                    {
                        radFemale.IsChecked = true;
                    }
                    if (StoreData.Department[i] == "IT")
                    {
                        cboDept.SelectedIndex = 0;
                    }
                    else
                    {
                        cboDept.SelectedIndex = 1;
                    }
                    if (StoreData.Team[i] == "Xuni")
                    {
                        cboTeam.SelectedIndex = 0;
                    }
                    else if (StoreData.Team[i] == "Win Forms")
                    {
                        cboTeam.SelectedIndex = 1;
                    }
                    else if (StoreData.Team[i] == "XAML")
                    {
                        cboTeam.SelectedIndex = 2;
                    }
                    else if (StoreData.Team[i] == "Wijmo5")
                    {
                        cboTeam.SelectedIndex = 3;
                    }
                    else if (StoreData.Team[i] == "Rhino")
                    {
                        cboTeam.SelectedIndex = 4;
                    }
                    else if (StoreData.Team[i] == "IT-Admin")
                    {
                        cboTeam.SelectedIndex = 5;
                    }
                    else if (StoreData.Team[i] == "C1-QA")
                    {
                        cboTeam.SelectedIndex = 6;
                    }
                    else if (StoreData.Team[i] == "Trainee")
                    {
                        cboTeam.SelectedIndex = 7;
                    }
                    cboTeam.DataContext = StoreData.Team[i];
                    txtPosition.Text = StoreData.Position[i];
                    txtPhno.Text = StoreData.Phone[i];
                    txtAddress.Text = StoreData.Address[i];
                    txtSalary.Text = StoreData.Salary[i];
                }
                else
                {
                    txtResultUp.Text = " ";
                }
            }
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
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

            txtResultUp.Text = StoreData.name + "," + StoreData.nrc + "," + StoreData.birthdate + "," + StoreData.gender + "," + StoreData.department + "," + StoreData.team + "," + StoreData.position + "," + StoreData.phone + "," + StoreData.address + "," + StoreData.salary;
            for (int i = 0; i < StoreData.EName.Length; i++)
            {
                StoreData.EName[i] = StoreData.name;
                StoreData.Nrc[i] = StoreData.nrc;
                StoreData.Gender[i] = StoreData.gender;
                StoreData.Department[i] = StoreData.department;
                StoreData.Team[i] = StoreData.team;
                StoreData.Position[i] = StoreData.position;
                StoreData.Phone[i] = StoreData.phone;
                StoreData.Address[i] = StoreData.address;
                StoreData.Salary[i] = StoreData.salary;
            }
            txtName.Text = "";
            txtNrc.Text = "";
            radMale.IsChecked = true;
            cboDept.SelectedIndex = 0;
            cboTeam.SelectedIndex = 0;
            txtPosition.Text = "";
            txtPhno.Text = "";
            txtAddress.Text = "";
            txtSalary.Text = "";
        }
    }
}
