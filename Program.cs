using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_or_post_fix
{
    class Program
    {
        static void Main(string[] args)
        {
            /*How to work prefix.*/

            String inc = "prefix";
            TypeOfIncrement(inc);
            String a = Console.ReadLine();
            int x = Int32.Parse(a);
            int y = ++x; // prefix increment (1. x = x + 1; 2. y = x)
            Result(y);
            Console.Clear();


            /*How to work postfix.*/

            inc = "postfix";
            TypeOfIncrement(inc);
            a = Console.ReadLine();
            x = Int32.Parse(a);
            y = x++; // prefix increment (1. y = x; 2. x = x + 1;)
            Result(y);
        }

        private static void TypeOfIncrement(String inc)
        {
            Console.WriteLine("This program shows how to work {0}.", inc);
            Console.WriteLine("Please enter your number and get {0} result.", inc);
        }

        private static void Result(int y)
        {
            Console.WriteLine("Your result {0}", y); // result
            Console.WriteLine("Press enter");
            Console.ReadLine();
        }
    }
}
