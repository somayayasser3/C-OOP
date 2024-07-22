using OOPAssign5Sol.Project01;
using OOPAssign5Sol.Project02;
using OOPAssign5Sol.Project03;
using System;

namespace OOPAssign5Sol
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Project01

            //_3DPoint Point01 = new _3DPoint(10, 10, 10);
            //Console.WriteLine(Point01);

            ////Console.WriteLine("Please Enter Point1:");
            ////int x1, y1, z1, x2, y2, z2;
            ////Console.Write("X1: ");
            ////x1 = int.Parse(Console.ReadLine()); // will Throw FormatException
            ////Console.Write("Y1: ");
            ////y1 = Convert.ToInt32(Console.ReadLine()); // will Throw FormatException
            ////Console.Write("Z1: ");
            ////int.TryParse(Console.ReadLine(), out z1);

            ////_3DPoint P1 = new _3DPoint(x1, y1, z1);
            ////Console.WriteLine("Please Enter Point2: ");
            ////Console.Write("X2: ");
            ////x2 = int.Parse(Console.ReadLine()); // will Throw FormatException
            ////Console.Write("Y2: ");
            ////y2 = Convert.ToInt32(Console.ReadLine()); // will Throw FormatException
            ////Console.Write("Z2: ");
            ////int.TryParse(Console.ReadLine(), out z2);
            ////_3DPoint P2 = new _3DPoint(x2, y2, z2);


            //// To Avoid Exception 
            //Console.WriteLine("Please Enter Point1:");
            //int x1, y1, z1, x2, y2, z2;

            //bool flag;
            //do
            //{
            //    Console.Write("X1: ");
            //    flag = int.TryParse(Console.ReadLine(), out x1);

            //} while (!flag);

            //do
            //{
            //    Console.Write("Y1: ");
            //    flag = int.TryParse(Console.ReadLine(), out y1);

            //} while (!flag);

            //do
            //{
            //    Console.Write("Z1: ");
            //    flag = int.TryParse(Console.ReadLine(), out z1);

            //} while (!flag);

            //_3DPoint P1 = new _3DPoint(x1, y1, z1);

            //Console.WriteLine("Please Enter Point2: ");

            //do
            //{
            //    Console.Write("X2: ");
            //    flag = int.TryParse(Console.ReadLine(), out x2);

            //} while (!flag);

            //do
            //{
            //    Console.Write("Y1: ");
            //    flag = int.TryParse(Console.ReadLine(), out y2);

            //} while (!flag);

            //do
            //{
            //    Console.Write("Z1: ");
            //    flag = int.TryParse(Console.ReadLine(), out z2);

            //} while (!flag);

            //_3DPoint P2 = new _3DPoint(x2, y2, z2);

            //Console.WriteLine($"P1: {P1}");
            //Console.WriteLine($"P2: {P2}");

            //if (P1 == P2) // Does not Work without Operator Overloading
            //    Console.WriteLine("P1 , P2 are Equal");
            //else
            //    Console.WriteLine("P1 , P2 are Not Equal");

            //Console.Write("Please Enter The Size Of Array:  ");
            //int Num;
            //do
            //{
            //    flag = int.TryParse(Console.ReadLine(), out Num);

            //} while (!flag || Num == 0);

            //_3DPoint[] Points = new _3DPoint[Num];
            //if (Points?.Length != 0)
            //{
            //    for (int i = 0; i < Points.Length; i++)
            //    {
            //        Points[i] = new _3DPoint();
            //        Console.Write($"Please Enter X Points[{i}]: ");
            //        Points[i].X = int.Parse(Console.ReadLine());                  
            //        Console.Write($"Please Enter Y Points[{i}]: ");
            //        Points[i].Y = int.Parse(Console.ReadLine());
            //        Console.Write($"Please Enter Z Points[{i}]: ");
            //        Points[i].Z = int.Parse(Console.ReadLine());
            //    }
            //}

            //Array.Sort(Points, new _3DPointsCompare());
            //Console.WriteLine("Array After Sorting: ");
            //foreach(_3DPoint item in Points)
            //{
            //    Console.WriteLine(item);
            //}

            //_3DPoint point01 = new _3DPoint(1, 2, 3);
            //_3DPoint point02 = (_3DPoint)point01.Clone();
            //Console.WriteLine($"HC OF point01 = {point01.GetHashCode()}");
            //Console.WriteLine($"HC OF point02 = {point02.GetHashCode()}");
            //Console.WriteLine($"point01 = {point01}");
            //Console.WriteLine($"point02 = {point02}");

            #endregion

            #region Project02
            //Console.WriteLine(Maths.Add(3, 5));
            //Console.WriteLine(Maths.Subtract(3, 5));
            //Console.WriteLine(Maths.Multiply(3, 5));
            //Console.WriteLine(Maths.Divide(3, 0));
            #endregion

            #region Project03

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1);

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2);

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3);

            Duration D4 = new Duration(666);
            Console.WriteLine(D4);

            D3 = D1 + D2;
            Console.WriteLine(D3);

            D3 = D1 + 7800;
            Console.WriteLine(D3);

            D3 = 666 + D3;
            Console.WriteLine(D3);

            D3 = ++D1;
            Console.WriteLine(D3);

            D3 = --D2;
            Console.WriteLine(D3);

            D1 = D1 - D2;
            Console.WriteLine(D1);
            if(D1 > D2)
            {
                Console.WriteLine("D1 is Greater Than D2");
            }
            else Console.WriteLine("D1 is Less Than D2");
            if(D1 <= D2)
            {
                Console.WriteLine("D1 is Less Than or Equal D2");
            }
            else
            {
                Console.WriteLine("D1 is Not Less Than or Equal D2");
            }
            if (D1 != null) Console.WriteLine("D1 is Not Null");
            //DateTime Obj = (DateTime)D1;
            //Console.WriteLine(Obj);
            
            #endregion



            Console.ReadKey();
        }
    }
}
