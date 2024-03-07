using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }

        // welke relatie is er ten opzichte van Category?
        // één product zit in één categorie
        public Category Category { get; set; }

        public Product()
        {
            
        }

        public Product(string name, string description, string image, decimal price, bool available)
        {
            Name = name;
            Description = description;
            Image = image;
            Price = price;
            Available = available;
        }
    }
}
