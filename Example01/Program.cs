using System;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.WriteLine("Enter a value for a:");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value for b:");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Subtracting {a} - {b} equals {subtractNumbers(a,b)} ");
        }
        static int subtractNumbers(int a, int b)
        {
            return a - b;
        }
    }
}
