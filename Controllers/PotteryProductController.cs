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

        public ViewResult List()
        {
            var potteryProductViewModel = new PotteryListViewModel();
            potteryProductViewModel.PotteryProducts = _potteryRepository.AllPotteryProducts;
            potteryProductViewModel.CurrentCategory = "Kitchen Supplies";
            return View(potteryProductViewModel);
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
