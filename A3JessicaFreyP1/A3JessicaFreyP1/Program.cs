/* Program name: A3JessicaFreyP1
 * Purpose: To create a console based math program
 * Modified History: Jessica Frey October 2016
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3JessicaFreyP1
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            int even;
            int squared;

            bool keeprunning = false;
            do
            {
                Console.WriteLine("Please choose an option: ");
                Console.WriteLine("1. Display a list of even numbers.");
                Console.WriteLine("2. Display a sequence of perfect squares.");
                Console.WriteLine("3. Exit program.");
                option = int.Parse(Console.ReadLine());
                Console.Clear();

                if (option == 1)
                {
                    even = getEven();

                }
                else if (option == 2)
                {
                    squared = getSquared();


                }
                else if (option == 3)
                {
                    Console.WriteLine("You have chosen to close the program.");
                }
                else
                {
                    Console.WriteLine("You have entered an incorrect value");
                }

            } while (keeprunning);



        }
        private static int getEven()
        {
            int even = 0;
            int i = 0;
            bool isValidNumber = false;
            while (!isValidNumber)
            {
                try
                {
                    Console.WriteLine("Please enter the number of even numbers you want display: ");
                    even = int.Parse(Console.ReadLine());
                    isValidNumber = true;

                    for (i = 0; i < even + 1; i += 2)
                    {
                        Console.WriteLine(i);
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("You have entered an incorrect option. Please enter a number.");
                    Console.Clear();
                }

                return even;
            }
        }

        private static int getSquared()
        {

            int squared = 0;
            int i = 1;
            bool isValidNumber = false;
            while (!isValidNumber)
            {

                try
                {
                    Console.WriteLine("Please enter the number of perfect squares you want displayed:");
                    squared = int.Parse(Console.ReadLine());
                    isValidNumber = true;
                    while (i < squared + 1)
                    {
                        Console.WriteLine(i * i);
                        i++;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("You have entered an incorrect option. Please enter a number.");
                    Console.Clear();
                }

            }
            return squared;
        }



    }
}

