using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HoraExtraWebApMVC.Models;
using HoraExtraWebApMVC.Models.Departamento;

namespace HoraExtraWebApMVC.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {

            List<DepartamentoModel> list = new List<DepartamentoModel>();
            list.Add(new DepartamentoModel { Id = 1, Nome = "TI", Gestor = "Dyu" });
            return View(list);
        }
    }
}
