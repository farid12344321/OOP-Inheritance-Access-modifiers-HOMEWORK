using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework
{
    internal class Bird : Animal
    {
        public Bird(string t) : base(t)
        {
            Console.WriteLine("Bird");
        }
    }
}
