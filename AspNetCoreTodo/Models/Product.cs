using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Models
{
    public class Product
    {
        [Required]
        public int ProductID { get; set; }

        public int? BrandID { get; set; }

        public String ProductName { get; set; }

        public double Price { get; set; }

        public DateTimeOffset? CreatTime { get; set; }
    }
}
