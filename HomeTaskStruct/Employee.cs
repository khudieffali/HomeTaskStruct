using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskStruct
{
    internal class Employee:Person
    {
        public double Salary { get; set; }
        public Employee(string name, string surname, byte age,double salary) : base(name, surname, age)
        {
            Salary = salary;
        }
    }
}
