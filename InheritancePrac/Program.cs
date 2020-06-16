using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>() 
            { new Dog(), new Dog(), new Cat(),
               new Dog(), new Cat(), new Cat() };

            animals.Add(new Cat());
            animals.Add(new Dog());

            foreach(var item in animals)
            {
                item.Eat();
                item.Sleep();
                if(item is Dog)
                {
                    ((Dog)item).Bark();
                }
               if(item is Cat)
                {
                    ((Cat)item).Meow();
                }

                var dog = item as Dog;
                if(dog != null) { dog.Bark(); }
                var cat = item as Cat;
                if (cat != null) { cat.Meow(); }
            }
        }
    }
}
