using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvcproject.Models
{
    public class ArtWork
    {
        [Display(Name = "Art ID")]
        public int art_id { get; set; }

        [Display(Name = "Title")]
        public string title { get; set; }
        [Display(Name = "Category ID")]
        public int category_id { get; set; }
        [Display(Name = "Price")]
        public decimal price { get; set; }
        [Display(Name = "File URL")]
        public string file_location { get; set; }
        [Display(Name = "User ID")]
        public int user_id { get; set; }
        [Display(Name = "Product Explanation")]
        public string product_explanation { get; set; }

        public ICollection<Category> Categories { get; set; }
        public ICollection<User> Users{ get; set; }

    }
}
