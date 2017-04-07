﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceStore.Web.Areas.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Default", new { area = "Admin" });
        }    
    }
}
