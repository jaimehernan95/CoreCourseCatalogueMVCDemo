using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseCatalogMVCDemo.Models;

namespace CourseCatalogMVCDemo.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ICourseRepository courseRepository;
        private readonly ShoppingCart shopping;
        private object shoppingCart;

        public ShoppingCartController (ICourseRepository courseRepository, ShoppingCart cart)
        {
            this.courseRepository = courseRepository;
            this.shopping = cart;
        }
        public IActionResult Index()
        {
            shoppingCart.ShoppingCartItems = ShoppingCart.GetShopppingCartItems();
            return View();
        }
        public RedirectToActionResult AddToShoppingCart(int courseId)
        {
            var selectCourse = courseRepository.GetCourseById(courseId);
        }
    }
}
