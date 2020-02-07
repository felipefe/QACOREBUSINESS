using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using QACoreBusiness.Util;

namespace QACoreBusiness.Elements
{
    class ElementsBaseFinanceiro : Base
    {
      

        #region URLs de Acesso
        public string UrlContextoGestorFin = UrlCoreBusiness + "/FIN/GestorFinanceiro";
        public static string UrlContextoContrato = UrlCoreBusiness + "/FIN/Contrato";
        public string UrlCreateContrato = ElementsBaseFinanceiro.UrlContextoContrato + "/Create";
        #endregion


        #region Gestor Financeiro
        public IWebElement ContextoGestorFinanceiro => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tile-group count-66 cols-22']//a[@data-title='Gestor Financeiro']");
        public IWebElement MenuAcoesDeMovimentacao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='main-tab']//a[@id='tab-menu-tabAcoes']");
        public IWebElement MenuContasAReceber => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='main-tab']//a[@id='tabMenuReceitas']");
        public IWebElement MenuContasAPagar => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='main-tab']//a[@id='tabMenuDespesas']");
        public IWebElement IconeMovimentarParcelasSelecionadas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui one wide column']//a[@data-content='Movimentar parcelas selecionadas']");
        public IWebElement IconeRemoverParcelasSelecionadas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='divbxmovreceita']//a[@data-content='Remover Parcelas selecionadas']");
        public IWebElement IconeBaixarParcelasSelecionadas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='divbxmovreceita']//a[@data-content='Baixar Parcelas']");

        #endregion



        #region Contrato
        public IWebElement ContextoContrato => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tile-group count-66 cols-22']//a[@data-title='Contratos']");
        public IWebElement HeaderCriarContrato => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[@data-content='Criar Contrato']");
        public IWebElement InputNumeroContrato => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='Contrato_NumDoc']");
        public IWebElement SelectPessoaContrato => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='Contrato_Pessoa_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement SearchPessoaContrato => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field']");
        public IWebElement SelectEmpresaContrato => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='Contrato_Empresa_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement SearchEmpresaContrato => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field']");
       // public IWebElement InputNumeroContrato => ElementWait.WaitForElementXpath(chromeDriver, "");
      //  public IWebElement InputNumeroContrato => ElementWait.WaitForElementXpath(chromeDriver, "");
        #endregion

    }
}
