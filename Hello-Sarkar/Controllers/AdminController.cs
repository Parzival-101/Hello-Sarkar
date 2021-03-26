using Hello_Sarkar.Models;
using Hello_Sarkar.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Sarkar.Controllers
{
    public class AdminController : Controller
    {
        private readonly IIssueRepository _issueRepository;
        private readonly INewsRepository _newsRepository;

        public AdminController(IIssueRepository issueRepository ,INewsRepository newsRepository)
        {
            _issueRepository = issueRepository;
            _newsRepository = newsRepository;

        }
        // GET: Issues List 
        public ActionResult Index()
        {
            var model = _issueRepository.GetAllIssue();
            return View(model);
        }

        // GET: Issues Details
        public ActionResult Details(int? id)
        {
            AdminDetailsViewModel adminDetailsViewModel = new AdminDetailsViewModel()
            {
                Issue = _issueRepository.GetIssue(id??1),
                PageTitle = "Issues Info"
        };
            var models = _issueRepository.GetAllIssue().Count();
            if (id > models)
            {
                return RedirectToAction("index");
            }
            return View(adminDetailsViewModel);
        }

        // GET: Create a News 
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(News news)
        {
            if(ModelState.IsValid)
            {
                News newNews = _newsRepository.Add(news);
                return RedirectToAction("details", new { id = newNews.Id });
            }
                return View();
        }

        // GET: AdminController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
