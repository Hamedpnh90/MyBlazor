using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazor.Lib.Models
{
    public class ShoppingCartItem

    {
        public Product product { get; }

        public int Price { get; protected set; }

        public int Quantity { get; set; }

        public int TotalPrice
        {
            get
            {

                return Price + Quantity;
            }
        }

        public ShoppingCartItem(Product product,int quantity)
        {
            this.product = product;
            this.Price = product.Price;   
            this.Quantity = quantity;   
        }

        public void UpdateQuantity(Product product,int quantity)
        {
            this.Quantity = quantity;
            this.Price = product.Price;
        }
    }
}
