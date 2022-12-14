using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework
{
    internal class Sedan : Car
    {
        public int Color { get; private set; }
       
        public readonly string Name;
        
        
        public Sedan()
        {
            Console.WriteLine("sedan");
            name = "sjbncsjbnc";
        }
    }
}
