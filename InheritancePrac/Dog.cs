using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class Dog : Animal
    {
        public string Color { get; set; }
        public Dog() { 
            this.Color = "갈색";
        }

        public void Bark() { Console.WriteLine("왕왕!"); }
    }
}
