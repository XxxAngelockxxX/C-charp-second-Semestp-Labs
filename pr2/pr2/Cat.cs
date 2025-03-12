using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class Cat : Animal
    {
        public Cat(int year) : base(year)
        {
            Console.WriteLine("viklic dochirniy constructor");
        }
        public sealed override void Voice() 
        { 
            Console.WriteLine("Mau - Mau"); 
        }
    }
}
