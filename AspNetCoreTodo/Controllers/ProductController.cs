using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTodo.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            //从数据库获取product信息
            var products = await _productService.GetProductsAsync();
            //把信息置于model中
            var model = new ProductViewModel()
            {
                Products = products
            };
            //使用model渲染视图
            return View(model);
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddProduct(Product newProduct)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            var successful = await _productService.AddProductAsync(newProduct);
            if (!successful)
            {
                return BadRequest("Could not add Product.");
            }

            return RedirectToAction("Index");
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TakeOff(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }

            var successful = await _productService.TakeOffAsync(id);
            if (!successful)
            {
                return BadRequest("Could not take product off.");
            }

            return RedirectToAction("Index");
        }
    }
}