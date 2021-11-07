using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositorios
{
    public interface IRepositorioItemPedido
    {
        ItemPedido GetItemPedido(int itemPedidoId);
        void RemoveItemPedido(int itemPedidoId);
    }

    public class RepositorioItemPedido : RepositorioBase<ItemPedido>, IRepositorioItemPedido
    {
        public RepositorioItemPedido(AplicationContext contexto) : base(contexto)
        {
        }

        public ItemPedido GetItemPedido(int itemPedidoId)
        {
            return
              _dbSet
              .Where(ip => ip.Id == itemPedidoId)
              .SingleOrDefault();
        }

        public void RemoveItemPedido(int itemPedidoId)
        {
            _dbSet.Remove(GetItemPedido(itemPedidoId));
        }
    }
}
