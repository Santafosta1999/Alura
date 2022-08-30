using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Alura.ListaLeitura.App.Negocio;
using System.Linq;
using Alura.ListaLeitura.App.HTML;
using Microsoft.AspNetCore.Mvc;

namespace Alura.ListaLeitura.App.Logica {
    public class CadastroController {
        public string Incluir(Livro livro) {
            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);

            return "O livro foi adicionado com sucesso.";
        }

        public IActionResult ExibeFormulario() {
            //var html = HtmlUtils.CarregaArquivoHTML("formulario");
            var html = new ViewResult { ViewName = "formulario" };
            return html;
        }
    }
}
