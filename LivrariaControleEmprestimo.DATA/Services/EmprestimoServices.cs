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
        public EmprestimoServices()
        {
           oRepositoryIVwLivroClienteEmprestimo = new RepositoryIVwLivroClienteEmprestimo();
        }



    }
}
