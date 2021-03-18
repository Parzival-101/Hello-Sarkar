using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Sarkar.Models
{
    public class Issue
    {
        public int ID { get; set; }
        public DateTime issuedDate { get; set; }
        public string Subject { get; set; }

        public string District { get; set; }
        public string Street { get; set; }
        public string Place { get; set; }
        public string issueDetails { get; set; }
    }
}
