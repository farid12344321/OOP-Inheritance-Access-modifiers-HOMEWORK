using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework
{
    public class Car
    {
        public string name;
        protected string color;
        private int _horsePower;

        public int HorsePowwer 
        {

            get
            {
                if(_horsePower > 200)
                {
                    return _horsePower;
                }
                    return -1;
            }


            set
            {
                _horsePower = value;
            }
        }
        public void Test()
        {
            Sedan sedan= new Sedan();
            Console.WriteLine("car");
        }

    }
}
