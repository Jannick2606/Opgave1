using System;
using System.Threading;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintClass print = new PrintClass();
            Thread t1 = new Thread(print.PrintEasy);
            Thread t2 = new Thread(print.PrintMultiple);
            t1.Start();
            t2.Start();
        }
    }
    class PrintClass
    {
        public void PrintEasy()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C#-trådning er nemt!");
                Thread.Sleep(1000);
            }
        }
        public void PrintMultiple()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Også med flere tråde");
                Thread.Sleep(1000);
            }
        }
    }
}
