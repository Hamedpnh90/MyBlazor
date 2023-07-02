using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazor.Lib.Models
{
    public class ShoppingCart
    {
       public IList<ShoppingCartItem> Items { get;  }

        public ShoppingCart()
        {
            Items = new List<ShoppingCartItem>();
        }
    }
}
