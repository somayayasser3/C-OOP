using System;
using Common; // Add Dependencies at the project i want to import into --> then add reference --> then Choose reference you want to add or Browse fro it to find

namespace OPPDemo1
{

    // We Can write in NameSpace
    // 1. Class
    // 2. Struct
    // 3. Interface
    // 4. Enum
    // Class, Interface --> Reference Type Data type
    // Struct, Enum --> Value Type Data type

    // Access Modifiers Allowed in NamseSpace
    // 1. Public
    // 2. Internal [Default]

    public enum Days
    {
        Saturday, // = 1, // we can change the default value in the DB Sat = 1, Sun = 2  and so on (1 Based) not (0 Based)
        Sunday,
        Monday, 
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }

    public enum Grades : int //Default stored in Data Base
    {
        A, // 0
        B, // 1
        C, // 2 
        D, // 3
        F // 4
    }

    public enum Gendre : int
    {
        Male = 0  ,
        Female = 1,
        male = 0,
        M = 0 
    }

    public enum Role
    {
        Admin = 10 , // In Database 10,20,30
        Editor = 20,
        Viewer = 30
    }

    public enum Branches : Byte// Default in DB as int  0,1,2,3,4 
        // we can store it as Byte = 8 bit 0:255
    {
        Dokki = 200, 
        NasrCity,
        Maadi = 252, // not valid Maadi = 253 // Alex = 254 // Cairo = 255 (out of index)
        Alex,
        SmartVillage,
        Cairo
        
    }
    
    // to Make Permission understand that there is more permissions using the sum of the existed Permissions 
    // we used Attributes (built in class)
    [Flags] // seaech for a labels their sum = the given int to the Employee
    public enum Permission : byte // used untill 8 permissions , short for 9 permissions
    {
        Delete = 1,
        Excute = 2, 
        Read = 4,
        Write = 8
    }

    class Program // can be Public or Internal As it is in NameSpace  // Default: Internal  
    {
        public static void DoSomeCode()
        {
            // Solve Exception that will Occured at runtime (Not Warning)

            try // perform block of try 
            {
                int X, Y, Z;
                X = int.Parse(Console.ReadLine());  // Format Exception
                Y = int.Parse(Console.ReadLine());  // Format Exception
                Z = X / Y; // Divided By Zero Exception

                int[] Numbers = { 1, 2, 3 };
                Numbers[10] = 100; // Index Out Of Range Exception
            }
            catch(Exception Ex) // if there is any Exception Occurred in Try Block, CLR will create Object from Class Of Exception and throw it in catch block (then insert it into table , print it, log)
            {
                // Exception will catch all Exceptions of Type Exception 
                // But we can create more than on Catch to catch different types of Exception with different actions
                Console.WriteLine(Ex.Message); // in web
                                               // 1. Log in file
                                               // 2. Store in DB
            }

            // Solve Exceptions
            // 1. Try Catch (not acceptable with non Protective Code)
            // 2. Write Protective Code then Use Try .. Catch 
            // in new Function DoSomeProtectiveCode
        }

        public static void DoSomeProtectiveCode()
        {
            bool Flag; // Store Output Of TryParse  // Default False
                       // TryParse --> True --> X = 10 (For Example)
                       // TryParse --> False --> X = 0
            int X, Y, Z;
            do
            {
                Console.Write("Please Enter The First Number: ");
                Flag = int.TryParse(Console.ReadLine(), out X);		

            } while (!Flag); // Protective Code

            do
            {
                Console.Write("Please Enter The Second Number: ");
                Flag = int.TryParse(Console.ReadLine(), out Y);
            } while (!Flag || Y == 0); // Protective Code
            Z = X / Y;


            //int[] Numbers = { 1, 2, 3 };
            int[] Numbers = null;
            if (Numbers?.Length > 10) // if Numbers is Null // use Null Propagation Opertor to Avoid Null Reference Exception 
            {                         // Numbers ==> Null , Numbers?.Length ==> Null
                                      // Numbers !=  Null , Numbers?.Length ==> Length
                Numbers[10] = 100;
            }
            //then we can add Try..Catch --> to handle cases I don't Expect to happen
            // During Calling Function

        }
        static void Main(string[] args)
        {
            #region Exception Handling
            //// Create Protective Code to avoid any Exception to be Occurred then use Try...Catch as a last defense Method 
            ////DoSomeCode(); // RunTime Errors (Exception)

            //// Exceptions 
            //// 1. System Exceptions 
            //// 1.1 Format Exceptions
            //// 1.2 Index Out Of Range Exception
            //// 1.3 Null Reference Exceptions
            //// 1.4 Invalid Operation Exception
            //// 1.5 Arithmetic Exception
            //// 1.5.1 Divided By Zero Exception
            //// 1.5.2 OverFlow Exception
            //// 2. Application Exception

            //// Hiararcy 
            //// 1. Exception Class (Parent)
            //// 1.1 System Exception (child) : Exception  and so on 
            //// ApplicationEx --> not class (Types of Exceptions occur in Applications)

            //try
            //{
            //    DoSomeProtectiveCode();
            //    throw new Exception(); // (Create New Object of Exception )To Throw Exception to show the reason of use Try .. Catch after Protective Code 
            //                           // Just for testing 
            //}
            //catch(Exception Ex) // will be performed only , if there is an Exception
            //{
            //    Console.WriteLine(Ex.Message);
            //}
            //// Without Using Try..Catch , the Execution of The Program will be Stopped.
            //// and the code after the Exception will be unreachable Code.
            //// so we use it to continue in the program if there is an Exception.
            //finally // will be Performed, if there is an exception or not
            //{
            //    // Close | Delete | Release | Deallocate Unmaganed Code
            //    // Unmanaged Code with CLR: 
            //    // 1. Open File
            //    // 2. Database Connection
            //    Console.WriteLine("Finally.");
            //}
            //Console.WriteLine("After Throw Exception In Try.. Catch");
            #endregion

            #region Access Modifiers
            //// keyWords to indicate the Accessbility Scope
            //// Access Modifiers fro Wider to Narrower
            //// 1. Public 
            //// 2. Protected Internal  == Internal Protected
            //// 3. Internal
            //// 4. Protected 
            //// 5. Private Protected 
            //// 6. Private
            //// Then File

            //TypeA obj = new TypeA(); // Accessible public (External using Import)
            //// TypeB Obj2 = new Common.TypeB(); // Not valid
            //                         // Not Accessible Due to its protection Level (Internal)
            ////obj.X = 5; // invalid --> X: Private not accessible out of its Project
            ////obj.Y = 20; // inValid (Y: internal) Accessible only at is scope and its Project
            //obj.Z = 1; // Valid (Z: Public) Accessible at its scope, its project, External Project 
            #endregion

            #region Enum
            // Only Contains Labels
            // We Use Enum when we controls the values of this data types
            // we need to define date type for set of values

            //Days day = Days.Friday;
            //Console.WriteLine(day);

            #region Ex01
            //Grades X = Grades.A;
            ////Console.WriteLine(X);
            //// if(X == 'A') // Not Valid --> Comparison Between Different Data Type
            //if (X == Grades.A)
            //    Console.WriteLine(":)");
            //else
            //    Console.WriteLine(":(");
            //Grades Y = (Grades)2; //Explicit casting
            //Console.WriteLine(Y); // C

            //Grades Z = (Grades)10; //Explicit casting
            //Console.WriteLine(Z); // 10 not label as it is not found in this enum
            #endregion

            #region Ex02
            //Console.WriteLine("Please Enter Your Grade: ");
            ////Grades X = (Grades)Enum.Parse(typeof(Grades), Console.ReadLine()); // UnSafe [The Worst Method]
            //// if the user entered value out of Enum Labels --> throw Exception Argument Exception
            //bool res= Enum.TryParse(typeof(Grades), Console.ReadLine(), out object X); // if the grade out of Enum Labels --> the X = null (Default Value)
            //Console.WriteLine($"Your Grade is : {X}");
            //Console.WriteLine($"Your Result is : {res}");

            //// TryParse is better than Parse but not the Best
            #endregion

            #region Ex03
            ////Gendre G1 = Gendre.Female;  //Female
            ////Console.Write(G1);
            ////G1 = (Gendre)(2);   //Female

            //string G2 = "male";
            ////Enum.TryParse(typeof(Gendre), G2, out object res); // Case Sensitive // C# 1.0
            ////bool flag = Enum.TryParse<Gendre>(G2, out Gendre res); // can't Parse so it returns the default value = 0 not the value i give to it = 1 // C# 2.0
            //// we can use the overload of this function 
            ////bool flag = Enum.TryParse<Gendre>(G2, true, out Gendre res); // ignore case sensitive //second parameter = true to ignore case 
            ////Console.WriteLine(res);
            ////Console.WriteLine(flag);

            //// Why Default Value Of Enum = 0
            //Gendre G = new Gendre(); // new here in Struct is value type in Stack not heap 
            //                         // new take Default Value of Enum = 0 when we use different value for Enum in DB not Default
            //                         // new Using Default value in Enum we return the Label of 0 'Male' not the value in DB 
            //                         // So we Avoid use 0 as default value fro Enum
            //Console.WriteLine(G);
            #endregion

            #region Ex04
            // when Deal with Multi values with the same label , it will take the first Label with this value
            //Gendre X = (Gendre) 0; // print the first value with 0 in Enum 
            //Console.WriteLine(X); 
            #endregion

            #region Ex05
            //Employee Emp = new Employee();
            //Emp.Name = "Somaya";
            //Emp.gendre = Gendre.Female;
            //Emp.permission = Permission.Delete; // if i want to give more than one Permission 
            //// 1. Store Permission in byte not int in DB
            //// 2. use 8 bit to store the permissions allowed for the Employee using Binary Numbers [0,1]
            //// Write in DB --> 00001000 -->8
            //// Read --> 00000100 --> 4 
            //// Execute --> 00000010 --> 2
            //// Delete --> 00000001 --> 1

            //// More Than 1 Permission
            //// Write & Read --> 00001100 --> 12
            //// Write & Excute --> 00001010 --> 10
            //// Write & Delete --> 00001001 --> 9
            //// Read & Execute --> 00000110 --> 6
            //// Read & Delete --> 00000101 --> 5
            //// Execute & Delete --> 00000011 --> 3
            //// Write & Read & Exceute --> 00001110 --> 14
            //// Write & Read & Delete --> 00001101 --> 13 
            //// Write & Execute & Delete --> 00001011 --> 11
            //// Read & Execute & Delete --> 00000111 --> 7
            //// All Permissions --> 00001111 --> 15

            //Emp.permission = (Permission)7; // Delete - Execute - Read 
            //// Flags in Enum tells that 7 is the Sum of Delete + Execute + Read not search for 7 in Enum
            //Console.WriteLine(Emp.permission);

            //// if you want to add new permission (write) 
            //// use XOR bitwise operation
            //Emp.permission = Emp.permission ^ Permission.Write;
            //// 7 ^ 8
            //// 0111 
            //// ^ 
            //// 1000
            ////=1111 = 15

            //Console.WriteLine(Emp.permission);

            //// To Remove [Deny] Permission
            //// Use XOR
            //Emp.permission = Emp.permission ^ Permission.Write;
            //// 15 ^ 8
            //// 1111
            //// ^ 
            //// 1000
            ////=0111 = 7

            //Console.WriteLine(Emp.permission);

            //// If i want to add a Permission already exist for the Employee
            //// it will be deleted
            //// Solution 
            //// 1. use And Operator Before XOR
            //// if Delete is Existed --> return  value of delete
            ////  else --> return Random Value
            //if ((Emp.permission & Permission.Delete) == Permission.Delete)
            //{
            //    Console.WriteLine("Delete Is Existed");
            //}
            //else
            //{
            //    Console.WriteLine("Delete isn't Existed ");
            //    Emp.permission = Emp.permission ^ Permission.Delete;
            //}
            //Console.WriteLine(Emp.permission);
            //// Emp.permission & Delete
            //// 111
            //// &
            //// 001
            ////=001 = Delete ==> Existed

            //// if you want to check specific permission is Existed or not
            //// if Existed --> Do Nothing
            //// Else --> Add this permission
            //// Do OR Operation

            //Emp.permission = Emp.permission | Permission.Write;
            //Console.WriteLine(Emp.permission);

            //// OR |
            //// 0111
            //// |
            //// 1000
            ////=1111 ==> Add this Permission





            #endregion
            #endregion

            #region Struct 
            //// Structure before OOP in C 
            //Point P1; // Value Type --> Declare Variable of Type Point
            //          // CLR Allocate bytes in stack(8 bytes) (uninitialized)
            //          //Console.WriteLine(P1.X); //--> invalid  as it's empty

            ////initianlization
            ////1. 
            //P1.X = 10;
            //P1.Y = 20;

            ////2.
            //P1 = new Point();  // Parameterless Constructor
            //// New is just for Constructor Selection
            //// That will initialize the attributes of Struct

            //Console.WriteLine(P1.X);
            //Console.WriteLine(P1.Y);

            //P1 = new Point(5, 7); //x= 5, y= 7

            //// or 
            //P1 = new Point(50); // x= y =50

            //// How to print P1
            //Console.WriteLine(P1); // (50,50) // Boxing, UnBoxing // from Object to String
            //Console.WriteLine(P1.ToString()); // OOPDemo1.Point  //NameSpace.DataType Name
            //                                  // After OverLoad (50,50)
            //                                  // it's better than print P1 
            //                                  // String to String
            //                                  //Struct can inherit  as a Microsoft Built in 
            //                                  // 1. Tostring
            //                                  // 2. GetHashCode
            //                                  // 3. Equals
            //                                  // 4. GetType

            //Point P2 = new(); // Valid as P2 can't hold any data type Except Point so it's Default //.net 5 C# 9
            //Console.WriteLine(P2.X);
            //Console.WriteLine(P2.Y);



            #endregion
            Console.ReadKey();
        }
    }

    public class Employee
    {
         public string Name; // varchar in DB
         public int Age; // int in DB
         public double Salary; // Double in DB
         public Gendre gendre; // Male - Female  // int in DB
                       // we want to make the user enter only Male - Female 
                       // so we use Enum 
                       // not String 

        public Role role; // Admin - Editor - Viewer

        public Permission permission; // int in DB
    }
}
