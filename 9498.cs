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
            int Test_Score;

            String str = Console.ReadLine();
            Test_Score = Convert.ToInt32(str);
            if (Test_Score <= 100 && Test_Score >= 0)
            {
                if (Test_Score >= 90)
                    Console.WriteLine('A');
                else if (Test_Score >= 80 && Test_Score < 90)
                    Console.WriteLine('B');
                else if (Test_Score >= 70 && Test_Score < 80)
                    Console.WriteLine('C');
                else if (Test_Score >= 60 && Test_Score < 70)
                    Console.WriteLine('D');
                else
                    Console.WriteLine('F');
            }
            else Console.WriteLine("Error!");
        }
    }
}
