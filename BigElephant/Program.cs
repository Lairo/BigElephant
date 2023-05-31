using System;
using System.Collections.Generic;

namespace BigElephant
{
    internal class Program
    {
        static void Main()
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            Elephant dummy;

            Random random = new Random();
            List<int> prices = new List<int>();

            while (true)
            {
                Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap, 4 testing object reference ");
                Console.WriteLine("loss, 5 Lucinda Speak to Lloyd, 6 Experimental");
                string choice = Console.ReadLine();
                Console.WriteLine();
                if (choice == "") return;
                if (int.TryParse(choice, out int num))
                {
                    if (num == 1)
                    {
                        Console.WriteLine("You have pressed 1");
                        Console.WriteLine("Calling lloyd.WhoAmI\n");
                        lloyd.WhoAmI();
                    }
                    else if (num == 2)
                    {
                        Console.WriteLine("You have pressed 2");
                        Console.WriteLine("Calling lucinda.WhoAmI()\n");
                        lucinda.WhoAmI();

                    }
                    else if (num == 3)
                    {
                        Swap();
                        Console.WriteLine("You have pressed 3");
                        Console.WriteLine("References have been swapped\n");
                    }
                    else if (num == 4)
                    {
                        Console.WriteLine("You have pressed 4");
                        lloyd = lucinda;
                        lloyd.EarSize = 4321;
                        lloyd.WhoAmI();
                    }
                    else if (num == 5)
                    {
                        lloyd.HearMessage("Hi ", lucinda);
                        Console.WriteLine();
                        lucinda.SpeakTo(lloyd, "Hi, Lloyd!\n");

                    }
                    else if (num == 6)
                    {
                        Console.WriteLine("You have pressed 6");
                        // Mario();
                        FillingAList();
                        foreach (var price in prices)
                        {
                            Console.WriteLine(price.ToString());
                        }
                        
                    }
                    else
                    {
                        return;
                    }
                }
            }

            void Swap()
            {
                dummy = lloyd;
                lloyd = lucinda;
                lucinda = dummy;
            }

            void Mario()
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("#");
                    }
                    Console.Write("\n");
                }
            }

            void FillingAList()
            {
                for (int i = 0; i < 7; i++)
                {
                    int value = random.Next(-10050, 2000);
                    prices.Add(value);
                }

            }
        }

    }
}

