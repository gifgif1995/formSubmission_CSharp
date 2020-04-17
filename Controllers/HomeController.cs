using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using formSubmission.Models;


namespace formSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/create")]
        public IActionResult Create(User newUser)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("success", newUser);
            }
            else
            {
                return View("index");
            }
        }
        
        [HttpGet]
        [Route("/success")]
        public IActionResult Success(User newUser)
        {
            return View(newUser);
        }
    }
}