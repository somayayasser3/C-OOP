using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Inheritance
{
    internal class Parent
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Constructor
        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"X: {X} , Y: {Y}";
        }

        public virtual int Product() // virtual: to allow to override this function 
        {
            return X * Y;
        }

        #endregion
    }
}
