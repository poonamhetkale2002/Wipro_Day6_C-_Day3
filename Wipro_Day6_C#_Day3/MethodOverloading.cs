using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Day6_C__Day3
{
   class MethodOverloading
    {
        static int add(int a, int b)
        {
            return (a + b);
        }
        static int sub(int a, int b)
        {
            return (a-b);
        }
        static int mul(int a, int b)
        {
            return (a * b);
        }
        static int div(int a, int b)
        {
            return (a / b);
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Value for a:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value for b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition:"+add(a,b));
            Console.WriteLine("Subtraction:"+sub(a,b));
            Console.WriteLine("Multiplication:"+mul(a,b));
            Console.WriteLine("Division:"+div(a,b));
            Console.ReadLine();
        }
    }
}
