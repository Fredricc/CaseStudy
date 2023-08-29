namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Random dice = new Random();
            //int roll1 = dice.Next();
            //int roll2 = dice.Next(101);
            //int roll3 = dice.Next(50, 101);

            //int firstValue = 500;
            //int secondValue = 600;
            //int largerValue;

            //largerValue = Math.Max(firstValue, secondValue);

            //Console.WriteLine(largerValue);

            //Console.WriteLine($"First roll: {roll1}");
            //Console.WriteLine($"Second roll: {roll2}");
            //Console.WriteLine($"Third roll: {roll3}");
            string message = "The quick brown fox jumps over the lazy dog.";
            bool result = message.Contains("dog");
            Console.WriteLine(result);

            if (message.Contains("fox"))
            {
                Console.WriteLine("What does the fox say?");
            }

             runAgain:
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }

            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples! +6 bonus to total!");
                total += 6;
            }

            if (total >= 15)
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("**************       You win!     ****************");
                Console.WriteLine("**************************************************");
            }
            else
            {
                Console.WriteLine("Sorry, you lose.");
            }

            Console.WriteLine("Do you want to play again: Y / N");
            char playAgain = Convert.ToChar(Console.ReadLine());

            if(playAgain == 'Y')
            {
                goto runAgain;
            }
            else if (playAgain == 'N')
            {
                Console.WriteLine("Thank you for playing. Goodbye");
            }
            Console.ReadLine();

        }
    }
}