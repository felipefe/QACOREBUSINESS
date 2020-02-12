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
        
        [Given(@"o numero de parcelas filtradas seja maior que zero")]
        public void GivenONumeroDeParcelasFiltradasSejaMaiorQueZero()
        {
            gfu.ValidaQuantidadeParcelasReceitasFiltradas();
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
        
        [When(@"clicar no botao Efetuar Baixa")]
        public void WhenClicarNoBotaoEfetuarBaixa()
        {
            gfu.CliqueBotaoEfetuarBaixa();
        }
        
        [Then(@"o sistema redireciona para imprimir movimentacao")]
        public void ThenOSistemaRedirecionaParaImprimirMovimentacao()
        {
            gfu.ValidaUrlImprimirMovimentacao();
        }
    }
}
