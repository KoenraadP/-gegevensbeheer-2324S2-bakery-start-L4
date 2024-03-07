using Bakery.Dal;
using Bakery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.Bll
{
    public static class Products
    {
        // READ ALL
        // eigenlijk wil ik hier gewoon 
        // de read methode uit ProductDal uitvoeren
        public static List<Product> Read()
        {
            return ProductDal.Read();
        }
    }
}
