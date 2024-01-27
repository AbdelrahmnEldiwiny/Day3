using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03_OOP.Interface_Example_03_
{
    internal class Airplane : Vechile, IMovable, IFlyable
    {
        public void Backward()  // Implicitly  
        {
            Console.WriteLine("Airplane Move BackWard on Ground");
        }

        void IMovable.Forward() // Explicitly 
        {
            Console.WriteLine("Airplane Move Forward on Ground");
        }

       void IFlyable.Forward() // Explicitly   // Always Private, Because Can Execute the In Interface
        {
            Console.WriteLine("Airplane Move Forward on Air");

        }
    }
}
