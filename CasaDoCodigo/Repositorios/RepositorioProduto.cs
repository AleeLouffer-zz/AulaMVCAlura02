using CasaDoCodigo.Models;
using CasaDoCodigo.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositorios
{
    public interface IRepositorioProduto
    {
        Task SaveProdutosAsync(List<Livro> livros);
        Task<IList<Produto>> GetProdutosAsync();
        Task<BuscaPorProdutosViewModel> GetProdutosAsync(string pesquisa);
    }

    public class RepositorioProduto : RepositorioBase<Produto>, IRepositorioProduto
    {
        public RepositorioProduto(IConfiguration configuration,
            AplicationContext contexto) : base(configuration, contexto)
        {
        }

        public async Task<IList<Produto>> GetProdutosAsync()
        {
            return await _dbSet
                .Include(prod => prod.Categoria)
                .ToListAsync();
        }

        public async Task<BuscaPorProdutosViewModel> GetProdutosAsync(string pesquisa)
        {
            IQueryable<Produto> query = _dbSet;

            if (!string.IsNullOrEmpty(pesquisa))
            {
                query = query.Where(q => q.Nome.Contains(pesquisa));
            }

            query = query
                .Include(prod => prod.Categoria);

            return new BuscaPorProdutosViewModel(await query.ToListAsync(), pesquisa);
        }

        public async Task SaveProdutosAsync(List<Livro> livros)
        {
            await SaveCategorias(livros);

            foreach (var livro in livros)
            {
                var categoria =
                    await _contexto.Set<Categoria>()
                        .SingleAsync(c => c.Nome == livro.Categoria);

                if (!await _dbSet.Where(p => p.Codigo == livro.Codigo).AnyAsync())
                {
                    await _dbSet.AddAsync(new Produto(livro.Codigo, livro.Nome, livro.Preco, categoria));
                }
            }
            await _contexto.SaveChangesAsync();
        }

        private async Task SaveCategorias(List<Livro> livros)
        {
            var categorias =
                livros
                    .OrderBy(l => l.Categoria)
                    .Select(l => l.Categoria)
                    .Distinct();

            foreach (var nomeCategoria in categorias)
            {
                var categoriaDB =
                    await _contexto.Set<Categoria>()
                    .SingleOrDefaultAsync(c => c.Nome == nomeCategoria);
                if (categoriaDB == null)
                {
                    await _contexto.Set<Categoria>()
                        .AddAsync(new Categoria(nomeCategoria));
                }
            }
            await _contexto.SaveChangesAsync();
        }
    }

    public class Livro
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Subcategoria { get; set; }
        public decimal Preco { get; set; }
    }
}
