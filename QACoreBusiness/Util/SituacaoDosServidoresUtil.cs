using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using QACoreBusiness.Elements;
using Xunit;

namespace QACoreBusiness.Util
{
    class SituacaoDosServidoresUtil
    {
        IWebDriver driver = Base.GetChromeDriver();
        ElementsSituacaoServidores servidor;

        public SituacaoDosServidoresUtil()
        {
            servidor = new ElementsSituacaoServidores { chromeDriver = driver };
        }

        public void IndexSituacaoServidores()
        {
            servidor.ContextoSituacaoServidores.Click();
        }

        public void SituacaoAtualCoreService(string situacao)
        {
            Assert.Equal(situacao, servidor.ColunaSituacaoServidores.Text);
        }

        internal void ValidarURLServiceStatus()
        {
            Assert.Contains(servidor.UrlSituacaoServidores, driver.Url);
        }

        public void CliqueIniciarOuPararCoreService()
        {
            servidor.BotaoPlayStopCoreService.Click();
        }

        public void NovaSitualCoreService(string novaSituacao)
        {
            Assert.Equal(novaSituacao, servidor.ColunaSituacaoServidores.Text);
        }

        public void CliqueBotaoLimpar()
        {
            servidor.BotaoLimparCoreService.Click();
        }

        public void CliqueConfirmaçaoModal()
        {
            servidor.BotaoSimModalConfirmarLimpeza.Click();
        }

        public void ValidarUrlUserTask()
        {
            Assert.Contains(servidor.UrlLimparMensagensCoreService, driver.Url);
        }

        public void ProgressoLimparCoreService()
        {
            Assert.Equal("100%", servidor.ProgressoLimpeza.Text);
        }

        public void CliqueBotaoVoltar()
        {
            servidor.BotaoVoltarPagina.Click();
        }

        public void isHabilitadoCoreService()
        {
            driver.Navigate().GoToUrl(servidor.UrlSituacaoServidores);
            SituacaoAtualCoreService("Running");
            driver.Navigate().GoToUrl(Base.UrlCoreBusiness);
        }
    }
}
