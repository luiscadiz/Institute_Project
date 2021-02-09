using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using Institute_Project.Models;

namespace Institute_Project.Controllers
{
    public class TestController : Controller
    {
        public TestController()
        {
        }

        public IActionResult Mensaje(int Id)
        {
            ViewData["Titulo"] = "Mostramos";
            ViewBag.Cantidad = Id;
            ViewBag.Mensaje = "Mensaje a mostrar";
            return View();
        }

        public string MostrarId(int id)
        {
            return "El ID es " + id.ToString();
        }

        public IActionResult Saludar(string nombre, string apellido)
        {
            string saludo = $"Hola {nombre} {apellido}";
            return View("Hola", saludo);
        }
    }
}