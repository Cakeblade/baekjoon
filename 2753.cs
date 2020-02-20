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
            int Test_Year;

            String str = Console.ReadLine();
            Test_Year = Convert.ToInt32(str);

            if (Test_Year % 400 == 0)
                Console.WriteLine('1');
            else if (Test_Year % 4 == 0 && Test_Year % 100 != 0)
                Console.WriteLine('1');
            else
                Console.WriteLine('0');
            
        }
    }
}
