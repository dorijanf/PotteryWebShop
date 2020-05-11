using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotteryWebShop.Models
{
    public class PotteryProductRepository : IPotteryProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public PotteryProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<PotteryProduct> AllPotteryProducts
        {
            get
            {
                return _appDbContext.PotteryProducts.Include(c => c.Category);
            }
        }

        public IEnumerable<PotteryProduct> PotteryProductsOfTheWeek
        {
            get
            {
                return _appDbContext.PotteryProducts.Include(c => c.Category)
                                                    .Where(p => p.IsProductOfTheWeek);
            }
        }

        public PotteryProduct GetPotteryProductById(int potteryProductId)
        {
            return _appDbContext.PotteryProducts.FirstOrDefault(p => p.Id == potteryProductId);
        }
    }
}
