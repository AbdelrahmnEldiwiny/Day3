using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03_OOP.Interface_Example_02
{
    class SeriesByFour : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 4;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
