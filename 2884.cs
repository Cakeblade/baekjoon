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
            int Hour, Min;

            String str = Console.ReadLine();
            String [] cstr = str.Split(' ');
            Hour = Convert.ToInt32(cstr[0]);
            Min = Convert.ToInt32(cstr[1]);

            if (Hour < 0 || Min < 0 || Hour > 23 || Min > 60)
                Console.WriteLine("Error!");
            else
            {
                if (Min - 45 < 0)
                {
                    if (Hour == 0) Hour = 23;
                    else Hour -= 1;
                    Min += 15;
                }
                else Min -= 45;
                Console.WriteLine(Hour + " " + Min);
            }
        }
    }
}
