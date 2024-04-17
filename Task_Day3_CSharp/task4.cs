using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Day3_CSharp
{
   class task4
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 }; 
            int sum = SumArray(array);
            Console.WriteLine("Sum of the array elements: " + sum);
        }
      public static int SumArray(int[] array)
        {
            return show(array, 0); 
        }

       private static int show(int[] array, int index)
        {
            if (index >= array.Length)
            {
                return 0; 
            }
            else
            {
                return array[index] + show(array, index + 1);
            }
        }
    }
}
