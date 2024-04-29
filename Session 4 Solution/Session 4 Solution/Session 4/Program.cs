using Session_4.Interface;
using Session_4.operators_Overloading;
using Session_4.PartialClass;
using Session_4.SealdEx;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Session_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
			#region Built-in Interface Iclonable
			/*
                Emoloyee emoloyee1 = new Emoloyee();
                emoloyee1.Id = 1;
                emoloyee1.Name = "Test";
                emoloyee1.Salary = 10_000;
            */
			//// This is an old way to initialize the object

			//// New way
			//// object initializer
			//Emoloyee Emp01 = new Emoloyee() { Id = 10, Name = "Ali", Salary = 10_000 };
			//Emoloyee Emp02 = new Emoloyee() { Id = 20, Name = "May", Salary = 12_000 };

			//Console.WriteLine($"Employee 01 = {Emp01.GetHashCode()}");  // 54267293
			//Console.WriteLine($"Employee 02 = {Emp02.GetHashCode()}");  // 18643596

			#region Shallow Copy

			//Emp02 = Emp01;
			////// This Object { Id = 10, Name = "Ali", Salary = 10_000 } Has 2 References [Emp01, Emp02]
			////// This Object { Id = 20, Name = "May", Salary = 12_000 } had become unreaachable object
			////// Shallow Copy [ Copy Identity (Address) ]

			//Console.WriteLine("After Shallow Copy --→ Emp02 = Emp01 ");

			//Console.WriteLine($"Employee 01 = {Emp01.GetHashCode()}");  // 54267293
			//Console.WriteLine($"Employee 02 = {Emp02.GetHashCode()}");  // 54267293

			//Console.WriteLine($"Employee 01 : {Emp01}"); // Employee 01 : Id = 10, Name = Ali, Salary = $10,000.00
			//Console.WriteLine($"Employee 02 : {Emp02}"); // Employee 02 : Id = 10, Name = Ali, Salary = $10,000.00 
			//Emp01.Salary = 100_000;
			//Console.WriteLine($"Employee 01 : {Emp01}"); // Employee 01 : Id = 10, Name = Ali, Salary = $100,000.00 
			//Console.WriteLine($"Employee 02 : {Emp02}"); // Employee 02 : Id = 10, Name = Ali, Salary = $100,000.00 

			#endregion

			#region Deep copy

			#region 2.1 Deep copy using clone method

			//Emp02 = (Emoloyee)Emp01.Clone();
			//// Clone Method : Will Generate New Object with New and Diffrent Identity
			////                This Object Will Have The Same Object State [Data] of Caller Object "Emp01"
			//// Deep copy

			//Console.WriteLine("After Deep Copy --→ Emp02 = (Emoloyee)Emp01.Clone() ");

			//Console.WriteLine($"Employee 01 = {Emp01.GetHashCode()}");  // 54267293
			//Console.WriteLine($"Employee 02 = {Emp02.GetHashCode()}");  // 33574638

			//Console.WriteLine($"Employee 01 : {Emp01}");  // Employee 01 = Id = 10, Name = Ali, Salary = $10,000.00
			//Console.WriteLine($"Employee 02 : {Emp02}");  // Employee 02 = Id = 10, Name = Ali, Salary = $10,000.00

			//Emp01.Salary = 100_000;

			//Console.WriteLine($"Employee 01 : {Emp01}");  // Employee 01 : Id = 10, Name = Ali, Salary = $100,000.00
			//Console.WriteLine($"Employee 02 : {Emp02}");  // Employee 02 = Id = 10, Name = Ali, Salary = $10,000.00

			#endregion

			#region 2.2 Deep copy using Copy Constructor

			//Emp02 = new Emoloyee(Emp01);

			//Console.WriteLine("Deep copy using Copy Constructor ");

			//Console.WriteLine($"Employee 01 = {Emp01.GetHashCode()}");  // 54267293
			//Console.WriteLine($"Employee 02 = {Emp02.GetHashCode()}");  // 33574638

			//Console.WriteLine($"Employee 01 : {Emp01}");  // Employee 01 = Id = 10, Name = Ali, Salary = $10,000.00
			//Console.WriteLine($"Employee 02 : {Emp02}");  // Employee 02 = Id = 10, Name = Ali, Salary = $10,000.00

			//Emp01.Salary = 100_000;

			//Console.WriteLine($"Employee 01 : {Emp01}");  // Employee 01 : Id = 10, Name = Ali, Salary = $100,000.00
			//Console.WriteLine($"Employee 02 : {Emp02}");  // Employee 02 = Id = 10, Name = Ali, Salary = $10,000.00

			#endregion

			#endregion

			#endregion

			#region Built-In Interface ICompareable

			//int[] Numbers = { 1, 2, 3, 4, 5, };

			//Array.Sort(Numbers);
			////Array has a class member method its named "sort"
			//// And sort call "compareTo" method and "compareTo" exist in IComparable intreface
			//// int class implement IComparable intreface, IComparable intreface has "compareTo" method

			//foreach (int i in Numbers)
			//	Console.WriteLine(i);  // Array is sorted

			//Emoloyee[] emoloyees =
			//{
			//	 new Emoloyee() { Id = 10 , Name = "Omar", Salary = 17_000},
			//	 new Emoloyee() { Id = 20 , Name = "Hema", Salary = 19_000},
			//	 new Emoloyee() { Id = 30 , Name = "Maya", Salary = 18_000}
			//};

			//Array.Sort(emoloyees);
			//// Failed to compare two elements in the array ,
			//// because Sort call "compareTo" method and "compareTo" exist in IComparable intreface
			//// and Employee class Not implement IComparable intreface, So Employee Must implement IComparable intreface

			//// Before implement IComparable intreface ()
			////foreach (Emoloyee emo in emoloyees)
			////{
			////    Console.WriteLine(emo);
			////} // InValid because it doesn't know Sort by any Attribute

			//// After implement IComparable intreface()
			//foreach (Emoloyee emo in emoloyees)
			//{
			//	Console.WriteLine(emo);
			//} // Valid 

			//// Test "compareTo"
			//int Result = emoloyees[0].CompareTo(emoloyees[1]);
			//Console.WriteLine(Result);

			#endregion

			#region Abstraction

			////Shape shape = new Shape(); // Not Valid → Shape is abstract

			//Rect rect = new Rect() { Dim01 = 10, Dim02 = 50 };

			//decimal rectArea = rect.CalaArea();
			//decimal rectPerimeter = rect.Perimeter;

			//Console.WriteLine($"Rect Area = {rectArea}");
			//Console.WriteLine($"Rect Premiter = {rectPerimeter}");

			//Circle circle = new Circle(10.10m);

			//decimal circlePerimeter = circle.Perimeter;
			//decimal circleCalaArea = circle.CalaArea();

			//Console.WriteLine($"circle Perimeter= {circlePerimeter}");
			//Console.WriteLine($"circle CalaArea = {circleCalaArea}");

			#endregion

			#region Operators Overloading

			//Complex C1 = new Complex() { Real = 2, Imag = 3 };
			//Complex C2 = new Complex() { Real = 3, Imag = 5 };

			//Complex C3 = default; // NULL

			#region +, +=, ++

			//C3 = C1 + C2;

			//Console.WriteLine($"C1 = {C1}");
			//Console.WriteLine($"C1 = {C2}");
			//Console.WriteLine($"C3 = {C3}");

			//C1 += C2; // Valid → C1 = C1 + C2
			//Complex c4 = C1 + C2 + C3; // Valid

			//Console.WriteLine($"C1 = {C1}");
			//Complex C5 = ++C1;
			//Console.WriteLine("After increase C1 ++");
			//Console.WriteLine($"C1 = {C5}");

			#endregion

			#region >, <

			//Complex C10 = new Complex() { Real = 3, Imag = 3 };
			//Complex C20 = new Complex() { Real = 3, Imag = 3 };

			//Console.WriteLine($"C10 = {C10}");
			//Console.WriteLine($"C20 = {C20}");

			//if (C10 > C20)
			//	Console.WriteLine("C10 is greter than C20");
			//else if (C10 < C20)
			//	Console.WriteLine("C10 is Less than C20");
			//else
			//	Console.WriteLine("C10 == C20");

			#endregion

			//object obj = 5;
			//int X = (int)obj; // Explicit Casting

			//int Y = (int)C1; // Explicit Casting (Recommended) → Readable
			//Console.WriteLine(Y); // 2

			//string str = /*string*/ C1; // Implicit Casting
			//Console.WriteLine(str);

			#endregion;

			#region User-Defiend Casting Operator

			//User user = new User()
			//{
			//	Id = 1,
			//	FullName = "Ebrahim shosha",
			//	Email = "ebrahimshosha@gmail.com",
			//	Password = "p@sw0rd",
			//	SecurityStamp = Guid.NewGuid().ToString()
			//};

			//// Manual Mapping
			//UserViewModel userView = (UserViewModel)user;
			//Console.WriteLine(userView.Id);
			//Console.WriteLine(userView.FName);
			//Console.WriteLine(userView.LName);
			//Console.WriteLine(userView.Email);

			#endregion

			#region Static (Class, Method, Constructor, Property, Attribute)

			////Utility U01 = new Utility(10, 20);
			////Utility U02 = new Utility(30, 40);
			////Console.WriteLine(U01.GetInch(254)); // 100
			////Console.WriteLine(U02.GetInch(254)); // 100

			////The Result of Calling Method "GetInch"
			//// Won't Differ by the Diffrence of the object State [Data (X, Y)]
			//// So we call Methods from Class directly not object

			//Console.WriteLine(Utility.GetInch(254));
			//Console.WriteLine(Utility.calcCircleArea(10));

			#endregion

			#region Sealed class, method, property

			//Parent parent = new Parent();
			//parent.Salary = 1000;
			//Console.WriteLine(parent.Salary); // 2000

			//Child child = new Child();
			//child.Salary = 1000;
			//Console.WriteLine(child.Salary); // 3000 

			#endregion

			#region Partial class

			//Employee employee = new Employee()
			//{
			//	Id = 1,
			//	Name = "Ibrahim",
			//	Age = 19,
			//	Salary = 10_000
			//};

			#endregion

			//1. Concrete Class : it’s a full implementation,it’s a class that allows creating an instance or an object, Another classes could inherit from it and it can inherit from anoter class
			//2. Abstract Class : it’s a partial implementation (Not Fully Implemented) for another class will complete the implementation in the future, it is not Concrete Clas, it’s a class that doesn't allow creating an instance or an object , because It Is Not Fully Implemented
			//3. Static   Class : is a Just Container For Static Members [Attributes, Property, Constructor, Method], U can't Create Object from This Class (Helper Class), it’s a class that doesn't allow creating an instance or an object, No Inheritance for this Class
			//4. Sealed   Class : when we don't want a class to be inherited by another class
			//5. Partial  Class : One part of the class contains the signature of the method. An implementation can be defined in the same part or another part
		}
	}
}