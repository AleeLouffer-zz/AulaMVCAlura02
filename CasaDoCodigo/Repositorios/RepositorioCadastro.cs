using CasaDoCodigo.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositorios
{
    public interface IRepositorioCadastro
    {
        Task<Cadastro> UpdateAsync(int cadastroId, Cadastro novoCadastro);
    }

    public class RepositorioCadastro : RepositorioBase<Cadastro>, IRepositorioCadastro
    {
        public RepositorioCadastro(IConfiguration configuration,
            AplicationContext contexto) : base(configuration, contexto)
        {
        }

        public async Task<Cadastro> UpdateAsync(int cadastroId, Cadastro novoCadastro)
        {
            var cadastroDB = _dbSet.Where(c => c.Id == cadastroId)
                .SingleOrDefault();

            if (cadastroDB == null)
            {
                throw new ArgumentNullException("cadastro");
            }

            cadastroDB.Update(novoCadastro);
            await _contexto.SaveChangesAsync();
            return cadastroDB;
        }
    }
}
