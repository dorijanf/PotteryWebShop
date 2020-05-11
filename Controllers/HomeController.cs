using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PotteryWebShop.Models;
using PotteryWebShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PotteryWebShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPotteryProductRepository _productRepository;
        public HomeController(IPotteryProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProductsOfTheWeek = _productRepository.PotteryProductsOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
