using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissaTalet
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 11);
                int guessCount = 1;

                Console.Write("Gissa på ett tal mellan 1-10: ");
                
                while (true)
                {
                    int mittNummer = Convert.ToInt32(Console.ReadLine());

                    if (randomNumber > mittNummer)
                    {
                        Console.Write("Du gissade för lågt, försök igen: ");
                        guessCount++;
                        continue;
                    }
                    else if (randomNumber < mittNummer)
                    {
                        Console.Write("du gissade för högt, försök igen: ");
                        guessCount++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Grattis, du svarade rätt på {0} många försök", guessCount);
                        Console.WriteLine("Vill du börja om? [Y]-[N]");
                        string restart = Console.ReadLine().ToLower();

                        if (restart == "y")
                        {
                            Console.Clear();
                            break;
                        }
                        else if (restart == "n")
                            Environment.Exit(0);

                        
                    }

                }

                
                //mittNummer = Convert.ToInt32
            }
        }
    }
}
