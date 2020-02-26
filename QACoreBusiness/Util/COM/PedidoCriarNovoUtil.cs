using OpenQA.Selenium;
using QACoreBusiness.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace QACoreBusiness.Util
{
    class PedidoCriarNovoUtil
    {
        public IWebDriver driver;
        private ElementsCOMPedido pedido;

        public PedidoCriarNovoUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            pedido = new ElementsCOMPedido { chromeDriver = driver };
        }

        //public void AcessarIndexPedidos()
        //{
        //    driver.Navigate().GoToUrl(pedido.UrlIndexPedido);
        //}

        public void PaginaInicialCoreBusiness()
        {
            Assert.Equal(pedido.UrlCoreBusiness + "/Home/MosaicoV2", driver.Url);
            Thread.Sleep(500);
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
            Thread.Sleep(1000);
            pedido.SessaoPagamento.Click();
        }

        public void CliqueTrocarVendedor()
        {
            Thread.Sleep(2000);
            pedido.ActionsTrocarVendedor.Click();
        }
    }
}
