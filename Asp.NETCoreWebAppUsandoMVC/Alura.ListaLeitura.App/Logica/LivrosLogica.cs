using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alura.ListaLeitura.App.HTML;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Alura.ListaLeitura.App.Negocio;

namespace Alura.ListaLeitura.App.Logica {
    public class LivrosController : Controller {
        public IEnumerable<Livro> Livros { get; set; }
        public string Detalhes(int id) {
            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.First(l => l.Id == id);

            return livro.Detalhes();
        }
        private static string CarregaLista(IEnumerable<Livro> livros) {
            var conteudoArquivo = HtmlUtils.CarregaArquivoHTML("lista");

            return conteudoArquivo.Replace("#NOVO-ITEM#", "");
        }
        public IActionResult ParaLer() {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.ParaLer.Livros;
            //var html = new ViewResult { ViewName = "lista" };
            //return html;
            return View("lista");
        }
        public IActionResult Lendo() {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lendo.Livros;
            //var html = new ViewResult { ViewName = "lista" };
            //return html;
            return View("lista");
        }
        public IActionResult Lidos() {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lidos.Livros;
            //var html = new ViewResult { ViewName = "lista" };
            //return html;
            return View("lista");
        }        


    }
}
