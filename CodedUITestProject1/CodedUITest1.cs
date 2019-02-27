using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.DirectUIControls;
using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUITestProject1
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest(CodedUITestType.WindowsStore)]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void UpdateDeleteSearch()
        {
            #region Variable Declarations
            XamlButton btnRegister = this.UIMap.UIEmployeeRegistrationWindow.UIRegisterButton;
            XamlEdit txtName = this.UIMap.UIEmployeeRegistrationWindow.UITxtNameEdit;
            XamlEdit txtNrc = this.UIMap.UIEmployeeRegistrationWindow.UITxtNrcEdit;
            XamlComboBox cboMonth = this.UIMap.UIEmployeeRegistrationWindow.UIDatepickerGroup.UIMonthComboBox;
            XamlComboBox cboDay = this.UIMap.UIEmployeeRegistrationWindow.UIDatepickerGroup.UIDayComboBox;
            XamlComboBox cboYear = this.UIMap.UIEmployeeRegistrationWindow.UIDatepickerGroup.UIYearComboBox;
            XamlRadioButton radMale = this.UIMap.UIEmployeeRegistrationWindow.UIMaleRadioButton;
            XamlComboBox cboJoinMonth = this.UIMap.UIEmployeeRegistrationWindow.UIDatepickerGroup1.UIMonthComboBox;
            XamlComboBox cboJoinDay = this.UIMap.UIEmployeeRegistrationWindow.UIDatepickerGroup1.UIDayComboBox;
            XamlComboBox cboJoinYear = this.UIMap.UIEmployeeRegistrationWindow.UIDatepickerGroup1.UIYearComboBox;
            XamlComboBox cboDepartment = this.UIMap.UIEmployeeRegistrationWindow.UICboDeptComboBox;
            XamlComboBox cboTeam = this.UIMap.UIEmployeeRegistrationWindow.UICboTeamComboBox;
            XamlEdit txtPosition = this.UIMap.UIEmployeeRegistrationWindow.UITxtPositionEdit;
            XamlEdit txtPhone = this.UIMap.UIEmployeeRegistrationWindow.UITxtPhnoEdit;
            XamlEdit txtAddress = this.UIMap.UIEmployeeRegistrationWindow.UITxtAddressEdit;
            XamlEdit txtSalary = this.UIMap.UIEmployeeRegistrationWindow.UITxtSalaryEdit;
            XamlButton btnAdd = this.UIMap.UIEmployeeRegistrationWindow.UIAddButton;
            XamlButton btnGoBack = this.UIMap.UIEmployeeRegistrationWindow.UIGoBackButton;
            XamlEdit txtUserName = this.UIMap.UIEmployeeRegistrationWindow.UITxtUserNameEdit;
            XamlEdit txtPassword = this.UIMap.UIEmployeeRegistrationWindow.UITxtPasswordEdit;
            XamlButton btnLogin = this.UIMap.UIEmployeeRegistrationWindow.UILogInButton;
            XamlButton btnUpdate = this.UIMap.UIEmployeeRegistrationWindow.UIUpdateButton;
            XamlEdit txtEname = this.UIMap.UIEmployeeRegistrationWindow.UITxtENameEdit;
            XamlButton btnSearch = this.UIMap.UIEmployeeRegistrationWindow.UISearchButton;
            XamlEdit txtNameEdit = this.UIMap.UIEmployeeRegistrationWindow.UITxtNameEdit;
            XamlButton btnUpdateUp = this.UIMap.UIEmployeeRegistrationWindow.UIUpdateButton1;
            XamlButton btnGoBackLogin = this.UIMap.UIEmployeeRegistrationWindow.UIGoBackToLoginButton;
            XamlButton btnGoBackToMain = this.UIMap.UIEmployeeRegistrationWindow.UIGoBackToMainButton;
            XamlButton btnSearchPage = this.UIMap.UIEmployeeRegistrationWindow.UISearchPageButton;
            XamlEdit txtSearchEname = this.UIMap.UIEmployeeRegistrationWindow.UITxtNameEdit;
            XamlButton btnSearchEname = this.UIMap.UIEmployeeRegistrationWindow.UISearchNameButton;
            XamlButton btnGoBackMain = this.UIMap.UIEmployeeRegistrationWindow.UIGoBackMainButton;
            XamlButton btnDeletePage = this.UIMap.UIEmployeeRegistrationWindow.UIDeletePageButton;
            XamlEdit txtEnameEdit = this.UIMap.UIEmployeeRegistrationWindow.UITxtENameEdit;
            XamlButton btnSearchByName = this.UIMap.UIEmployeeRegistrationWindow.UISearchByNameButton;
            XamlButton btnDelete = this.UIMap.UIEmployeeRegistrationWindow.UIDeleteButton;
            XamlButton btnGoBackToLogin = this.UIMap.UIEmployeeRegistrationWindow.UIGoBackToLoginButton1;
            #endregion

            XamlWindow empRegistration = XamlWindow.Launch("ff6d66de-f0b4-486f-8ac7-4cc493221fcf_fgj28ymhhr2yg!App");

            Mouse.Click(btnRegister);
            txtName.Text = "Aung Aung";
            txtNrc.Text = "12/U Ka Ta(N)900002";
            cboDay.SelectedIndex = 6;
            cboMonth.SelectedIndex = 7;
            cboYear.SelectedIndex = 78;
            radMale.Selected = true;
            cboJoinDay.SelectedIndex = 20;
            cboJoinMonth.SelectedIndex = 10;
            cboJoinYear.SelectedIndex = 100;
            cboDepartment.SelectedIndex = 0;
            cboTeam.SelectedIndex = 1;
            txtPosition.Text = "Software Engineer";
            txtPhone.Text = "0945214455";
            txtAddress.Text = "Yangon";
            txtSalary.Text = "500000";
            Mouse.Click(btnAdd);
            Mouse.Click(btnGoBack);
            txtUserName.Text = "Moon";
            txtPassword.Text = "123";
            Mouse.Click(btnLogin);
            Mouse.Click(btnUpdate);
            txtEname.Text = "Aung Aung";
            Mouse.Click(btnSearch);
            txtNameEdit.Text = "Aung Khine";
            Mouse.Click(btnUpdateUp);
            Mouse.Click(btnGoBackLogin);
            Mouse.Click(btnDeletePage);
            txtEnameEdit.Text = "Aung Khine";
            Mouse.Click(btnSearchByName);
            Mouse.Click(btnDelete);
            Mouse.Click(btnGoBackToLogin);
            Mouse.Click(btnGoBackToMain);
            Mouse.Click(btnSearchPage);
            txtSearchEname.Text = "Aung Khine";
            Mouse.Click(btnSearchEname);
            Mouse.Click(btnGoBackMain);

            empRegistration.Close();
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{

        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{

        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
