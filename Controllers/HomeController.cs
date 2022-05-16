using Bootcamp_MVC_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bootcamp_MVC_2.Controllers
{
    public class HomeController : Controller
    {
       
        

        public IActionResult Index()
        {
            Config config = new Config();
            return View(config);
        }

        public IActionResult Unidades()
        {
            ListaVehiculos lista = new ListaVehiculos();
            return View(lista.lista());
        }

    }
}