using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Day6_C__Day3
{
    class DefaultParameter
    {
        static void Main()
        {
           Console.WriteLine("Area of Rectangle:"+display(10, 2));
            Console.WriteLine("Area of Rectangle:" +display(length:3, height:2));//named parameter
            Console.ReadLine();
        }

        static float display(float length=5, float height=6) //default values 
        {
           return(length * height);
        }
    }
}
