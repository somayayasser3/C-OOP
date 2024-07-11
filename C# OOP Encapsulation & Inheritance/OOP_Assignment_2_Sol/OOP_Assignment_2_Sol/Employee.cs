using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment_2_Sol
{
    [Flags]
    public enum  SecurityLevel : byte
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8
    }

    public struct HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

    }

    public enum Gender
    {
        Male,
        Female
    }
    internal class Employee
    {
        private string v1;
        private SecurityLevel dBA;
        private int v2;
        private Gender female;
        #region Attributes
        //int id;
        //string name;
        //SecurityLevel securityLevel;
        //double salary;
        //HiringDate hiringDate;
        //Gender gender;
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("{0} is the Employee Id\nhis Name is {1}\nHis Security Level is {2}\nhis Salary is ${3} \nhis Hiring Date: {4} - {5} - {6} \nhis Gender is {7} ",
                Id, Name, P_securityLevel, Salary, P_hiringDate.Day, P_hiringDate.Month , P_hiringDate.Year, P_gender);
        }
        #endregion

        #region Setters & Getters

        public int GetId()
        {
            return this.Id;
        }

        public void SetId(int id)
        {
            this.Id = id;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public SecurityLevel GetSecurityLevel()
        {
            return this.P_securityLevel;
        }

        public void SetSecurityLevel(SecurityLevel level)
        {
            this.P_securityLevel = level;
        }

        public double GetSalary()
        {
            return this.Salary;
        }

        public void SetSalary(double sal)
        {
            this.Salary = sal;
        }

        public HiringDate GetHiringDate()
        {
            return this.P_hiringDate;
        }

        public void SetHiringDate(HiringDate date)
        {
            this.P_hiringDate = date;
        }

        public Gender GetGender()
        {
            return this.P_gender;
        }

        public void SetGender(Gender gen)
        {
            this.P_gender = gen;
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel P_securityLevel { get; set; }
        public double Salary { get; set; }
        public HiringDate P_hiringDate { get; set; }
        public Gender P_gender { get; set; }
        #endregion

        #region Constructors
        public Employee(int id, string name, SecurityLevel p_securityLevel, double salary, HiringDate p_hiringDate, Gender p_gender)
        {
            Id = id;
            Name = name;
            P_securityLevel = p_securityLevel;
            Salary = salary;
            P_hiringDate = p_hiringDate;
            P_gender = p_gender;
        }

        public Employee(int id, int month) :this( id, "Somaya", SecurityLevel.DBA, 5000,Gender.Female)
        {
            Id = id;
        }


        public Employee(int id, string v1, SecurityLevel dBA, double v2, Gender female)
        {
            Id = id;
            this.Name = v1;
            this.P_securityLevel = dBA;
            this.Salary= v2;
            this.P_gender = female;
        }

        public Employee(int id, string name, SecurityLevel ss)
        {
            Id = id;
            Name = name;
            this.P_securityLevel = ss;
        }
        #endregion
    }
}
