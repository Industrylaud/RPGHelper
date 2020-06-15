using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RPGHelper.ViewModels
{
    public class AddMusicViewModel
    {

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        
        [Display(Name = "Category")]
        public string Category { get; set; }

        [Display(Name = "Category 2")]
        public string Category2 { get; set; }

        [Display(Name = "Category 3")]
        public string Category3 { get; set; }
       
        [Required]
        [Display(Name = "URL (należy dodać embed po www.youtube.com/)")]
        public string URL { get; set; }
    }
}
