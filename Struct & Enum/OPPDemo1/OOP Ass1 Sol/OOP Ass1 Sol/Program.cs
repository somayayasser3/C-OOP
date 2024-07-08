using System;
namespace OOP_Ass1_Sol
{

    public enum WeekDays: byte
    {
        Monday ,
        Tuesday ,
        Wednesday ,
        Thursday ,
        Friday ,
        Saturday ,
        Sunday
    }

    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    public enum Month
    {
        March = 1,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,
        January,
        Febraury
    }
    [Flags]
    public enum Permission : byte
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    [Flags]
    public enum Colors : byte 
    {
        Red = 1,
        Green = 2,
        Blue = 4
    }

    public struct Point
    {
        public double X;
        public double Y;

        public Point(double _X, double _Y)
        {
            this.X = _X;
            this.Y = _Y;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {

            #region Q1- Print WeekDays Enum Members
            //WeekDays WeekDay;
            //for (int i = 1; i < 8; i++)
            //{
            //    WeekDay = (WeekDays)i;
            //    Console.WriteLine(WeekDay);
            //}
            #endregion

            #region Q2- Month Range
            //Console.Write("Please Enter a Season Name: ");
            //string SeasonName = Console.ReadLine();
            //bool flag = Enum.TryParse<Season>(SeasonName, true, out Season res); 
            ////Console.WriteLine(res);
            //if (flag)
            //{
            //    if (res == Season.Spring)
            //    {
            //        for (int i = 1; i <= 3; i++)
            //        {
            //            Console.WriteLine((Month)i);
            //        }
            //    }
            //    else if (res == Season.Summer)
            //    {
            //        for (int i = 4; i <= 6; i++)
            //        {
            //            Console.WriteLine((Month)i);
            //        }
            //    }
            //    else if (res == Season.Autumn)
            //    {
            //        for (int i = 7; i <= 9; i++)
            //        {
            //            Console.WriteLine((Month)i);
            //        }
            //    }
            //    else if (res == Season.Winter)
            //    {
            //        for (int i = 10; i <= 12; i++)
            //        {
            //            Console.WriteLine((Month)i);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Season Entered.");
            //}

            #endregion

            #region Q3- Employee Permissions
            //Employee Emp = new Employee();
            //Emp.per = (Permission)3; // Read & Write

            //Console.WriteLine(Emp.per);
            ////if ((Emp.per & Permission.Execute) == Permission.Execute)
            ////{
            ////    // To Delete
            ////    Console.WriteLine("Execute Is Existed");
            ////    Emp.per = Emp.per ^ Permission.Execute;
            ////}
            ////else
            ////{
            ////    // To Add
            ////    Console.WriteLine("Execute isn't Existed ");
            ////    Emp.per = Emp.per ^ Permission.Execute;
            ////}
            ////Console.WriteLine(Emp.per);

            ////if ((Emp.per & Permission.Read) == Permission.Read)
            ////{
            ////    // To Delete
            ////    Console.WriteLine("Read Is Existed");
            ////    Emp.per = Emp.per ^ Permission.Read;
            ////}
            ////else
            ////{
            ////    // To Add
            ////    Console.WriteLine("Read isn't Existed ");
            ////    Emp.per = Emp.per ^ Permission.Read;
            ////}
            ////Console.WriteLine(Emp.per);
            #endregion

            #region Q4- Colors
            //Console.Write("Please Enter A Color: ");
            //string Col = Console.ReadLine();
            //bool Flag = Enum.TryParse(Col, true, out Colors res);
            //if (Flag)
            //{
            //    if (res == Colors.Blue || res == Colors.Green || res == Colors.Red)
            //    {
            //        Console.WriteLine($"The {res} is Primary Color");
            //    }

            //    else 
            //    {
            //        Console.WriteLine($"The {Col} is not Primary Color");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"The {Col} is Invalid Color");
            //}
            #endregion

            #region Q5- Distance Between Points
            //double x1, y1 , x2 , y2;
            //bool Flag;
            //do
            //{
            //    Console.Write("Please Enter The x1: ");
            //    Flag = double.TryParse(Console.ReadLine(), out x1);
            //} while (!Flag);


            //do
            //{
            //    Console.Write("Please Enter The y1: ");
            //    Flag = double.TryParse(Console.ReadLine(), out y1);
            //} while (!Flag);

            //Point P1 = new Point(x1, y1);

            //////////////////////////////////////////
            //do
            //{
            //    Console.Write("Please Enter The x2: ");
            //    Flag = double.TryParse(Console.ReadLine(), out x2);
            //} while (!Flag);


            //do
            //{
            //    Console.Write("Please Enter The y2: ");
            //    Flag = double.TryParse(Console.ReadLine(), out y2);
            //} while (!Flag);
            //Point P2 = new Point(x2, y2);

            //double Distance = Math.Sqrt((Math.Pow((P1.X - P2.X), 2)) + (Math.Pow((P1.X - P2.X), 2)));

            //Console.WriteLine(Distance);
            #endregion
            Console.ReadKey();
        }

    }

    public class Employee
    {
        public string Name;
        public int Age;
        public Permission per;
    }
}
