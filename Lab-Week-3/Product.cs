using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Week_3
{
    internal class Product
    {
        public int Price { get; set; }
        public int ProductId { get; set; }
        public String ProductName { get; set; }

        public Product(int price, int productId, string productName)
        {
            Price = price;
            ProductId = productId;
            ProductName = productName;
        }
    }
}
