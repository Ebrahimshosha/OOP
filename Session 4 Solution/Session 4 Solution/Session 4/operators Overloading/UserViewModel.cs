using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4.operators_Overloading
{
    // View Model : is the Class that Will be Rendered at View (HTML)
    internal class UserViewModel
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; } 

        public static /*UserViewModel*/ explicit operator UserViewModel(User user)
        {
            string[] Names = user.FullName.Split(' ');
            return new UserViewModel()
            {
                Id = user.Id,
                FName = Names[0],
                LName = Names[1],
                Email = user.Email
            };
        }
    }
}
