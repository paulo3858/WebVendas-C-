using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebVendas.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Nome"] = "Paulo Henrique Teodoro de Lima";
            ViewData["Numero"] = "2019073858";
            ViewData["Email"] = "paulo.lima3858@edu.faccar.com.br";
            ViewData["Materia"] = "Programação Orientada a objetos";
            ViewData["Dias"] = "Somente 1 dia, Terça-feira";
            ViewData["Bimestre"] = "Estou no 3 Bimestre";

            return View();
        }
    }
}
