using MyBlazor.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazor.Lib.Services
{
    public class ProductService : IProductService
    {
        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(string Sku)
        {
            throw new NotImplementedException();
        }

        public Product GetProductBySlug(string Slug)
        {
            throw new NotImplementedException();
        }
    }
}
