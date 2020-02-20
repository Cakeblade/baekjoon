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
            int[] Result_Arr = new int[int_Input];
            for (int i = 0; i < int_Input; i++)
            {
                string input = Console.ReadLine();
                string[] calc_num = input.Split();
                Result_Arr[i] = Convert.ToInt32(calc_num[0]) + Convert.ToInt32(calc_num[1]);
            }
            for (int i = 0; i < int_Input; i++)
                Console.WriteLine(Result_Arr[i]);
        }
    }
}
