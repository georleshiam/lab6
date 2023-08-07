using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
   public abstract class Bird: Animal
    {
        public int wingSpan;
        public string color;
    }

    public override void Eat()
    {
        Console.WriteLine(" Birds eat worms.")
    }






}
