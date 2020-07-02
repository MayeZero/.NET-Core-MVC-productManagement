using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Models
{
    public class ProductViewModel
    {
        public Product[] Products { get; set; }

        public Brand[] Brands { get; set; }

        public Category[] Categories { get; set; }

        public ProductPicture[] ProductPictures { get; set; }
    }
}
