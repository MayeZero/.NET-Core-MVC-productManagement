using AspNetCoreTodo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Services
{
    public interface IProductInfoService
    {
        Task<ProductInfo[]> GetProductInfosAsync();
    }
}
