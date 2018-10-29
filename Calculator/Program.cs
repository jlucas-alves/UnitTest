using System;

namespace Calculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var calculator = new Calculator(new FileIOWrapper());
            var result = calculator.AddFromFile(@"c:\temp\\unitTestData\numbers.txt");
            Console.WriteLine($"Result: {result}");

            Console.ReadLine();
        }
    }
}