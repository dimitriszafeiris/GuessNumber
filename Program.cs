using System;

//Namespace
namespace GuessNumber
{
    //main class
    class Program
    {
        static void Main(string[] args)
        {
            getAppInfo();

            while (true)
            {
                // Ask for users name
                Console.WriteLine("What's your name");

                //get user name
                string inputName = Console.ReadLine();

                //print welcome message
                Console.WriteLine("Hello {0}, welcome to our game.", inputName);

                //init numbers
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;

                Console.WriteLine("It's time to guess the number {0}. It's between 1 and 10.", inputName);

                //check if user find the number
                while (guess != correctNumber)
                {
                    //get user input guess
                    string input = Console.ReadLine();

                    //check if input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        //change color
                        //Console.ForegroundColor = ConsoleColor.Red;
                        // Write error message
                        //Console.WriteLine("Sorry {0}, but {1} is not a number.", inputName, input);
                        //Reset color back
                        //Console.ResetColor();

                        changeColor(ConsoleColor.Red, "Sorry, but this is not a number.");

                        continue;
                    }

                    //assign user input(cast to int) to guess var
                    guess = Int32.Parse(input);

                    //check guess
                    if (guess != correctNumber)
                    {
                        //change color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Write error message
                        Console.WriteLine("Wrong number {0}, please try again.", inputName);

                        //Reset color back
                        Console.ResetColor();
                    }
                }
                //change color
                Console.ForegroundColor = ConsoleColor.Green;

                // Write success message
                Console.WriteLine("Well done {0}, correct number is {1}.", inputName, guess);

                //Reset color back
                Console.ResetColor();

                Console.WriteLine("Do you want to play again?[y/n]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    Console.WriteLine("Bye bye {0}", inputName);
                    changeColor(ConsoleColor.DarkGreen, "Press any key to exit...");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("Bye bye {0}", inputName);
                    changeColor(ConsoleColor.DarkGreen, "Press any key to exit...");
                    Console.ReadLine();
                    return;
                }

            }

        }

        static void getAppInfo()
        {
            // app variables
            string appName = "GuessNumber";
            string appVersion = "1.0";
            string appAuthor = "Dimitris Zafeiris";

            //change color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Write app details
            Console.WriteLine("{0}: Version {1}, created by {2}", appName, appVersion, appAuthor);

            //Reset color back
            Console.ResetColor();
        }

        //print color messages
        static void changeColor(ConsoleColor color, string message)
        {
            //change color
            Console.ForegroundColor = color;

            // Write error message
            Console.WriteLine(message);

            //Reset color back
            Console.ResetColor();
        }
    }
}