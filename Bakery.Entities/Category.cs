using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }

        // welke relatie is er ten opzichte van Product?
        // één categorie kan veel producten bevatten

        public List<Product> Products { get; set; }

        public Category()
        {
            
        }

        public Category(string name)
        {
            Name = name;
        }
    }
}
