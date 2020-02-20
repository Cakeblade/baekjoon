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
            string Raw_input = Console.ReadLine();
            int int_Input = Convert.ToInt32(Raw_input);
            for (int i = 1; i < 10; i++)
                Console.WriteLine("{0} * {1} = {2}", int_Input, i, int_Input * i);
        }
    }
}
