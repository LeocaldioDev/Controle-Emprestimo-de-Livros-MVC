using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaControleEmprestimo.WEB.Controllers
{

    public class LivroController : Controller
    {
        private LivroServices oLivroServices = new LivroServices();
        public IActionResult Index()
        {
            var osLivros = oLivroServices.repositoryLivro.SelecionarTodos();
            return View(osLivros);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Livro livroo)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            oLivroServices.repositoryLivro.Incluir(livroo);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id) 
        {
            Livro livro = oLivroServices.repositoryLivro.SelecionarPK(id);
            return View(livro);
        }

        [HttpPost]
        public IActionResult Edit(Livro lv) 
        {
           
           Livro livro= oLivroServices.repositoryLivro.Alterar(lv);
            int id = livro.Id;

            return RedirectToAction("Details", new { id });
        }

        public IActionResult Details(int id)
        {
           Livro livro = oLivroServices.repositoryLivro.SelecionarPK(id);

            return View(livro);
        }

        public IActionResult Delete(int id)
        {
            oLivroServices.repositoryLivro.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}
