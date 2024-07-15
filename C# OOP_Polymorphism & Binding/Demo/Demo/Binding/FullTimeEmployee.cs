using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Binding
{
    internal class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public FullTimeEmployee(int id , string name, int age, decimal salary): base(id, name, age)
        {
            //Id = id;
            //Name = name;
            //Age = age;
            Salary = salary;
        }

        public new void GetEmployeeType()
        {
            Console.WriteLine("I am Full Time Employee");
        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($"Full Time Employee : Id = {Id}, Name = {Name}, Age = {Age}, Salary = {Salary}");
        }
    }
}
