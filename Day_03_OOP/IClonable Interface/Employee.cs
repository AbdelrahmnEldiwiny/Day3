using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03_OOP.IClonable_Interface
{
    class Employee : ICloneable
    {

        public int Id { get; set; }

        public string? Name { get; set; }

        public decimal Salary { get; set; }

        public Department? department;


        public Employee() 
        { 
            department = new Department();
        }

        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;

            // Modified to use the argument instead of using the 'this' which returns null
            department = (Department?)employee?.department?.Clone(); // Must do Deep Copy To Avoid Changing in Values
               //department = employee.department;
        }



        public object Clone()
        {
            return new Employee 
            { 
                Id = this.Id, 
                Name = this.Name, 
                Salary = this.Salary,
                department = (Department?) this?.department?.Clone() // Must do Deep Copy To Avoid Changing in Values
                
            };
        }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Salary = {Salary:c}";
        }

    }
}
