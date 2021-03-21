using Hello_Sarkar.Models;
using Hello_Sarkar.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Sarkar.Controllers
{
    public class HomeController : Controller
    {
     
        private readonly ILogger<HomeController> _logger;
        private readonly IIssueRepository _issueRepository;
        private INewsRepository _newsRepository;

        public HomeController(ILogger<HomeController> logger , IIssueRepository issueRepository ,INewsRepository newsRepository )
        {
            _logger = logger;
            _issueRepository = issueRepository;
            _newsRepository = newsRepository;
        }

        //Get List of all news
        public IActionResult Index()
        {
            var model = _newsRepository.GetAllNews();
            return View(model);
        }

        //Get details view of any news
        public ActionResult Details(int? id)
        {
            NewsDetailsViewModel newsDetailsViewModel = new NewsDetailsViewModel()
            {
                News = _newsRepository.GetNews(id ??1),
                PageTitle = "Detailed News"
            };

            return View(newsDetailsViewModel);
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
