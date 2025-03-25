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

       
        public IActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            oClienteRepository.orepositoryCliente.Incluir(model);
            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
           Cliente cliente= oClienteRepository.orepositoryCliente.SelecionarPK(id);
            return View(cliente);
        }

        public IActionResult Edit(int id) 
        {
            Cliente cliente = oClienteRepository.orepositoryCliente.SelecionarPK(id);
            return View(cliente);
        }


        [HttpPost]
        public IActionResult Edit(Cliente model) 
        {
            Cliente ocliente = oClienteRepository.orepositoryCliente.Alterar(model);
            
            int id = ocliente.Id;

            return RedirectToAction("Details", new { id });
        }

        public IActionResult Delete(int id)
        {
            oClienteRepository.orepositoryCliente.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}
