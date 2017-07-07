using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randompractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////creating a random object
            //Random ranNum = new Random();
            ////saving the random number from our random object(ranNum)
            //int randy = ranNum.Next(0, 50);
            ////printing out the random int variable
            //Console.WriteLine(randy);
            //Console.WriteLine(randy);
            //Console.WriteLine(randy);
            ////did NOT save that value to an integer
            //Console.WriteLine(ranNum.Next(0, 40));

            //Rock, Paper, Scissors and stuff
            Random ranWord = new Random();
            string[] words = { "Rock", "Paper", "Scissors" };
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string saying = "You can never have to much cake";
            Console.WriteLine(numbers[ranWord.Next(0, 9)]);
            Console.WriteLine(words[ranWord.Next(0, 3)]);
            Console.WriteLine(saying[ranWord.Next(0, saying.Length)]);







        }
    }
}
