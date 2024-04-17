using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Assignment
{
    
    class ProductBill
    {
        
        public string pcode;
        public string Pname;
        public int QtyInStock;
        public double Price;
        public string Brand;

        // Constructor to initialize product properties
        public ProductBill(string pcode, string pname, int qtyInStock, double price, string brand)
        {
            this.pcode = pcode;
            Pname = pname;
            QtyInStock = qtyInStock;
            Price = price;
            Brand = brand;
        }

        // Method to take inputs from admin and set product details
        public static ProductBill TakeInputs()
        {
            Console.WriteLine("Enter product code:");
            string pcode = Console.ReadLine();

            Console.WriteLine("Enter product name:");
            string pname = Console.ReadLine();

            Console.WriteLine("Enter quantity in stock:");
            int qtyInStock = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter price:");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter brand:");
            string brand = Console.ReadLine();

            return new ProductBill(pcode, pname, qtyInStock, price, brand);
        }

        // Method to display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Code: " + pcode);
            Console.WriteLine("Product Name: " + Pname);
            Console.WriteLine("Quantity in Stock: " + QtyInStock);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Brand: " + Brand);
        }
    }
    
    public class Program1
    {
       static List<ProductBill> products = new List<ProductBill>();
        static void Main(string[] args)
        {
            bool isAdmin = false;

             Console.WriteLine("Who are you? (Admin/Customer)");
             string userType = Console.ReadLine();

             if (userType.ToLower() == "admin")
             {
                 isAdmin = true;
                 AdminMenu();
             }
             else if (userType.ToLower() == "customer")
             {
                 CustomerMenu();
             }
             else
             {
                 Console.WriteLine("Invalid user type.");
             }

            //Console.WriteLine(DateTime.Now.ToString());
            //Console.WriteLine(DateTime.Now.ToLongDateString().ToString());
            //Console.WriteLine(DateTime.Now.ToString("MMMM dd"));

            Console.ReadLine();
        }
        
        static void AdminMenu()
        {
            bool isAdminLoggedIn = true;

            while (isAdminLoggedIn)
            {
                Console.WriteLine("Admin Menu:");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Display Products");
                Console.WriteLine("3. Logout");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        DisplayProducts();
                        break;
                    case 3:
                        isAdminLoggedIn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void AddProduct()
        {
            ProductBill product = ProductBill.TakeInputs();
            products.Add(product);
            Console.WriteLine("Product added successfully!");
        }

        static void DisplayProducts()
        {
            Console.WriteLine("Products:");
            foreach (var product in products)
            {
                product.DisplayProductDetails();
                Console.WriteLine();
            }
        }

        static void CustomerMenu()
        {
            Console.WriteLine("Customer Menu:");
            Console.WriteLine("1. Order Product");
            Console.WriteLine("2. Get Bill");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    OrderProduct();
                    break;
                case 2:
                    GetBill();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void OrderProduct()
        {
            Console.WriteLine("Enter product name:");
            string productName = Console.ReadLine();

            ProductBill product = products.Find(p => p.Pname == productName);
            if (product != null)
            {
                Console.WriteLine("Product found!");
                product.DisplayProductDetails();
                Console.WriteLine("Enter quantity to purchase:");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity <= product.QtyInStock)
                {
                    product.QtyInStock -= quantity;
                    Console.WriteLine("Product ordered successfully!");
                }
                else
                {
                    Console.WriteLine("Not enough quantity in stock.");
                }
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        static void GetBill()
        {
            double totalAmount = 0;

            Console.WriteLine("Bill:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Product Name\tQty\tPrice\tTotal");
            Console.WriteLine("------------------------------");

            if (DateTime.Now.ToString("MMMM dd") == "January 26")
            {
                foreach (var product in products)
                {
                    double discountedPrice = product.Price * 0.5; // 50% discount
                    double subtotal = discountedPrice * product.QtyInStock;
                    totalAmount += subtotal;
                    Console.WriteLine($"{product.Pname}\t{product.QtyInStock}\t{discountedPrice}\t{subtotal}");
                }
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Total Amount (50% discount applied): {totalAmount}");
            }
            else
            {
                foreach (var product in products)
                {
                    double discountedPrice = product.Price; // 0% discount
                    double subtotal = discountedPrice * product.QtyInStock;
                    totalAmount += subtotal;
                    Console.WriteLine($"{product.Pname}\t{product.QtyInStock}\t{discountedPrice}\t{subtotal}");
                }
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Total Amount (0% discount applied): {totalAmount}");

            }
        }
    }
}
