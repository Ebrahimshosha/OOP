using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2.Inheritance
{
    class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int _X, int _Y) 
        {
            X = _X;
            Y = _Y;
        }
    

        public int Product()
        { 
            return X * Y; 
        }

        public override string ToString()
        {
            return $"({X} , {Y})"; 
        }
    }
}
