using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.ViewModel
{
    public class BestSellersViewModel
    {
        public Product Product { get; set; }
        public int SalesCount { get; set; }
        public string ProductImage { get; set; }
    }
}