using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             string[] fraudulentOrderIDs = new string[3];

             fraudulentOrderIDs[0] = "A123";
             fraudulentOrderIDs[1] = "B456";
             fraudulentOrderIDs[2] = "C789";
             // fraudulentOrderIDs[3] = "D000";
             */

            //string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

            //Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            //Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            //Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            //fraudulentOrderIDs[0] = "F000";

            //Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

            //Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

            //string[] names = { "Rowena", "Robin", "Bao" };
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //int[] inventory = { 200, 450, 700, 175, 250 };
            //int sum = 0;
            //int bin = 0;
            //foreach (int items in inventory)
            //{
            //    sum += items;
            //    bin++;
            //    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            //}
            //Console.WriteLine($"We have {sum} items in inventory.");

            //string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            //foreach (string orderID in orderIDs)
            //{
            //        if (orderID.StartsWith("B"))
            //        {
            //            Console.WriteLine($"The name {orderID} starts with 'B'!");
            //        }
            //}

            /*
              The following code creates five random OrderIDs
              to test the fraud detection process.  OrderIDs 
              consist of a letter from A to E, and a three
              digit number. Ex. A123.
            */
            //Random random = new Random();
            //string[] orderIDs = new string[5];

            //for (int i = 0; i < orderIDs.Length; i++)
            //{
            //    int prefixValue = random.Next(65, 70);
            //    string prefix = Convert.ToChar(prefixValue).ToString();
            //    string suffix = random.Next(1, 1000).ToString("000");

            //    orderIDs[i] = prefix + suffix;
            //}

            //foreach (var orderID in orderIDs)
            //{
            //    Console.WriteLine(orderID);
            //}
            Random dice = new Random();

            //int roll1 = dice.Next(1, 7);
            //int roll2 = dice.Next(1, 7);
            //int roll3 = dice.Next(1, 7);

            //int total = roll1 + roll2 + roll3;
            //Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            //if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            //{
            //    if ((roll1 == roll2) && (roll2 == roll3))
            //    {
            //        Console.WriteLine("You rolled triples!  +6 bonus to total!");
            //        total += 6;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
            //        total += 2;
            //    }


            //for (int i = 1; i < 5; i++)
            //{
            //    if (i == 3)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //int num = 1;

            //while (num <= 10)
            //{
            //    if (num == 3)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(num);
            //    num++;
            //}

            string msg = Concat("Finishing ", "the last module");
            Console.WriteLine(msg);
        }
        static string Concat(string x, string y)
        {
            string res = ("x" + "y");
            return res;
        }
    }
    }