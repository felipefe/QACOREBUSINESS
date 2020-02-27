using OpenQA.Selenium;
using QACoreBusiness.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace QACoreBusiness.Util
{
    class PedidoEfetivarUtil
    {
        IWebDriver driver;
        ElementsCOMPedido pedido;

        public PedidoEfetivarUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            pedido = new ElementsCOMPedido { chromeDriver = driver};
        }

        public void PedidoComCliente()
        {
            Assert.Contains("", pedido.PedidoComCliente.Text);
        }

        public void PedidoComEntrega()
        {           
            Assert.DoesNotContain("Entrega", pedido.PedidoComEntrega.Text);
        }

        public void PedidoComItens()
        {
            Assert.NotEqual("R$ 0,00", pedido.ValorPedido.Text);
        }

        public void PedidoComNegociacao()
        {
            Assert.DoesNotContain("Pagamento", pedido.SessaoPagamento.Text);
        }

        public void PedidoComVendedor()
        {
            pedido.ActionsTrocarVendedor.Click();
            Assert.NotEqual("Vendedor", pedido.SelectVendedorInformado.Text);
            driver.Navigate().Back();
        }

        public void CliqueEfetivarPedido()
        {
            pedido.ActionsEfetivarPedido.Click();
        }

        public void RedirecionaIndexPedidos()
        {
            Assert.Equal( pedido.UrlIndexPedido, driver.Url);
        }

        public void NaoRedirecionaIndexPEdidos()
        {
            Assert.Contains(pedido.UrlEditPedido, driver.Url);
        }

        public void AlertaPendenciasPedido()
        {
            Assert.Equal("Pendências", pedido.PendenciasPedido.Text);
        }
    }
}
