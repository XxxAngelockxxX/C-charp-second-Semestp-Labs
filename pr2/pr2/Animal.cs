using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class Animal
    {
        public int Year;

        public Animal(int year) 
        {
            Year = year;
            Console.WriteLine("viklic batkivskiy constructor");
        }
        public virtual void Voice()
        {
            Console.WriteLine("ANY VOICE");
        }
    }
}
