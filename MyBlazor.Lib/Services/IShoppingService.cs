using MyBlazor.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazor.Lib.Services
{
    public interface IShoppingService
    {
        ShoppingCart GetAll();

        void AddProduct(Product product, int Quantity);


        void DeleteCartItem(ShoppingCartItem item);

        bool ProductExist(string Sku);

        int count();
    }
}
