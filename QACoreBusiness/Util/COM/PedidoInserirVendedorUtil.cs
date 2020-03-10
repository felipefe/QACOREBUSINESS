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
        IWebDriver driver;
        ElementsCOMPedido pedido;

        public PedidoInserirVendedorUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            pedido = new ElementsCOMPedido { chromeDriver = driver};
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
            Thread.Sleep(500);
            pedido.SearchGenerico.SendKeys(nomeVendedor); 
            Thread.Sleep(3000);
            pedido.SearchGenerico.SendKeys(Keys.Enter);
            
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
