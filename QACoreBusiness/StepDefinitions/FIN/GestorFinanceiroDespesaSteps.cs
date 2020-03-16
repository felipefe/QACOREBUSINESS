using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util.FIN;

namespace QACoreBusiness.StepDefinitions.FIN
{
    [Binding]
    public class GestorFinanceiroDespesaSteps
    {
        GestorFinanceiroDespesaUtil gfd = new GestorFinanceiroDespesaUtil();

        [Given(@"que clica na aba Contas a Pagar")]
        public void GivenQueClicaNaAbaContasAPagar()
        {
            gfd.CliqueAbaContasPagar();
        }
        
        [Given(@"clique para pesquisar despesas")]
        public void GivenCliqueParaPesquisarDespesas()
        {
            gfd.CliquePesquisarDespesas();
        }
        
        [Given(@"clique no botao limpar filtros")]
        public void GivenCliqueNoBotaoLimparFiltros()
        {
            gfd.CliqueLimparFiltro();
        }
        
        [Given(@"clique no botao Filtrar Despesas")]
        public void GivenCliqueNoBotaoFiltrarDespesas()
        {
            gfd.CliqueFiltrarDespesa();
        }
        
        [Given(@"o numero de parcelas despesas filtradas seja maior que \{(.*)}")]
        public void GivenONumeroDeParcelasDespesasFiltradasSejaMaiorQue(int parcelasFiltradas)
        {
            gfd.ValidaQtdDespesasFiltradas(parcelasFiltradas);
        }
        
        [Given(@"selecione a primeira parcela da lista")]
        public void GivenSelecioneAPrimeiraParcelaDaLista()
        {
            gfd.SelecionarPrimeiraLinhaTabela();
        }
        
        [Given(@"clique no botao Movimentar Parcela")]
        public void GivenCliqueNoBotaoMovimentarParcela()
        {
            gfd.CliqueMovimentarParcela();
        }
        
        [Given(@"o valor a ser movimentado seja maior que Zero")]
        public void GivenOValorASerMovimentadoSejaMaiorQueZero()
        {
            gfd.ValidaValorMovimentacao();
        }
        
        [Given(@"clique no icone para Baixar Parcela")]
        public void GivenCliqueNoIconeParaBaixarParcela()
        {
            gfd.CliqueIconeBaixarDespesa();
        }

        [Given(@"selecione a conta bancaria de pagamento \{'(.*)'}")]
        public void GivenSelecioneAContaBancariaDePagamento(string contaBancaria)
        {
            gfd.SelecionarContaBancariaPagamento(contaBancaria);
        }

        [Given(@"selecione o caixa recebido \('(.*)'\)")]
        public void GivenSelecioneOCaixaRecebido(string caixa)
        {
            gfd.SelectCaixaRecebidoCheque(caixa);
        }

        [Given(@"informe a data de entrada do cheque em caixa")]
        public void GivenInformeADataDeEntradaDoChequeEmCaixa()
        {
            gfd.InformeDataEntradaChequeEmCaixa();
        }

        [When(@"selecione o caixa recebido \('(.*)'\)")]
        public void WhenSelecioneOCaixaRecebido(string caixa)
        {
            gfd.SelectCaixaRecebidoCheque(caixa);
        }

        [When(@"informe a data de entrada do cheque em caixa")]
        public void WhenInformeADataDeEntradaDoChequeEmCaixa()
        {
            gfd.InformeDataEntradaChequeEmCaixa();
        }

        [When(@"clicar no botao da header Novo Cheque Proprio")]
        public void WhenClicarNoBotaoDaHeaderNovoChequeProprio()
        {
            gfd.CliqueNovoLancarNovoChequeProprioViaIndex();
        }


    }
}
