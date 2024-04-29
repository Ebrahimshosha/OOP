using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4.Interface
{
    class Emoloyee : ICloneable, IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Emoloyee()
        {

        }

        // Copy Constructor : Special Constructor Used To Make Deep Copy
        public Emoloyee(Emoloyee emoloyee)
        {
            Id = emoloyee.Id;
            Name = emoloyee.Name;
            Salary = emoloyee.Salary;
        }

        public object Clone()
        {
            return new Emoloyee
            {
                Id = Id,
                Name = Name,
                Salary = Salary
            };
        }

        //public object Clone()
        //{
        //          return new Emoloyee(this);
        //}

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Salary = {Salary:c}";
        }

        // +Ve : this.Salary > obj.Salary
        // -Ve : this.Salary < obj.Salary
        //  0  : this.Salary = obj.Salary
        public int CompareTo(object? obj)
        {
            Emoloyee PassedEmployee = (Emoloyee)obj;  // Explicit Casting [Unsafe casting]

            if (this.Salary > PassedEmployee.Salary)
            {
                return 1;
            }
            else if (this.Salary < PassedEmployee.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
