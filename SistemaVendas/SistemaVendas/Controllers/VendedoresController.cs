using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;
using SistemaVendas.Services;

namespace SistemaVendas.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorService;
        public VendedoresController(VendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }

        public IActionResult Index()
        {
            var listaVendedores = _vendedorService.BuscarVendedores();
            return View(listaVendedores);
        }

        //Create GET
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Create POST
        [HttpPost] //Anotação para indicar que é um metodo post
        [ValidateAntiForgeryToken] //Anotação de segurança contra ataques XSRF/CSRF
        public IActionResult Create(Vendedor vendedor)
        {
            _vendedorService.InserirVendedor(vendedor);
            return RedirectToAction(nameof(Index));
        }
    }
}