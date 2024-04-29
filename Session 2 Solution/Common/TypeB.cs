using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common

{
    //No Inheritance
    //internal class TypeB
    //{
    //    public TypeB()
    //    {
    //        TypeA obj = new TypeA();

    //        // obj.X = 1; // Invalid : X is Private
    //        // obj.Y = 2; // Invalid : Y is Private
    //        // obj.Z = 3; // valid   : Z is Internal
    //    }
    //}

    // Inheritance
    public class TypeB : TypeA
    {
        public TypeB() 
        {
            /*
             * X is Private
             * Y is Private
             * Z is internal
             */
        }
    }
}
