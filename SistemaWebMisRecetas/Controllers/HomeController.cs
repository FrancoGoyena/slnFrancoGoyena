﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaWebMisRecetas.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebMisRecetas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nombre = "Bienvenido al sistema de Empleados";
            ViewBag.Fecha = DateTime.Now.ToString();
            return View();
        }
    }
}
