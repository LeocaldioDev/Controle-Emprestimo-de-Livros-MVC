using LivrariaControleEmprestimo.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class EmprestimoServices
    {

        public RepositoryIVwLivroClienteEmprestimo oRepositoryIVwLivroClienteEmprestimo { get; set; }
        public RepositoryLivro oRepositoryLivro { get; set; }

        public RepositoryCliente oRepositoryCliente { get; set; }
        public EmprestimoServices()
        {
            oRepositoryLivro = new RepositoryLivro();
            oRepositoryCliente = new RepositoryCliente();
           oRepositoryIVwLivroClienteEmprestimo = new RepositoryIVwLivroClienteEmprestimo();
        }



    }
}
