using CasaDoCodigo.Models;
using System.Collections.Generic;

namespace CasaDoCodigo.Repositorios
{
    public interface IRepositorioProduto
    {
        void SaveProdutos(List<RepositorioProduto.Livro> livros);
        IList<Produto> GetProdutos();
    }
}