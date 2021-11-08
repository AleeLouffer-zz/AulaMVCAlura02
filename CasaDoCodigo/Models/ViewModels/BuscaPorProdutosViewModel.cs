using System.Collections.Generic;

namespace CasaDoCodigo.Models.ViewModels
{
    public class BuscaPorProdutosViewModel
    {
        public BuscaPorProdutosViewModel(IList<Produto> produtos, string pesquisa)
        {
            Produtos = produtos;
            Pesquisa = pesquisa;
        }

        public IList<Produto> Produtos { get; }
        public string Pesquisa { get; set; }
    }
}
