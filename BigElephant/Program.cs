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
                        Console.WriteLine("You have pressed 1");
                        Console.WriteLine("Calling lloyd.WhoAmI\n");
                        lloyd.WhoAmI();
                    }
                    else if(num == 2)
                    {
                        Console.WriteLine("You have pressed 2");
                        Console.WriteLine("Calling lucinda.WhoAmI()\n");
                        lucinda.WhoAmI();

                    } else if (num == 3)
                    {
                        Swap();
                        Console.WriteLine("You have pressed 3");
                        Console.WriteLine("References have been swapped\n");
                    }

                }
            }

            void Swap()
            {
                dummy = lloyd;
                lloyd = lucinda;
                lucinda = dummy;
            }

        }
        

    }
}
