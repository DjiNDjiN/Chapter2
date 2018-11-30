using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            double numberThree = numberOne + numberTwo;
            Console.WriteLine("{0:f6}", numberThree);

        }
    }
}
