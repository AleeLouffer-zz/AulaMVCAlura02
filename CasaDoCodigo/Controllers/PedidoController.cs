using CasaDoCodigo.Models;
using CasaDoCodigo.Models.ViewModels;
using CasaDoCodigo.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IRepositorioProduto _produtoRepository;
        private readonly IRepositorioPedido _pedidoRepository;

        public PedidoController(IRepositorioProduto repositorioProduto,
            IRepositorioPedido repositorioPedido)
        {
            _produtoRepository = repositorioProduto;
            _pedidoRepository = repositorioPedido;
        }

        public async Task<IActionResult> Carrossel()
        {
            return View(await _produtoRepository.GetProdutosAsync());
        }

        //MELHORIA: 2) Nova view de Busca de Produtos
        //Para saber mais: Formação .NET
        //https://cursos.alura.com.br/formacao-dotnet
        public async Task<IActionResult> BuscaProdutos(string pesquisa)
        {
            return View(await _produtoRepository.GetProdutosAsync(pesquisa));
        }

        public async Task<IActionResult> Carrinho(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                await _pedidoRepository.AddItemAsync(codigo);
            }

            var pedido = await _pedidoRepository.GetPedidoAsync();
            List<ItemPedido> itens = pedido.Itens;
            CarrinhoViewModel carrinhoViewModel = new CarrinhoViewModel(itens);
            return base.View(carrinhoViewModel);
        }

        public async Task<IActionResult> Cadastro()
        {
            var pedido = await _pedidoRepository.GetPedidoAsync();

            if (pedido == null)
            {
                return RedirectToAction("Carrossel");
            }

            return View(pedido.Cadastro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Resumo(Cadastro cadastro)
        {
            if (ModelState.IsValid)
            {
                return View(await _pedidoRepository.UpdateCadastroAsync(cadastro));
            }
            return RedirectToAction("Cadastro");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<UpdateQuantidadeResponse> UpdateQuantidade([FromBody] ItemPedido itemPedido)
        {
            return await _pedidoRepository.UpdateQuantidadeAsync(itemPedido);
        }
    }
}
