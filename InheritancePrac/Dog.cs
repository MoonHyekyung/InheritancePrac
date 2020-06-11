using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class Dog
    {
        public int Age { get; set; }
        public string Color { get; set; }
        public Dog() { 
            this.Age = 0;
            this.Color = "갈색";
        }

        public void Eat() { Console.WriteLine("냠냠"); }
        public void Sleep() { Console.WriteLine("zzzzzzz"); }
        public void Bark() { Console.WriteLine("왕왕!"); }
    }
}
