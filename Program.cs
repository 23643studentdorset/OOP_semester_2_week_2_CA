using System;

namespace OOP_semester_2_week_2_CA
{
    class Program
    {
        public static double DoubleValidation(string output)
        {
            string num;
            double parsedNum;
            do
            {
                Console.WriteLine($"{output}");
                num = Console.ReadLine();
            } while (!double.TryParse(num, out parsedNum));
            return parsedNum;
        }


        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Wich exercise would you like to execute? or 0 to finish");
                for (int c = 1; c <= 3; c++)
                {
                    Console.WriteLine($"{c}. Question {c}");
                }
                String userInput = Console.ReadLine();

                if (userInput.Equals("0"))
                {
                    return;
                }


                switch (userInput)
                {
                    case "1":
                        {
                            Exercise1.run();
                            break;
                        }
                    case "2":
                        {
                            Exercise2.run();
                            break;
                        }
                    case "3":
                        {
                            Exercise3.run();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("That is not an option");
                            break;
                        }
                }

            } while (flag);

        }

        public class Exercise1
        {
            /*
             * Write a console-based application that prompts a user for an hourly pay rate. 
             * While the user enters values less than $5.65 or greater than $49.99, continue to prompt the user. 
             * Before the program ends, display the valid pay rate.
             */
            public static void run()
            {
                double payRate;
                do {
                    payRate = DoubleValidation("Please insert a number that is between 5.65 and 49.99");

                }while (payRate > 5.65 && payRate < 49.99);
                Console.WriteLine($"The payrate is {payRate}");
            }
        }

        public class Exercise2
        {
            /*
             * Write a console-based application that sums the integers from 1 to 50.
             */
            public static void run()
            {
                int sum = 0;
                for (int i = 0; i > 51; i++)
                {
                    sum += i; 
                }
                Console.WriteLine($"The sum of all the numbers from 1 to 50 is {sum}");
            }
        }

        public class Exercise3
        {
            /*
            Write a program that generates a random number between 1 and 10. 
            Ask a user to guess the random number, then display the random number and a message indicating whether the user's guess was too high, too low, or correct.
            ------HINT-------
            You can create a random number that is at least min but less than max using the following statements
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(min, max); 1, 11
            */
            public static void run()
            {
                Random rand = new Random();
                int hideNumber = rand.Next(1, 11);
                bool flag = true;

                do
                {
                    string num;
                    int parsedNum;
                    do
                    {
                        Console.WriteLine("Input a number between 1 to 10 to guess the hide number");
                        num = Console.ReadLine();
                    } while (!int.TryParse(num, out parsedNum));
                    
                    

                    if (parsedNum == hideNumber)
                    {
                        Console.WriteLine("Great you find the number");
                        flag = false;
                    }
                    else if (parsedNum < hideNumber)
                    {
                        Console.WriteLine("Your number is too low");
                    }
                    else
                    {
                        Console.WriteLine("Your number is too high");
                    }
                } while (flag);

            }
        }








    }
}

