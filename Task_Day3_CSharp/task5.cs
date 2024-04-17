using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Day3_CSharp
{
    class task5
    {
        /*
          b) Create a recursive function in C# to find the nth element 
        of a Fibonacci sequence and store the first n elements in an array.
         */
        public static void Main(string[] args)
        {
            Console.WriteLine("How many numbers you want in sequence?==>");
            int n = Convert.ToInt32(Console.ReadLine()); // Number of elements in the Fibonacci sequence
            int[] fibSeq = new int[n];

            // Generate Fibonacci sequence
            for (int i = 0; i < n; i++)
            {
                fibSeq[i] = Fibonacci(i);
            }

            // Display the Fibonacci sequence
            Console.WriteLine("Fibonacci Sequence elements:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(fibSeq[i] + " ");
            }
            Console.WriteLine();

            // Find the nth element of the Fibonacci sequence
            int nthElement = Fibonacci(n - 1);
            Console.WriteLine($"The {n}th element of the Fibonacci sequence is: {nthElement}");
        }

        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}

/*
//a)  Implement a C# method SliceArray that takes an array, a starting index,
//and an end index, then returns a new array containing the elements from
//the start to the end index.

namespace Task_Day3_CSharp
{
    class task5
    {
        
static int[] SliceArray(int[] x, int start, int end)
{
    int[] new1 = new int[(end - start) + 1];
    if (start < 0 || end < 0 || start > end || end > x.Length - 1 || start > x.Length - 1)
    {
        Console.WriteLine("Enter Valid index numbers /(start should be < end).");
    }
    else
    {
        int k = 0;
        for (int i = start; i <= end; i++)
        {
            new1[k] = x[i];
            k++;
        }
    }
    return new1;
}
static void Main()
{
    int[] x = new int[5];
    Console.WriteLine("Enter Array elements:");
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Enter Start Index:(<end)");
    int start = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter End Index:(>start)");
    int end = Convert.ToInt32(Console.ReadLine());

    int[] res = SliceArray(x, start, end);
    Console.WriteLine("new Array elements are:" + string.Join(", ", res));
    Console.ReadLine();
}
    }
}


*/