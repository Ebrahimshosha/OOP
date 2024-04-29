using Common;

namespace Session_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            TypeA obj = new TypeA();
            //obj.x = 1;  // Not Valid because x is private in TypeA class in comman project (another project)
            //obj.y = 2;  // Not valid because y is internal in comman project (another project)
            //obj.z = 3;  // valid     because z is puplic 
            #endregion

            #region struct

            //Point p1;
            //// Declare Object from type "Point"
            //// CLR will Allocate 8 bytes uninitialized at stack

            //p1 = new Point(4, 5);
            //// new is just only for constructor selection That will intialize the attributes of the object 
            //// because maybe there is more than one costructor

            ////Console.WriteLine($"x = {p1.X}"); 
            ////Console.WriteLine($"y = {p1.Y}"); 

            ////Console.WriteLine(p1.ToString());
            //Console.WriteLine(p1);  // == Console.WriteLine(p1.ToString());

            #endregion

            #region Encapsulation

            ////Employee Emp = new Employee();
            ////Console.WriteLine(Emp);  // default value

            //Employee Emp1 = new Employee();

            //Emp1.id = 1;                         // Set Id directly using Attribute
            //Console.WriteLine(Emp1.id);          // Get Id directly using Attribute

            //Emp1.SetName("Ali");                 // Set Name using Setter function
            //Console.WriteLine(Emp1.GetName());   // Get Name using Getter function

            //Emp1.Salary = 10_000;                // Set Salary using Property
            //Console.WriteLine(Emp1.Salary);      // Get Salary using Property

            //Console.WriteLine(Emp1);

            #endregion

            PhoneBook Note = new PhoneBook(3);

            Note.AddPerson(0, "Ali", 20);
            Note.AddPerson(1, "Mai", 22);
            Note.AddPerson(2, "Aya", 24);

            for (int i = 0; i < Note.Size; i++)
            {
                Console.WriteLine(Note[i]);
            }

        }
    }
}