using LivrariaControleEmprestimo.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Services
{
     public class ClienteServices
    {
        public RepositoryCliente orepositoryCliente { get; set; }

        public ClienteServices()
        {
           orepositoryCliente = new RepositoryCliente();
        }
    }
}
