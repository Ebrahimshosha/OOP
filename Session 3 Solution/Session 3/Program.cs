
using Session_3.Interfaces;
using Session_3.PolyMorphism_Overriding;
using System.Runtime.CompilerServices;

namespace Session_3
{
    internal class Program
    {
        #region Polymerphism 1. Function overloading
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        public static double Sum(double x, double y, double z)
        {
            return x + y + z;
        }
        #endregion

        #region When U Need Binding
        /*

        public static void ProcessEmployee(FullTimeEmployeee employee)
        {
            if (employee is not null)
            {
                employee.MyFun1();
                employee.MyFun2();
            }
        }

        public static void ProcessEmployee(PartTimeEmployeee employee)
        {
            if (employee is not null)
            {
                employee.MyFun1();
                employee.MyFun2();
            }
        }
        */
        // This is hbd (3k) This is not overloading because two function have same behavioures(code)


        public static void ProcessEmployee(Employee employee)  
        {
			// empployee is a referene refer to object from employee or any object inheriting from employee (FullTimeEmployeee, PartTimeEmployeee)
			if (employee is not null)
            {
                employee.MyFun1();  // Static  Binded Function → Always → I am Employee
                employee.MyFun2();  // Dynamic Binded Function → Based on object
            }
        }
        // This is Binding  
        #endregion

        #region Interface Example 02
        /*
        public static void Print10NumbersFromSeries(SeriesByTwo series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{series.Current}  ");
                    series.GetNext();
                }
                series.Reset();
                Console.WriteLine();
            }
        }

        public static void Print10NumbersFromSeries(SeriesByThree series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{series.Current}  ");
                    series.GetNext();
                }
                series.Reset();
                Console.WriteLine();
            }
        }
        */

        public static void Print10NumbersFromSeries(ISeries series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{series.Current}  ");
                    series.GetNext();
                }
                series.Reset();
                Console.WriteLine();
            }
        } 
        #endregion

        static void Main(string[] args)
        {

            #region Polymerphism 1. Function Overloading

            //// Function overloading is a very well - known concept used in object-oriented languages
            //// having many functions with the same name and different parameters in a single code
            //// Support in Class, Struct

            //Console.WriteLine(Sum(5, 10));

            //Console.WriteLine(Sum(5, 10, 5));

            //Console.WriteLine(Sum(0.2, 0.4, 0.5));

            #endregion

            #region Polymerphism 2. Function Overriding

            //TypeA typeA = new TypeA();
            //Console.WriteLine(typeA.A); // 0 beacuse the constructor is empty paramterless with default values

            //typeA = new TypeA(11);
            //typeA.A = 11;
            //typeA.MyFun1(); // I am Base [Parent]
            //typeA.MyFun2(); // TypeA : A = 11

            //TypeB typeB = new TypeB(5, 10);
            //typeB.A = 11;
            //typeB.B = 12;
            //typeB.MyFun1(); // I am BDerived [Child]                          
            //typeB.MyFun2(); // TypeA : A = 11, TyeB : B = 12 

            #endregion

            #region What is Binding

            //// Reference from parent refere to Object from child

            //TypeA RefBase;
            //// Refernce eligable to refer to object from type "TypeA" or object from class inherting from class type "TypeA" (TypeB)

            //RefBase = new TypeB(1, 2); // Binding

            //// RefBase sees only the parent part from child 
            //RefBase.A = 11;  // Valid      RefBase see A
            ////RefBase.b = 10;  // Not valud  RefBase Not see b


            //RefBase.MyFun1();               // excute MyFun1 in TypeA  // I am Base [Parent]
            //// Static Binding [Early Binding]
            //// Compiler will Bind function Call Based on Reference Type Not Object type
            //// at Compilation time

            //RefBase.MyFun2(); // "override" // excute MyFun1 in TypeB  // TypeA : A = 11, TyeB : B = 2
            ////Dynamic Binding[Late Binding]
            //// CLR will Bind function Call Based on Object Type Not Reference type
            //// at RunTime time

            #endregion

            #region No Binding

            //// Animal =    Dog                  → Binding
            //// Animal is a Dog                  → Binding

            //// FullTimeEmoloyee is a Employeee  → Binding

            //// Dog = Animal         → NoBinding
            //// Dog = ( Dog )Animal  → Explicit Casting

            //TypeA ReffBase;
            //ReffBase = new TypeA(1);     // Valid
            //ReffBase = new TypeB(1, 2);  // Valid

            //TypeB ReffChild = (TypeB)ReffBase;  // Casting operator

            //ReffChild.B = 100;  // → No Binding
            //Console.WriteLine(ReffChild);

            #endregion

            #region When U Need Binding

            //FullTimeEmployeee fullTimeEmployeee = new FullTimeEmployeee();
            //ProcessEmployee(fullTimeEmployeee);

            //PartTimeEmployeee partTimeEmployeee = new PartTimeEmployeee();
            //ProcessEmployee(partTimeEmployeee);

            #endregion

            /// TypeA typeA = new TypeC(1, 2, 3);  // typeA is an Indirect Parent for TypeC
            /// typeA.A = 11;
            /// // typeA.B = 2;  //  Invalid
            /// // typeA.C = 3;  // Invalid
            /// typeA.MyFun1(); // Static  Binded Function → I am Base [parent]
            /// typeA.MyFun2(); // Dynamic Binded Function → TypeC : A = 11,B = 2,C = 3

            /// TypeB typeB = new TypeC(1, 2, 3);  // typeB is an direct Parent for TypeC
            /// typeB.A = 11;
            /// typeB.B = 2;
            /// // typeB.C = 3;  // Invalid             
            /// typeB.MyFun1(); // Static  Binded Function → I am Derived [Child]
            /// typeB.MyFun2(); // Dynamic Binded Function → TypeC : A = 11,B = 2,C = 3

            #region More practise

            //TypeA typeA = new TypeD(1, 2, 3, 4); // Indirect Parent
            //TypeB typeB = new TypeD(1, 2, 3, 4); // Indirect Parent
            //TypeC typeC = new TypeD(1, 2, 3, 4); // Direct   parent   

            //typeA.MyFun2();  // TypeC : A = 1, B = 2, C = 3 → because TypeD broke Chaning
            //typeB.MyFun2();  // TypeC : A = 1, B = 2, C = 3 → because TypeD broke Chaning
            //typeC.MyFun2();  // TypeC : A = 1, B = 2, C = 3 → because TypeD broke Chaning

            //TypeA typeA = new TypeE(1, 2, 3, 4, 5); // Indirect Parent
            //TypeB typeB = new TypeE(1, 2, 3, 4, 5); // Indirect Parent
            //TypeC typeC = new TypeE(1, 2, 3, 4, 5); // InDirect parent   

            //typeA.MyFun2();  // TypeC : A = 1, B = 2, C = 3 → because TypeD broke Chaning
            //typeB.MyFun2();  // TypeC : A = 1, B = 2, C = 3 → because TypeD broke Chaning
            //typeC.MyFun2();  // TypeC : A = 1, B = 2, C = 3 → because TypeD broke Chaning

            //TypeD typeD = new TypeE(1, 2, 3, 4, 5); // Direct   parent
            //typeD.MyFun2();  // TypeD : A = 1, B = 2, C = 3, D = 4, E = 5 

            #endregion

            #region Interface Example 01

            //MyType myType = new MyType();
            //myType.Salary = 1000;
            //myType.MyFunc();  // Hello Route
            //// myType.Print(); // NotValid

            //IMyType refrenceFromInterface = new MyType();
            //refrenceFromInterface.Salary = 2000;
            //refrenceFromInterface.MyFunc();  // Hello Route
            //refrenceFromInterface.Print();   // Hello Default Implemented Method from Interface

            //// *VIP * How To Access Default Implemented Method ? !
            //// Create Refrence from Interface refer to object from class ,
            //// That Class must be implemented this Interface

            #endregion

            #region Interface Example 02

            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10NumbersFromSeries(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumbersFromSeries(seriesByThree);

            #endregion

            #region Implicit and Explicit Interface

            ////Airplane airplane = new Airplane();
            ////airplane.forword(); // Not Valid

            //// To refer to forward in Airplane :
            //// create reference from IFlyable Interface refer to object from Airpalne

            //IFlyable flyable = new Airplane();
            //flyable.Forword(); // Valid → Move forword on Air 

            //IMovable movable = new Airplane();
            //movable.Forword(); // Valid  → Move forword on ground

            #endregion
        }
    }
}