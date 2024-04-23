using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskStruct
{
    internal class CustomCollection<T> where T : Person
    {
        private static T[] _arr=new T[0];

        public void Add (T item) 
        {
            Array.Resize(ref _arr , _arr.Length+1);
            _arr[_arr.Length-1]=item;
        }

        public void GetById(int id)
        {
            foreach (var item in _arr)
            {
                if (item.Id == id) Console.WriteLine(item.Id + " " + item.Name + " " + item.Surname + " " + item.Age + " ");
               else Console.WriteLine("Isci Tapilmadi");
            }
            if (_arr.Length == 0) Console.WriteLine("Isci tapilmadi");
        }
        public T[] GetAll()
        {
            return _arr;
        }

    }
}
