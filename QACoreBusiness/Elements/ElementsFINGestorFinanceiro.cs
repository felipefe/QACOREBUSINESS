using OpenQA.Selenium;
using QACoreBusiness.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QACoreBusiness.Elements
{
    class ElementsFINGestorFinanceiro : Base
    {

        #region URLs de Acesso
        public string UrlContextoGestorFin = UrlCoreBusiness + "/FIN/GestorFinanceiro";
        public string UrlListaParcelasBaixa = UrlCoreBusiness + "/FIN/Contrato/ListarParcelasBaixa";
        public string UrlImprimirMovimentacao = UrlCoreBusiness + "/FIN/Contrato/ImprimirMovimentacao";
        #endregion


        #region Gestor Financeiro
        public IWebElement ContextoGestorFinanceiro => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tile-group count-66 cols-22']//a[@data-title='Gestor Financeiro']");
        public IWebElement MenuAcoesDeMovimentacao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='main-tab']//a[@id='tab-menu-tabAcoes']");
        public IWebElement MenuContasAReceber => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='main-tab']//a[@id='tabMenuReceitas']");
        public IWebElement MenuContasAPagar => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='main-tab']//a[@id='tabMenuDespesas']");
        public IWebElement IconeMovimentarParcelasSelecionadas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui one wide column']//a[@data-content='Movimentar parcelas selecionadas']");
        public IWebElement IconeRemoverParcelasSelecionadas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='divbxmovreceita']//a[@data-content='Remover Parcelas selecionadas']");
        public IWebElement IconeBaixarParcelasSelecionadas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='divbxmovreceita']//a[@data-content='Baixar Parcelas']");
        public IWebElement TextViewParcelasFiltradas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='divqtdreceitasfilter']//span[@id='spanCountCR']");
        public IWebElement TextViewValorParcelasMovimentar => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='divbxmovreceita']//span[@id='spanSumMovR']");
        public IWebElement TabelaParcelasGestor => ElementWait.WaitForElementXpath(chromeDriver, "//table[@id='tableReceitas']//tbody");
        public List<IWebElement> LinhasTabelaParcelasGestor => TabelaParcelasGestor.FindElements(By.TagName("tr")).ToList();
        #endregion

        #region Contas a Pagar
        #endregion

        #region Contas a Receber
        public IWebElement PesquisaReceitaGestorFinanceiro => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='searchReceita']//a[@data-content='Pesquisa']");
        public IWebElement LimparFiltroReceitas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='item']//a[@data-content='Limpar Filtro']");
        public IWebElement BotaoFiltrarReceitas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='item']//div[contains(text(),'Filtrar Receita')]");
        #endregion

        #region Lista Parcelas Baixa
        public IWebElement CollapseParcela => ElementWait.WaitForElementXpath(chromeDriver, "//table[@id='parcelasBaixa']//tbody//tr//td//span//a");
        public IWebElement SelectMeioPagamentoPagto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='field'][2]");
        public IWebElement SearchMeioPagamentoPagto => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field']");
        public IWebElement BotaoEfetuarBaixa => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Efetuar Baixa']");

        #endregion
    }
}
