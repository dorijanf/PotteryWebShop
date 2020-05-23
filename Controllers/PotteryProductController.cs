using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PotteryWebShop.Models;
using Microsoft.AspNetCore.Mvc;
using PotteryWebShop.ViewModels;
using System.Net.NetworkInformation;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PotteryWebShop.Controllers
{
    public class PotteryProductController : Controller
    {
        private readonly IPotteryProductRepository _potteryRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PotteryProductController(IPotteryProductRepository potteryRepository,
                                        ICategoryRepository categoryRepository)
        {
            _potteryRepository = potteryRepository;
            _categoryRepository = categoryRepository;
        }

        /*
        public ViewResult List()
        {
            var potteryProductViewModel = new PotteryListViewModel();
            potteryProductViewModel.PotteryProducts = _potteryRepository.AllPotteryProducts;
            potteryProductViewModel.CurrentCategory = "Kitchen Supplies";
            return View(potteryProductViewModel);
        }
        */

        public ViewResult List(string category)
        {
            IEnumerable<PotteryProduct> potteryProducts;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                potteryProducts = _potteryRepository.AllPotteryProducts.OrderBy(p => p.Id);
                currentCategory = "All pottery products";
            }
            else
            {
                potteryProducts = _potteryRepository.AllPotteryProducts.Where(p => p.Category.CategoryName == category)
                                                                       .OrderBy(p => p.Id);

                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            
            return View(new PotteryListViewModel
            {
                PotteryProducts = potteryProducts,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var potteryProduct = _potteryRepository.GetPotteryProductById(id);
            if(potteryProduct == null)
            {
                return NotFound();
            }
            return View(potteryProduct);
        }
    }
}
