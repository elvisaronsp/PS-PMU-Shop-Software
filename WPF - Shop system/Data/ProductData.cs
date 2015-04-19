using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF___Shop_system.Data
{
    public class ProductData
    {
        public static string ProductStatus(string productID)
        {
            ProductClassesDataContext currectProduct = new ProductClassesDataContext();
            var product = currectProduct.GetTable<Product>()
                          .Where(pr => pr.UNumber == productID)
                          .FirstOrDefault();

            if (product != null)
            {
                return "Product found!";
            }
            else
            {
                return "Product is not found!";
            }
        }

        public Product ProductSearching(string productName)
        {
            ProductClassesDataContext currectProduct = new ProductClassesDataContext();
            var product = currectProduct.GetTable<Product>()
                          .Where(pr => pr.Name == productName)
                          .FirstOrDefault();

            if (product != null)
            {
                return product;
            }
            else
            {
                return null;
            }
        }
    }
}
