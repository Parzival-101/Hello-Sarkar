using Hello_Sarkar.Models;
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
        public string Index()
        {
            return _issueRepository.GetIssue(1).Subject;

        }

        // GET: AdminController1/Details/5
        public ActionResult Details()
        {
            Issue model = _issueRepository.GetIssue(1);
            ViewBag.PageTitle = "Issues Info";
            return View(model);
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
