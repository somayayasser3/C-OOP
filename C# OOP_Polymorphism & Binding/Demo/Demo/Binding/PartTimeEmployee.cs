using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Binding
{
    internal class PartTimeEmployee: Employee
    {
        public int CountOfHours { get; set; }
        public decimal HourRate { get; set; }
        //public PartTimeEmployee(int countOfHours)
        //{
        //    CountOfHours = countOfHours;
        //}

        public new void GetEmployeeType()
        {
            Console.WriteLine("I am Part Time Employee.");
        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($"Part Time Employee : Id = {Id}, Name = {Name}, Age = {Age}, Count Of Hours = {CountOfHours} , Hour Rate = {HourRate}");
        }
    }

}
