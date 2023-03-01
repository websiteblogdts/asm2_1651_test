using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651_DTS
{

    public class Staff : Person
    {
        public string StaffID { get; set; }
        public Staff(string name, int age, string address, string phoneNumber, string staffID) : base(name, age, address, phoneNumber)
        {
            StaffID = staffID;
        }

        public Staff()
        {
        }

        public override void EnterInformation()
        {
            this.Name = UI.EnterStaffName();
            this.Age = UI.EnterStaffAge();
            this.Address = UI.EnterStaffAddress();
            this.PhoneNumber = UI.EnterStaffPhone();
            this.StaffID = UI.EnterStaffID();
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
            Console.ForegroundColor = ConsoleColor.White;
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
    }
}