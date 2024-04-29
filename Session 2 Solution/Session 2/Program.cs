using Session_2.Inheritance;
using System;
using System.Security.Cryptography.X509Certificates;
using Common;

namespace Session_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Class and Constructors and Constructor Chaining

			//Car C1;
			///// Declare for Reference from type "Car" ,Refering to NULL
			///// Can Refer to an Object from type "Car" OR an object from Another Class inheriting from "Car"
			///// CLR will allocate 4 bytes for the reference "C1" at Stack
			///// CLR will allocate 0 bytes at Heap

			//C1 = new Car(10, "KIA", 180);
			///// new
			///// Allocate Required numbers of bytes for the object at Heap [16 bytes]
			///// Initialize Allocated Bytes of the object with the default value of its datatype 
			///// Call User-Defined constructor [if exists]
			///// Assign the Address of the Allocated Object at Heap to the Reference "C1"
			//Console.WriteLine(C1.ToString());

			//Car C2 = new Car(10, "KIA");
			//Console.WriteLine(C2.ToString());

			//Car C3 = new Car(10);
			//Console.WriteLine(C3.ToString());

			#endregion

			#region Inheritance

			//Parent P1 = new Parent(1, 2);

			//Console.WriteLine(P1.Product());    // 2
			//Console.WriteLine(P1.ToString());   // (1, 2)

			//Child C1 = new Child(1, 2, 3);

			//Console.WriteLine(C1.Product());    // 2       After overriding →  6
			//Console.WriteLine(C1.ToString());   // (1, 2)  After overriding →  (1, 2, 3)

			#endregion

			/// Relationships Between Classes
			/// 1. Inheritance : is  a [FullTimeEmployee is  an Employee]
			/// 2. Aggregation : has a [Order            has an item]
			///    2.1 Composition [room has a wall]
			///    2.2 Association [room has a chair]

			#region Access Modifiers (Private Protected, Protected, Internal Protected)

			// NO Inheritance

			TypeA obj = new TypeA();

			//obj.X = 1; // Invalid : X is Private
			//obj.Y = 2; // Invalid : Y is Private
			//obj.Z = 3; // Invalid : Z is Internal 

			// Inheritance in TypeB in Session 2

			#endregion
		}
	}
}