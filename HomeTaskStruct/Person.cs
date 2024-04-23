using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskStruct
{
    internal class Person
    {
        public int Id { get; set; }
        public static int  IdCount { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public Person(string name,string surname,byte age)
        {
            IdCount++;
            Id=IdCount;
            Name=name;
            Surname=surname;
            Age=age;

        }

    }
}
