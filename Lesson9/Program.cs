using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        // void (int a, int b)
        delegate void BinaryOp(int a, int b);
        static void Main(string[] args)
        {
            //ShowBinOp();

            Action<int, int> action = Sum; //для void-методов

            Func<DateTime, string> func = ToString; //для не void-методов

            Console.ReadLine();
        }

        private static void ShowBinOp()
        {
            BinaryOp op = new BinaryOp(Sum);
            //BinaryOp op = Sum; синтакс сахар
            //op(10, 20);
            op += new BinaryOp(Sum);
            op += Sum; //синт сахар
            op -= Sum;
            op += Mul;
            op += Mul;

            Delegate[] ops = op.GetInvocationList();
            for (int i = 0; i < ops.Length; i++)
            {
                (ops[i] as BinaryOp)(10, 20);
            }
        }

        static void Sum(int a, int b)
        {
            double sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        static void Mul(int a, int b)
        {
            double mul = 1;
            for (int i = a; i <= b; i++)
            {
                mul *= i;
            }
            Console.WriteLine(mul);
        }

        static string ToString(DateTime time)
        {
            return time.ToLongDateString();
        }
    }
}
