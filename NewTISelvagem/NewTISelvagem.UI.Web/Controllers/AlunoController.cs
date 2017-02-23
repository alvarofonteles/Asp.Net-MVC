using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewTISelvagem.Aplicacao;
using NewTISelvagem.Dominio;

namespace NewTISelvagem.UI.Web.Controllers
{
    public class AlunoController : Controller
    {
        //
        // GET: /Aluno/
        private readonly AlunoAplicacao appAluno;

        public AlunoController()
        {
            //appAluno = AlunoAplicacaoConstrutor.AlunoAplicacaoADO();//usando ADO
            appAluno = AlunoAplicacaoConstrutor.AlunoAplicacaoEF();//usa Entity Framework
        }

        public ActionResult Index()
        {
            var listarTodos = appAluno.ListaTodos();
            return View(listarTodos);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                appAluno.Salvar(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        public ActionResult Editar(string id)
        {
            var aluno = appAluno.ListaPorId(id);
            if (aluno == null)
                return HttpNotFound();

            return View(aluno);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                appAluno.Salvar(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        public ActionResult Detalhes(string id)
        {
            var aluno = appAluno.ListaPorId(id);
            if (aluno == null)
                return HttpNotFound();

            return View(aluno);
        }

        public ActionResult Excluir(string id)
        {
            var aluno = appAluno.ListaPorId(id);
            if (aluno == null)
                return HttpNotFound();

            return View(aluno);
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmar(string id)
        {
            var aluno = appAluno.ListaPorId(id);
            appAluno.Deletar(aluno);
            return RedirectToAction("Index");
        }
    }
}
