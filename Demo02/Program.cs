using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demo02
{
    class Program
    {
        public static async Task<int> Sum(int x, int y)
        {
            return await Task.Run(() =>
            {
                Console.WriteLine(".....Inside Sum");
                Thread.Sleep(5000);
                return x + y;
            });
            
        }

        public static async Task<int> CallSum()
        {
            int result = await Sum(3, 5);
            Console.WriteLine("Sum Finish. Result {0}", result);
            return result;
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
