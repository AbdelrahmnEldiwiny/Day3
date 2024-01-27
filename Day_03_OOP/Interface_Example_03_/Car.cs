using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03_OOP.Interface_Example_03_
{
    internal class Car : Vechile, IMovable
    {

        public void Forward()
        {
            throw new NotImplementedException();
        }
        public void Backward()
        {
            throw new NotImplementedException();
        }
    }
}
