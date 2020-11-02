using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;
using SistemaVendas.Models.ViewModels;
using SistemaVendas.Services;

namespace SistemaVendas.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorService;
        private readonly DepartamentoService _departamentoService;
        public VendedoresController(VendedorService vendedorService, DepartamentoService departamentoService)
        {
            _vendedorService = vendedorService;
            _departamentoService = departamentoService;
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
            var departamentos = _departamentoService.BuscarDepartamentos();
            var viewModel = new VendedorFormViewModel { Departamentos = departamentos };
            return View(viewModel);
        }

        //Create POST
        [HttpPost] //Anotação para indicar que é um metodo post
        [ValidateAntiForgeryToken] //Anotação de segurança contra ataques XSRF/CSRF
        public IActionResult Create(Vendedor vendedor)
        {
            _vendedorService.InserirVendedor(vendedor);
            return RedirectToAction(nameof(Index));
        }

        //Delete GET
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var vendedor = _vendedorService.BuscarVendedorId(id.Value);
            
            if (vendedor == null)
            {
                return NotFound();
            }
            return View(vendedor);
        }

        //Delete Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _vendedorService.ExcluirVendedor(id);
            return RedirectToAction(nameof(Index));
        }
    }
}