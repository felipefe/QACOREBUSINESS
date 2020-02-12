using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using QACoreBusiness.Util;


namespace QACoreBusiness.Elements
{
    class ElementsCOMRecepcaoMercadoria : Base
    {
        public string UrlRecepcaoMercadoria = UrlCoreBusiness + "/COM/LoteFiscal";
        public string UrlLoteFiscalItem = UrlCoreBusiness + "/COM/LoteFiscalItem/Index/";


        public IWebElement ContextoRecepcaoMercadoria => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tile-group count-39 cols-13']//a[@data-title='Recepção de Mercadorias e Serviços']");
        public IWebElement ActionsRecepcao => ElementWait.WaitForElementXpath(chromeDriver, "//table[@class='ui table selectable striped coregrid']//tbody//tr[1]//td[@class=' hidden-mobile']//div//a");
        public IWebElement BotaoNovoLancamentoManual => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[@data-content='Novo lançamento manual']");
        public IWebElement ColunaStatusRecepcaoMercadoria => ElementWait.WaitForElementXpath(chromeDriver, "//table[@class='ui table selectable striped coregrid']//tbody//tr//td[@data-field='Status']");
        public IWebElement ColunaNumeroRecepcaoMercadoria => ElementWait.WaitForElementXpath(chromeDriver, "//table[@class='ui table selectable striped coregrid']//tbody//tr//td[@data-field='NumeroDoc']");


    }
}
