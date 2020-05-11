using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotteryWebShop.Models
{
    public interface IPotteryProductRepository
    {
        IEnumerable<PotteryProduct> AllPotteryProducts { get; }
        IEnumerable<PotteryProduct> PotteryProductsOfTheWeek { get; }
        PotteryProduct GetPotteryProductById(int potteryProductId);
    }
}
