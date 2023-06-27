using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazor.Lib.Models
{
    public class Product
    {

        public string Sku { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string Slug
        {
            get
            {
                return Sku.ToLower();
            }
        }

        public string FullUrl { get {

                return string.Format("/product/{0}", Slug);
            
            } }

        public Product(string sku,string name,string image,string description,string Price)
        {
            this.Sku = sku; 
            this.Name = name;
            this.Description = description;
            this.Price = Price;
            this.Image = image;
            
        }
    }
}
