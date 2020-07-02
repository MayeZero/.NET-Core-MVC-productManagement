using AspNetCoreTodo.Data;
using AspNetCoreTodo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Services
{
    public class ProductService:IProductService
    {
        private readonly SqlServerDbContext _context;

        public ProductService(SqlServerDbContext context)
        {
            _context = context;
        }

        public async Task<Product[]> GetProductsAsync()
        {
            var products = await _context.Products
                .Where(x => x.ProductID != null)
                .ToArrayAsync();

            return products;
        }

        public async Task<Brand[]> GetBrandsAsync()
        {
            var brands = await _context.Brands
                .Where(x => x.BrandID != null)
                .ToArrayAsync();

            return brands;
        }

        public async Task<Category[]> GetCategoriesAsync()
        {
            var categories = await _context.Categories
                .Where(x => x.CategoryID != null)
                .ToArrayAsync();

            return categories;
        }

        public async Task<ProductPicture[]> GetProductPictures()
        {
            var productpictures = await _context.ProductPictures
                .Where(x => x.ID != null)
                .ToArrayAsync();

            return productpictures;
        }

        public async Task<bool> AddProductAsync(Product newProduct)
        {

            newProduct.BrandID = newProduct.BrandID;
            newProduct.ProductName = newProduct.ProductName;
            newProduct.Price = newProduct.Price;
            newProduct.CreatTime = DateTimeOffset.Now.AddDays(3);

            _context.Products.Add(newProduct);

            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }

        public async Task<bool> TakeOffAsync(int id)
        {
            var product = await _context.Products
                .Where(x => x.ProductID == id)
                .SingleOrDefaultAsync();

            if (product == null) return false;

            _context.Products.Remove(product);

            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1; // One entity should have been updated
        }
    }
}
