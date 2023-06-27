using MyBlazor.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazor.Lib.Storage
{
    public class StorageService : IStorageService
    {
        public IList<Product> Products { get; private set; }

        public StorageService()
        {
            Products = new List<Product>();


                AddProduct(new Product("1", "asp", "1.jpg", "this is aps", "2000"));
                AddProduct(new Product("2", "C#", "2.jpg", "this is aps", "2000"));
                AddProduct(new Product("3", "JS", "3.jpg", "this is aps", "2000"));
             
                   
            


        }


        public void AddProduct(Product product)
        {
            if (!Products.Any(p => p.Sku == product.Sku))

                    {
                Products.Add(product);
            }
        }
    }
}
