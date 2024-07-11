using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class Car
    {

        #region Attributes
        //int id;
        //string model;
        //double speed;
        #endregion

        #region Properties
        public int Id { get; set; } // 4 Bytes
        public string Model { get; set; } // 4 Bytes for Reference
        public double Speed { get; set; } // 8 Bytes
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"CarId: {Id}\nModel: {Model} \nSpeed: {Speed}";
        }
        #endregion

        #region Constructors
        // Constructor in Class :
        //If There is no User defined Constructor, Compiler Will Always Generate Empty Parameterless constructor => Will do Nothing.
        //If You defined a User defined Constructor ,  Compiler Will No Longer Generate Empty Parameterless constructor.

        //// Empty Paramterless Constructor
        public Car()
        {
            // Do Nothing
        }
        public Car(int id, string model, double speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
        }
        // Constructor Chaining
        public Car(int id, string model):this(id, model, 190) // perform chain before the constructor itself // Go to the above Constructor then --> the Constuctor itself
        {
            //Id = id;
            //Model = model;
            //Speed = 190;
        }
        //public Car(int id):this(id , "Audi", 200)
        //{
        //    //Id = id;
        //    //Model = "Audi";
        //    //Speed = 200;
        //}

        public Car(int id) : this(id, "Audi") // Go to 
                                              // 1. Constructor 2 
                                              // 2. Constructor 1
                                              // 3. Constructor 3
        { 
            //Id = id;
            //Model = "Audi";
            //Speed = 200;
        }

        #endregion
    }
}
