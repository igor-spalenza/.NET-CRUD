using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Treinamento_CRM_Educacional.Data;
using Treinamento_CRM_Educacional.Models;

namespace Treinamento_CRM_Educacional.Controllers
{
    public class PessoaController : Controller
    {
        private readonly TreinamentoDataContext _ctx = new TreinamentoDataContext();
        public ViewResult Index()
        {
            var pessoas = _ctx.Pessoas.ToList();

            return View(pessoas);
        }


        [HttpGet]
        public ViewResult AddEdit(int? id)
        {
            Pessoa pessoa = new Pessoa();
            if (id != null)
            {
                pessoa = _ctx.Pessoas.Find(id);
            }
            return View(pessoa);
        }


        [HttpPost]
        public ActionResult AddEdit(Pessoa pessoa)
        {
            //TO DO validar
            if (pessoa.Id == 0)
            {
                _ctx.Pessoas.Add(pessoa);
            } else
            {
                _ctx.Entry(pessoa).State = System.Data.Entity.EntityState.Modified;
            }

            _ctx.SaveChanges();

            //TO DO add na tabela
            return RedirectToAction("Index");
        }


        public ActionResult Excluir(int id)
        {
            return null;
        }
        

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }





        //Pessoa = MODEL | pessoa = variável
        //[HttpPost]
        //public ActionResult PessoaCadastrar(Pessoa pessoa)
        //{
        //            conexao.pessoas.Add(pessoa);
        //            conexao.SaveChances();

        //            return RedirectToAction("Index");
        //        }
    }
}