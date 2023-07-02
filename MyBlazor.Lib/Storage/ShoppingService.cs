using MyBlazor.Lib.Models;
using MyBlazor.Lib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazor.Lib.Storage
{
    public class ShoppingService : IShoppingService
    {
        private readonly IStorageService _storageService;

        public ShoppingService(IStorageService storageService)
        {
            _storageService = storageService;
        }
        public void AddProduct(Product product, int Quantity)
        {

            var items = GetAll().Items;
            if(ProductExist(product.Sku))
            {
                 var item=  items.FirstOrDefault(i=>i.product.Sku==product.Sku);        

                item.UpdateQuantity(product,Quantity); 
            }
            else
            {
                items.Add(new ShoppingCartItem(product, Quantity));
            
            }
        }

        public int count()
        {
            return GetAll().Items.Count;    
        }

        public void DeleteCartItem(ShoppingCartItem item)
        {

            var items= GetAll().Items;  
            if(ProductExist(item.product.Sku))
            {
                items.Remove(items.First(i=>i.product.Sku==item.product.Sku));
            }
            

                
            
        }

        public ShoppingCart GetAll()
        {
            return _storageService.ShoppingCart;
        }

        public bool ProductExist(string Sku)
        {
            var items=GetAll().Items;   

            return items.Any(i=>i.product.Sku == Sku);
            

            

        }
    }
}
