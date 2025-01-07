using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();   
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: (Name), Age: (Age), Salary: (Salary)";
        }
    }
}
