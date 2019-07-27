using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double? CurrentPrice { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrEmpty(ProductName);
        }

        public Product Retrive(int productId)
        {
            return new Product();
        }

        public List<Product> Retrive()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
