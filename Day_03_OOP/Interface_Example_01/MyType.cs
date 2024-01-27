using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Day_03_OOP.Interface_Example_01
{
    internal class MyType : IMytype  /* : --> implements*/
    {
        ///private int salary;  // implement Encapsulation
        ///public int Salary
        ///{
        ///    get
        ///    {
        ///        return salary;
        ///    }
        ///    set
        ///    {
        ///        salary = value;        
        ///    }
        /// }

        public int Salary { get; set; }

        public void Myfun() => Console.WriteLine("Hello World !!");




    }
}
