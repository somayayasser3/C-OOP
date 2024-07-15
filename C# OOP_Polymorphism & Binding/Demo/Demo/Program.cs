using Demo.Binding;
using Demo.Polymorphism_Overriding;
using System;

namespace Demo
{
    class Program
    {
        #region Method Overloading
        // Using just for Readability like Console.WriteLine()
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Sum(int x, double y)
        {
            return x + y;
        }

        public static double Sum(double x, int y)
        {
            return x + y;
        }
        #endregion

        // Employee employee
        // Can Refer ==> Object Employee
        // Can Refer ==> Object from Class Inherit from Employee [FullTimeEmployee, PartTimeEmployee]
        public static void ProcessEmployee(Employee employee)
        {
            if(employee != null)
            {
                employee.GetEmployeeType(); // Static Binding ==> From Parent
                employee.GetEmployeeData(); // Dynamic Binding ==> From Child
            }
        }

        //// Not Overloading
        //public static void ProcessEmployee(PartTimeEmployee employee)
        //{
        //    if (employee != null)
        //    {
        //        employee.GetEmployeeType();
        //        employee.GetEmployeeData();
        //    }
        //}
        static void Main(string[] args)
        {
            #region Ploymorphism
            #region OverLoading
            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(1, 2, 3));
            //Console.WriteLine(Sum(2.5, 7.4));
            //Console.WriteLine(Sum(2.5, 7));
            //Console.WriteLine(Sum(2, 1.2));

            #endregion

            #region Overriding
            // Supported for Classes Only
            // Function Overriding Must be with Class [Inheritance]

            //TypeA typeA= new TypeA(1);
            //typeA.A = 10;
            //typeA.Func01();
            //typeA.Func02();

            //TypeB typeB = new TypeB(1, 2);
            //typeB.A = 11;
            //typeB.B = 9;
            //typeB.Func01();
            //typeB.Func02();
            #endregion
            #endregion

            #region Binding
            // Ref From Parent ==> Ref From Child
            //TypeA RefBase;
            ///// Declare var From Ref TypeA
            ///// RefBase ==> refer to Object fro TypeA
            ///// Or refer to Object From Any Class [Inherit From TypeA]
            ///// 

            //RefBase = new TypeB(1, 2);
            //RefBase.A = 10;
            ////RefBase.B = 12; // Invalid
            //RefBase.Func01(); // TypeA , New  [Early Binding]
            //RefBase.Func02(); // TypeB , Override  [Dynamic Binding] Virtual --> Search for the Last Override for this Function 

            #endregion

            #region Not Binding [Explicit Casting]
            // Ref From Child ==> Ref From Parent [Explicit Casting] [Unsafe Casting]
            //TypeB RefTypeB = (TypeB)new TypeA(1);

            //TypeA typeA = new TypeA(1);
            //TypeB typeB = (TypeB)typeA; // Excplicit Casting // Throw Invalid Cast Exception

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);

            //TypeA typeA = new TypeB(1, 2); // Binding

            //TypeB typeB = (TypeB)typeA; // Casting operator Overloading
            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B); // Valid without Exception 
            //// Because the Object I am tring to cast is TypeB at First

            // Like this
            //object o = 2;
            //int x = (int)o;
            //Console.WriteLine(x);

            #endregion

            #region Ex01
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(10, "Somaya", 25, 5000);
            //ProcessEmployee(fullTimeEmployee);
            //// employee = new FullTimeEmployee ;

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Id = 20,
            //    Name = "Ahmed",
            //    Age = 25,
            //    HourRate = 2.5M,
            //    CountOfHours = 8
            //};

            /////partTimeEmployee.Id = 20;
            /////partTimeEmployee.Name = "Ahmed";
            /////partTimeEmployee.Age = 25;
            /////partTimeEmployee.HourRate = 2.5M;
            /////partTimeEmployee.CountOfHours = 8;

            //ProcessEmployee(partTimeEmployee); // Invalid without binding or Overloading
            //// employee = new PartTimeEmployee ;

            #endregion

            #region Ex02
            //TypeA typeA = new TypeC(1, 2, 3); // Binding
            //typeA.A = 10;
            ////typeA.B = 20; //invalid // Only can refer to what in TypeA
            ////typeA.C = 30; // invalid 
            //typeA.Func01(); // Parent
            //typeA.Func02(); // Grand Child

            //Console.WriteLine("===============================================================");

            //TypeB typeB = new TypeC(1, 2, 3);
            //typeB.A = 10;
            //typeB.B = 20;
            ////typeB.C = 30; // invalid
            //typeB.Func01(); // B
            //typeB.Func02(); // C

            //TypeA typeA = new TypeE(1,2,3,4,5); //InDirect Parent
            //TypeB typeB = new TypeE(1, 2, 3,4,5); //InDirect Parent
            //TypeC typeC = new TypeE(1, 2, 3,4,5); //InDirect Parent
            //TypeD typeD = new TypeE(1, 2, 3,4,5); // Direct Parent

            //typeA.Func02(); // Dynamic Bonded Method
            //typeB.Func02(); // Dynamic Bonded Method
            //typeC.Func02(); // Dynamic Bonded Method
            //typeD.Func02(); // Dynamic Binding // Last Override Func02 in Class TypeE

            //// Last Override Of Func02 ==> was In Type C
            //// TypeD ==> New Vitual



            #endregion

            Console.ReadKey();
        }
    }
}
;