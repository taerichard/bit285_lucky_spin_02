﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LuckySpin;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        public IActionResult Index(int luck)
        {
            return new ContentResult { Content = new Lucky7().Output(luck), ContentType = "text/html" };
        }
    }
}