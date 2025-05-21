using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Repositories
{
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        protected ControleEmprestimoLivroContext _contexto;

        public bool _saveChanges = true;

        public RepositoryBase(bool SaveChanges = true) 
        {
            _saveChanges = SaveChanges;
            _contexto = new ControleEmprestimoLivroContext();
        }
        public T Alterar(T objecto)
        {
            _contexto.Entry(objecto).State = EntityState.Modified;
            if (_saveChanges)
            {
                _contexto.SaveChanges();
            }
            return objecto;

        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

        public void Excluir(T objecto)
        {
            _contexto.Set<T>().Remove(objecto);
            if (_saveChanges) 
            {
                _contexto.SaveChanges();
            }
        }

        public void Excluir(params object[] variavel)
        {
            var obj = SelecionarPK(variavel);
            Excluir(obj);

        }


        public T Incluir(T objecto)
        {
            _contexto.Set<T>().Add(objecto);
            if (_saveChanges)
            {
                _contexto.SaveChanges();
            }
            return objecto;
        }

        public void SaveChanges()
        {
            _contexto.SaveChanges();
        }

        public T SelecionarPK(params object[] variavel)
        {
            return _contexto.Set<T>().Find(variavel);
        }

        public List<T> SelecionarTodos()
        {
          return _contexto.Set<T>().ToList();
        }
    
    }
}
