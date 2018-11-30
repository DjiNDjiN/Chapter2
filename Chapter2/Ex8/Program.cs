using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            string stringifiedHelloWorld = (string)helloWorld;
            Console.WriteLine(stringifiedHelloWorld);

        }
    }
}
