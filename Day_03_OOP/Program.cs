using Day_03_OOP.IClonable_Interface;
using Day_03_OOP.Interface_Example_01;
using Day_03_OOP.Interface_Example_02;
using Day_03_OOP.Interface_Example_03_;

namespace Day_03_OOP
{
    class Program
    {
        #region Example 02
        //public static void Print10NumbersInSeries(ISeries series)
        //{
        //    if (series == null)
        //        return;

        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($" {series.Current}\t");
        //        series.GetNext();  
        //    }

        //    series.Reset();
        //    Console.WriteLine();
        //    Console.WriteLine();

        //}

        #endregion

        static void Main(string[] args)
        {

            #region Example 01

            // IMytype mytype;

            /// Declare For Reference of Type " IMytype " Refering to NULL 
            /// This Reference " IMytype " Can Refer To An Object From Class OR Struct Implementing The Interface 
            /// CLR Will Allocate 4 Bytes At STACK For The Reference  

            //mytype = new IMytype();  Invalid Can't Create Object From Interface

            //MyType myType = new MyType();

            //myType.Salary = 10_000;
            //myType.Myfun(); // Hello World 


            //myType.print();  

            //IMytype ReferenceFromInterface = new MyType();

            //ReferenceFromInterface.Salary = 20_000;
            //ReferenceFromInterface.Myfun();
            //ReferenceFromInterface.Print(); 
            #endregion

            #region Example 02 

            //SeriesByTwo seriesbytwo = new SeriesByTwo();

            //Print10NumbersInSeries(seriesbytwo);

            //SeriesByThree seriesByThree = new SeriesByThree();

            //Print10NumbersInSeries(seriesByThree);

            //SeriesByFour seriesByFour = new SeriesByFour();

            //Print10NumbersInSeries(seriesByFour);

            #endregion

            #region Example 03

            //Airplane airplane = new Airplane();

            //airplane.Backward();

            //IMovable movableForAirplane = new Airplane();

            //movableForAirplane.Backward();
            //movableForAirplane.Forward();



            #endregion

            #region Shallow Copy 

            //int[] Arr01 = { 1, 2, 3, };

            //int[] Arr02 = { 7, 8, 9 };

            //Console.WriteLine($"HasCode Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HasCode Of Arr01 = {Arr02.GetHashCode()}");

            //Arr02 = Arr01; // The Object {1,2,3} Will Have Two Reference [Arr01 & Arr02] 
            //               // The Object {7,8,9} Will Became UnReachable Object 


            //Console.WriteLine("After Shallow Copy -->  Arr02 = Arr01;");

            //Console.WriteLine($"HasCode Of Arr01 = {Arr01.GetHashCode()}");  // The Same Value
            //Console.WriteLine($"HasCode Of Arr01 = {Arr02.GetHashCode()}");  // The Same Value

            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]);

            #endregion

            #region Deep Copy

            //int[] Arr01 = { 1, 2, 3, };

            //int[] Arr02 = { 7, 8, 9 };

            //Console.WriteLine($"HasCode Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HasCode Of Arr01 = {Arr02.GetHashCode()}");


            //Arr02 = (int []) Arr01.Clone(); // Clone Return Object 

            //// Clone Method Will Generate New Object and Put the Copied Values Of Arr01 into Arr02 As A new Object
            //// This Object Will Have The Same Object State Of [Data] of The Caller Of Clone 

            //Console.WriteLine("After Deep Copy -->  Arr02 = (int []) Arr01.Clone();");

            //Console.WriteLine($"HasCode Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HasCode Of Arr01 = {Arr02.GetHashCode()}");


            //foreach (int item in Arr01)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();


            //foreach (int item in Arr02)
            //{
            //    Console.WriteLine(item);
            //}

            //Arr02[0] = 100;

            //Console.WriteLine();

            //Console.WriteLine(Arr01[0]); // 1
            #endregion

            #region Why Clone Method Says it Makes Shallow Copy 

            //string[] Names01 = {"Amr", "Mona"};
            //string[] Names02 = { "Ahemd", "Yassmin" };

            //Console.WriteLine($"HashCode of Name01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HashCode of Name02 = {Names02.GetHashCode()}");

            //Names02 = (string[]) Names01.Clone();

            //Console.WriteLine("After Deep Copy  -->  Names02 = (string[]) Names01.Clone();");

            //Console.WriteLine($"HashCode of Name01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HashCode of Name02 = {Names02.GetHashCode()}");

            //Console.WriteLine($"{Names01[0].GetHashCode()}");
            //Console.WriteLine("==============================");
            //Console.WriteLine($"{Names02[0].GetHashCode()}");

            //Names02[0] = "Alaa";
            //Console.WriteLine(Names02[0]);

            //Console.WriteLine(Names01[0]);

            //string[] Names03 = { "Abdelrahman" };
            //string[] Names04 = { "Abdelrahman" };


            //Console.WriteLine($"HashCode of Name03 = {Names03.GetHashCode()}");
            //Console.WriteLine($"HashCode of Name04 = {Names04.GetHashCode()}");

            //Console.WriteLine($"{Names03[0].GetHashCode()}");
            //Console.WriteLine("==============================");
            //Console.WriteLine($"{Names04[0].GetHashCode()}");

            #endregion


            #region IClonable
            Employee employee01 = new Employee()
            {
                Id = 1,
                Name = "Abdelrahman",
                Salary = 6_000,
                department = new Department()
                {
                    Id = 101,
                    Name = "Sales"

                }

            };

            Employee employee02 = new Employee()
            {
                Id = 2,
                Name = "Yara",
                Salary = 8_000,
                department = new Department()
                {
                    Id = 102,
                    Name = "HR"

                }
            };


            Console.WriteLine($"HashCode Of Employee01 = {employee01.GetHashCode()}");
            Console.WriteLine($"HashCode Of Employee02 = {employee02.GetHashCode()}");


            //employee02 = (Employee) employee01.Clone();

            employee02 = new Employee(employee01); // Copy Constructor


            Console.WriteLine("After Deep Copy --> employee02 = (Employee) employee01.Clone();");

            Console.WriteLine($"HashCode Of Employee01 = {employee01.GetHashCode()}");
            Console.WriteLine($"HashCode Of Employee02 = {employee02.GetHashCode()}");

            Console.WriteLine(employee01);
            Console.WriteLine(employee02);

            //  if (employee02.department.Name == null)
            employee02.department.Name = "Hamada";


            Console.WriteLine(employee01.department.Name);


            #endregion




        }
    }
}
