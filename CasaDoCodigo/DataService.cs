using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using CasaDoCodigo.Models;
using CasaDoCodigo.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace CasaDoCodigo
{
    class DataService : IDataService
    {
        public async Task InicializaDBAsync(IServiceProvider provider)
        {
            var contexto = provider.GetService<AplicationContext>();

            await contexto.Database.EnsureCreatedAsync();

            await contexto.Database.MigrateAsync();

            if (await contexto.Set<Produto>().AnyAsync())
            {
                return;
            }

            List<Livro> livros = await GetLivrosAsync();

            var repositorioProduto = provider.GetService<IRepositorioProduto>();
            await repositorioProduto.SaveProdutosAsync(livros);
        }

        private async Task<List<Livro>> GetLivrosAsync()
        {
            var json = await File.ReadAllTextAsync("livros.json");
            return JsonConvert.DeserializeObject<List<Livro>>(json);
        }
    }
}
