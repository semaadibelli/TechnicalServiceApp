﻿using Microsoft.AspNetCore.Mvc;

namespace TechnicalService.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register() { return View(); }

    }
}