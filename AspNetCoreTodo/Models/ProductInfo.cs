using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Models
{
    public class ProductInfo
    {
        [Required]
        public int ProductID { get; set; }

        public String ProductName { get; set; }

        public double Price { get; set; }

        public String BrandCHName { get; set; }

        public String BrandENName { get; set; }

        public String Description { get; set; }

        public String CategoryName { get; set; }

        public DateTimeOffset? CreatTime { get; set; }
    }
}
