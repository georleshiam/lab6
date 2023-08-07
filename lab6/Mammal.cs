using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public abstract class Mammal: Animal
    {
        public string furColor;

        public override void Move()
        {
            Console.Write("Walk");
        }


        public override void Eat()
        {
            Console.Write("Animals eat meat! ")
        }

        public override void Drink()
        {
            Console.Write("Sip sip through beak;")
        }
    }
}
