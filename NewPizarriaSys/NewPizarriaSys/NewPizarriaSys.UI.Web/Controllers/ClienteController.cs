using NewPizarriaSys.Dominio.Negocios;
using NewPizarriaSys.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewPizarriaSys.UI.Web.Models;
using NewPizarriaSys.Dominio;

namespace NewPizarriaSys.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteNegocio _clienteNegocio = new ClienteNegocio();

        public ActionResult Index(ClienteModel model)
        {
            if (ModelState.IsValid)
            {
                var cliFone = _clienteNegocio.ListarTelefones(model.Telefone);
                return View(cliFone);
            }

            var cliente = _clienteNegocio.ListarTodos();
            return View(cliente);
        }

        [HttpGet]
        public ActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Inserir(ClienteModel model)
        {
            if (ModelState.IsValid)
            {
                _clienteNegocio.Salvar(new Cliente
                {
                    Nome = model.Nome,
                    Telefone = model.Telefone,
                    Email = model.Email
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var cliente = _clienteNegocio.BuscarPorId(id);
            return View(new ClienteModel(cliente));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(ClienteModel model)
        {
            if (ModelState.IsValid)
            {
                _clienteNegocio.Salvar(new Cliente
                {
                    Id = model.Id,
                    Nome = model.Nome,
                    Telefone = model.Telefone,
                    Email = model.Email
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Detalhes(int id)
        {
            var cliente = _clienteNegocio.BuscarPorId(id);
            return View(new ClienteModel(cliente));
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            var cliente = _clienteNegocio.BuscarPorId(id);
            return View(new ClienteModel(cliente));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Excluir(ClienteModel model)
        {
            _clienteNegocio.Excluir(new Cliente { Id = model.Id });
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Consultar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Consultar(string telefone)
        {
            var cliente = _clienteNegocio.ListarTelefones(telefone);
            if (cliente.Count() == 0)
                return View();

            return View("Index", cliente);
        }
    }
}
