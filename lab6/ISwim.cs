using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public interface ISwim
    {
        public bool inWater { get; set; }
        public void Swim()
        {
            Console.WriteLine("Just keep swimming..")
        }
    }
}
