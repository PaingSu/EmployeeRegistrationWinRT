using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegistrationWinRT
{
    public class StoreData
    {
        static public string[] EName = new string[50];
        static public string[] Nrc = new string[50];
        static public string[] BDDay = new string[50];

        static public string[] Gender = new string[50];
        static public string[] JDDay = new string[50];
        static public string[] JDMonth = new string[50];
        static public string[] JDYear = new string[50];
        static public string[] Department = new string[50];
        static public string[] Team = new string[50];
        static public string[] Position = new string[50];
        static public string[] Phone = new string[50];
        static public string[] Address = new string[50];
        static public string[] Salary = new string[50];

        static public string name = "";
        static public string nrc = "";
        static public string birthdate = "";

        static public string gender = "";
        static public string joindate = "";
        static public string joinmonth = "";
        static public string joinyear = "";
        static public string department = "";
        static public string team = "";
        static public string position = "";
        static public string phone = "";
        static public string address = "";
        static public string salary = "";

        public static void Add()
        {
            for (int i = 0; i < EName.Length; i++)
            {
                EName[i] = name;
            }
            for (int i = 0; i < Nrc.Length; i++)
            {
                Nrc[i] = nrc;
            }
            for (int i = 0; i < BDDay.Length; i++)
            {
                BDDay[i] = birthdate;
            }
            for (int i = 0; i < Gender.Length; i++)
            {
                Gender[i] = gender;
            }
            for (int i = 0; i < JDDay.Length; i++)
            {
                JDDay[i] = joindate;
            }
            for (int i = 0; i < JDMonth.Length; i++)
            {
                JDMonth[i] = joinmonth;
            }
            for (int i = 0; i < JDYear.Length; i++)
            {
                JDYear[i] = joinyear;
            }
            for (int i = 0; i < Department.Length; i++)
            {
                Department[i] = department;
            }
            for (int i = 0; i < Team.Length; i++)
            {
                Team[i] = team;
            }
            for (int i = 0; i < Position.Length; i++)
            {
                Position[i] = position;
            }
            for (int i = 0; i < Phone.Length; i++)
            {
                Phone[i] = phone;
            }
            for (int i = 0; i < Address.Length; i++)
            {
                Address[i] = address;
            }
            for (int i = 0; i < Salary.Length; i++)
            {
                Salary[i] = salary;
            }
        }
    }
}
