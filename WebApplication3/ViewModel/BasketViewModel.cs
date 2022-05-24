using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.ViewModel
{
    public class BasketViewModel
    {
        public List<BasketLine> BasketLines { get; set; }
        [Display(Name = "Basket Total")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal TotalCost { get; set; }
    }
}