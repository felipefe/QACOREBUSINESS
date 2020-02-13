using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util.FIN;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class GestorFinanceiroSteps
    {
        GestorFinanceiroUtil gfu = new GestorFinanceiroUtil();

        [Given(@"acesse a index gestor financeiro")]
        public void GivenAcesseAIndexGestorFinanceiro()
        {
            gfu.AcesseIndexGestorFinanceiro();
        }
        
        [Given(@"que clica na aba Contas a Receber")]
        public void GivenQueClicaNaAbaContasAReceber()
        {
            gfu.CliqueAbaContasReceber();
        }
        
        [Given(@"clique na pesquisa")]
        public void GivenCliqueNaPesquisa()
        {
            gfu.CliquePesquisaGestorFin();
        }
        
        [Given(@"clique para limpar filtros")]
        public void GivenCliqueParaLimparFiltros()
        {
            gfu.CliqueLimparFiltros();
        }
        
        [Given(@"clique no botao Filtrar Receitas")]
        public void GivenCliqueNoBotaoFiltrarReceitas()
        {
            gfu.CliqueFiltrarReceitas();
        }
        
        
        [Given(@"selecione a primeira parcela listada")]
        public void GivenSelecioneAPrimeiraParcelaListada()
        {
            gfu.SelecionarPrimeiraParcelaListada();
        }
        
        [Given(@"clique no botao movimentar parcela")]
        public void GivenCliqueNoBotaoMovimentarParcela()
        {
            gfu.CliqueMovimentarParcelaSelecionada();
        }
        
        [Given(@"o valor a ser movimentado seja maior que zero")]
        public void GivenOValorASerMovimentadoSejaMaiorQueZero()
        {
            gfu.ValidaValorParcelasSelecionadas();
        }
        
        [Given(@"clique no icone Baixar Parcela")]
        public void GivenCliqueNoIconeBaixarParcela()
        {
            gfu.CliqueIconeBaixarParcelas();
        }
        
        [Given(@"seja redirecionado para /FIN/Contrato/ListarParcelasBaixa")]
        public void GivenSejaRedirecionadoParaFINContratoListarParcelasBaixa()
        {
            gfu.ValidaRedirecionamentoListarParcelasBaixa();
        }
        
        [Given(@"clique no collapse para exibir meio pagamento parcela")]
        public void GivenCliqueNoCollapseParaExibirMeioPagamentoParcela()
        {
            gfu.CliqueCollapseExibirMeioPagamentoParcela();
        }
        
        [Given(@"selecione o meio de pagamento \{'(.*)'}")]
        public void GivenSelecioneOMeioDePagamento(string meioPagamento)
        {
            gfu.SelectMeioPagamentoBaixaParcela(meioPagamento);
        }

        [Given(@"o numero de parcelas filtradas seja maior que \{(.*)}")]
        public void GivenONumeroDeParcelasFiltradasSejaMaiorQue(int quantidadeParcelas)
        {
            gfu.ValidaQuantidadeParcelasReceitasFiltradas(quantidadeParcelas);
        }

        [Given(@"selecione a segunda parcela listada")]
        public void GivenSelecioneASegundaParcelaListada()
        {
            gfu.SelecionarSegundaParcelaListada();
        }

        [Given(@"clique no botao Adicionar Multiplos Meios de Pagamento")]
        public void GivenCliqueNoBotaoAdicionarMultiplosMeiosDePagamento()
        {
            gfu.CliqueBotaoAdicionarMultiplosMeiosPagamento();
        }

        [Given(@"selecione a parcela de crédito/abatimento")]
        public void GivenSelecioneAParcelaDeCreditoAbatimentoQueSejaMaiorQueOValorAQuitar()
        {
            gfu.SelecionarParcelaAbatimentoSeHouver();
        }

        [Given(@"ache no select a parcela de crédito/abatimento que seja maior que o valor a quitar")]
        public void GivenAcheNoSelectAParcelaDeCreditoAbatimentoQueSejaMaiorQueOValorAQuitar()
        {
            gfu.FindParcelaCredito();
        }

        [When(@"clicar no botao Efetuar Baixa")]
        public void WhenClicarNoBotaoEfetuarBaixa()
        {
            gfu.CliqueBotaoEfetuarBaixa();
        }

        [When(@"selecione o meio de pagamento \{'(.*)'}")]
        public void WhenSelecioneOMeioDePagamento(string meioPagamento)
        {
            gfu.SelecionarMeioPagamentoMultiplosMeios(meioPagamento);
        }

        [When(@"informar o planos de contas \{'(.*)'}")]
        public void WhenInformarOPlanosDeContas(string PC)
        {
            gfu.SelecionarPlanoContasMultiplosMeios(PC);
        }

        [When(@"informar o centro de custo \{'(.*)'}")]
        public void WhenInformarOCentroDeCusto(string CC)
        {
            gfu.SelecionarCentroCustoMultiplosMeios(CC);
        }

        [When(@"informar no input o historico \{'(.*)'}")]
        public void WhenInformarNoInputOHistorico(string historico)
        {
            gfu.InputHistoricoMultiplosMeioPagto(historico);
        }

        [When(@"clicar no botao Adicionar para multiplos meios de pagamento")]
        public void WhenClicarNoBotaoAdicionarParaMultiplosMeiosDePagamento()
        {
            gfu.CliqueSalvarMultiplosMeiosPagto();
        }

        [When(@"clicar no botao Vincular Parcelas de Crédito/Abatimento")]
        public void WhenClicarNoBotaoVincularParcelasDeCreditoAbatimento()
        {
            gfu.CliqueVincularParcelasAbatimento();
        }

        [When(@"memorizar o valor a quitar")]
        public void WhenMemorizarOValorAQuitar()
        {
            gfu.MemorizarValorAbater();
        }

        [When(@"validar que os créditos disponíveis são maiores que \{(.*)}")]
        public void WhenValidarQueOsCreditosDisponiveisSaoMaioresQue(int qntidade)
        {
            gfu.ValidaQuantidadeCreditos(qntidade);
        }

        [When(@"validar que o valor total dos creditos disponiveis sao maiores que o valor a quitar")]
        public void WhenValidarQueOValorTotalDosCreditosDisponiveisSaoMaioresQueOValorAQuitar()
        {
            gfu.ValidaTotalCreditosEValorQuitar();
        }

        [When(@"selecionar os creditos até o valor total selecionado ser igual ou maior que o valor a quitar")]
        public void WhenSelecionarOsCreditosAteOValorTotalSelecionadoSerIgualOuMaiorQueOValorAQuitar()
        {
            gfu.SelecionarParcelasDeAbatimento();
        }

        [When(@"clicar no botao Vincular creditos")]
        public void WhenClicarNoBotaoVincularCreditos()
        {
            gfu.CliqueSalvarCreditosSelecionados();
        }


        [Then(@"o sistema redireciona para imprimir movimentacao")]
        public void ThenOSistemaRedirecionaParaImprimirMovimentacao()
        {
            gfu.ValidaUrlImprimirMovimentacao();
        }
    }
}
