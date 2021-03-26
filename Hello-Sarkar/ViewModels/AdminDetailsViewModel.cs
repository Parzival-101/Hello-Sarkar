using Hello_Sarkar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Sarkar.ViewModels
{
    public class AdminDetailsViewModel
    {
        public Issue Issue { get; set; }
        public string PageTitle { get; set; }
        public int Total { get; set; }
    }
}
