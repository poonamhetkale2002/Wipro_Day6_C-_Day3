using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Day6_C__Day3
{
  class NamedParameter
    {
        static void Main(String[] args)
        {
            DisplayDetails(id: 10, name: "Poonam", dept: "hr"); //named parameters
            //in named parameter if we  change position of parameter then it will give desired o/p

            DisplayDetails(90000, "hr", "Kirti"); //it may gives wrong o/p if we change poition of parameter.

            //named parameters
            DisplayDetails(id:98, dept: "accts",name: "Komal"); //it gives accurate result.

        }
        static void DisplayDetails(int id, string name,String dept)
        {
            Console.WriteLine($"Id > {id}\n" +$"Name > {name}\n" +$"Dept > {dept}\n" );
        }
    }
}
