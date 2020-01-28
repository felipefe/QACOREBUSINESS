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
        IWebDriver driver = Base.chromeDriver;
        ElementsEfetivarPedido pedido;


        public void AcessarIndexPedidos()
        {
            pedido = new ElementsEfetivarPedido();
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
    }
}
