using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            bool hasProblem;
            do
            {
                hasProblem = false;
                Console.WriteLine("num1: ");
                string num1Str = Console.ReadLine();
                Console.WriteLine("num2: ");
                string num2Str = Console.ReadLine();
                try
                {
                    num1 = Convert.ToInt32(num1Str);
                    num2 = Convert.ToInt32(num2Str);
                }
                catch
                {
                    Console.WriteLine("Xeta bas verdi");
                    hasProblem = true;
                }
            }
            while (hasProblem);




          

            Console.WriteLine(num1/num2);
        }
    }
}
