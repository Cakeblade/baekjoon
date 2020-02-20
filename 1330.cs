using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bla
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 10000;
            const int MIN = -10000;
            int num1, num2;
            String str = Console.ReadLine();

            String[] cstr = str.Split(' ');

            num1 = checked(Convert.ToInt32(cstr[0]));
            num2 = checked(Convert.ToInt32(cstr[1]));

            if (num1 < MAX && num2 < MAX && num1 > MIN && num2 > MIN)
            {
                if (num1 > num2)
                    Console.WriteLine('>');
                else if (num1 < num2)
                    Console.WriteLine('<');
                else
                    Console.WriteLine("==");
            }
            else Console.WriteLine("Error!");

        }
    }
}
