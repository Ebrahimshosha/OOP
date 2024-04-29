using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2.Inheritance
{
    class Child : Parent
    {
        public int Z;

        public Child(int _X, int _Y,int _Z) : base (_X,_Y)
        // By default this constructor chain on Paramterless Constructor and must write Paramterless Constructor in parent
        // but I will it to chain to the exist constructor in Parent
        {
            Z = _Z;
        }

        public new int Product()
        {
            return X * Y * Z;
            //return base.Product() * Z;
        }

        public override string ToString() // Must be in the first look → public , Virtual
        {
            return $"({X} , {Y} , {Z})";
        }

    }
}
