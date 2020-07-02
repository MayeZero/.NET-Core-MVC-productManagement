using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Models
{
    public class Category
    {
        [Required]
        public int CategoryID { get; set; }

        public String CategoryName { get; set; }
    }
}
