using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewPizarriaSys.Dominio.Negocios;
using NewPizarriaSys.Dominio;

namespace NewPizarriaSys.Web.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/

        public ActionResult Index()
        {
            var cliente = new ClienteNegocio().ListarTudo();
            return View(cliente);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                new ClienteNegocio().Salvar(cliente);
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        public ActionResult Editar(string id)
        {
            var cliente = new ClienteNegocio().ListarPorId(id);
            if (cliente == null)
                return HttpNotFound();

            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                new ClienteNegocio().Salvar(cliente);
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        public ActionResult Detalhes(string id)
        {
            var cliente = new ClienteNegocio().ListarPorId(id);
            if (cliente == null)
                return HttpNotFound();
            return View(cliente);
        }

        public ActionResult Excluir(string id)
        {
            var cliente = new ClienteNegocio().ListarPorId(id);
            if (cliente == null)
                return HttpNotFound();

            return View(cliente);
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmado(string id)
        {
            var cliente = new ClienteNegocio().ListarPorId(id);
            new ClienteNegocio().Excluir(cliente);

            return RedirectToAction("Index");
        }
    }
}
