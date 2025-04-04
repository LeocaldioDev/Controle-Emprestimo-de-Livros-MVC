using LivrariaControleEmprestimo.DATA.Repositories;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class EmprestimoController : Controller
    {
        public EmprestimoServices oEmprestimo = new EmprestimoServices();
        public IActionResult Index()
        {
            var Emprestimos = oEmprestimo.oRepositoryIVwLivroClienteEmprestimo.SelecionarTodos();

            return View(Emprestimos);
        }
    }
}
