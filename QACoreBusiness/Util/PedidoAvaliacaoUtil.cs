using OpenQA.Selenium;
using QACoreBusiness.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace QACoreBusiness.Util
{
    class PedidoAvaliacaoUtil
    {
        IWebDriver driver = Base.chromeDriver;
        ElementsAvaliarPedido avaliar;

        public PedidoAvaliacaoUtil()
        {
            avaliar = new ElementsAvaliarPedido();
        }

        public void PedidoEmStatusAvaliacao()
        {
            Assert.Equal("Avaliação", avaliar.SituacaoPedido.Text);
        }

        public void ActionsDoPedido()
        {
            avaliar.ActionsPedido.Click();
        }

        public void CliqueAvaliacaoPedido()
        {
            avaliar.ActionsAvaliarPedido.Click();
        }

        public void IndexAvaliarPedido()
        {
            Assert.Contains(avaliar.UrlAvaliacaoPedido, driver.Url);
        }

        public void ProsseguirAvaliacao()
        {
            avaliar.BotaoProsseguir.Click();
        }

        public void IndexPedidos()
        {
            Assert.Equal(avaliar.UrlIndexPedido, driver.Url);
        }

        public void PedidoEmStatusSeparacao()
        {
            Assert.Equal("Separação", avaliar.SituacaoPedido.Text);
        }
    }
}
