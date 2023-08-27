namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random dice = new Random();
            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);

            int firstValue = 500;
            int secondValue = 600;
            int largerValue;

            largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine(largerValue);

            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");

        }
    }
}