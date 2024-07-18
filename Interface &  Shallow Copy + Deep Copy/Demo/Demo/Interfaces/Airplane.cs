//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Demo.Interfaces
//{
//    internal class Airplane : Vehicle, IMoveable, IFlyable
//    {
//        // Speed --> inherited From Class Vehicle
//        // Forward() --> Implement from Interface
//        // Backward()  --> Implement from Interface
//        // Right()  --> Implement from Interface
//        // Left()   --> Implement from Interface

//        // Forward()
//        // Backward()
//        // Right()
//        // Left()
//        //public void Backward() // Implemented Implicitly 
//        //                      // So which Backward Function from IMoveable | from IFlyable 
//        //                      // So We need to Implement it Explicilty 
//        //{
//        //    throw new NotImplementedException();
//        //}

//        //public void Forward()
//        //{
//        //    throw new NotImplementedException();
//        //}

//        //public void Left()
//        //{
//        //    throw new NotImplementedException();
//        //}

//        //public void Right()
//        //{
//        //    throw new NotImplementedException();
//        //}
//        void IMoveable.Backward() // Implemented Explicitly So we can differntiate it from IMoveable or IFlyable
//        {
//            Console.WriteLine("Airplane Move Backward on Ground");
//        }

//        void IFlyable.Backward()
//        {
//            Console.WriteLine("Airplane Move Backward on Air");
//        }

//        void IMoveable.Forward()
//        {
//            Console.WriteLine("Airplane Move Forward on Ground");
//        }

//        void IFlyable.Forward()
//        {
//            Console.WriteLine("Airplane Move Forward on Air");
//        }

//        void IMoveable.Left()
//        {
//            Console.WriteLine("Airplane Move Left on Ground");
//        }

//        void IFlyable.Left()
//        {
//            Console.WriteLine("Airplane Move Left on Air");
//        }

//        void IMoveable.Right()
//        {
//            Console.WriteLine("Airplane Move Right on Ground");
//        }

//        void IFlyable.Right()
//        {
//            Console.WriteLine("Airplane Move Right on Air");
//        }
//    }
//}
