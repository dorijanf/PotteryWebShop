using PotteryWebShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotteryWebShop.ViewModels
{
    public class PotteryListViewModel
    {
        public IEnumerable<PotteryProduct> PotteryProducts { get; set; }
        public string CurrentCategory { get; set; }
    }
}
