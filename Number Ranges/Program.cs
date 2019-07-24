using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 12, 43, 54, 91, 31, 92, 22, 13, 82, 37, 54 };
            int max = array.Max();
            int min = array.Min();
            int sixthHighest = (from number in array
                                 orderby number descending
                                 select number).Distinct().Skip(5).First();
            Console.WriteLine("the smallest number is {0}", min);
            Console.WriteLine("the largest nunmber is {0}", max);
            Console.WriteLine("the Sixth Highest nunmber is {0}", sixthHighest);
            Console.Read();

        }
    }
}
