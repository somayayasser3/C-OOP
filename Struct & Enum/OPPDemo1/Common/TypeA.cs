using System;
using System.Collections.Generic;
using System.Text;

                    // Class Library: Project isn't Executable without Main
                    // (Rosylen) Coverted to IL only
                    // users can use it into there projects with import its name (using ClassName)
                    // Console App: C# (Rosylen) --> IL(Jet) --> Native Code(Executable File)

namespace Common
{
    public class TypeA // Public Accessible 
    {                  // 1. at Same Project (Internal)
                       // 2.  at Different Project (External) in condition to import this class (using ClassName)              

        #region What You Can Write Inside The Struct Or Class
        // 1. Attributes[Fields] => Member Variable  
        // 2. Functions[Constructor, Getter Setter, Method]
        // 3. Properties[Full Property, Automatic Property, Indexer]
        // 4. Events
        #endregion

        #region Access Modifier Allowed Inside Class?
        // 1. Private [Default]
        // 2. Private Protected --> inheritance
        // 3. Protected --> inheritance
        // 4. Internal
        // 5. Protected Internal --> inheritance
        // 6. Public
        #endregion

        #region Access Modifier Allowed Inside Struct?
        // 1. Private[Default]
        // 2. Internal
        // 3. Public
        // Protected is't Allowed as Struct doesn't Support inheritance
        #endregion

        int X; // Lock // Accessible within its Project in its Scope not all Project
        internal int Y; // Heart // Accessible within its Project 
        public int Z; // No sign // Accessible at its Scope , at the same Project , at External Project
        TypeB obj = new TypeB(); // valid at the same Project

        void print()
        {
            Console.WriteLine(X); //Valid
        }
    }
}
