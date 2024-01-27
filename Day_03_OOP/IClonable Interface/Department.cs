using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03_OOP.IClonable_Interface
{
    internal class Department : ICloneable
    {
        public int Id { get; set; }
        public string? Name { get; set; }


        //public Department()
        //{
            
        //}
        //public Department(Department department)
        //{
        //    Id = department.Id;
        //    Name = department.Name;
        //}

        public object Clone()
        {
            return new Department()
            {
                Id = this.Id,
                Name = this.Name
            };
        }
    }
}
