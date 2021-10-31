using CasaDoCodigo.Models;
using CasaDoCodigo.Repositorios;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using static CasaDoCodigo.Repositorios.RepositorioProduto;

namespace CasaDoCodigo
{
    class DataService : IDataService
    {
        private readonly AplicationContext _contexto;
        private readonly IRepositorioProduto _repositorioProduto;

        public DataService(AplicationContext contexto, IRepositorioProduto repositorioProduto)
        {
            _contexto = contexto;
            _repositorioProduto = repositorioProduto;
        }

        public void InicializaDB()
        {
            _contexto.Database.EnsureCreated();
            List<Livro> livros = GetLivros();
            _repositorioProduto.SaveProdutos(livros);
        }

        private static List<Livro> GetLivros()
        {
            var json = File.ReadAllText("livros.json");
            var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
            return livros;
        }
    }
}
