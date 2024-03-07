using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bakery.Entities;

namespace Bakery.Dal
{
    public static class ProductDal
    {
        // CREATE

        // READ ALL
        public static List<Product> Read()
        {
            using (var db = new BakeryDbContext())
            {
                // alle records uit tabel Products halen
                // en opslaan als List in C#
                List<Product> lstProducts = db.Products.ToList();
                return lstProducts;
            }
        }

        // UPDATE

        // DELETE
    }
}
