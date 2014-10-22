using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demo01
{
    class Program
    {
        public static void Sum(int x, int y)
        {
            Console.WriteLine(".....Inside Sum");
            Thread.Sleep(5000);
        }

        public static void CallSum()
        {
            Sum(3, 5);
            Console.WriteLine("Sum Finish");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main Start");

            CallSum();

            Console.WriteLine("After Call Sum");
            Console.WriteLine("Main Finish");
            Console.ReadLine();
        }
    }
}