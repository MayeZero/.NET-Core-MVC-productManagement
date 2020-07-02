using AspNetCoreTodo.Data;
using AspNetCoreTodo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Services
{
    public class ProductInfoService:IProductInfoService
    {
        private readonly SqlServerDbContext _context;
        
        public ProductInfoService(SqlServerDbContext context)
        {
            _context = context;
        }

        public async Task<ProductInfo[]> GetProductInfosAsync()
        {
            var productInfos = await _context.Products
                .Join(_context.Brands, p => p.BrandID, b => b.BrandID,
                (p, b) => new
                {
                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    Price = p.Price,
                    CreatTime = p.CreatTime,
                    BrandCHName = b.BrandCHName,
                    BrandENName = b.BrandENName,
                    Description = b.Description,
                    CategoryID = b.CategoryID
                })
                .Join(_context.Categories, b => b.CategoryID, c => c.CategoryID,
                (b, c) => new ProductInfo
                {
                    ProductID = b.ProductID,
                    ProductName = b.ProductName,
                    Price = b.Price,
                    BrandCHName = b.BrandCHName,
                    BrandENName = b.BrandENName,
                    Description = b.Description,
                    CategoryName = c.CategoryName,
                    CreatTime = b.CreatTime
                }).ToArrayAsync();
            return productInfos;
        }
    }
}
