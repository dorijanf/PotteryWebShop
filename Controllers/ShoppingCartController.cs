using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PotteryWebShop.Models;
using PotteryWebShop.ViewModels;
using NLog;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PotteryWebShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IPotteryProductRepository _productRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPotteryProductRepository productRepository, ShoppingCart shoppingCart)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var selectedProduct = _productRepository.AllPotteryProducts.FirstOrDefault(
                p => p.Id == productId);

            if(selectedProduct != null)
            {
                _shoppingCart.AddToCart(selectedProduct, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            var selectedProduct = _productRepository.AllPotteryProducts.FirstOrDefault(
                p => p.Id == productId);

            if(selectedProduct != null)
            {
                _shoppingCart.RemoveFromCart(selectedProduct);
            }

            return RedirectToAction("Index");
        }
    }
}
