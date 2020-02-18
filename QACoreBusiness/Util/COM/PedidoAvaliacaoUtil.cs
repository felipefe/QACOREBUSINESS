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
        IWebDriver driver = Base.GetChromeDriver();
        ElementsCOMPedido avaliar;

        public PedidoAvaliacaoUtil()
        {
            avaliar = new ElementsCOMPedido { chromeDriver = driver };
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

        public void MotivoUm(string motivoUm)
        {
            Assert.Contains(motivoUm, avaliar.AvaliacaoMotivoUm.Text);
        }

        public void PedidoEmStatusSeparacao()
        {
            Assert.Equal("Separação", avaliar.SituacaoPedido.Text);
        }

        public void ValidaUrlIndexPedido()
        {
            Assert.Equal(avaliar.UrlIndexPedido, driver.Url);
        }

        public void MotivoDois(string motivoDois)
        {
            Assert.Contains(motivoDois, avaliar.AvaliacaoMotivoDois.Text);
        }

        public void CliqueBotaoBloquear()
        {
            avaliar.BotaoBloquear.Click();
        }

        public void SituacaoPedido(string status)
        {
            Assert.Equal(status, avaliar.SituacaoPedido.Text);
        }
    }
}
