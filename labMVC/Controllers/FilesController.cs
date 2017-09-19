using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace labMVC.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
			string[] files = Directory.GetFiles(Server.MapPath("~/TextFiles"));
			ViewBag.files = files;
			return View();
        }
		// GET: File contents
		public ActionResult Contents(string id)
		{
			var path = Server.MapPath($"~/TextFiles/{id}.txt");
			ViewBag.details = System.IO.File.ReadAllText(path);
			return View();
		}
	}
}