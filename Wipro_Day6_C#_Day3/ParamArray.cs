using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Day6_C__Day3
{
   class ParamArray
    {
        static void Main()
        {
            Console.WriteLine("Addition:"+Add(1, 2));
            Console.WriteLine("Addition:" + Add(10,40,30));
            Console.WriteLine("Addition:" + Add(4, 5, 34,145,45));
        }
        static int Add(params int[] num)
        {
            int sum = 0;
            foreach (int i in num)
            {
                sum += i;
            }
            return sum;
        }
    }
}
