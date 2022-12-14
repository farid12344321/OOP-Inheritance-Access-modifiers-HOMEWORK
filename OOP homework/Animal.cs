using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework
{
    internal class Animal
    {
        public string name;


        public Animal(string test)
        {
            Console.WriteLine(test);
        }



        public void Sound()
        {
            Console.WriteLine("Animal's sound");
        }
            
    }
}
