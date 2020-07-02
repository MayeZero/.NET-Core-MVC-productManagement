using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Models
{
    public class ProductPicture
    {
        [Required]
        public int ID { get; set; }

        public String PicUrl { get; set; }

        public int? ProductID { get; set; }

        public DateTimeOffset? CreatTime { get; set; }
    }
}
