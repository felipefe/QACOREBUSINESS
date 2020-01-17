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
        ElementsCreatePedido createPedido;


        public void AcessarIndexPedidos()
        {
            createPedido = new ElementsCreatePedido { Driver = driver };
            driver.Navigate().GoToUrl(ElementsCreatePedido.UrlIndexPedido);
        }

        public void CriarNovoPedido()
        {
            createPedido.BotaoCriarNovo.Click();
        }

        public void UrlEditPedido()
        {
            Assert.Contains(ElementsCreatePedido.UrlContainsEditPedido, driver.Url);
        }
    }
}
