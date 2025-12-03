using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GjettTallet
{
    internal class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Are you able to find the Number? >:]");
            int number = RandomizeTheNumber();
            // Console.WriteLine(number); //will be taken away, just for testing
            EnterGuess(number);
            
        }

        static int RandomizeTheNumber()
        {
            Random rand = new Random();
            int number = rand.Next(1,101);
            return number;
        }

        static void EnterGuess(int number)
        {
            Console.Write("Enter your guess:");
            if (!int.TryParse(Console.ReadLine(), out int Guess))
            {
                Console.WriteLine("Please enter a number");
                EnterGuess(number);
            }

            HigherOrLower(number, Guess);
        }


        static void HigherOrLower(int number, int Guess)
        {

            //Thread.Sleep(2000);
            // Console.WriteLine(Guess);//will be taken away, just for testing
            // Console.WriteLine(number); //will be taken away, just for testing
            if (Guess > number)
            {
                Console.WriteLine("You gotta go Lower!");
                EnterGuess(number);
            }
            else if (Guess < number)
            {
                Console.WriteLine("You gotta go Higher!");
                EnterGuess(number);
            }
            else if (Guess == number)
            {
                Console.WriteLine("You did it!!!!! Would you like to play again?");
                Replay();
            }
        }


        static void Replay()
        {
            string Answer = Console.ReadLine();
            string Capitalize = Answer.ToUpper();
            switch (Capitalize)
            {
                case "YES":
                    Main();
                    break;
                case "NO":
                    Console.WriteLine("Have a Good day then!");
                    break;
                default:
                    Console.WriteLine("Please write Yes or No");
                    Replay();
                    break;
            }
        }
    }
}
