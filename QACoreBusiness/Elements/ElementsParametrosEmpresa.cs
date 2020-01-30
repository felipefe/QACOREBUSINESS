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
        public string UrlParametroEmpresa = UrlCoreBusiness + "/Parametro/ParametrosEmpresa/";
        #endregion

        public IWebElement ContextoEmpresa => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tile-group count-18 cols-6']//a[@data-title='Empresas']");
        public IWebElement BotaoParametrosEmpresa => ElementWait.WaitForElementXpath(chromeDriver, "//td[@class=' hidden-mobile']//a[@data-content='Parâmetros da Empresa']");
        
        #region Parametros Configuração Emissao NF-e
        public IWebElement SelectAmbienteHomologacao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='NFeConfigParameter_Ambiente_auto_wrapper']//div[@class='ui selec2 fluid']//span[@id='select2-NFeConfigParameter_Ambiente-container']");
        public IWebElement SearchAmbienteEmissao => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-container select2-container--default select2-container--open']//input[@class='select2-search__field'][@type='search']");
        public IWebElement BotaoSalvarParamConfigNFE => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@class='ui large button']");
        public IWebElement TextViewEditTituloParametro => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui sixteen wide column']//form//h2[@class='ui dividing header']");
        public IWebElement EditParametroConfigNFE => ElementWait.WaitForElementXpath(chromeDriver, "//table[@class='ui table selectable striped coregrid']//tbody//tr//td//a[@data-content='Editar'][@href='/COREBusiness/Parametro/Edit?idParam=3']");
        public IWebElement ColunaAmbienteEmissaoAtual => ElementWait.WaitForElementXpath(chromeDriver, "//table[@class='ui table selectable striped coregrid']//tbody//tr//td[contains(text(),'Ambiente:')]");
  
        #endregion

    }
}
