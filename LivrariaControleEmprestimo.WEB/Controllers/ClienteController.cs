using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteServices oClienteRepository = new ClienteServices();
        public IActionResult Index()
        {
            List<Cliente> oListCLiente = oClienteRepository.orepositoryCliente.SelecionarTodos();
            return View(oListCLiente);
        }
    }
}
