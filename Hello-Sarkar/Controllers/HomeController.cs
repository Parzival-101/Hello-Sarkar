using Hello_Sarkar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//using Hello_Sarkar.ViewModels;

namespace Hello_Sarkar.Controllers
{
    public class HomeController : Controller
    {
     
        private readonly ILogger<HomeController> _logger;
        private readonly IIssueRepository _issueRepository;

        public HomeController(ILogger<HomeController> logger , IIssueRepository issueRepository )
        {
            _logger = logger;
            issueRepository = _issueRepository;
        }

        public IActionResult Index()
        {
            return View();     
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Issue issue)
        {
            if (ModelState.IsValid)
            {
                Issue newissue = _issueRepository.Add(issue);
                return RedirectToAction("details", new { id = newissue.ID });
            }
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
