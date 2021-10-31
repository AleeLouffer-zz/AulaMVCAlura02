using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositorios
{
    public interface IRepositorioItemPedido
    {
        void UpdateQuantidade(ItemPedido itemPedido);
    }

    public class RepositorioItemPedido : RepositorioBase<ItemPedido>, IRepositorioItemPedido
    {
        public RepositorioItemPedido(AplicationContext contexto) : base(contexto)
        {
        }

        public void UpdateQuantidade(ItemPedido itemPedido)
        {
            var itemPedidoDB = 
            _dbSet
                .Where(ip => ip.Id == itemPedido.Id)
                .SingleOrDefault();

            if(itemPedidoDB != null)
            {
                itemPedidoDB.AtualizaQuantidade(itemPedido.Quantidade);

                _contexto.SaveChanges();
            }
        }
    }
}
