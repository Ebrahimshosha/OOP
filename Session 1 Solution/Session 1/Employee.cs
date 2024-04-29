using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1
{
    internal struct Employee
    {
        // Attributes
        public int id;
        private string name;
        private decimal salary;

        // constructor
        public Employee(int _id, string _name, decimal _salary, int _age)
        {
            id = _id;
            name = _name;
            salary = _salary;
            Age = _age;  // [Hidden attribute] Automatic property

        }


        // Encapsulation : Separate Data Definition[Attributes] From Its Use[Getter Setter, Property]

        #region 1. Applying EnCapsulation : Using Getter Setter Function

        // Getter
        public string GetName()
        {
            return name;  // name must be private
        }

        // Setter
        public void SetName(string value)
        {
            //Name = value;
            name = value.Length < 5 ? value : value.Substring(0, 5);   // control value [Data Validation]    
        }

        #endregion

        #region 2. Applying EnCapsulation : Using Property Function [Recommended] → Easy Use like Attributes

        //2.1 Full Property → if u want to validate the return value 
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value >= 4000 ? value : 4000;  // control value [Data Validation]  
            }
            /// if U deny user from access salary → aceess set with private access modifier or delete set
            /// Read Only
            ///private set
            ///{
            ///    salary = value;
            ///}
        }

        //// decimal deduction;     // U shouldn't write attribute in constructor
        // because it is derived Attribute

        public decimal Decduction      /// ReadOnly Property   
        {
            get { return salary * .1M; }
            //set { deduction = value; }  /// Read Only → if delete set or private set
        }

        /// propful : is a code snippet for Full property
        ///private string address;
        ///public string Address
        ///{
        ///    get { return address; }
        ///    set { address = value; }
        ///}



        //2.2 Automatic Property → if u don't want to validate the return value 
        // Compiler will generate Backing Field (Hidden private Attribute)
        public int Age { set; get; }

        /// The last line == 
        //public int Age
        //{
        //    set { Age = value; }
        //    get { return Age; }
        //}


        // prop : is a code snippet for Automatic property
        //public string Address { get; set; }

        #endregion


        public override string ToString()
        {
            return $"Id : {id}\nName : {name}  \nSalary : {salary:c}";
        }
    }


}
