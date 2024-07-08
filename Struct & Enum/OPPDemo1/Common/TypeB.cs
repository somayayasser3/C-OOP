using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    internal class TypeB  // internal Accessible only at the same Project
    {
        public TypeB()
        {
            TypeA tybeA = new TypeA(); // Available here as it's Public in the same Project and External Project (import)
            //tybeA.X = 10; // invalid as X is Private (not accessible out its scope)
            tybeA.Y = 20; // Valid (Internal) accessible at Scope and its Project
            tybeA.Z = 5; //Valid (Public) // Accessible at its scope, at the same project, at External Project

        }
    }
}
