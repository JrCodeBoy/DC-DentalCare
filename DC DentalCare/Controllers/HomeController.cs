﻿using DC_DentalCare.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DC_DentalCare.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}