using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGoMarkets.Models;

namespace WebGoMarkets.ModelViews
{
    public class ProductHomeVM
    {
        public Category category { set; get; }
        public List<Product> lsProducts { set; get; }
    }
}
