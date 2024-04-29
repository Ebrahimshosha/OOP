using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4
{
    // Static Class:
    // is a Just Container For Static Members [Attributes, Property, Constructor, Method]
    // U can't Create Object from This Class (Helper Class)
    // No Inheritance for this Class

    // Static Class Famous : Math

    internal static class Utility
    {
		/// Static Constructor : ** every class has one and Only One Static Constructor
		/// Will be excuted just only one time per class lifetime before the first usage of class
		/// Usages of Class
		/// 1. Create Object From This Class
		/// 2. Create Object From another Class inheriting From This Class
		/// 3. Call Static Method
		/// 4. Call Static property

		//Static Constructor : Ther is no constructor Overloading Because it doesn't Take any Parameter
		//static Utility()  
		//    // Static Constructor →  used to initialize any static data (Attribute),
		//    // or to perform a particular action that needs to be performed only once.
		//{
		//    pi = 3.14; // U can intialize static data when u  declare it in U use Constant Attribute (line 35)
		//}

		// 1. Static Attribute
		// private static double pi = 3.14;
		// Compiler Will Initialize The Static Attribute With The Default Value Of its Data Type = 0

		// 2. Constant Attribute  
		private const double pi = 3.14;
        // In const : 
        // 1. U must delete set from Static property 
        // 2. U must inialize it (pi = 3.14)

        // Class Member property : Static property
        // Static property Get and Set one of these :
        // 1. Static Attribute
        // 2. Constant
        public static double Pi
        {
            get { return pi; }
            //set { pi = value; }
        }

        // Class Member Method : Static Method
        public static double GetInch(double cm)
        {
            return cm / 2.54;
        }

        // Class Member Method : Static Method
        public static double calcCircleArea(double Radius)
        {
            return Pi * Math.Pow(Radius, 2);
        }

    }
}
