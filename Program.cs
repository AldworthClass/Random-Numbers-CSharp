using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            
            // Task 1, 2 and 3 from lesson
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Task 1 - Random Numbers");
            Console.WriteLine("-----------------------");
            Task1RandomNumbers(generator);    // Calls Task1RandomNumber method, and passes the random number generator to it
            Console.WriteLine();
            
            
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Task 2 - Slightly Less Bad Guessing Game");
            Console.WriteLine("----------------------------------------");
            Task2Guess(generator);    // Calls Task2Guess method, and passes the random number generator to it
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Task 3 - Roll the Dice");
            Console.WriteLine("----------------------");
            Task3RollDice(generator);   // Calls Task3RollDice method, and passes the random number generator to it

            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Task 4 - Magic 8-Ball");
            Console.WriteLine("----------------------");
            Task4Magic8Ball(generator);   // Calls Task3RollDice method, and passes the random number generator to it



            Console.ReadLine();	// Keeps the program from quitting
        }


        // Solution for Task 1 - Random Numbers
        public static void Task1RandomNumbers(Random generator)
        {
            int max, min;
            Console.WriteLine("Provide me with a maximum value: ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Provide me with a minimum value smaller than the maximum of " + max + ": ");
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

        // Solution for Task 3 - Toll the Dice
        public static void Task3RollDice(Random generator)
        {
            int num1, num2, total;
            Console.WriteLine("Hit ENTER to roll the dice.");
            Console.ReadLine();
            num1 = generator.Next(1, 7);
            num2 = generator.Next(1, 7);
            total = num1 + num2;
            Console.WriteLine("Die 1 - " + num1);
            Console.WriteLine("Die 2 - " + num2);
            Console.WriteLine("Total - " + total);
        }
        // Solution for Task 4 - Magic 8-Ball
        public static void Task4Magic8Ball(Random generator)
        {
            int response = generator.Next(6);
            Console.WriteLine("Welcome to the future-seer 3000.  Please ask your yes/no question:");
            Console.ReadLine(); // Since we do nothing with the users question, we don't need to store it in a variable
            Thread.Sleep(500);
            if (response == 0)
                Console.WriteLine("Yes, definitely!");
            else if (response == 1)
                Console.WriteLine("Ask again later");
            else if (response == 2)
                Console.WriteLine("No way!");
            else if (response == 3)
                Console.WriteLine("The future is hazy, I can't tell");
            else if (response == 4)
                Console.WriteLine("There is a high probability of it being so.");
            else
                Console.WriteLine("Outlook not so good.");

        }
    }
}
