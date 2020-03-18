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
        ElementsCOMPedido pedido;
        IWebDriver driver;

        public PedidoInserirNegociacaoUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            pedido = new ElementsCOMPedido { chromeDriver = driver };
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
            Thread.Sleep(2000);
            pedido.InputDescricaoNegociacao.SendKeys(descricao);
        }

        public void SelecionarFormaPagamento(String formaPagamento)
        {
            pedido.SelectFormaPagamento.Click();
            Thread.Sleep(3000);
            pedido.SearchFormaPagamento.SendKeys(formaPagamento);
            Thread.Sleep(3500);
            pedido.SearchFormaPagamento.SendKeys(Keys.Enter);
        }

        public void SalvarNegociacao()
        {
            Thread.Sleep(2000);
            pedido.BotaoSalvarNegociacao.Click();
        }

        public void TotalGeralLiquidoNegociacao()
        {
            Assert.Contains("R$",pedido.ValorTotalGeralLiquidoNegociacao.Text);
        }

        public void NegociacaoSemFormaPagamento(string mensagem)
        {
            Assert.Equal(mensagem, pedido.NegociacaoSemFormaPagamento.Text);
        }
    }
}
