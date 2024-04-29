using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3.Interfaces
{
	// Developer 01
	// Interface: is a code Contract between developer who wrote it and the developer who will implement it
	interface IMyType
    {
		// Default Access Modifiers Inside The Interface is Puplic
		// Private Access Modifiers Not Allowed to use Inside The Interface

		// U can"t Create Object from interface
        // But U Can Create Refrence from Interface refer to object from class or struct ,
		// That Class or struct must be implemented this Interface 

		// what U Can Write Inside The Interface ?

		// 1. Signature for Property
		public int Salary { set; get; } // Get and Set what? I don't Know,
                                        // Compiler will not Generate Backing-Field (Hidden private Attribute)
										// Because we are in Interface Not Class Or Struct
										// If U in Class or Struct This line named Automatic property

		// 2. Signature for Method
		public void MyFunc();

        // 3. Default Implemented Method → C # 8.0 Feature (.Net core 3.1 [2019] )
        public void Print()
        {
            Console.WriteLine("Hello Default Implemented Method from Interface");
        }
    }

    // Developer 02
    class MyType : IMyType  // Implements
    {
        public int Salary { get; set; } // Compiler will generate Backing Field (Hidden private Attribute)

		public void MyFunc()
        {
            Console.WriteLine("Hello Route");
        }
    }


}
