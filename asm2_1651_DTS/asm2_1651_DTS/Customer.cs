using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651_DTS
{
    public class Customer : Person
    {
        List<Order> orders = new List<Order>();
        public int CustomerID { get; set; }
        public List<Order> Orders { get => orders; set => orders = value; }
        public Customer(int customerID)
        {
            CustomerID = customerID;
        }

        public Customer()
        {
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




