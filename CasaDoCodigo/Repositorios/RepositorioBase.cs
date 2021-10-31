using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositorios
{
    public class RepositorioBase<T> where T : BaseModel
    {
        protected readonly AplicationContext _contexto;
        protected readonly DbSet<T> _dbSet;

        public RepositorioBase(AplicationContext contexto)
        {
            _contexto = contexto;
            _dbSet = _contexto.Set<T>();
        }
    }
}
