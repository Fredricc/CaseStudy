﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //int day1Winner = Convert.ToInt32(Console.ReadLine());
            //int day2Winner = Convert.ToInt32(Console.ReadLine());
            //int day3Winner = Convert.ToInt32(Console.ReadLine());



            string[][] olympiad = new string[][]
            {
                //day 1 - 5 participants
                new string[] { "Jill Yan", "Bridgette Ramona", "Sree Sanda", "Jareth Charlene", "Carl Soner" },
                //day 2 - 7 participants
                new string[] { "Anna Hel", "Mariette Vedrana", "Fran Mayur", "Drake Hilmar", "Nikolay Brooks", "Eliana Vlatko", "Villem Mario" },
                //day 3 - 4 participants
                new string[] { "Hieremias Zavia", "Ziya Ollie", "Christoffel Casper", "Kristian Dana", }

            };
            //your code goes here
            //string x = olympiad[0][day1Winner - 1];
            //string y = olympiad[1][day2Winner -1];
            //string z = olympiad[2][day3Winner - 1];

                int[,,] a = new int[2, 3, 4];

            Console.Write(a.Rank);

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

        }
    }
}