﻿using OpenQA.Selenium;
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
        public string UrlContextoGestorFin => UrlCoreBusiness + "/FIN/GestorFinanceiro";
        public string UrlListaParcelasBaixa => UrlCoreBusiness + "/FIN/Contrato/ListarParcelasBaixa";
        public string UrlImprimirMovimentacao => UrlCoreBusiness + "/FIN/Contrato/ImprimirMovimentacao";
        public string UrlGerarRenegociacao => UrlCoreBusiness + "/FIN/Contrato/GerarRenegociacaoContrato";
        public string UrlVisualizarContrato => UrlCoreBusiness + "/FIN/Contrato/Visualizar?idContrato";
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
        public IWebElement PesquisaDespesaGestorFinanceiro => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='infoDespesas']//a[@data-content='Pesquisa']");
        public IWebElement LimparFiltroReceitas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='item']//a[@data-content='Limpar Filtro']");
        public IWebElement BotaoFiltrarReceitas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='item']//div[contains(text(),'Filtrar Receita')]");
        public IWebElement TextViewParcelasFiltradasDespesa => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='divqtddespesasfilter']//span[@id='spanCountCD']");
        public IWebElement TabelaParcelasDespesa => ElementWait.WaitForElementXpath(chromeDriver, "//table[@id='tableDespesas']//tbody");
        public List<IWebElement> LinhasTabelaDespesas => TabelaParcelasDespesa.FindElements(By.TagName("tr")).ToList();
        public IWebElement IconeMovimentarDespesasSelecionadas => ElementWait.WaitForElementXpath(chromeDriver, "//form[@id='frmDespesas']//div[@class='ui one wide column']//a[@data-content='Movimentar parcelas selecionadas']");
        public IWebElement TextViewValorParcelasMovimentarDespesa => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='divbxmovdespesa']//span[@id='spanSumMovD']");
        public IWebElement IconeBaixarParcelasDespesasSelecionadas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='divbxmovdespesa']//a[@data-content='Baixar Parcelas selecionadas']");
        public IWebElement SelectContaBancariaDespesa => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='five fields']//div[@class='field']//span[@class='select2 select2-container select2-container--default']");
        #endregion

        #region Contas a Receber
        public IWebElement PesquisaReceitaGestorFinanceiro => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='searchReceita']//a[@data-content='Pesquisa']");
        public IWebElement LimparFiltroDespesas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='area-despesa']//div[@class='item']//a[@data-content='Limpar Filtro']");
        public IWebElement BotaoFiltrarDespesa => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='item']//div[contains(text(),'Filtrar Despesa')]");
        #endregion

        #region Lista Parcelas Baixa / Multiplos Meios
        public IWebElement CollapseParcela => ElementWait.WaitForElementXpath(chromeDriver, "//table[@id='parcelasBaixa']//tbody//tr//td//span//a");
        public IWebElement SelectMeioPagamentoPagto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='field'][2]");
        public IWebElement SelectMeioPagamentoPagtoMultiplosMeios => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='ConfigMovimento_MeioPagamento_auto_wrapper']");
        public IWebElement BotaoEfetuarBaixa => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Efetuar Baixa']");
        public IWebElement BotaoAddMultiplosMeiosPagto => ElementWait.WaitForElementXpath(chromeDriver, "//div//a[@data-content='Adicionar Múltiplos Meios de Pagamento']");
        public IWebElement InputHistoricoMultiplosMeiosPagto => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='ConfigMovimento_Historico']");
        public IWebElement InputSegundoHistoricoMultiplosMeiosPagto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='area_adicionar'][2]//input[@id='ConfigMovimento_Historico']");
        public IWebElement InputValorMultiplosMeiosPagto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='area_adicionar'][1]//input[@id='ConfigMovimento_Valor']");
        public IWebElement InputSegundoValorMultiplosMeiosPagto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='area_adicionar'][2]//input[@id='ConfigMovimento_Valor']");
        public IWebElement TextViewValorAddFirstMultiplosMeios => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='active content'][1]//div[@class='ui grid']//div[@class='ui two wide column'][4]//div[@class='ui column displayFor']");
        public IWebElement TextViewValorAddSecondMultiplosMeios => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='active content'][2]//div[@class='ui grid']//div[@class='ui two wide column'][4]//div[@class='ui column displayFor']");
        public IWebElement SelectMeioPagamentoMultiplosMeios => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='area_adicionar'][1]//div[@id='ConfigMovimento_MeioPagamento_auto_wrapper']");
        public IWebElement SelectSegundoMeioPagamentoMultiplosMeios => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='area_adicionar'][2]//div[@id='ConfigMovimento_MeioPagamento_auto_wrapper']");
        public IWebElement SelectContaBancariaSegundoMeio => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='area_adicionar'][2]//div[@id='ConfigMovimento_ContaBancaria_auto_wrapper']");
        public IWebElement SelectPlanoContasMultiplosMeios => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='area_adicionar'][1]//div[@id='ConfigMovimento_PlanoConta_auto_wrapper']");
        public IWebElement SelectSegundoPlanoContasMultiplosMeios => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='area_adicionar'][2]//div[@id='ConfigMovimento_PlanoConta_auto_wrapper']");
        public IWebElement SelectCentroCustoMultiplosMeios => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='area_adicionar'][1]//div[@id='ConfigMovimento_CentroCusto_auto_wrapper']");
        public IWebElement SelectSegundoCentroCustoMultiplosMeios => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='area_adicionar'][2]//div[@id='ConfigMovimento_CentroCusto_auto_wrapper']");
        public IWebElement BotaoSalvarMultiplosMeiosPagto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='area_adicionar'][1]//div[@class='actions']//input[@value='Adicionar']");
        public IWebElement BotaoSalvarSegundoMultiplosMeiosPagto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='area_adicionar'][2]//div[@class='actions']//input[@value='Adicionar']");
        public IWebElement SelectContaBancaria => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='five fields']//div[@class='field']//span[@class='select2 select2-container select2-container--default select2-value-selected']");

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

        #region Juros/Multa/Desconto
        public IWebElement ParcelaABaixar => ElementWait.WaitForElementXpath(chromeDriver, "//table[@id='parcelasBaixa']//tbody//tr[1]");
        public IWebElement ValorOriginalParcelaModal => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui stackable four column row grid'][1]//div[@class='ui column displayFor'][4]");
        public IWebElement JurosMultaParcelaModal => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui stackable four column row grid'][2]//div[@class='ui column displayFor'][2]");
        public IWebElement ValorLiquidoPagarParcelaModal => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui stackable four column row grid'][2]//div[@class='ui column displayFor'][4]");
        public IWebElement InputValorPagarDescontoJurosParcela => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='ContratoParcela_ValorPagar']");
        public IWebElement FlagBaixaParcial => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='ContratoParcela_BaixaParcial_auto_wrapper']//div[@class='ui toggle checkbox']//label");
        public IWebElement BotaoGravarJurosMulta => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Gravar']");
        public IWebElement BotaoEditarDadosBaixaParcela => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[@data-content='Alterar Dados da Baixa(todas as parcelas)']");
        public IWebElement FlagAlterarDataPagamentoParaMovimento => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='ContratoViewModel_SetDateVencimento_auto_wrapper']//div[@class='ui toggle checkbox']");
        public IWebElement BotaoAlterarDadosBaixa => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Alterar']");
        #endregion


        #region Renegociar/Substituir Parcela
        public IWebElement AddParcelaContratoByModal => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui right aligned buttons']//div[@class='ui basic green button'][1]");
        public IWebElement BotaoCriarContratoByModal => ElementWait.WaitForElementXpath(chromeDriver, "//a[@data-content='Criar Contrato']");
        public IWebElement AcoesSubstituir => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='sidebarMenuAcoes']//a[4]");
        public IWebElement AcoesRenegociar => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='sidebarMenuAcoes']//a[3]");
        public IWebElement InputValorLiquidoRenegociar => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='ContratoRenegociacaoViewModel_ValorLiquidoRenegociar']");
        public IWebElement BotaoMontarRenegociacao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[contains(text(),'Montar Renegociação')]");
        public IWebElement BotaoInserirParcelaManualmente => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui right aligned buttons']//div[@class='ui basic green button'][1]");
        public IWebElement InputDtVencNovaParcelaContratoRenegociacao => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='parcelaVencimento1']");
        public IWebElement InputValorNovaParcelaContratoRenegociacao => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='parcelaValor1']");
        public IWebElement BotaoGerarRenegociacao => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='contrato-submit']");
        public IWebElement LinhaNovaParcelaContrato => ElementWait.WaitForElementXpath(chromeDriver, "//table[@id='viewcontratoParcelas']//tbody//tr[1]");
        public IWebElement LinhaParcelaSubstituidaContrato => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='contratoParcelasSubstituidas']//table//tbody//tr");
        public IWebElement InputDataVencimentoParcela => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='ContratoParcela_Vencimento']");
        public IWebElement BotaoSalvarParcela => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Adicionar']");
        public IWebElement ValorParcelaSubstituir => ElementWait.WaitForElementXpath(chromeDriver, "//table[@id='ParcelasASubstituir']//tbody//tr//td[6]");
        public IWebElement InputValorNovaParcelaSubstituta => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='parcelaValor1']");
        public IWebElement BotaoSalvarContratoSubstituido => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='contrato-submit']");
        public IWebElement InputNumeroContratoByModal => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='Contrato_NumDoc']");
        public IWebElement SelectContratoSubstituto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='SubstituicaoParcelasViewModel_ContratoSubstituto_auto_wrapper']");
        public IWebElement BotaoSubstituirParcela => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Substituir Parcelas']");
        #endregion


        #region Cadastro Cheque
        public IWebElement BotaoSalvarCheque  => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Salvar']");
        public IWebElement TextAreaObservacao => ElementWait.WaitForElementXpath(chromeDriver, "//textarea[@id='Cheque_Observacao']");
        public IWebElement InputDataEmissaoCheque => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='Cheque_Emissao']");
        public IWebElement InputDataBomParaCheque => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='Cheque_BomPara']");
        public IWebElement InputNumeroCheque => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='Cheque_NumeroCheque']");
        public IWebElement SelectBancoEmitente => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='Cheque_Emitente_auto_wrapper']//div");
        public IWebElement BotaoLancarCheque => ElementWait.WaitForElementXpath(chromeDriver, "//a[@data-content='Lançar Cheque']");
        public IWebElement SelectCheque => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-selection select2-selection--single']//span[contains(text(),'Selecionar Cheque')]");
        public IWebElement BotaoIncluirNovoCheque => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='chequeMultiplaBXApp']//a//img");
        public IWebElement BotaoVincularChequeMultiplosMeios => ElementWait.WaitForElementXpath(chromeDriver, "//a[@data-content='Vincular documento do Cheque']");
        public IWebElement SelectEmpresaCheque => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='Cheque_Empresa_auto_wrapper']");
        public IWebElement SelectResponsavelCheque => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='Cheque_Responsavel_auto_wrapper']");
        public IWebElement InputBuscarCheques => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='ConfigMovimento_TermCheques']");
        public IWebElement RemoverContaBancariaBaixa => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='field'][3]//div[@class='ui select2 fluid']//span[@class='select2-selection__clear']");
        public List<IWebElement> LinhasTabelaCheques => chromeDriver.FindElements(By.XPath("//table[@id='ChequesMultiplaBaixa']//tbody//tr")).ToList();
        public IWebElement SelectCaixaRecebido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='Cheque_CaixaRecebido_auto_wrapper']");
        public IWebElement InputDataEntradaChequeEmCaixa => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='Cheque_DataEntradaCaixa']");
        public IWebElement BotaoLancarChequeTerceiro => ElementWait.WaitForElementXpath(chromeDriver, "//a[@data-content='Novo Cheque de Terceiros']");
        public IWebElement InputValorChequeTerceiro => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='Cheque_Valor']");
        public List<IWebElement> ListaChequesTerceiro => chromeDriver.FindElements(By.XPath("//div[@id='pageContent']//table//tbody//tr")).ToList();
        public IWebElement ActionExcluirCheque => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@data-content='Excluir']");
        public IWebElement BotaoExcluirCheque => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Excluir']");
        public IWebElement BotaoLancarChequeProprio=> ElementWait.WaitForElementXpath(chromeDriver, "//a[@data-content='Novo Cheque Próprio']");

        #endregion

    }
}
