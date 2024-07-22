using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Sealed
{
    internal class Parent
    {
        private decimal salary;

        public virtual decimal Salary
        {
            get { return salary; }
            set { salary = value +1000; }
        }

        public virtual void Print()
        {
            Console.WriteLine("I am Parent");
        }
    }

    class Child : Parent
    {
        // Sealed Method: Can be Inherited But can Not be Override
        public sealed override void Print() 
        {
            Console.WriteLine("I am Child");
        }

        // Sealed Property: can be Inherited But can not Be overrided
        public sealed override decimal Salary
        {
            get { return base.Salary; }
            set { base.Salary = value < 5000 ? 5000 : value; }
        }
    }

    // Can't Inherit from Sealed Class
    sealed class GrandChild : Child
    {
        //public override void Print() // Invalid to be Overrided
        //{
        //    base.Print(); 
        //}
        //public new void Print() // Valid
        //{

        //}
    }

    //class Test : GrandChild // Invalid
    //{

    //}

}
