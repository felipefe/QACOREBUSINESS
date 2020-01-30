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
        public string UrlSituacaoServidores = UrlCoreBusiness + "/ServiceStatus/Status";
        #endregion


        #region ServiceStatus
        public IWebElement ContextoSituacaoServidores => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tile-group count-18 cols-6']//a[@data-title='Situação dos Servidores']");
        public IWebElement IsCoreService => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='ServiceControl']//table[@class='ui table webgrid']//tbody//tr[1]");
        public IWebElement ColunaSituacaoServidores => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='ServiceControl']//table[@class='ui table webgrid']//tbody//tr[1]//td[2]");
        public IWebElement BotaoPlayStopCoreService => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='ServiceControl']//table[@class='ui table webgrid']//tbody//tr[1]//td//a");
        #endregion

    }
}
