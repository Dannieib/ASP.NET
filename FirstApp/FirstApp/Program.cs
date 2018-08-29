using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        //out referncing method

        //public void getValue(out int x)
        //{
        //    int temp = 5;
        //    x = temp;
        //}


        ////referencing method
        //public void swap (ref int x, ref  int y, ref  int z)
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = z;
        //    z = temp;
        //}





        //public int FindMax (int num1, int num2)
        //{
        //    int result;
        //    if (num1 > num2)
        //    {
        //        result = num1;
        //    }
        //    else
        //    {
        //        result = num2;

        //    }
        //    return result;
        //}

        //    public double length;
        //    public double width;

        //    public double Area() {

        //        return length * width;
        //    }


        //    public void display()
        //    {

        //        Console.WriteLine(" Length: " + length);
        //        Console.WriteLine(" Width: " + width);
        //        Console.WriteLine("Total Area of the Rectangle: " + Area());
        //    }
        //}
        //    class ExecuteProgram
        //    {

        ////referencing method

        public static void Main(string[] args)
        {

            float result = 0;

            Console.WriteLine("Please enter your first Number");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("HINT: + or - or x or /");
            string operate = Console.ReadLine();


            Console.WriteLine("please enter your second number");
            float num2 = float.Parse(Console.ReadLine());
           
            switch (operate)
            {
                case "_":
                    result = num1 - num2;
                    Console.WriteLine("the answer is : " + result);
                    break;

                case "+":
                    result = num1 + num2;
                    Console.WriteLine("the answer is : " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine("the answer is : " + result);
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine("the answer is : " + result);
                    break;

                case "%":
                    result = num1 % num2;
                    Console.WriteLine("the answer is : " + result);
                    break;

                default:
                Console.WriteLine("invalid entry");
              
              break;
                   
                  
                
            }

            

            Console.ReadKey();

            //Program p = new Program();
            //int a = 100;
            //Console.WriteLine("befoere methpod call" + a);
            //p.getValue(out a);

            //Console.WriteLine("after method call " + a);

            //Program p = new Program();
            //int a = 100;
            //int b = 200;
            //int c = 50;

            //Console.WriteLine("before swap of value A " + a);
            //Console.WriteLine("before swap of value B " + b);
            //Console.WriteLine("before swap of value C " + c);
            //p.swap(ref a, ref b, ref c);

            //Console.WriteLine("before swap of value A " + a);
            //Console.WriteLine("before swap of value B " + b);
            //Console.WriteLine("before swap of value C " + c);



            //int a = 100;
            //int b = 200;
            //int ret;

            //Program p = new Program();
            //ret = p.FindMax(a, b);
            //Console.WriteLine("max value is: " + ret);
            //Console.ReadLine();



            //Program p = new Program();
            //p.length = 4.5;
            //p.width = 3.5;
            //p.display();
            //Console.ReadLine();


            //        int i, j;

            //        for(i=2; i < 100; i++)
            //        {
            //            for (j = 2; j <= (i / j); j++)
            //            {
            //                if ((i % j) == 0)
            //                {
            //                    break;
            //                }
            //            }
            //                    if (j > (i / j)) 
            //                { 
            //            Console.WriteLine("prime number is: " + i);
            //                }
            //        }
            //Console.ReadLine(); 



        }

    }
    
}
