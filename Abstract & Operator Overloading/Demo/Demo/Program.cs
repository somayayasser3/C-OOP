using Demo.Abstraction;
// using Demo.Casting_Operator_Overloading;
using Demo.Operator_Overloading;
using Demo.Partial;
using Demo.Static;
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int Result = 10 + 20;
            //string Name = "Somaya " + "Yasser";
            #region Operator Overloading

            #region Binary Operator Overloading
            //Complex C1 = new Complex()
            //{
            //    Real = 3,
            //    Imag = 5
            //}; // Object Initializer

            //Console.WriteLine(C1);

            //Complex C2 = new Complex()
            //{
            //    Real = 2,
            //    Imag = 4
            //}; // Object Initializer

            //Console.WriteLine(C2);

            ////Complex C3 = C1 + C2; // use + Operator OverLoading 

            ////Console.WriteLine(C3);

            ////Complex C3 = C1 - C2; // use - Operator OverLoading 

            ////Console.WriteLine(C3);

            //Complex C3 = new Complex();
            //C3 += C1; // C3 = C3 + C1;
            //Console.WriteLine(C3);
            #endregion

            #region Unary Operator Overloading
            //Complex C1 = new Complex()
            //{
            //    Real = 4,
            //    Imag = 5
            //};

            //Console.WriteLine(C1++); // Postfix (print then Increment) ==> 4 + 5i
            //Console.WriteLine(C1); // Print after increment ==> 5 + 6i
            //Console.WriteLine(++C1); // Prefix (increment then Print) ==> 6 + 7i


            //Console.WriteLine(C1--); // Postfix (print then decrement) ==> 6 + 7i
            //Console.WriteLine(C1); // Print after decrement ==> 5 + 6i
            //Console.WriteLine(--C1); // Prefix (decrement then Print) ==> 4 + 5i
            #endregion

            #region Relational Operator
            //Complex C1 = new Complex()
            //{
            //    Real = 4,
            //    Imag = 5
            //};

            //Complex C2 = new Complex()
            //{
            //    Real = 3,
            //    Imag = 7
            //};

            //if (C1 > C2)
            //    Console.WriteLine("C1 is greater than C2");
            //else if (C2 > C1)
            //    Console.WriteLine("C2 is greater than C1");

            #endregion
            #endregion


            #region Casting Operator Overloading
            ////object obj = 2;  // Boxing
            ////int X = (int) obj; // Explicit Casting
            ////                   // (int) Casting Operator

            //Complex C1 = new Complex()
            //{
            //    Real = 2,
            //    Imag = 4
            //};

            //int Y = (int) C1;
            //Console.WriteLine(Y);

            //string S1 = C1;
            //S1 = (string)C1; // Recommended [Just for Readability]
            //Console.WriteLine(S1);
            #endregion

            #region Casting Operator Overloading [MVC]
            //// 1. Get Data From View: EmployeeViewModel -we need to cast it to type of -> Employee [Model]-then store it into Database-> Database
            //// 2.Get Data From Database: Database --> Employee --> EmployeeViewModel -->View
            //Employee employee = new Employee() // Such As: Object from Database
            //{
            //    Id = 10,
            //    FullName = "Somaya Yasser",
            //    Email = "somaya.yasser.galal3@gmail.com",
            //    Password = "123456",
            //    SecurityStamp = Guid.NewGuid()
            //};

            //EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            //employeeViewModel = (EmployeeViewModel)employee; // Invalid 
            //                                                 // Reference Type to Reference Type
            //                                                 // So we need Casting Operator Overloading
            //                                                 // in View Model Not Model Itself
            //                                                 // as if there is any change in DB , it will reflect in Model Class 
            //                                                 // and will Generate from Beginning then delete any Change occured in it before. 
            //Console.WriteLine(employeeViewModel.FirstName);
            //Console.WriteLine(employeeViewModel.LastName);

            //object obj = new EmployeeViewModel()
            //{
            //    FirstName = "Somaya",
            //    LastName = "Yasser",
            //    Email = "Somayayasser65@gmail.com"
            //};
            //EmployeeViewModel E = (EmployeeViewModel)obj;
            //// Explicit casting 
            //// Casting Operator Overloading
            //// any user Defined Class has Explicit Casting from Object Class
            //Console.WriteLine(E.FirstName);

            #endregion

            #region Abstraction
            ////Shape shape = new Shape(); // invalid - [Abstract Class]
            ////shape.CalcArea();

            ////Rectangle rectangle = new Rectangle(10, 20);
            ////Console.WriteLine($"The Area of Rectangle: {rectangle.CalArea()}");
            ////Console.WriteLine($"The Perimeter Of Reactangle: {rectangle.Perimeter}");
            ////Square square = new Square(80);
            ////Console.WriteLine($"the Perimeter of Square: {square.Perimeter}");
            ////Console.WriteLine($"The Area Of Square: {square.CalArea()}");
            ////Circle circle = new Circle(12);
            ////Console.WriteLine($"The Area Of The Circle: {circle.CalArea()}");
            ////Console.WriteLine($"The Perimeter of the Circle: {circle.Perimeter}");

            // Use Constructor for Abstract Class

            //Shape shape = new Rectangle(11, 22); // Dynamic Binding [Late Binding]
            //Console.WriteLine(shape.Perimeter);
            //Console.WriteLine(shape.CalArea());
            #endregion

            #region Static
            ////Utility U01 = new Utility(10, 20);
            ////Console.WriteLine($"CM to INCH = {U01.CmToInch(254)}");

            ////Utility U02 = new Utility(100, 200);
            ////Console.WriteLine($"CM to INCH = {U02.CmToInch(254)}");
            //// If Result Of Calling  Method CmToInch will not Differ by Difference of the Object
            //// By The Difference The Object State [X , Y]
            //// Non-Static Method --> Static Method 

            //Console.WriteLine(Utility.CmToInch(254));
            //Console.WriteLine(Utility.CalcCircleArea(5));
            //Console.WriteLine(Utility.CalcCircleArea(10));

            ////Utility utility = new Utility(); // Invalid [Static Class]

            #endregion

            #region Partial
            Employee employee = new Employee();
            employee.Id = 10;
            employee.Name = "Somaya Yasser";
            employee.Salary = 17000;
            employee.Test = 5;
            employee.Print();

            #endregion
            Console.ReadKey();
        }
    }
}
