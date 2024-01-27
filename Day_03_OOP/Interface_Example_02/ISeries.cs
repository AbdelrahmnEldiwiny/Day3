using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03_OOP.Interface_Example_02
{
    interface ISeries
    {
        public int Current { get; set; }  // Signature For Property 


        public void GetNext();

        public void Reset();
          


    }
}
