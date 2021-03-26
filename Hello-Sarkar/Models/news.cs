using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Sarkar.Models
{
    public class News
    {
        public int Id { get; set; }

        [Required, MaxLength(100 , ErrorMessage ="Keep the heading short")]
        [Display(Name ="News Headline")]
        public string Title { get; set; }

        [Required]
        [Display(Name ="News Details")]
        public string Info { get; set; }
        public string Source { get; set; }
    }
}
