using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigElephant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            Elephant dummy = new Elephant() { Name = "no", EarSize = 0};

            while (true)
            {
                Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
                string choice = Console.ReadLine();
                if (choice == "") return;
                if (int.TryParse(choice, out int num))
                {
                    if(num == 1)
                    {
                        lucinda.WhoAmI();
                    }
                    else if(num == 2)
                    {
                        lloyd.WhoAmI();

                    } else if (num == 3)
                    {
                        Swap();
                        
                    }

                }
            }


        }

        public void Swap()
        {
            dummy = lucinda;
            lloyd = lucinda;
            lloyd = dummy;
        }
    }
}
