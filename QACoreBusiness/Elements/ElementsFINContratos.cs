using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using QACoreBusiness.Util;
using System.Linq;

namespace QACoreBusiness.Elements
{
    class ElementsFINContratos : Base
    {


        #region URLs de Acesso
        public string UrlCreateContrato => UrlContextoContrato + "/Create";
        public string UrlParcelasContrato => UrlContextoContrato + "/Parcelas?idContrato=";
        public string UrlContextoContrato => UrlCoreBusiness + "/FIN/Contrato";
        public string UrlContratoPagtoAntecipado => UrlCoreBusiness + "/FIN/PagamentoAntecipado/Create";
        public string UrlLancarReceita => UrlCoreBusiness + "/FIN/DespesaReceita/Create?tipoPC=C";
        public string UrlLancarDespesa => UrlCoreBusiness + "/FIN/DespesaReceita/Create?tipoPC=D";
        #endregion


        #region Contrato
        public IWebElement ContextoContrato => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tile-group count-66 cols-22']//a[@data-title='Contratos']");
        public IWebElement HeaderCriarContrato => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[@data-content='Criar Contrato']");
        public IWebElement InputNumeroContrato => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='Contrato_NumDoc']");
        public IWebElement SelectPessoaContrato => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='Contrato_Pessoa_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement SearchPessoaContrato => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field']");
        public IWebElement SelectEmpresaContrato => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='Contrato_Empresa_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement SearchEmpresaContrato => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field']");
        public IWebElement SelectPlanoContas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='Contrato_PlanoConta_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement SearchPlanoContas => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field']");
        public IWebElement SelectCentroCusto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='idCentroCusto_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement SearchCentroCusto => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field']");
        public IWebElement BotaoAddParcelasAutomaticamente => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui right aligned buttons']//div[@data-content='Adicionar Parcelas automaticamente']");
        public IWebElement BotaoAddParcelasManualmente => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui right aligned buttons']//div[@data-content='Adicionar Parcelas Manualmente']");
        public IWebElement InputHistoricoContrato => ElementWait.WaitForElementXpath(chromeDriver, "//textarea[@id='Contrato_Historico']");
        public IWebElement FirstLinhaTabelaContrato => ElementWait.WaitForElementXpath(chromeDriver, "//table[@class='ui table selectable striped coregrid']//tbody//tr[1]");
        public IWebElement SelectContaPrevistaPagto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='Contrato_ContaBancaria_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement SearchContaPrevistaPagto => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field']");
        public IWebElement BotaoCriarSalvarContrato => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Criar Contrato']");
        public List<IWebElement> LinhasTabelaContratosFinanceiro => chromeDriver.FindElements(By.XPath("//table[@class='ui table selectable striped coregrid']//tbody//tr")).ToList();
        #endregion

        #region Adicionar Parcelas Automaticamente Contrato
        public IWebElement BotaoSalvarParcelas=> ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Salvar']");
        public IWebElement InputValorOriginalParcelaContrato => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='Contrato_ValorEfetivo']");
        public IWebElement InputValorPorParcelaContrato => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='ContratoViewModel_ValorParcela']");
        public IWebElement InputQntidadeParcelaContrato => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='Contrato_QtdParcelasOriginal']");
        public IWebElement InputIntervaloDiasParcelaContrato => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='Contrato_IntervaloParcelas']");
        public IWebElement InputVencimentoPrimeiraParcelaContrato => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='Contrato_DataPrimeiraParcela']");
        public IWebElement TabelaParcelas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='divParcelas']//table//tbody");
        #endregion

        #region Adicionar Parcelas Manualmente Contrato
        public IWebElement InputValorOriginalManualmente => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='ContratoParcela_Valor']");
        public IWebElement InputDataVencimentoManualmente => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='ContratoParcela_Vencimento']");
        public IWebElement BotaoAddParcelasCriadas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Adicionar']");
        public IWebElement ValorParcelaManual => ElementWait.WaitForElementXpath(chromeDriver, "//tbody//tr//td[3]//div//div//input");
        public IWebElement ActionsParcelasContrato => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@data-content='Parcelas']");
        public IWebElement BotaoHeaderContratoNovaParcela => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[@data-content='Nova Parcela']");
        public IWebElement TabelaContratoNovaParcela => ElementWait.WaitForElementXpath(chromeDriver, "//table[@class='ui table webgrid']//tbody");
        public IWebElement InputDataVencimentoNovaParcela => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='ContratoParcela_Vencimento_auto_wrapper']//input[@id='ContratoParcela_Vencimento']");
        public IWebElement InputValorOriginalNovaParcela => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='ContratoParcela_Valor_auto_wrapper']//input[@id='ContratoParcela_Valor']");
        #endregion

        #region Excluir/Cancelar Contrato
        public IWebElement ActionsContrato => ElementWait.WaitForElementXpath(chromeDriver, "//table[@class='ui table selectable striped coregrid']//tbody//tr//td//a//img[@alt='Opções']");
        public IWebElement ActionsExcluirContrato => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@data-content='Excluir / Cancelar']");
        public IWebElement BotaoExcluirContratoModal => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Excluir']");
        public IWebElement AlertaExcluirImpossivel => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui warning  message']");
        #endregion

        #region Contrato Pagamento Antecipado
        public IWebElement BotaoSalvarContrato => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Salvar']");
        public IWebElement SelectMeioPagamentoPagtoAntecipado => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='MovContratoParcela_MeioPagamento_auto_wrapper']");
        public IWebElement SearchMeioPagamentoPagtoAntecipado => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field']");
        public IWebElement InputValorContratoPagtoAntecipado => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='ContratoParcela_ValorPagar']");
        public IWebElement HeaderLancarPagtoAntecipado => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[@data-content='Lançar Pagamento Antecipado']");
        #endregion

        #region Contrato Lançar Receita
        public IWebElement HeaderLancarReceita => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[@data-content='Lançar Receitas']");
        public IWebElement InputValorPagoContrato => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='ContratoParcela_ValorPago']");
        #endregion

        #region Contrato Lançar Despesa
        public IWebElement HeaderLancarDespesa => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[@data-content='Lançar Despesas']");
        #endregion

    }
}
