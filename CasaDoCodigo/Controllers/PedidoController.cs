using CasaDoCodigo.Models;
using CasaDoCodigo.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IRepositorioProduto _repositorioProduto;
        private readonly IRepositorioPedido _repositorioPedido;
        private readonly IRepositorioItemPedido _repositorioItemPedido;

        public PedidoController(IRepositorioProduto repositorioProduto,
            IRepositorioPedido repositorioPedido,
            IRepositorioItemPedido repositorioItemPedido)
        {
            _repositorioProduto = repositorioProduto;
            _repositorioPedido = repositorioPedido;
            _repositorioItemPedido = repositorioItemPedido;
        }

        public IActionResult Carrossel()
        {
            return View(_repositorioProduto.GetProdutos());
        }

        public IActionResult Carrinho(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                _repositorioPedido.AddItem(codigo);
            }

            return View(_repositorioPedido.GetPedido().Itens);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            return View(_repositorioPedido.GetPedido());
        }

        [HttpPost]
        public void UpdateQuantidade(ItemPedidoDTO itemPedido)
        {
            Trace.WriteLine(itemPedido);
           // _repositorioItemPedido.UpdateQuantidade(itemPedido);
        }

        public class ItemPedidoDTO
        {
            public string Id { get; set; }

            public string Quantidade { get; set; }

        }
    }
}