using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTest3_3I_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b: ");
            int b = int.Parse(Console.ReadLine());
            while(a<0)
            {
                Console.WriteLine("Number a has to be positive! Enter again!");
                a = int.Parse(Console.ReadLine());

            }
            while (b < 0)
            {
                Console.WriteLine("Number b has to be positive!!! Enter again!");
                b = int.Parse(Console.ReadLine());
            }
            decimal result = func(a+b) * func(Math.Abs(a-b));
            Console.WriteLine("Result is:  {0}",result);
        }
        static decimal func(int n)
        {
            decimal sum = 0;
            for(int i = 1; i <= n; i++)
            {
                if(i == 1)
                {
                    sum += 1;
                }
                else
                {
                    sum += 1 /(decimal) Math.Pow(i, 4);
                }
            }
            return sum;
        }
    }
}
