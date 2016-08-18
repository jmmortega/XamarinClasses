using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinClasses.Generics
{
    public class Concatter<T>
    {
        private string _concat;

        public void Add(T element)
        {
            _concat += element.ToString();
        }

        public void Print()
        {
            Console.WriteLine(_concat);
        }
    }
}
