using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Models
{
    public class Brand
    {
        [Required]
        public int BrandID { get; set; }

        public int? CategoryID { get; set; }

        public String BrandCHName { get; set; }

        public String BrandENName { get; set; }

        public String Description { get; set; }

        public DateTimeOffset? CreatTime { get; set; }
    }
}
