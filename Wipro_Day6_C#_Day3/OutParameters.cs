using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Day6_C__Day3
{
   class OutParameters
    {
        static void operations(int x,int y,out int add, out int sub,out int mul,out int div)
        {
            add = x + y;
            sub = x - y;
            mul = x * y;
            div = x / y;
        }
        static void Main(String[] args)
        {
            int add,sub,mul, div;
            Console.WriteLine("Enter Value for a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value for b:");
            int b = Convert.ToInt32(Console.ReadLine());
            operations(a, b, out add, out sub, out mul, out div);
            Console.WriteLine("Addition:" + add);
            Console.WriteLine("Subtraction:" + sub);
            Console.WriteLine("Multiplication:" + mul);
            Console.WriteLine("Division:" + div);
            Console.ReadLine();
        }
    }
}
