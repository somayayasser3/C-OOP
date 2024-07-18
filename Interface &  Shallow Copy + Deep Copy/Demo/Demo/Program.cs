// using Demo.Interfaces;
using Demo.ICloneableInterface;
using System;
using System.Text;
namespace Demo
{
    class Program
    {
        //public static void Print10NumbersFromSeries(/*SeriesByTwo*/ ISeries series) // Call by Reference from Class implement this Interface (ISeries) SeriesByTwo - SeriesByThree 
        //{
        //    if (series != null)
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.Write($"{series.Current}");
        //            series.GetNext();
        //        }

        //        series.Reset();
        //        Console.WriteLine("\n");
        //    }
        //}
            static void Main(string[] args)
            {
            #region Interface
            //IMyType myType = new IMyType(); // Invalid
            //                                // You Can not Create an object from interface
            //IMyType myType;  // valid
            //                 // you can create a reference from interface
            //                 // CLR will allocate 4 Bytes for Reference "myType"
            //                 // Reference will refer to Null
            //                 // Reference can also refer to an Object from Class or Struct Implement Interface
            //myType.Id = 40; // Invalid
            //myType.MyFun(10); // Invalid
            //myType.Print(); // Invalid 
            //                // myType refers to Null not an Object

            //MyType myType1 = new MyType();
            //myType1.Id = 10;
            //myType1.MyFun(50);
            //myType1.Print(); // Invalid as this isn't implemented [Default implemented Method]

            //IMyType myType1 = new MyType();
            //// Ref from Interface ==> Object from Class Implement Interface
            //myType1.Id = 10;
            //myType1.MyFun(50);
            //myType1.Print(); // Valid
            #endregion

            #region Interface Ex01
            // Series
            // 0 2 4 6 8 10
            // 0 3 6 9 12
            // 0 4 8 12

            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10NumbersFromSeries(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumbersFromSeries(seriesByThree); // Not Valid with Function of Specific Data Type without overloading for this Class 
            //                                         // So we Replace this Data Type with Interface Type 

            //SeriesByFour seriesByFour = new SeriesByFour();
            //Print10NumbersFromSeries(seriesByFour);
            #endregion

            #region Interface Ex02 [Explicilty vs Implicitly]
            // Interface Solve Two Problems
            // 1. there is No Multi Inheritance in Class
            // 2. there is No Inheritance In Struct

            //Car car = new Car();
            //car.Backward();

            //Airplane airplane = new Airplane();
            ////airplane.Backward(); // Invalid , which Backward (IMoveable | IFlyable)

            //IMoveable MoveablePlane = new Airplane(); // Ref From Interface refer to this class (implement more than one interface) [ Method implemented Explicitly]
            //MoveablePlane.Backward();

            //IFlyable FlyablePlane = new Airplane();
            //FlyablePlane.Backward();

            #endregion

            #region Shallow Copy & Deep Copy
            // Shallow Copy and Deep Copy --> Reference Type not value Type
            // 2 References refer to the Same Object ==> Shallow Copy
            // 2 References refer to Different Object [even if with the Same State] ==> Deep Copy
            #region Array Of Value Type
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3]; // {0 , 0 , 0} 

            //Console.WriteLine($"HC Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HC Of Arr02 = {Arr02.GetHashCode()}");

            #region Shallow Copy [Stack]
            //Arr02 = Arr01; // Equal References [Shallow Copy] At Stack
            //               // سطحي 
            //               // References [Arr01 , Arr02] ==> Same Object
            //Console.WriteLine("After Shallow Copy: "); // Same Address
            //Console.WriteLine($"HC Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HC Of Arr02 = {Arr02.GetHashCode()}");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            //Arr02[0] = 50;

            //// After Modifying Element [0]
            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");
            #endregion

            #region Deep Copy [Heap]
            //// take a copy of the Object itself not its Reference using Clone
            //Arr02 = (int [])Arr01.Clone();
            //// Clone => Deep Copy
            //// Deep Copy Occurred At Heap
            //// Create New Object With Different and New Reference [Address - Identity] 
            //// then Take A copy of Object State [Data] of the Same Caller
            //// That Object will be the Same object State of Caller [Arr01]
            //// Return to An Object
            //// need Casting

            //Console.WriteLine("After Deep Copy: "); // Different Address
            //Console.WriteLine($"HC Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HC Of Arr02 = {Arr02.GetHashCode()}");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            //Arr02[0] = 50;

            //// After Modifying Element [0]
            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            #endregion

            #endregion

            #region Array Of Reference Type
            #region Array of String [Immutable Type]
            //string[] Names01 = { "Somaya" };
            //string[] Names02 = new string[1]; // {null}

            //Console.WriteLine($"HC Of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC Of Names02 = {Names02.GetHashCode()}");

            #region Shallow Copy [At Stack]
            //Names02 = Names01; // Shallow Copy [same References] --> Stack
            //                   // References [Names01 , Names02] ==> Same Object

            //Console.WriteLine("After Shallow Copy:");

            //Console.WriteLine($"HC Of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC Of Names02 = {Names02.GetHashCode()}");

            //Console.WriteLine($"Names01[0] = {Names01[0]}");
            //Console.WriteLine($"Names02[0] = {Names02[0]}");

            //Names02[0] = "Sara";

            //Console.WriteLine("After Modifying Element 0: ");
            //Console.WriteLine($"Names01[0] = {Names01[0]}");
            //Console.WriteLine($"Names02[0] = {Names02[0]}");

            #endregion

            #region Deep Copy [At Heap]
            //Names02 = (string[])Names01.Clone();
            //// Clone ==> Deep Copy  
            //// Make A New Array which is shallow copy of the Original Array
            //// Create New Object With New And Different Identity
            //// Object will have Same Object State [Data] Of Caller [Names01]
            //Console.WriteLine("After Deep Copy: ");
            //Console.WriteLine($"HC Of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC Of Names02 = {Names02.GetHashCode()}");

            //Console.WriteLine($"Names01[0] = {Names01[0]}");
            //Console.WriteLine($"Names02[0] = {Names02[0]}");

            //Names02[0] = "Sara";

            //Console.WriteLine("After: ");
            //Console.WriteLine($"Names01[0] = {Names01[0]}");
            //Console.WriteLine($"Names02[0] = {Names02[0]}");
            #endregion

            #endregion

            #region Array of StringBuilder [ Mutable Type]
            //StringBuilder[] Names01 = new StringBuilder[1]; // null
            //Names01[0] =new StringBuilder("Somaya");
            //StringBuilder [] Names02 = new StringBuilder [1];

            //Console.WriteLine($"HC Of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC Of Names02 = {Names02.GetHashCode()}");

            #region Shallow Copy [ At Stack]
            //Names02 = Names01 ;
            //// Shallow Copy
            //// 2 Reference [Names01 , Names02] refer to the Same Object
            //Console.WriteLine("After Shallow Copy: ");
            //Console.WriteLine($"HC Of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC Of Names02 = {Names02.GetHashCode()}");

            //Console.WriteLine($"Names01[0] = {Names01[0]}");
            //Console.WriteLine($"Names02[0] = {Names02[0]}");

            //Names01[0] .Append(" Sara"); 
            //Console.WriteLine("After: "); // The Same As it is Mutable Can be Changed in the Same Address
            //Console.WriteLine($"Names01[0] = {Names01[0]}"); 
            //Console.WriteLine($"Names02[0] = {Names02[0]}");

            #endregion

            #region Deep Copy [ At Heap]
            //Names02 = (StringBuilder[])Names01.Clone();
            //// Deep Copy
            //// 2 Reference [Names01, Names02 ] ==> 2 Different Objects
            //Console.WriteLine("After Deep Copy: ");
            //Console.WriteLine($"HC Of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC Of Names02 = {Names02.GetHashCode()}");

            //Console.WriteLine($"Names01[0] = {Names01[0]}");
            //Console.WriteLine($"Names02[0] = {Names02[0]}");

            //Names01[0].Append(" Yousef");

            //Console.WriteLine("After: ");
            //Console.WriteLine($"Names01[0] = {Names01[0]}");
            //Console.WriteLine($"Names02[0] = {Names02[0]}");

            #endregion
            #endregion
            #endregion
            #endregion

            #region Shallow Copy And Deep Copy for User Defined Data Type

            //Employee employee01 = new Employee() { Id = 10, Name = "Somaya", Salary = 5000 };
            //Employee employee02 = new Employee() { Id = 20, Name = "Sara", Salary = 9000 };

            //Employee employee01 = new Employee() { Id = 10, Name = new StringBuilder("Somaya"), Salary = 5000 };
            //Employee employee02 = new Employee() { Id = 20, Name = new StringBuilder("Sara"), Salary = 9000 };
            //Console.WriteLine($"HC Of Employee01 = {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee01: {employee01}");
            //Console.WriteLine($"HC Of Employee02 = {employee02.GetHashCode()}");

            //Console.WriteLine($"Employee01: {employee02}");
            #region Shallow Copy with String [ At Stack]
            //employee02 = employee01; // Shallow Copy
            //// 2 References [Emploee01 , Employee02] refer to the Same Object
            //// { Id = 10, Name = "Somaya", Salary = 5000 }; ==> 2 References
            //// { Id = 20, Name = "Sara", Salary = 9000 }; ==> Unreachable Object
            //Console.WriteLine("After Shallow Copy: ");
            //Console.WriteLine($"HC Of Employee01 = {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee01: {employee01}");
            //Console.WriteLine($"HC Of Employee02 = {employee02.GetHashCode()}");
            //Console.WriteLine($"Employee01: {employee02}");

            //employee01.Id = 100;
            //employee01.Name = "Yousef";
            //employee01.Salary = 15000;

            //Console.WriteLine("After Changing : ");
            //Console.WriteLine($"Employee01: {employee01}");
            //Console.WriteLine($"Employee01: {employee02}");

            #endregion

            #region Shallow Copy With StringBuilder [ At Stack]
            //employee02 = employee01; // Shallow Copy
            //// 2 References [Emploee01 , Employee02] refer to the Same Object
            //// { Id = 10, Name = "Somaya", Salary = 5000 }; ==> 2 References
            //// { Id = 20, Name = "Sara", Salary = 9000 }; ==> Unreachable Object
            //Console.WriteLine("After Shallow Copy: ");
            //Console.WriteLine($"HC Of Employee01 = {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee01: {employee01}");
            //Console.WriteLine($"HC Of Employee02 = {employee02.GetHashCode()}");
            //Console.WriteLine($"Employee01: {employee02}");

            //employee01.Id = 100;
            //employee01.Name.Append(" Yousef");
            //employee01.Salary = 15000;

            //Console.WriteLine("After Changing : ");
            //Console.WriteLine($"Employee01: {employee01}");
            //Console.WriteLine($"Employee01: {employee02}");
            #endregion

            #region Deep Copy with String
            //employee02 = (Employee)employee01.Clone(); // Invalid for user Defined data Type // we should implement Icloneable Interface to implement Clone Function 
            //// Create New Object with New and Different Identity
            //// Object has the Same Object State Of Caller

            //Console.WriteLine("After Deep Copy: ");
            //Console.WriteLine($"HC Of Employee01 = {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee01: {employee01}");
            //Console.WriteLine($"HC Of Employee02 = {employee02.GetHashCode()}");
            //Console.WriteLine($"Employee01: {employee02}");

            //employee02.Id = 200;
            //employee02.Name = "Yousef";
            //employee02.Salary = 20000;

            //Console.WriteLine("After Changing: ");
            ////Console.WriteLine($"HC Of Employee01 = {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee01: {employee01}");
            ////Console.WriteLine($"HC Of Employee02 = {employee02.GetHashCode()}");
            //Console.WriteLine($"Employee01: {employee02}");

            #endregion

            #region Deep Copy With StringBuilder
            //employee02 = (Employee)employee01.Clone(); // Invalid for user Defined data Type // we should implement Icloneable Interface to implement Clone Function 
            //// Create New Object with New and Different Identity
            //// Object has the Same Object State Of Caller

            //Console.WriteLine("After Deep Copy: ");
            //Console.WriteLine($"HC Of Employee01 = {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee01: {employee01}");
            //Console.WriteLine($"HC Of Employee02 = {employee02.GetHashCode()}");
            //Console.WriteLine($"Employee01: {employee02}");

            //employee02.Id = 200;
            //employee02.Name .Append(" Yousef");
            //employee02.Salary = 20000;

            //Console.WriteLine("After Changing: ");
            ////Console.WriteLine($"HC Of Employee01 = {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee01: {employee01}");
            ////Console.WriteLine($"HC Of Employee02 = {employee02.GetHashCode()}");
            //Console.WriteLine($"Employee01: {employee02}");
            #endregion

            // We have 2 Ways to do Deep Copy User Defined DataType
            // 1. Clone()
            // 2. Copy Constructor

            #region Deep Copy With Copy Constructor
            //employee02 = new Employee(employee01);
            //Console.WriteLine("After Copy Constructor: ");
            //Console.WriteLine($"HC Of Employee01 = {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee01: {employee01}");
            //Console.WriteLine($"HC Of Employee02 = {employee02.GetHashCode()}");
            //Console.WriteLine($"Employee01: {employee02}");
            #endregion
            #endregion

            #region Built in Interface ICompareable
            ////int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////Array.Sort(Numbers); // Sort ==> Use ICompareable Implementation
            ////foreach(int num in Numbers)
            ////{
            ////    Console.WriteLine(num);
            ////}

            //Employee[] employees = new Employee[4]
            //{
            //    new Employee(){Id = 10, Name = "Somaya", Salary = 15000},
            //    new Employee(){Id = 20, Name = "Sara", Salary = 20000},
            //    new Employee(){Id = 30, Name = "Yousef", Salary = 11000},
            //    new Employee(){Id = 40, Name = "Ahmed", Salary = 10000},
            //};

            //// System.InvalidOperationException without Implementation of Icompareable Interface
            //Array.Sort(employees);
            //foreach (Employee emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}

            //// CompareTo() ==> Object Member Function
            //Console.WriteLine(employees[0].CompareTo(employees[1]));

            //// we can use CompareTo with Int Like This
            //Console.WriteLine(employees[0].Id.CompareTo(employees[1].Id));
            #endregion

            #region Built in Interface IComparer
            //Employee[] employees = new Employee[4]
            //{
            //    new Employee(){Id = 20, Name = "Somaya", Salary = 15000},
            //    new Employee(){Id = 10, Name = "Sara", Salary = 20000},
            //    new Employee(){Id = 30, Name = "Yousef", Salary = 11000},
            //    new Employee(){Id = 40, Name = "Ahmed", Salary = 10000},
            //};

            //// System.InvalidOperationException without Implementation of Icompareable Interface
            //Array.Sort(employees, new EmployeeIdComparer()); // Sort used Compare() function in IComparer Interface
            //                                                 // Use 2 Parameters (Array to Sort, object of class that have the function to implement IComparer Interface)
            //foreach (Employee emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion
            Console.ReadKey();
            }
    }
}

