using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTodo.Controllers
{
    public class ProductInfoController : Controller
    {
        private readonly IProductInfoService _productInfoService;

        public ProductInfoController(IProductInfoService productInfoService)
        {
            _productInfoService = productInfoService;
        }

        public async Task<IActionResult> Index()
        {
            var productinfos = await _productInfoService.GetProductInfosAsync();

            var model = new ProductInfoViewModel
            {
                ProductInfos = productinfos
            };

            return View(model);
        }
    }
}