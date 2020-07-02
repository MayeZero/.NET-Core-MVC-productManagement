using AspNetCoreTodo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Services
{
    public interface IProductService
    {
        Task<Product[]> GetProductsAsync();

        Task<Brand[]> GetBrandsAsync();

        Task<Category[]> GetCategoriesAsync();

        Task<ProductPicture[]> GetProductPictures();

        Task<bool> AddProductAsync(Product newProduct);

        Task<bool> TakeOffAsync(int id);
    }
}
