using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4.operators_Overloading
{
    // Model : is a Class that Represents a Table in Database
    class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string SecurityStamp { get; set; }
    }
}
