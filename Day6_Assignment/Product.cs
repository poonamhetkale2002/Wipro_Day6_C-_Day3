namespace Day6_Assignment
{
   class Product
    {
        
        public string pcode;
        public string Pname;
        public int QtyInStock;
        public double Discount;
        public string Brand;

        // Constructor to initialize product properties
        public Product(string pcode, string pname, int qtyInStock, double discount, string brand)
        {
            this.pcode = pcode;
            Pname = pname;
            QtyInStock = qtyInStock;
            Discount = discount;
            Brand = brand;
        }

        // Method to take inputs from admin and set product details
        public static Product TakeInputs()
        {
            Console.WriteLine("Enter product code:");
            string pcode = Console.ReadLine();

            Console.WriteLine("Enter product name:");
            string pname = Console.ReadLine();

            Console.WriteLine("Enter quantity in stock:");
            int qtyInStock = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter discount allowed:");
            double discountAllowed = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter brand:");
            string brand = Console.ReadLine();

            return new Product(pcode, pname, qtyInStock, discountAllowed, brand);
        }

        // Method to display product details
        public void DisplayDetails()
        {
            Console.WriteLine("Product Code: " + pcode);
            Console.WriteLine("Product Name: " + Pname);
            Console.WriteLine("Quantity in Stock: " + QtyInStock);
            Console.WriteLine("Discount Allowed: " + Discount);
            Console.WriteLine("Brand: " + Brand);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Product p= Product.TakeInputs(); //Take unput details            
            p.DisplayDetails();  // Display product details

            // Customer wants to purchase a product
            Console.WriteLine("Enter product name to purchase:");
            string productName = Console.ReadLine();
           
            if (((p.Pname).ToLower() )==(productName.ToLower()))
            {
                Console.WriteLine("Product found!");
                p.DisplayDetails();
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

    }
}
