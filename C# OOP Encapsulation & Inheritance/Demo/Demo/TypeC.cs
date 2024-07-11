using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class TypeC : TypeA
    {
        //M = 10; // invalid private
        //X = 20; // invalid private protected ==> not inherited
        //Y = 30; // valid ==> protected ==> inherited as private
        //Z = 40; // valid --> internal protected ==> inherited as private 
    }
}
