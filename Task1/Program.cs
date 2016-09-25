using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int guessNumber = random.Next(1,6);
            Console.Write("Опитай се да познаеш числото: ");
            int userGuess = int.Parse(Console.ReadLine());
            Console.WriteLine((guessNumber == userGuess) + " числото е: {0}", guessNumber);

        }
    }
}
