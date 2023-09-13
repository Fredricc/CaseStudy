﻿namespace BaseballGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };

            //your code goes here
            for (int i = 0; i < notAllowedSymbols.Length; i++)
            {
                if (password.Contains(notAllowedSymbols[i]))
                {
                    Console.WriteLine("Invalid");
                    break;
                }else
                {
                    Console.WriteLine("ok");
                }
            }

            string s = "SoloLearn is awesome";

            Console.Write(s.IndexOf('e'));

            string text = "This is some text about a dog. The word dog appears in this text a number of times. This is the end.";

            text = text.Replace("dog", "cat");
            text = text.Substring(0, text.IndexOf(".") + 1);

            Console.WriteLine(text);
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