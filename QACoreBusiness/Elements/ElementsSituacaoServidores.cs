using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using QACoreBusiness.Util;

namespace QACoreBusiness.Elements
{
    class ElementsSituacaoServidores : Base
    {

        #region URLs de Acesso
        public string UrlSituacaoServidores => UrlCoreBusiness + "/ServiceStatus/Status";
        public string UrlLimparMensagensCoreService => UrlCoreBusiness + "/UserTask/ShowStatus?taskHash=";
        #endregion


        #region COREService
        public IWebElement ContextoSituacaoServidores => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tile-group count-18 cols-6']//a[@data-title='Situação dos Servidores']");
        public IWebElement IsCoreService => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='ServiceControl']//table[@class='ui table webgrid']//tbody//tr[1]");
        public IWebElement ColunaSituacaoServidores => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='ServiceControl']//table[@class='ui table webgrid']//tbody//tr[1]//td[2]");
        public IWebElement BotaoPlayStopCoreService => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='ServiceControl']//table[@class='ui table webgrid']//tbody//tr[1]//td//a");
        public IWebElement BotaoLimparCoreService => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[@data-content='Limpar Mensagens do CORE Business Service']");
        public IWebElement BotaoSimModalConfirmarLimpeza => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='confirmation-modal']//div[@class='actions']//a[@class='ui approve positive right labeled icon button']");
        public IWebElement ProgressoLimpeza => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='bar']//div[@class='progress']");
        public IWebElement BotaoVoltarPagina => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//img[@title='Voltar para página anterior']");

        #endregion

    }
}
