using System;
using Demo.Encapsulation;
using Demo.Inheritance;
using Common; 
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation
            ////Employee Emp = new Employee(); // new in struct doesn't create object, it is just to detect which constructor used to initialize values
            ////                               // here , used default constructor (default values)
            ////Console.WriteLine(Emp);
            //Employee Emp = new Employee(1, "Somaya", 3000, 10); // user defined constructor
            //// Console.WriteLine(Emp);


            //// how to change Attribute value
            //Emp.id = 20; // Set Id Directly through its Attribute
            //// Console.WriteLine(Emp.Id); // Get Id Directly through its Attribute

            //// 1. What if the Atrribute Name Changes After that , the external Classes will not know that these attributes have been changed 
            //// So we shouldn't use the Atrribute name to change its value
            //// 2. if i want to make my attribute read only (get (public) not set (private))
            //// we can't make it private (not get not set) // or using property , make setter private or delete it from Property
            //// 3. i can't control the attribute values (put Constraint) // check condition before setter 

            //// Emp.Name; //Invalid (Private) no set or get througth attribute Name
            //// So use Getter
            //Console.WriteLine(Emp.GetName()); // get value using Getter

            //// So use Setter
            //Emp.SetName("Yousef"); // set value using Setter
            //Console.WriteLine(Emp.GetName());

            //// use Property 
            ////Emp.Salary; // not valid as salary is Attribute is private not accessible

            //Emp.Salary = 2000; // Set property as a Setter
            //Console.WriteLine(Emp.Salary); // Getter Property as a Getter

            //// Automatic Property
            //Emp.Age = 24;
            //Console.WriteLine(Emp.Age);
            //// Read only Property
            //Console.WriteLine(Emp.Deduction);
            #endregion

            #region Indexer
            // Special Properity [This] can take parameters
            // User For Array , String [Array of Chars]
            // Indexer for String have no Setter

            //PhoneBook Note = new PhoneBook(3);
            //Note.AddPerson(0, "Somaya", 123);

            //// Use Setter & Getter with Array Attribute
            //int Num = Note.GetPersonNumber("Ahmed");
            //if (Num == -1)
            //{
            //    Console.WriteLine("Person not Found");
            //}
            //else Console.WriteLine(Num);

            //Note.SetPersonNumber("Somaya", 999); // Setter
            //Console.WriteLine(Note.GetPersonNumber("Somaya")); // Getter

            // Use Properity for Array Attribute ==> use name as index of array [indexer this]
            //Console.WriteLine(Note["Somaya"]); // Use Indexer as a Getter
            //Note["Somaya"] = 999; // Use Indexer as a Setter
            //Console.WriteLine(Note["Somaya"]);

            //// To Print All elements in Array
            //for (int i = 0; i < Note.Size; i++)
            //{
            //    Console.WriteLine(Note[i]);
            //}

            #endregion

            #region Class
            //Car C1;
            //// Declare Reference from Type Car
            //// Can refer to an Object From Type Car
            //// Or An Object from class [inherit from Class Car]
            //// CLR will Allocate 4 Bytes for Reference "C1" at Stack
            //// Zero Bytes Allocated At Heap
            //C1 = new Car(); // Parameterless Construtor
            //// New ==>
            //// 1. Allocate Required Bytes At Heap 16 Bytes
            //// 2. Initialize Allocated Bytes with Default value of DataType
            //// 3. Call User Defined Constructor [If Exist]
            //// 4. Assign the Reference C1 to Allocated Object
            //Console.WriteLine(C1);

            //Car C1 = new Car(10, "BMW", 209);
            //Console.WriteLine(C1);

            //Car C2 = new Car(20, "BYD");
            //Console.WriteLine(C2);

            //Car C3 = new Car(30);
            //Console.WriteLine(C3);
            #endregion

            #region Inheritance
            ////Parent P1 = new Parent(1, 2);
            ////Console.WriteLine(P1);
            ////Console.WriteLine(P1.Product());

            //Child ch = new Child(3, 4, 5);
            //Console.WriteLine(ch.ToString());
            //Console.WriteLine(ch.Product());
            #endregion

            #region Access Modifiers
            //TypeA obj1 = new TypeA();
            //obj1.X = 10; // invalid [private]
            //obj1.Y = 20; // invalid [private]
            //obj1.Z = 30; // valid [intenal]
            //obj1.M = 40; // INVALID [private]

            //TypeB objB = new TypeB();
            //objB.X = 10; // invalid private
            //objB.Y = 20; // invalid private
            //objB.Z = 30; // invalid internal

            //TypeC obj = new TypeC();
            //obj.X = 20; // invalid
            //obj.Y = 30; // invalid
            //obj.Z = 40; // invalid 
            //obj.M = 20; // invalid
            #endregion
            Console.ReadKey();
        }
    }
}
