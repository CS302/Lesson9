using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = 100;
            var text = "textString";
            Console.WriteLine(text.Length);

            var x = GetNumber();

            //number1 = "blabla";

            dynamic number = 100;
            Console.WriteLine(number);
            number += 10;
            Console.WriteLine(number);

            number = "string";
            number = number + 10;
            Console.WriteLine(number);
        }

        private static int GetNumber()
        {
            return 100;
        }
    }
}
