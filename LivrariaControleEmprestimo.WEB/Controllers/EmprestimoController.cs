using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Repositories;
using LivrariaControleEmprestimo.DATA.Services;
using LivrariaControleEmprestimo.WEB.Models;
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

        public IActionResult Create()
        {

            EmprestimoViewModel oEmprestimoViewModel = new EmprestimoViewModel();

            List<Livro> olistLivros = oEmprestimo.oRepositoryLivro.SelecionarTodos();
            List<Cliente> olistCliente = oEmprestimo.oRepositoryCliente.SelecionarTodos();

            oEmprestimoViewModel.oListCliente = olistCliente;
            oEmprestimoViewModel.oListLivro = olistLivros;

            return View(oEmprestimoViewModel);
        }
    }
}