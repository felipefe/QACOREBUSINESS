using OpenQA.Selenium;
using QACoreBusiness.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QACoreBusiness.Elements
{
    class ElementsRPTGerenciadorDeRelatorios : Base
    {
        #region URLs de Acesso
        public string UrlIndexGerenciadorRelatorios = UrlCoreBusiness + "/RPT/ReportView";
        public string UrlDefinicoesRelatorios = UrlCoreBusiness + "/RPT/Report";
        public string UrlCarregaDefinicaoRpt = UrlCoreBusiness + "/RPT/Report/LoadReport";
        public string UrlEditarDefinicaoRpt = UrlCoreBusiness + "/RPT/ReportView/EditBuilder/";
        public string ArquivoUploadRptSeparacoes = PathLocalProject + "\\extras\\rptSeparacoes.exe";
        #endregion

        #region Definiçao de reatorio 
        public IWebElement ContextoGerenciadoRelatorios => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tile-group count-5 cols-4']//a[@data-title='Gerenciador de Relatórios']");
        public IWebElement BotaoHeaderDefinicoesDeRelatorios => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[@data-content='Definições de Relatórios']");
        public IWebElement BotaoCarregarDefinicaoRelatorio => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[@data-content='Carregar Definição de Relatório']");
        public IWebElement BotaoSelecionarArquivoRpt => ElementWait.WaitForElementXpath(chromeDriver, "//form//div[@class='field']//label[@class='ui basic large icon button']");
        public IWebElement BotaoEnviarArquivoRpt => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Carregar']");
        public IWebElement ActionsDefinicaoRelatorio => ElementWait.WaitForElementXpath(chromeDriver, "//table[@class='ui table selectable striped coregrid']//tbody//tr//td//a/img[@alt='Opções']");
        public IWebElement SalvarRptApartirDestaDefinicao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Salvar']");
        public IWebElement SalvarRptEditDefinicao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Gravar']");
        public IWebElement ExcluirReport => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Excluir']");
        public List<IWebElement> ListaContainerActions => chromeDriver.FindElements(By.XPath("//div[@class='tool-container gradient tool-top tool-rounded']")).ToList();
        public IWebElement MenuUsuarioLogado => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='user-menu']");
        public IWebElement MenuUsuarioLogadoRelatorio => ElementWait.WaitForElementXpath(chromeDriver, "//div//a[@href='/COREBusiness/RPT/ReportView/UserReportViews']");
        public IWebElement EditDefinicaoAbaColunas => ElementWait.WaitForElementXpath(chromeDriver, "//a[@id='tab-menu-tabFields']");
        public IWebElement BotaoExecutarRelatorio => ElementWait.WaitForElementXpath(chromeDriver, "//tbody//tr//td//a[@data-content='Executar Relatório']");
        public List<IWebElement> RelatoriosImportados => chromeDriver.FindElements(By.XPath("//table[@class='ui table selectable striped coregrid']//tbody//tr")).ToList();
        public List<IWebElement> EditDefinicaoColunasCategoria => chromeDriver.FindElements(By.XPath("//div[@id='tabFields']//div[@class='ui fluid styled accordion']//div[@class='title']")).ToList();
        public List<IWebElement> EditDefinicaoLinhasDeColunaSelect => chromeDriver.FindElements(By.XPath("//div[@class='ui fluid styled accordion']//div[@class='content active']//table//tbody//tr")).ToList();
        #endregion


    }
}
