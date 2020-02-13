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

        #region Lista Parcelas Baixa / Multiplos Meios
        public IWebElement CollapseParcela => ElementWait.WaitForElementXpath(chromeDriver, "//table[@id='parcelasBaixa']//tbody//tr//td//span//a");
        public IWebElement SelectMeioPagamentoPagto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='field'][2]");
        public IWebElement SearchGenerico => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field']");
        public IWebElement BotaoEfetuarBaixa => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Efetuar Baixa']");
        public IWebElement BotaoAddMultiplosMeiosPagto => ElementWait.WaitForElementXpath(chromeDriver, "//div//a[@data-content='Adicionar Múltiplos Meios de Pagamento']");
        public IWebElement InputHistoricoMultiplosMeiosPagto => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='ConfigMovimento_Historico']");
        public IWebElement SelectMeioPagamentoMultiplosMeios => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='ConfigMovimento_MeioPagamento_auto_wrapper']");
        public IWebElement SelectPlanoContasMultiplosMeios => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='ConfigMovimento_PlanoConta_auto_wrapper']");
        public IWebElement SelectCentroCustoMultiplosMeios => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='ConfigMovimento_CentroCusto_auto_wrapper']");
        public IWebElement BotaoSalvarMultiplosMeiosPagto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Adicionar']");
        #endregion

        #region Abatimento
        public IWebElement BotaoVincularParcelaAbatimento => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui right aligned one wide column']//a[@data-content='Vincular parcela de Crédito / Abatimento']");
        public IWebElement ValorParcelasAbatimento => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui stackable four column row grid']//div[@class='ui column displayFor'][2]");
        public IWebElement CreditosDisponiveisAbatimento => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui grid']//div[@class='ui right aligned three wide column']");
        public IWebElement ValorTotalParcelasCredito => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui grid']//div[@class='ui right aligned four wide column']");
        public IWebElement ValorTotalCreditosSelecionado => ElementWait.WaitForElementXpath(chromeDriver, "//table[@id='CreditosMultiplaBaixa']//tfoot//tr//td[@class='align-right']");
        public IWebElement ValorPagarParcelaBaixa => ElementWait.WaitForElementXpath(chromeDriver, "//table[@id='parcelasBaixa']//tbody//tr//td[8]");
        public List<IWebElement> LinhasTabelaCreditosAbatimento => chromeDriver.FindElements(By.XPath("//table[@id='CreditosMultiplaBaixa']//tbody//tr")).ToList();
        public IWebElement BotaoSalvarParcelaSelecionadasAbatimento => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Vincular']");
        public List<IWebElement> ParcelasCreditoParaAbatimentoUnico => chromeDriver.FindElements(By.XPath("//span[@class='select2-results']//ul[@class='select2-results__options']//li//div[@class='clearfix']")).ToList();
        public IWebElement SelectParcelaAbatimento => ElementWait.WaitForElementXpath(chromeDriver, "//table[@id='parcelasBaixa']//tbody//tr//td//div//div//div[@class='field']//div[@class='ui select2 fluid']//span[@class='select2 select2-container select2-container--default']");
        #endregion
    }
}
