﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AddressApi.Controllers
{
    public class AddressController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}