using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class Animal
    {
        public int Age { get; set; }
        public Animal()
        {
            this.Age = 0;
        }
        public void Eat() { Console.WriteLine("냠냠"); }
        public void Sleep() { Console.WriteLine("zzzzzzzzzzzzz"); }
    }
    
}
