using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PotteryWebShop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PotteryWebShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<PotteryProduct> ProductsOfTheWeek { get; set; }
    }
}
