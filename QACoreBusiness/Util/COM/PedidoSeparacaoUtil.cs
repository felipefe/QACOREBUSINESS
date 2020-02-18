using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using QACoreBusiness.Elements;
using Xunit;

namespace QACoreBusiness.Util
{
    class PedidoSeparacaoUtil 
    {
        IWebDriver driver = Base.GetChromeDriver();
        ElementsCOMPedido separacao;

        public PedidoSeparacaoUtil()
        {
            separacao = new ElementsCOMPedido { chromeDriver = driver };
        }

        public void SituacaoPedido()
        {
            Assert.Equal("Separação", separacao.SituacaoPedido.Text);
        }

        public void CliqueActionSeparacao()
        {
            separacao.ActionsSepararPedido.Click();
        }

        public void IndexSeparacaoWMS()
        {
            Assert.Contains(separacao.UrlSeparacaoPedido, driver.Url);
        }

        public void CliqueBotaoDefinirTodos()
        {
            separacao.BotaoDefinirTodos.Click();
        }

        public void MensagemSucessoSeparacao(string mensagem)
        {
            Assert.Equal(mensagem, separacao.AlertaMensagemPedidoAtualizado.Text);
        }

        public void CliqueBotaoMarcarTodos()
        {
            separacao.CloseAlertaPedidoAtualizado.Click();
            Thread.Sleep(2000);
            separacao.BotaoMarcarTodos.Click();
        }

        public void MensagemModificadoResposavelSeparacao(string mensagem)
        {
            Assert.Equal(mensagem, separacao.AlertaMensagemPedidoAtualizado.Text);
        }

        public void CliqueBotaoFinalizarWMS()
        {
            separacao.BotaoFinalizarSeparacaoWMS.Click();
        }

        public void IndexFinalizarSeparacaoCOM()
        {
            Thread.Sleep(1000);
            Assert.Contains(separacao.UrlCOMFinalizarSeparacao, driver.Url);
        }

        public void CliqueFinalizarSeparacaoCOM()
        {
            separacao.BotaoFinalizarSeparacaoCOM.Click();
        }

        public void SituacaoPedidoEmConferencia()
        {
            Assert.Equal("Conferência", separacao.SituacaoPedido.Text);
        }
    }
}
