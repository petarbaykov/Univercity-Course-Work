using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task229b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of first array");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter size of second array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter size of third array");
            int k = int.Parse(Console.ReadLine());

            int[] fArray = new int[m];
            int[] sArray = new int[n];
            int[] tArray = new int[k];

            fillArray(fArray, m);
            fillArray(sArray, n);
            fillArray(tArray, k);

            int product1 = productOfOddIndexes(fArray);
            int product2 = productOfOddIndexes(sArray);
            int product3 = productOfOddIndexes(tArray);
            Console.WriteLine(product1);
            Console.WriteLine(product2);
            Console.WriteLine(product3);
            double avrG = geometric(product1, product2, product3);
            Console.WriteLine(avrG);

        }
        static void fillArray(int[] arr, int n)
        {
            Random rand = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(i, n);
            }
        }
        static int productOfOddIndexes(int[] arr)
        {
            int product = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != 0 && arr[i] % 2 == 0)
                {
                    product += arr[i];
                }
            }
            return product;
        }
        static double geometric(int p1, int p2, int p3)
        {
            int avrGeometric = p1 * p2 * p3;
            return Math.Sqrt(avrGeometric);
        }
    }
}
