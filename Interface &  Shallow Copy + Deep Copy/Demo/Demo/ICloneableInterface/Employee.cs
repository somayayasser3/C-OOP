using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.ICloneableInterface
{
    internal class Employee : ICloneable //, IComparable<Employee>
    {
        public int Id { get; set; }
        public string /*StringBuilder*/ Name { get; set; }
        public decimal Salary { get; set; }

        // Deep Copy
        public object Clone() // Single Responsibility - use only one Method
        {
            return new Employee(this); // Deep Copy with Copy Constructor
            //{
            //    //Id = this.Id,
            //    //Name = this.Name,
            //    //Salary = this.Salary
            //};
        }


        // Copy Constructor
        // only One Time
        public Employee(Employee employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name;
            this.Salary = employee.Salary;
        }

        public Employee()
        {

        }

        public override string ToString()
        {
            return $"Id = {Id} , Name = {Name} , Salary = {Salary}";
        }

        //public int CompareTo(object obj)
        //{
        //    // +ve this.salary > obj.salary
        //    // -ve this.salary < obj.salary
        //    // Zero this.salary = obj.salary
        //    Employee PassedEmployee = (Employee)obj; // Unsafe

        //    if (this.Salary > PassedEmployee.Salary)
        //        return 1;
        //    else if (this.Salary < PassedEmployee.Salary)
        //        return -1;
        //    else
        //        return 0;
        //}

        // Implement Generic ICompareable interface
        //public int CompareTo(Employee other)
        //{
        //    if (this.Salary > other.Salary)
        //        return 1;
        //    else if (this.Salary < other.Salary)
        //        return -1;
        //    else
        //        return 0;
        //}
    }
}
