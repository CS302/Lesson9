using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson9_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> workItem = GetNumbers;
            IAsyncResult ires = workItem.BeginInvoke(10, 20, ShowGetNumbersResult, null);

            while (Console.ReadLine() != "exit") {}

            Console.ReadLine();
        }

        static void ShowGetNumbersResult(IAsyncResult ires)
        {
            AsyncResult res = (AsyncResult)ires;
            Func<int, int, int> workItem = (Func<int, int, int>)res.AsyncDelegate;
            int sum = workItem.EndInvoke(ires);
            Console.WriteLine("сумма = {0}", sum);
                
        }

        static int GetNumbers(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
            return sum;
        }
    }
}
