using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public abstract class Animal
    {
        public string name;
        public int size;
        public virtual int eyes;


        public abstract void Move();
        public abstract void Eat();

        public virtual void Drink() 
        {
        Console.WriteLine("Drink drink drink water.")
        }
      
    }
}
