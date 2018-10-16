using System;

namespace TAloops
{
    class Program
    {
        static void Main()
        {
            int i = 100;
            while (i > 0)
            {
                Console.WriteLine(i + " bottles of beer on the wall, " + 100 + " bottles of beer...");
                i--;
                Console.WriteLine("Take one down, pass it around " + i + " bottles of beer on the wall.");
            }
            Console.ReadLine();

            Random rnd = new Random();
            int bugs = rnd.Next(0, 100);

            do
            {
                Console.WriteLine(bugs + " little bugs in the code, " + bugs + " little bugs...");
                bugs = rnd.Next(0, 100);
                Console.WriteLine("Take one down, patch it around " + bugs + " little bugs in the code.");
            } while (bugs != 0);

            Console.ReadLine();
        }
    }
}
