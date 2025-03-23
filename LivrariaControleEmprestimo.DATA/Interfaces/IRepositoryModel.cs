using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Interfaces
{
    internal interface IRepositoryModel<T> where T : class
    {
        List<T> SelecionarTodos();
        T SelecionarPK (params object[] variavel);
        T Incluir(T objecto);
        T Alterar(T objecto);
        void Excluir(T objecto);

        void Excluir(params object[] variavel);
        void SaveChanges();
    }
}
