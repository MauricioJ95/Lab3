using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            {
                Console.WriteLine("Please enter your name");
                var name = Console.ReadLine();
                int i;
                bool isInvalidInput, shouldContinue;
                string y;
                do
                {
                    do
                    {
                        Console.WriteLine(name + ", Please enter a number between 1 and 100");
                        string integer = Console.ReadLine();
                        i = int.Parse(integer);
                        isInvalidInput = i < 1 || i > 100;
                    } while (isInvalidInput);//input is invalid
                    if (i % 2 == 0) //integer is even 
                    {
                        if (i % 2 == 0 && i <= 25) //the number is even and less than 25
                        {
                            Console.WriteLine(name + ", This number is even and less than 25");
                        }

                        if (i % 2 == 0 && i >= 60) //the number is even and less than 60
                        {
                            Console.WriteLine(i + ", That's Even " + name);
                        }

                        if (i % 2 == 0 && i >= 26 && i <= 60) //the number is even greater than or equal to 26 and less than or equal to 60
                        {
                            Console.WriteLine(name + ", Even");
                        }
                    }
                    else
                    {
                        Console.WriteLine(i + ", That number is odd " + name);
                    }

                    Console.WriteLine("Continue? y/n"); //console asks user if they want to continue
                    input = Console.ReadLine(); //console reads the input
                    shouldContinue = input == "y"; //declares if they wish to continue or not
                } while (shouldContinue);//user wants to continue 
                Console.WriteLine("Bye!"); //console says goodbye
                Console.ReadKey();
            }

        }

    }
}

