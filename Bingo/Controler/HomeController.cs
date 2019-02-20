using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bingo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoAzure.Controler
{
    public class HomeController : Controller
    {
        IrepositoryBingo repo;

        public HomeController(IrepositoryBingo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Reglas()
        {
            ViewData["Message"] = "reglas";

            return View();
        }

        public IActionResult Partida()
        {
            List<int> numeros = this.repo.GenerarNumeros();

            ViewBag.ale = this.repo.NumerosAleatorios();

            //ViewBag.men = this.helper.NumerosAleatorios().Count();

            return View(numeros);
        }

        public IActionResult Cartones()
        {
            List<int> carton = this.repo.GenerarCartones();
            int[,] cartones = this.repo.validarCarton(carton);
            int[,] cartoneTapado = this.repo.taparCartones(cartones);
            ViewData["carton"] = cartoneTapado;
            return View();
        }


    }
}