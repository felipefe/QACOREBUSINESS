using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using QACoreBusiness.Util;


namespace QACoreBusiness.Elements
{
    class ElementsParametrosEmpresa : Base
    {

        #region URLs de acesso
        public string UrlIndexEmpresa = UrlCoreBusiness + "/IDFe/Empresa";
        #endregion

        public IWebElement BotaoParametrosEmpresa => ElementWait.WaitForElementXpath(chromeDriver, "");
        //table[@class='ui table selectable striped coregrid']//tr//td[@class='hidden-mobile']//a[data-content='Parâmetros da Empresa']

        #region Parametros Configuração Emissao NF-e
        public IWebElement SelectAmbienteHomologacao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='NFeConfigParameter_Ambiente_auto_wrapper']//div[@class='ui selec2 fluid']//span[@id='select2-NFeConfigParameter_Ambiente-container']");
        public IWebElement SearchAmbienteHomologacao => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-container select2-container--default select2-container--open']//input[@class='select2-search__field'][@type='search']");
        public IWebElement BotaoSalvarParamConfigNFE => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@class='ui large button']");

        #endregion

    }
}
