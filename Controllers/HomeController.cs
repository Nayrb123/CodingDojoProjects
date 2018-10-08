using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quoting_dojo.Models;
using DbConnection;

namespace quoting_dojo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("quotes")]
        public IActionResult Quotes()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM quote");
            System.Console.WriteLine(AllQuotes[0]["quote"]);
            for(int i = 0; i < AllQuotes.Count; i++)
            {
                System.Console.WriteLine(AllQuotes);
            }
            ViewBag.Allquotes = AllQuotes;
            return View("quotes");
        }

        [HttpPost("create")]
        public IActionResult Create(Quote test)
        {
            if(ModelState.IsValid)
            {
                string query = $"INSERT INTO quote (quote, user) VALUES ('{test.quote}', '{test.user}')";
                Console.WriteLine($"\n\n****{test.quote}");
                DbConnector.Execute(query);
                Console.WriteLine(test);
                return RedirectToAction("Quotes");
            }
            else {
                return View("Index");
            }
        }
    }
}
