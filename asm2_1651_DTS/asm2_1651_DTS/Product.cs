using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651_DTS
{
    public class Product
    {
        List<OrderDetail> orderDetails = new List<OrderDetail>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        internal List<OrderDetail> OrderDetails
        {
            get => orderDetails;
            set => orderDetails = value;
        }

        public Product(int productID, string name, double price)
        {
            ProductID = productID;
            Name = name;
            Price = price;
        }

        public Product()
        {

        }
    }
   /* public Product SearchObjectProduct(int idProductToSearch)
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
    public bool SearchProductID(int idProductToSearch)
    {
        var productInList = Products.FirstOrDefault(n => n.ProductID.Equals(idProductToSearch));
        if (productInList == null)
        {
            return false;
        }
        return true;
    }*/
}