using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    class Program
    {
        static void Main(string[] args)
        {

            // C Sharp program to make array of numbers
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = list;
            Console.Write("original array: ");
            foreach( int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();


            //reversed array of numbers
            Array.Reverse(temp);
            Console.Write("reversed Array ");
            foreach(int i in temp)
            {
                Console.Write(i + " ");
            
            } 
            //sorted array of numbers
            Array.Sort(list);
            Console.WriteLine("Sorted arrays: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
