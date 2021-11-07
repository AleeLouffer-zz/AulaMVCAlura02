using System.Collections.Generic;
using CasaDoCodigo.Models;
using CasaDoCodigo.Models.ViewModels;
using CasaDoCodigo.Repositorios;
using Microsoft.AspNetCore.Mvc;

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

            List<ItemPedido> itens = _repositorioPedido.GetPedido().Itens;
            CarrinhoViewModel carrinhoViewModel = new CarrinhoViewModel(itens);
            return base.View(carrinhoViewModel);
        }

        public IActionResult Cadastro()
        {
            var pedido = _repositorioPedido.GetPedido();

            if (pedido == null)
            {
                return RedirectToAction("Carrossel");
            }

            return View(pedido.Cadastro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Resumo(Cadastro cadastro)
        {
            if (ModelState.IsValid)
            {
                return View(_repositorioPedido.UpdateCadastro(cadastro));
            }

            return RedirectToAction("Cadastro");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public UpdateQuantidadeResponse UpdateQuantidade([FromBody]ItemPedido itemPedido)
        {
           return _repositorioPedido.UpdateQuantidade(itemPedido);
        }
    }
}