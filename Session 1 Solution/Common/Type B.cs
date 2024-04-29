using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class Type_B
    {
        public Type_B() 
        {
            TypeA obj = new TypeA();
            // obj.x = 10;   // Not Valid because x is private
            // obj.y = 20;   // valid     because y is internal
            // obj.z = 30;   // valid     beacuse z is public
        }
    }
}
