using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651_DTS
{
    public class UI
    {
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


            public static string EnterCustomerName()
            {
                Console.Write("Enter Customer Name: ");
                return Console.ReadLine();
            }

            public static int EnterCustomerAge()
            {
                Console.Write("Enter Customer Age: ");
                return int.Parse(Console.ReadLine());
            }

            public static string EnterCustomerAddress()
            {
                Console.Write("Enter Customer Address: ");
                return Console.ReadLine();
            }

            public static string EnterCustomerPhone()
            {
                Console.Write("Enter Customer Phone: ");
                return Console.ReadLine();
            }

            public static int EnterCustomerID()
            {
                Console.Write("Enter Customer ID: ");
                return int.Parse(Console.ReadLine());
            }

            public static string EnterStaffName()
            {
                Console.Write("Enter Staff Name: ");
                return Console.ReadLine();
            }

            public static int EnterStaffAge()
            {
                Console.Write("Enter Staff Age: ");
                return int.Parse(Console.ReadLine());
            }

            public static string EnterStaffAddress()
            {
                Console.Write("Enter Staff Address: ");
                return Console.ReadLine();
            }

            public static string EnterStaffPhone()
            {
                Console.Write("Enter Staff Phone: ");
                return Console.ReadLine();
            }

            public static string EnterStaffID()
            {
                Console.Write("Enter Staff ID: ");
                return Console.ReadLine();
            }
        }
      /*  public static string EnterCustomerName()
        {
            Console.Write("Enter Customer Name: ");
            return Console.ReadLine();
        }

        public static int EnterCustomerAge()
        {
            Console.Write("Enter Customer Age: ");
            return int.Parse(Console.ReadLine());
        }

        public static string EnterCustomerAddress()
        {
            Console.Write("Enter Customer Address: ");
            return Console.ReadLine();
        }
        public static string EnterCustomerPhone()
        {
            Console.Write("Enter Customer Phone Number: ");
            return Console.ReadLine();
        }

        public static int EnterCustomerID()
        {
            Console.Write("Enter Customer ID: ");
            return int.Parse(Console.ReadLine());
        }

        public static string EnterStaffName()
        {
            Console.Write("Enter Staff Name: ");
            return Console.ReadLine();
        }
        public static int EnterStaffAge()
        {
            Console.Write("Enter Staff Age: ");
            return int.Parse(Console.ReadLine());
        }

        public static string EnterStaffAddress()
        {
            Console.Write("Enter Staff Address: ");
            return Console.ReadLine();
        }

        public static string EnterStaffPhone()
        {
            Console.Write("Enter Staff Phone Number: ");
            return Console.ReadLine();
        }
        public static string EnterStaffRole()
        {
            Console.Write("Enter Staff Role: ");
            return Console.ReadLine();
        }

        public static double EnterStaffSalary()
        {
            Console.Write("Enter Staff Salary: ");
            return double.Parse(Console.ReadLine());
        }

        public static int EnterOrderID()
        {
            Console.Write("Enter Order ID: ");
            return int.Parse(Console.ReadLine());
        }
        public static int EnterProductID()
        {
            Console.Write("Enter Product ID: ");
            return int.Parse(Console.ReadLine());
        }

        public static int EnterCustomerIDForOrder()
        {
            Console.Write("Enter Customer ID for Order: ");
            return int.Parse(Console.ReadLine());
        }

        public static int EnterQuantity()
        {
            Console.Write("Enter Quantity: ");
            return int.Parse(Console.ReadLine());
        }
        public static DateTime EnterDate()
        {
            Console.Write("Enter Date (dd/MM/yyyy): ");
            return DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        }*/
    } 

