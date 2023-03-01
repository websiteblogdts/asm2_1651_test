namespace asm2_1651_DTS
{

    /*class Program
    {
        static void Main(string[] args)
        {
            UI.Menu();
            UI.ChooseOption();
        }
    }
*/

    public class Program
    {
        static List<Product> Products = new List<Product>();
        static List<Customer> Customers = new List<Customer>();
        static List<Order> Orders = new List<Order>();
        static List<OrderDetail> OrderDetails = new List<OrderDetail>();
        static List<Staff> Staffs = new List<Staff>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Milk Tea Shop!");
            while (true)
            {
                Menu();
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        PrintInformationOfProduct();
                        break;
                    case 3:
                        UpdateProduct();
                        break;
                    case 4:
                        DeleteProduct();
                        break;
                    case 5:
                        AddInformationCustomer();
                        break;
                    case 6:
                        OrderProduct();
                        break;
                    case 7:
                        CustomerOrderProductManagement();
                        break;
                    case 8:
                        SearchOrderProduct();
                        break;
                    case 9:
                        RemoveOrderProduct();
                        break;
                    case 10:
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void PrintInformationOfProduct()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------Product-List----------");
            ConsoleTable.From<Product>(Products).Write();
            Console.ForegroundColor ConsoleColor.White;
            if (!Products.Any())
            {
                Console.WriteLine("Invalid result, Please Do Select 1");
                Console.WriteLine("**********************************");
            }
        }
        public bool SearchProductID(int idProductToSearch)
        {
            var productInList = Products.FirstOrDefault(n => n.ProductID.Equals(idProductToSearch));
            if (productInList == null)
            {
                return false;
            }
            return true;
        }
        public Product SearchObjectProduct(int idProductToSearch)
        {
            var productInList = Products.FirstOrDefault(n => n.ProductID.Equals(idProductToSearch));
            return productInList;
        }
        public bool UpdateProductByID(int idProductToUpdate, string newName, double newPrice)
        {
            var productInList = Products.FirstOrDefault(n => n.ProductID.Equals(idProductToUpdate));
            productInList.Name = newName;
            productInList.Price = newPrice;
            return true;
        }
        public bool DeleteProductByID(int idProductToDelete)
        {
            var productInList = Products.FirstOrDefault(n => n.ProductID.Equals(idProductToDelete));
            Products.Remove(productInList);
            return true;
        }

        public override void EnterInformation()
        {
            this.Name = UI.EnterCustomerName();
            this.Age = UI.EnterCustomerAge();
            this.Address = UI.EnterCustomerAddress();
            this.PhoneNumber = UI.EnterCustomerPhone();

        }

        public void AddInformationCustomer()
        {
            Customer newCustomer = new Customer();
            newCustomer.CustomerID = UI.EnterCustomerID();
            while (SearchCustomerID(newCustomer.CustomerID))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Customer ID already Exist. Please Enter Customer ID again");
                Console.ForegroundColor = ConsoleColor.White;
                newCustomer.CustomerID = UI.EnterCustomerID();
            }
            newCustomer.EnterInformation();
            Customers.Add(newCustomer);
        }
        public Customer GetCustomerOrderProductByID(int idCustomerToSearch)
        {
            var customerInList = Customers.FirstOrDefault(x => x.CustomerID.Equals(idCustomerToSearch));
            return customerInList;
        }

        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View Product");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Add Information Customer ");
            Console.WriteLine("6. Order Product ");
            Console.WriteLine("7. Customer Order Product Management");
            Console.WriteLine("8. Search Order Product");
            Console.WriteLine("9. Remove Order Product");
            Console.WriteLine("10. Exit");
            Console.WriteLine();
            Console.WriteLine("Please choose your option");
        }
    }
}