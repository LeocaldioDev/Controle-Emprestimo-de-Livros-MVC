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

            oEmprestimoViewModel.dataEmprestimo = DateTime.Now;
            oEmprestimoViewModel.dataEntrega = DateTime.Now.AddDays(7);

            return View(oEmprestimoViewModel);
        }

        [HttpPost]
        public IActionResult Create(EmprestimoViewModel oEmprestimoViewModel)
        {

            oEmprestimoViewModel.oListCliente = oEmprestimo.oRepositoryCliente.SelecionarTodos();
            oEmprestimoViewModel.oListLivro = oEmprestimo.oRepositoryLivro.SelecionarTodos();
            oEmprestimoViewModel.oLivro = oEmprestimo.oRepositoryLivro.SelecionarPK(oEmprestimoViewModel.idLivro);
            oEmprestimoViewModel.oCliente = oEmprestimo.oRepositoryCliente.SelecionarPK(oEmprestimoViewModel.idCliente);
            LivroClienteEmprestimo oLivroClienteEmprestimo = new LivroClienteEmprestimo();
            oLivroClienteEmprestimo.DataEmprestimo = oEmprestimoViewModel.dataEmprestimo;
            oLivroClienteEmprestimo.DataDevolucao = oEmprestimoViewModel.dataEntrega;
            oLivroClienteEmprestimo.Entregue = false;
            oLivroClienteEmprestimo.Idcliente = oEmprestimoViewModel.idCliente;
            oLivroClienteEmprestimo.Idlivro = oEmprestimoViewModel.idLivro;


            if (oLivroClienteEmprestimo.Idcliente == 0 || oLivroClienteEmprestimo.Idlivro ==0)
            {
                return BadRequest();
            }
            oEmprestimo.oRepositoryLivroClienteEmprestimo.Incluir(oLivroClienteEmprestimo);

            return RedirectToAction("Index");
        }
    }
}