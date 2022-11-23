using locadoradeveiculos.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace locadoradeveiculos.Controllers
{
    [Authorize]
    public class QueryController : Controller
    {
        private readonly Contexto contexto;

        public QueryController(Contexto context)
        {
            contexto = context;
        }

        public IActionResult Cliente(string nome)
        {
            List<Cliente> lista = new List<Cliente>();

            if (nome == null)
            {
                lista = contexto.clientes
                    .OrderBy(o => o.nome).ToList();
            }
            else
            {
                lista = contexto.clientes.Where(c => c.nome == nome)
                    .OrderBy(o => o.nome).ToList();
            }
            return View(lista);
        }

        public IActionResult Pesquisa()
        {
            return View();
        }
    }
}
