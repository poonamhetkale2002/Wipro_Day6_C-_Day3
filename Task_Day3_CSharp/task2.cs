using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Day3_CSharp
{
    class task2
    {
        /*
         //task2 a)
        static void Main(string[] args)
        {
            int[] array = InitializeArray(10); // Initialize array with 10 random integers
            Console.WriteLine("Original array:");
            PrintArray(array);

            BruteForceSort(array); // Sort the array using BruteForceSort
            Console.WriteLine("Sorted array:");
            PrintArray(array);
        }

        // Function to initialize an array with random integers
        public static int[] InitializeArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(100); // Generates random integers between 0 and 99
            }
            return array;
        }

        // Function to print the elements of an array
        public static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // Brute force sorting algorithm
        public static void BruteForceSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        // Swap elements
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }*/


        List<int> a = new List<int>();
        //insert elements
        void insert(int x)
        {
            a.Add(x);
            Console.WriteLine(x + " added Successfully.");
        }
        int linear_Search(int item)  //without sorting
        {
            int flag = -1;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == item)
                {
                    flag = i;
                }
            }
            return flag;
        }
        static void Main()
        {
            task2 t = new task2();
            int ch;
            do
            {
                Console.WriteLine("Enter Yout Choice:\n 0.Exit 1.Insert 2.Linear_Search==> ");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter int Element to add in array: ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        t.insert(x);
                        break;                   
                    case 2:
                        Console.WriteLine("Enter Element to Search:");
                        int y = Convert.ToInt32(Console.ReadLine());
                        int z=t.linear_Search(y);
                        Console.WriteLine("Element found at:" + z + " Position.");
                        break;                   
                    case 0: break;
                    default:
                        Console.WriteLine("Invalid Choice .");
                        break;
                }
            }
            while (ch != 0);
            Console.ReadLine();
        }
    }
}
