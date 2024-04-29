using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4.SealdEx
{
    internal class Parent
    {
        private int salry;

        public virtual int Salary
        {
            get { return salry; }
            set { salry = value + 1000; }
        }

        public virtual void Print()
        {
            Console.WriteLine("Hello Parent");
        }
    }

    internal class Child:Parent
    {
        // sealed property : U Can't override on sealed property in another classes inherite from Child
        public sealed override int Salary 
        { 
            get => base.Salary;
            set => base.Salary = value + 1000;
        }

        // sealed Method : U Can't override on sealed Method in another classes inherite from Child
        public sealed override void Print()
        {
            Console.WriteLine("Hello Child");
        }
    }

    // Sealed Class : No Classes can inherite from it
    internal sealed class GrandChild : Child
    {
        //public override void Print()
        //{
        //    Console.WriteLine("Hello GrandChild");
        //}
    }
}
