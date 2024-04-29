using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4
{
    // Abstract Class
    // is a partial implementation (Not Fully Implemented) for another class will complete the implementation in the future
    // U Can't Create object [instance] from Abstract Class, because It Is Not Fully Implemented

    abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

		// Abstract Property
		public abstract decimal Perimeter
        {
            get;
        }

		// Abstract method : if class has abstract method (Not Fully Implemented) must be abstract class
		public abstract decimal CalaArea();
    }

    // Abstract Class
    abstract class RectBase : Shape
    {
        public override decimal CalaArea()
        {
            return Dim01 * Dim02;
        }
    }

    // Concrete Class (Full implementd), U can create object from it
    class Rect : RectBase /*  --→  Inherinte and implement */
    {
        public override decimal Perimeter
        {
            get { return (Dim01 + Dim02) * 2; }
        }
    }

	/*
     *  override :
     *  1. To override virtual method
     *  2. To implement abstract method and abstract property
    */

	// Concrete Class (Full implementd), U can create object from it
	class Square : RectBase
    {
        public Square(decimal Dim)
        {
            Dim01 = Dim02 = Dim;
        }
        public override decimal Perimeter
        {
            get { return Dim01 * 4; }
        }
    }

    // Concrete Class (Full implementd), U can create object from it
    class Circle : Shape
    {
        public Circle(decimal radius)
        {
            Dim01 = Dim02 = radius;
        }
        public override decimal Perimeter
        {
            get { return (2 * 3.14m * Dim01); }
        }

        public override decimal CalaArea()
        {
            return 3.14m * Dim01 * Dim01;
        }
    }
}
