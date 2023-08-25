namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int result = 3 + 1 * 5 / 2;
            //Console.WriteLine(result);
            //Console.WriteLine(5 / 10);
            //decimal gradePointAverage = 3.99872831m;
            //Console.WriteLine((int)gradePointAverage);

            Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);

        }
    }
}