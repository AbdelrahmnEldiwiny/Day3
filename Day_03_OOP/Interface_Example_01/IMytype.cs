using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03_OOP.Interface_Example_01
{
    internal interface IMytype
    {
        // Defalut Access Modifier Inside Interface Is Public

        // Signature For Property 

         int Salary { get; set; }

        // Signature For Method 

        void Myfun();  // Until C# 7.3 

        // Default Implemented Method -> C# 8.0 [ .NET Core 3.1 (2019) ]
         void Print()
        {
            Console.WriteLine("Hello I am Default Implemented Method");
        }

    }
}
