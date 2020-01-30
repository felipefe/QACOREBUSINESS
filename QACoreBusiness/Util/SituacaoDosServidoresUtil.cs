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
        IWebDriver driver = Base.chromeDriver;
        ElementsSituacaoServidores servidor;

        public SituacaoDosServidoresUtil()
        {
            servidor = new ElementsSituacaoServidores();
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
    }
}
