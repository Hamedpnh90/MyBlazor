using MyBlazor.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazor.Lib.Services
{
    public interface IProductService
    {

        Product GetProduct(string Sku);
        Product GetProductBySlug(string Slug);

        IList<Product> GetAll();
    }
}
