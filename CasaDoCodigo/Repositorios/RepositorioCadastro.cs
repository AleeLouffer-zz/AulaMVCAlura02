using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositorios
{
    public interface IRepositorioCadastro
    {

    }

    public class RepositorioCadastro : RepositorioBase<Cadastro>, IRepositorioCadastro
    {
        public RepositorioCadastro(AplicationContext contexto) : base(contexto)
        {
        }
    }
}
