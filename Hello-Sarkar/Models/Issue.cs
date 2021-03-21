using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Sarkar.Models
{
    public class Issue
    {
        public int ID { get; set; }
        public DateTime IssuedDate { get; set; }
        
        [Required, MaxLength(20)]
        public string Subject { get; set; }

        [Required]
        public Dstrc District { get; set; }
        
        [Required]
        public string Street { get; set; }
        
        [Required]
        public string Place { get; set; }
        
        [Required, MaxLength(100)]
        public string IssueDetails { get; set; }
    }
}
