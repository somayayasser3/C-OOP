using Demo.ICloneableInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class EmployeeIdComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Employee PassedEmployee01 = (Employee)x;
            Employee PassedEmployee02 = (Employee)y;
            // x.id > y.id ==> 1
            // x.id < y.id ==> -1
            // x.id = y.id ==> 0
            // y = null ==> 1
            // x = null ==> -1
            // x = null && y == Null ==> 0


            //if (PassedEmployee01.Id > PassedEmployee02.Id)
            //    return 1;
            //else if (PassedEmployee01.Id < PassedEmployee02.Id)
            //    return -1;
            //else
            //    return 0;

            return (PassedEmployee01.Id.CompareTo(PassedEmployee02.Id)); //?? (PassedEmployee02 == null? 0 : -1);
        }
    }
}
