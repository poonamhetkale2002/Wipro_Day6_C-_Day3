using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Day6_C__Day3
{
    class CallByValue_Reference
    {
        
        static void CallByValue(int x)
        {
            x = 20;
            Console.WriteLine("CAll By VAlue X:"+x);
        }
        static void CallByReference( ref int x)
        {
            x = 200;
            Console.WriteLine("By Reference X:"+x);
        }
        static void Main()
        {
            int x = 500;
            Console.WriteLine("Before CallBy Value X:" + x);
            CallByValue(x);
            Console.WriteLine("After CallBy Value X:" + x);

            Console.WriteLine("Before CallBy Reference X:" + x);
            CallByReference(ref x);
            Console.WriteLine("After CallByReference X:" + x);
            
            Console.ReadLine();
        }
    }
}
