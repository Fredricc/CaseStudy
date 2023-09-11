using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,,,] arr;

            //your code goes here
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(num[k, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}