namespace BaseballGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class MathClass
        {
            public const int ONE = 1;
        }
        static void Main(string[] args)
        {
            Console.Write(MathClass.ONE);
        }
        //string password = Console.ReadLine();
        //char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };

        ////your code goes here
        //for (int i = 0; i < notAllowedSymbols.Length; i++)
        //{
        //    if (password.Contains(notAllowedSymbols[i]))
        //    {
        //        Console.WriteLine("Invalid");
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine("ok");
        //    }
        //}

        //string s = "SoloLearn is awesome";

        //Console.Write(s.IndexOf('e'));

        //string text = "This is some text about a dog. The word dog appears in this text a number of times. This is the end.";

        //text = text.Replace("dog", "cat");
        //text = text.Substring(0, text.IndexOf(".") + 1);

        //Console.WriteLine(text);

        //string a = "some text";
        //Console.WriteLine(a.Length);
        ////Outputs 9

        //Console.WriteLine(a.IndexOf('t'));
        ////Outputs 5

        //a = a.Insert(0, "This is ");
        //Console.WriteLine(a);
        ////Outputs "This is some text"

        //a = a.Replace("This is", "I am");
        //Console.WriteLine(a);
        ////Outputs "I am some text"

        //if (a.Contains("some"))
        //    Console.WriteLine("found");
        ////Outputs "found"

        //a = a.Remove(4);
        //Console.WriteLine(a);
        ////Outputs "I am"

        //a = a.Substring(2);
        //Console.WriteLine(a);
        ////Outputs "am"
        ///

        //string[] words =  {
        //    "home",
        //    "programming",
        //    "victory",
        //    "C#",
        //    "football",
        //    "sport",
        //    "book",
        //    "learn",
        //    "dream",
        //    "fun"
        //};

        //string letter = Console.ReadLine();

        //int num = 0;


        //for (int count = 0; count < 10; count++)
        //{
        //    if (words[count].Contains(letter))
        //    {
        //        Console.WriteLine(words[count]);

        //        num++;
        //    }

        //}
        //if (num == 0)
        //{
        //    Console.WriteLine("No match");
        //}


    }
    }
    public class Solution
    {
        public int CalPoints(string[] ops)
        {
            var scores = new List<int>();

            foreach (var op in ops)
            {
                switch (op)
                {
                    case "+":
                        scores.Add(scores[^1] + scores[^2]);
                        break;
                    case "D":
                        scores.Add(scores[^1] * 2);
                        break;
                    case "C":
                        scores.RemoveAt(scores.Count - 1);
                        break;
                    default:
                        scores.Add(int.Parse(op));
                        break;
                }
            }

            return scores.Sum();
        }
    }
}