using Session_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3
{
    class Airplane : IMovable, IFlyable
    {
        // Implicitly
        //public void Forword()
        //{
        //    Console.WriteLine("Move forword");
        //}

        // Explicitly
        void IMovable.Forword()
        {
            Console.WriteLine("Move forword on ground");
        }

        void IFlyable.Forword()
        {
            Console.WriteLine("Move forword on Air");
        }
    }
}
