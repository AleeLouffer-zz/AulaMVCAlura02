using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CasaDoCodigo.Repositorios
{
    public abstract class RepositorioBase<T> where T : BaseModel
    {
        protected readonly IConfiguration _configuration;
        protected readonly AplicationContext _contexto;
        protected readonly DbSet<T> _dbSet;

        public RepositorioBase(IConfiguration configuration,
            AplicationContext contexto)
        {
            _configuration = configuration;
            _contexto = contexto;
            _dbSet = contexto.Set<T>();
        }
    }
}
