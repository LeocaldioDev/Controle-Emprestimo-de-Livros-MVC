using LivrariaControleEmprestimo.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class LivroServices
    {
        public RepositoryLivro repositoryLivro { get; set; }

        public LivroServices() 
        { 
        repositoryLivro = new RepositoryLivro();
        }
    }
}
