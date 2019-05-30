using System;
using EstacionamentoMVC.Models;
using EstacionamentoMVC.Repositorios;
using EstacionamentoMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstacionamentoMVC.Controllers {

    public class CarroController : Controller {
        private CarroRepositorio repositorio = new CarroRepositorio ();
        private MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
        private ModeloRepositorio modeloRepositorio = new ModeloRepositorio();

        [HttpGet]
        public IActionResult Index () {
            var marcas = marcaRepositorio.Listar();
            var modelos = modeloRepositorio.Listar();

            CarroViewModel carro = new CarroViewModel();
            carro.Marcas = marcas;
            carro.Modelos = modelos;

            return View (carro);
        }

        [HttpPost]
        public IActionResult RegistrarCarro (IFormCollection form) {
            System.Console.WriteLine (form["nome"]);
            System.Console.WriteLine (form["marca"]);
            System.Console.WriteLine (form["modelo"]);
            System.Console.WriteLine (form["placa"]);
            System.Console.WriteLine (form["entrada"]);

            Registro cadastro = new Registro (
                nome: form["nome"],
                marca: form["marca"],
                modelo: form["modelo"],
                placa: form["placa"]
            );


            // Usuario usuario = new Usuario();

            // usuario.NomeUsuario = form["nome"];

            // cadastro.Usuario = usuario;

            repositorio.Inserir (cadastro);
            ViewData["NomeVIew"] = "Registro";

            return RedirectToAction("Index", "Carro");
        }

        [HttpGet]
        public IActionResult Listar(){
            ViewData["registro"] = repositorio.Listar();

            return View();
        }
        
    }
}