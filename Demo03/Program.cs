using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demo03
{
    class Program
    {
        public static async Task Sum(int x, int y)
        {
            await Task.Run(() =>
            {
                Console.WriteLine(".....Inside Sum");
                Thread.Sleep(5000);
            });
        }

        public static async Task CallSumAsync()
        {
            await Sum(3, 5);
            Console.WriteLine("Sum Finish");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main Start");

            CallSumAsync();

            Console.WriteLine("After Call Sum");
            Console.WriteLine("Main Finish");
            Console.ReadLine();
        }
    }
}