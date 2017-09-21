using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Char_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string count = "";
            Console.WriteLine("What would you liek to count?");
            count = @Console.ReadLine();
            int amountc = 0;
            foreach (char c in count)
            {
                amountc += 1;
            }
            Console.Write("Your string has " + amountc + " charachters.");
            Thread.Sleep(5000);
        }
    }
}
