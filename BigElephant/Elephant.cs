using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigElephant
{
    internal class Elephant
    {
        public string Name;
        public int EarSize;

        public void WhoAmI()
        {
            Console.WriteLine($"My name is {Name}.\nMy ears are {EarSize} inches tall\n");
        }
    }
}
