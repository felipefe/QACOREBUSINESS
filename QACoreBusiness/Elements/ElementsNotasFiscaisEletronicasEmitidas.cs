using OpenQA.Selenium;
using QACoreBusiness.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace QACoreBusiness.Elements
{
    class ElementsNotasFiscaisEletronicasEmitidas : Base
    {

        public string UrlNFEEmitidas => UrlCoreBusiness + "/IDFe/NFe";
        public IWebElement ContextoNFEEmitidas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tile-group count-18 cols-6']//a[@data-title='NF-e - Notas Fiscais Eletrônicas Emitidas']");
        public IWebElement ColunaUsoAutorizadoNFE => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='pageContent']//table[@class='ui table selectable striped coregrid']//tbody//tr[1]//td[6]");
        public IWebElement ColunaValorNFE => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='pageContent']//table[@class='ui table selectable striped coregrid']//tbody//tr[1]//td[7]");


    }
}
