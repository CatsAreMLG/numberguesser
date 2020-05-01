using System;

namespace numberguesser {
    class Program {
        static void Main (string[] args) {
            GetAppInfo ();
            GreetUser ();

            while (true) {
                Random random = new Random ();
                int correctNumber = random.Next (1, 10);
                int guess = 0;

                Console.WriteLine ("Guess a number between 1 and 10");

                while (guess != correctNumber) {
                    string input = Console.ReadLine ();
                    if (!int.TryParse (input, out guess)) {
                        PrintColorMessage (ConsoleColor.Red, "Please input a number.");
                        continue;
                    }
                    guess = Int32.Parse (input);
                    if (guess != correctNumber) {
                        PrintColorMessage (ConsoleColor.Red, "Wrong number, try again!");
                    }
                }

                PrintColorMessage (ConsoleColor.Green, "You got it; Good job!");

                while (true) {
                    Console.WriteLine ("Would you like to play again? [y/n]");
                    string answer = Console.ReadLine ().ToLower ();
                    if (answer == "y") {
                        break;
                    } else if (answer == "n") {
                        return;
                    } else {
                        PrintColorMessage (ConsoleColor.Red, "Please input 'y' or 'n'.");
                        continue;
                    }
                }
            }
        }

        static void GetAppInfo () {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "shrimp";
            PrintColorMessage (ConsoleColor.Green, $"{appName}: Version {appVersion} by {appAuthor}");
        }
        static void GreetUser () {
            Console.WriteLine ("What is your name?");
            string userName = Console.ReadLine ();
            Console.WriteLine ("Hello {0}, let's play a game.", userName);
        }
        static void PrintColorMessage (ConsoleColor color, string message) {
            Console.ForegroundColor = color;
            Console.WriteLine (message);
            Console.ResetColor ();
        }
    }
}