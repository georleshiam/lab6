using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
   public class Stork: Bird, IWalks
    {
        public string beakSize;
        public int legs { get; set; }

        public Stork(string feathercolor)
        {
            color = feathercolor;
        }

        public void fly()
        {
            Console.Write("Kawkaw");
        }
    }
}
