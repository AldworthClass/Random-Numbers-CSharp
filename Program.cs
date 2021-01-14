using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randNum, num1, num2;

            randNum = generator.Next(10) + 1;
            Console.WriteLine("My random number is " + randNum);

            Console.WriteLine("Here are some numbers from 1 to 5!");
            Console.Write(generator.Next(5) + 1 + " ");
            Console.Write(generator.Next(5) + 1 + " ");
            Console.Write(generator.Next(5) + 1 + " ");
            Console.Write(generator.Next(5) + 1 + " ");
            Console.Write(generator.Next(5) + 1 + " ");
            Console.WriteLine(generator.Next(5) + 1 + " ");
            Console.WriteLine();

            Console.WriteLine("Here are some numbers from 1 to 100!");
            Console.Write(generator.Next(100) + 1 + " ");
            Console.Write(generator.Next(100) + 1 + " ");
            Console.Write(generator.Next(100) + 1 + " ");
            Console.Write(generator.Next(100) + 1 + " ");
            Console.Write(generator.Next(100) + 1 + " ");
            Console.WriteLine(generator.Next(100) + 1 + " ");
            Console.WriteLine();

            num1 = generator.Next(10) + 1;
            num2 = generator.Next(10) + 1;
            if (num1 == num2)
            {
                Console.WriteLine("The random numbers were the same! Weird.");
            }
            if (num1 != num2)
            {
                Console.WriteLine("The random numbers were different! Not weird.");
            }
            
            // Task 1 and 2 from lesson
            Console.WriteLine();
            Console.WriteLine("Task 1 - Random Numbers");
            Console.WriteLine("-----------------------");
            Task1RandomNumbers(generator);    // Calls Task1RandomNumber method, and passes the random number generator to it
            Console.WriteLine();
            
            
            Console.WriteLine();
            Console.WriteLine("Task 2 - Slightly Less Bad Guessing Game");
            Console.WriteLine("----------------------------------------");
            Task2Guess(generator);    // Calls Task2Guess method, and passes the random number generator to it


            Console.ReadLine();	// Keeps the program from quitting
        }


        // Solution for Task 1 - Random Numbers
        public static void Task1RandomNumbers(Random generator)
        {
            int max, min;
            Console.WriteLine("Provide me with a maximum value: ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Provide me with a maximum value smaller than the maximum: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here is a random number between " + min + " and " + max + ":");
            Console.WriteLine(generator.Next(min, max + 1));
        }

        // Solution for Task 2 – A Slightly Less Bad Guessing Game
        public static void Task2Guess(Random generator)
        {
            int guess, secretNumber;
            secretNumber = generator.Next(1, 11);
            Console.WriteLine("Please guess the secret number.  It could be anything from 1 to 10.");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess == secretNumber)
                Console.WriteLine("Congradulations, you guessed it!!");
            else
                Console.WriteLine("Sorry but no, the secret number was " + secretNumber);

        }
    }
}
