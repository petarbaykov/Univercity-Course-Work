using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task361
{
    class Program
    {
        static void Main(string[] args)
        {
            string sampleString = "a*b + A*A * B*A - A*A / A*A";
            string newStr = replace(sampleString);
            Console.WriteLine(newStr);
        }
        static string replace(string S)
        {
            return S.Replace("A*A", "sqr(A)");
        }
    }
}
