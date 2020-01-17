using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace QACoreBusiness.Util
{
    class PedidoCriarNovoUtil
    {
        IWebDriver driver = ChromeDriverNavegador.driver;
        ElementsPedidoCriarNovo createPedido;


        public void AcessarIndexPedidos()
        {
            createPedido = new ElementsPedidoCriarNovo { Driver = driver };
            driver.Navigate().GoToUrl(ElementsPedidoCriarNovo.UrlIndexPedido);
        }

        public void CriarNovoPedido()
        {
            createPedido.BotaoCriarNovo.Click();
        }

        public void UrlEditPedido()
        {
            Assert.Contains(ElementsPedidoCriarNovo.UrlContainsEditPedido, driver.Url);
        }
    }
}
