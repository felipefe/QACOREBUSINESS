using OpenQA.Selenium;
using QACoreBusiness.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace QACoreBusiness.Util
{
    class PedidoInserirNegociacaoUtil
    {
        ElementsEfetivarPedido pedido;
        IWebDriver driver = ElementsBase.chromeDriver;

        public PedidoInserirNegociacaoUtil()
        {
            pedido = new ElementsEfetivarPedido { Driver = driver };
        }

        public void PedidoSemCliente()
        {
            Assert.Contains("Pessoa", pedido.ClienteSemPedido.Text);
        }

        public void SessaoPagamento()
        {
            pedido.SessaoPagamento.Click();
        }

        public void PedidoSemItens()
        {
            Assert.Contains("Nenhum item adicionado ao pedido", pedido.PedidoSemItens.Text);
        }

        public void ValorPedidoMaiorQueZero()
        {
            Assert.NotEqual("R$ 0,00", pedido.ValorPedido.Text );
        }

        public void CliqueCriarNegociacao()
        {
            pedido.BotaoCriarNegociacao.Click();
        }

        public void AlertaPedidoSemCliente()
        {
            Assert.Contains("Não é possível criar uma negociação para um pedido sem cliente", pedido.AlertaNegociacaoPedidoSemCliente.Text);
        }

        public void AlertaPedidoSemItens()
        {
            Assert.Contains("Não é possível criar negociação com pedido sem itens", pedido.AlertaNegociacaoPedidoSemItens.Text);
        }

        public void DescricaoNegociacaoPedido(String descricao)
        {
            pedido.EditTextDescricaoNegociacao.SendKeys(descricao);
        }

        public void SelecionarFormaPagamento(String formaPagamento)
        {
            pedido.SelectFormaPagamento.Click();
            Thread.Sleep(2000);
            pedido.SearchFormaPagamento.SendKeys(formaPagamento);
            pedido.SearchFormaPagamento.SendKeys(Keys.Enter);
        }

        public void SalvarNegociacao()
        {
            pedido.BotaoSalvarNegociacao.Click();
        }

        public void TotalGeralLiquidoNegociacao()
        {
            Assert.Contains("R$",pedido.ValorTotalGeralLiquidoNegociacao.Text);
        }
    }
}
