using OpenQA.Selenium;
using QACoreBusiness.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QACoreBusiness.Elements
{
    class ElementsCOSOrdemServico : Base
    {       // public IWebElement  => ElementWait.WaitForElementXpath(chromeDriver, "");

        #region URLs de Acesso
        public string UrlOrdemServico => UrlCoreBusiness + "/COS/OrdemServico";
        public string UrlEditOrdemServico => UrlCoreBusiness + "/COS/OrdemServico/Edit/";
        #endregion

        #region Index Ordem Serviço
        public IWebElement BotaoNovoSimples => ElementWait.WaitForElementXpath(chromeDriver, "//a[@data-content='Novo Simples...']");
        public List<IWebElement> ListaOS => chromeDriver.FindElements(By.XPath("//table[@class='ui table selectable striped coregrid']//tbody//tr")).ToList();
        #endregion

        #region Novo Simples
        public IWebElement SelectPessoaNovoSimples => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='OrdemServico_Pessoa_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement InputDataPrazoFinalNovoSimples => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='OrdemServico_PrazoFinal']");
        public IWebElement TextAreaResumoNovoSimples => ElementWait.WaitForElementXpath(chromeDriver, "//textarea[@id='OrdemServico_Resumo']");
        public IWebElement TextAreaObervacaoNovoSimples => ElementWait.WaitForElementXpath(chromeDriver, "//textarea[@id='OrdemServico_Observacao']");
        public IWebElement BotaoSalvarNovoSimples => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Salvar']");
        public IWebElement SelectTipoOS => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='OrdemServico_Tipo_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement ActionExcluir => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@data-content='Excluir']");
        public IWebElement TextAreaJustificativa => ElementWait.WaitForElementXpath(chromeDriver, "//textarea[@id='OrdemServico_JustificativaCancelamento']");
        public IWebElement BotaoCancelarOS => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Cancelar O.S.']");

        #endregion
    }
}
