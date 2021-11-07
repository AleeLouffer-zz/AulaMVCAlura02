using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositorios
{
    public interface IRepositorioCadastro
    {
        Cadastro Update(int cadastroId, Cadastro novoCadastro);
    }

    public class RepositorioCadastro : RepositorioBase<Cadastro>, IRepositorioCadastro
    {
        public RepositorioCadastro(AplicationContext contexto) : base(contexto)
        {
        }

        public Cadastro Update(int cadastroId, Cadastro novoCadastro)
        {
            var cadastroDB = _dbSet.Where(c => c.Id == cadastroId)
                .SingleOrDefault();

            if (cadastroDB == null)
            {
                throw new ArgumentException("cadastro");
            }

            cadastroDB.Update(novoCadastro);
            _contexto.SaveChanges();
            return cadastroDB;
        }
    }
}
