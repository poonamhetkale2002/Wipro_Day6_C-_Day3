namespace Task_Day3_CSharp
{
    class task1
    {
        /*
         * a) Create a function named InitializeArray that initializes an array 
         * with a given size and fills it with random integers.
         public static void Main(string[] args)
        {
            int size = 10; // Example size of the array
            int[] array = InitializeArray(size);
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

            
        b) Develop functions named InsertElement, DeleteElement, UpdateElement,
        and ReverseArray that perform the corresponding operations on an array.
        Provide a brief comment on each function describing its behavior."

         */

        
            List<int> a = new List<int>();
            //insert elements
            void insert(int x)
            {
                a.Add(x);
                Console.WriteLine(x + " added Successfully.");
            }

            //Delete elements
            void delete(int item)
            {
            int flag = 0;
                for (int i = 0; i < a.Count; i++)
                {
                     if (a[i] == item)
                        {
                           a.Remove(item);
                            flag = 1;
                        }
                }
            if (flag==1)
            {
                Console.WriteLine(item + " Removed Successfully.");
            }
            else
            {
                Console.WriteLine(item + " Does not exists.");
            }
        }

            void update(int pos, int item)
            {
                if (pos < a.Count && pos >= 0)
                {
                    a[pos]= item;
                    Console.WriteLine(item + " Updated successfully.");
                }
                else
                {
                    Console.WriteLine("invalid position.");
                }
            }

            //Display elements.
            void display()
            {
                for (int i = 0; i < a.Count; i++)
                {
                    Console.WriteLine(a[i]);
                }
            }

            //reverse elements
            void reverse()
            {
                Console.WriteLine("reverse elements of an integer array:");
                for (int i = a.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(a[i]);
                }
            }

            
                 
            static void Main(string[] args)
            {
                task1 p = new task1();
                int ch;
                do
                {
                    Console.WriteLine("Enter Yout Choice:\n 0.Exit 1.Insert 2.Delete 3.Display 4.Update 5.Reverse==> ");
                     ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine("Enter int Element to add in array: ");
                            int x = Convert.ToInt32(Console.ReadLine());
                            p.insert(x);
                            break;
                        case 2:
                            Console.WriteLine("Enter Element to delete element:");
                            int z = Convert.ToInt32(Console.ReadLine());
                            p.delete(z);
                            break;
                        case 3:
                            p.display();
                            break;
                        case 4:
                            Console.WriteLine("Enter position to update element:");
                            int pos = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Element to Update:");
                            int item = Convert.ToInt32(Console.ReadLine());
                            p.update(pos, item);
                            break;
                        case 5: p.reverse(); break;
                        
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
