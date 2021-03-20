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
        public AdminController(IIssueRepository issueRepository)
        {
            _issueRepository = issueRepository;

        }
        // GET: AdminController1
        public ActionResult Index()
        {
            var model = _issueRepository.GetAllIssue();
            return View(model);
        }

        // GET: AdminController1/Details/5
        public ActionResult Details(int id)
        {
            AdminDetailsViewModel adminDetailsViewModel = new AdminDetailsViewModel()
            {
                Issue = _issueRepository.GetIssue(id),
                PageTitle = "Issues Info"
        };
         
            return View(adminDetailsViewModel);
        }

        // GET: AdminController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
