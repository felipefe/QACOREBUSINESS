using OpenQA.Selenium;
using QACoreBusiness.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace QACoreBusiness.Util
{
    class PedidoCriarNovoUtil
    {
        IWebDriver driver = Base.GetChromeDriver();
        ElementsCOMPedido pedido;


        public void AcessarIndexPedidos()
        {
            pedido = new ElementsCOMPedido();
            driver.Navigate().GoToUrl(pedido.UrlIndexPedido);
        }

        public void CriarNovoPedido()
        {
            pedido.BotaoCriarNovo.Click();
        }

        public void UrlEditPedido()
        {
            Assert.Contains(pedido.UrlEditPedido, driver.Url);
        }

        public void CliqueSessaoEntregas()
        {
            System.Threading.Thread.Sleep(1000);
            pedido.SessaoEntregas.Click();
        }

        public void CliqueSessaoProdutos()
        {
            System.Threading.Thread.Sleep(4000);
            pedido.SessaoProdutos.Click();
        }

        public void CliqueSessaoPagamento()
        {
            System.Threading.Thread.Sleep(1000);
            pedido.SessaoPagamento.Click();
        }

        public void CliqueTrocarVendedor()
        {
            System.Threading.Thread.Sleep(2000);
            pedido.ActionsTrocarVendedor.Click();
        }
    }
}
