using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Box
    {
        double length;
        double breadth;
        double width;
        static void Main(string[] args)
        {

            Box box1 = new Box();
            Box box2 = new Box();
            double sum;


            box1.breadth = 12.3;
            box1.length = 10.2;
            box1.width = 11.0;

            sum = box1.width * box1.breadth * box1.length;
            Console.WriteLine(" the size of box1 is : " + sum);
            Console.WriteLine();

            box2.breadth = 14.3;
            box2.length = 11.2;
            box2.width = 18.09;

            sum = box2.width * box2.breadth * box2.length;
            Console.WriteLine(" the size of box2 is : " + sum);

            Console.ReadKey();
        }
    }
}
