using OpenQA.Selenium;
using QACoreBusiness.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace QACoreBusiness.Util
{
    class PedidoInserirVendedorUtil
    {
        IWebDriver driver = Base.chromeDriver;
        ElementsMontarPedido pedido;

        public PedidoInserirVendedorUtil()
        {
            pedido = new ElementsMontarPedido();
        }

        public void CliqueTrocarVendedor()
        {
            pedido.ActionsTrocarVendedor.Click();

        }

        public void UrlTrocarVendedorPedido()
        {
            Assert.Contains( pedido.UrlTrocarVendedor , driver.Url);
        }

        public void VendedorJaInformado()
        {
            Assert.NotEqual("Vendedor" ,pedido.SelectVendedorInformado.Text);

        }

        public void SelecionarVendedor(String nomeVendedor)
        {
            pedido.SelectVendedor.Click();

            pedido.SearchInformarVendedor.SendKeys(nomeVendedor); 
            Thread.Sleep(2000);
            pedido.SearchInformarVendedor.SendKeys(Keys.Enter);
            
        }

        public void BotaoTrocarVendedor()
        {
            pedido.BotaoTrocarVendedor.Click();
        }

        public void UrlEdicaoPedido()
        {
            Assert.Contains(pedido.UrlEditPedido, driver.Url);
        }

        public void MensagemAposInserirVendedor()
        {
            Assert.Equal("Os dados do pedido foram carregados com sucesso.", pedido.AlertaMensagemPedidoAtualizado.Text);
        }

        public void MensagemVendedorJaInserido()
        {
            Assert.Equal("Favor indicar um vendedor diferente do vendedor atual.", pedido.AlertaVendedorJaInserido.Text);
        }
    }
}
