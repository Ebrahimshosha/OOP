using Session_4.SealdEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4.PartialClass
{
    internal partial class Employee : Parent
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
    }
}
