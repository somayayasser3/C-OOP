using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Casting_Operator_Overloading
{
    // View Model: Class Represent Data That will be Rendered in View
    internal class EmployeeViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        #region Casting Operator Overloading
        public static explicit operator EmployeeViewModel(Employee emp)
        {
            string[] arr = new string[2];
            arr = emp?.FullName?.Split(" ");
            return new EmployeeViewModel()
            {
                Email = emp?.Email ?? string.Empty,
                FirstName = arr?.Length > 0 ? arr[0] : string.Empty,
                LastName = arr?.Length > 1 ? arr[1] : string.Empty
            };
        }
        #endregion 
    }
}
