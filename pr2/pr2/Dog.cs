using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class Dog:Animal
    {
        public Dog(int year):base(year) 
        {

            Console.WriteLine("viklic dochirniy constructor");

        }
        public override void Voice()
        {
            Console.WriteLine("Gav - Gav");
        } 
    }
}
