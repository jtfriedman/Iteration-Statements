using System;

namespace Iteration_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an Integer value between 1 and 100 to execute an iterative statement: ");

            try
            {
                string input = Console.ReadLine();
                int value = int.Parse(input);

                if ((value < 100) && (value > 0))
                {
                    Console.WriteLine("Executing a loop");
                    for (int i = 0; i < value; i++)
                    {
                        Console.WriteLine("You have entered " + value.ToString() + ". This is the current integer value in the loop: " + i.ToString());
                    }
                }
            }
            catch
            {
                Console.WriteLine("Please enter a proper integer");
                Console.ReadKey(true);
            }
        }
    }
}
