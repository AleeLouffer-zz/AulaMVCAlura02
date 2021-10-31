using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositorios
{
    public class RepositorioProduto : RepositorioBase<Produto>, IRepositorioProduto
    {
        public RepositorioProduto(AplicationContext contexto) : base(contexto)
        {
        }

        public IList<Produto> GetProdutos()
        {
            return _dbSet.ToList();
        }

        public void SaveProdutos(List<Livro> livros)
        {
            foreach (var livro in livros)
            {
                if (!_dbSet.Where(p => p.Codigo == livro.Codigo).Any())
                {
                    _dbSet.Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
                }
            }
            _contexto.SaveChanges();
        }

        public class Livro
        {
            public string Codigo { get; set; }
            public string Nome { get; set; }
            public decimal Preco { get; set; }
        }
    }
}
