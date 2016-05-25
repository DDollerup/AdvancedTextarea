using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdvancedTextarea.Factories;
using AdvancedTextarea.Models;

namespace AdvancedTextarea.Controllers
{
    public class HomeController : Controller
    {
        PageFactory pageFac = new PageFactory();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewPage(int id = 0)
        {
            return View(pageFac.Get(id));
        }

        public ActionResult AddPage()
        {
            return View();
        }

        [ValidateInput(false)]
        [HttpPost]
        public ActionResult AddPageSubmit(Page page)
        {
            pageFac.Add(page);
            return RedirectToAction("Index");
        }
    }
}