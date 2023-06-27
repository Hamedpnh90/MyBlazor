using MyBlazor.Lib.Models;
using MyBlazor.Lib.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazor.Lib.Services
{
    public class ProductService : IProductService
    {
        private readonly IStorageService _storageService;

        public ProductService(IStorageService storageService)
        {
            _storageService = storageService;
        }
        public IList<Product> GetAll()
        {
            return _storageService.Products.ToList();
        }

        public Product GetProduct(string Sku)
        {
            return _storageService.Products.FirstOrDefault(p => p.Sku == Sku);  
        }

        public Product GetProductBySlug(string Slug)
        {
            return _storageService.Products.FirstOrDefault(p => p.Slug == Slug);
        }
    }
}
