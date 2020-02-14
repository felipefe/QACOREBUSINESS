using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util.FIN;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class GestorFinanceiroReceitaSteps
    {
        GestorFinanceiroReceitaUtil gfu = new GestorFinanceiroReceitaUtil();

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

        [Given(@"selecione a conta bancaria \{'(.*)'}")]
        public void GivenSelecioneAContaBancaria(string conta)
        {
            gfu.SelecionarContaBancaria(conta);
        }

        [Given(@"o vencimento da parcela seja retroativo a data atual")]
        public void GivenOVencimentoDaParcelaSejaRetroativoADataAtual()
        {
            gfu.ValidaVencimentoParcelaRetroativoDataAtual();
        }

        [When(@"clique no botao Adicionar Multiplos Meios de Pagamento")]
        public void WhenCliqueNoBotaoAdicionarMultiplosMeiosDePagamento()
        {
            gfu.CliqueBotaoAdicionarMultiplosMeiosPagamento();
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

        [When(@"selecione o segundo meio de pagamento \{'(.*)'}")]
        public void WhenSelecioneOSegundoMeioDePagamento(string segundoMeio)
        {
            gfu.SelecionarSegundoMeioPagamentoMultiplosMeios(segundoMeio);
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

        [When(@"ratear o valor exibido no input por \{(.*)}")]
        public void WhenRatearOValorExibidoNoInputPor(int rateio)
        {
            gfu.RatearValorParcela(rateio);
        }

        [When(@"seja validado o valor do rateio")]
        public void WhenSejaValidadoOValorDoRateio()
        {
            gfu.ValidaValorAddMultiplosMeio();
        }

        [When(@"valide que o resto do rateio seja inserido no input")]
        public void WhenValideQueORestoDoRateioSejaInseridoNoInput()
        {
            gfu.ValidaValorRateioInseridoInput();
        }

        [When(@"seja validado o resto do rateio")]
        public void WhenSejaValidadoORestoDoRateio()
        {
            gfu.ValidaRestoRateioSegundoMeio();
        }

        [When(@"informar o planos de contas do segundo meio \{'(.*)'}")]
        public void WhenInformarOPlanosDeContasDoSegundoMeio(string pc)
        {
            gfu.SelectSegundoPlanoContasMeioPagamento(pc);
        }

        [When(@"informar o centro de custo do segundo meio \{'(.*)'}")]
        public void WhenInformarOCentroDeCustoDoSegundoMeio(string cc)
        {
            gfu.SelectSegundoCentroCusto(cc);
        }

        [When(@"informar no input o historico do segundo meio \{'(.*)'}")]
        public void WhenInformarNoInputOHistoricoDoSegundoMeio(string historico)
        {
            gfu.InformarSegundoHistoricoMultiplosMeios(historico);
        }

        [When(@"clicar no botao Adicionar para segundo multiplos meios de pagamento")]
        public void WhenClicarNoBotaoAdicionarParaSegundoMultiplosMeiosDePagamento()
        {
            gfu.CliqueSalvarSegundoMeioPagamento();
        }

        [When(@"selecione a conta bancaria do segundo meio de pagamento \{'(.*)'}")]
        public void WhenSelecioneAContaBancariaDoSegundoMeioDePagamento(string contaBancaria)
        {
            gfu.SelecionarContaBancariaSegundoMeio(contaBancaria);
        }

        [When(@"clicar no botao Editar Valor / Data Movimento")]
        public void WhenClicarNoBotaoEditarValorDataMovimento()
        {
            gfu.CliqueBotaoEditarJurosMulta();
        }

        [When(@"memorizar o valor do juros/multa")]
        public void WhenMemorizarOValorDoJurosMulta()
        {
            gfu.MemorizarValorJurosMulta();
        }

        [When(@"memorizar o valor original da parcela")]
        public void WhenMemorizarOValorOriginalDaParcela()
        {
            gfu.MemorizarValorOriginalParcela();
        }

        [When(@"validar que o valor liquido a pagar seja maior que o valor original da parcela")]
        public void WhenValidarQueOValorLiquidoAPagarSejaMaiorQueOValorOriginalDaParcela()
        {
            gfu.ValidaValorLiquidoMaiorQueValorOriginal();
        }

        [When(@"alterar o valor a pagar para o valor original")]
        public void WhenAlterarOValorAPagarParaOValorOriginal()
        {
            gfu.EditarValorPagarParcelaJurosMulta();
        }

        [When(@"desabilitar a flag de baixa parcial")]
        public void WhenDesabilitarAFlagDeBaixaParcial()
        {
            gfu.DesabilitarFlagBaixaParcial();
        }

        [When(@"clicar no botao Gravar")]
        public void WhenClicarNoBotaoGravar()
        {
            gfu.ClicarGravarDescontoJurosMulta();
        }

        [When(@"clicar no botao Alterar dados da baixa \(todas as parcelas\)")]
        public void WhenClicarNoBotaoAlterarDadosDaBaixaTodasAsParcelas()
        {
            gfu.CliqueAlterarDadosBaixaParcela();
        }

        [When(@"marcar a flag Alterar Data de Pagamento para Data de vencimento")]
        public void WhenMarcarAFlagAlterarDataDePagamentoParaDataDeVencimento()
        {
            gfu.MarcarFlagAlterarDataMovimento();
        }

        [When(@"clicar no botao Alterar dados baixa")]
        public void WhenClicarNoBotaoAlterarDadosBaixa()
        {
            gfu.CliqueAlterarDadosBaixaModificados();
        }

        [Then(@"o sistema redireciona para imprimir movimentacao")]
        public void ThenOSistemaRedirecionaParaImprimirMovimentacao()
        {
            gfu.ValidaUrlImprimirMovimentacao();
        }

        [Then(@"o valor a pagar deve ser o mesmo que valor original")]
        public void ThenOValorAPagarDeveSerOMesmoQueValorOriginal()
        {
            gfu.ValorPagarIgualValorOriginal();
        }

        [Then(@"o valor do desconto deve ser o mesmo memorizado anteriormente")]
        public void ThenOValorDoDescontoDeveSerOMesmoMemorizadoAnteriormente()
        {
            gfu.ValidaValorDesconto();
        }

        [Then(@"clicar no botao Efetuar Baixa")]
        public void ThenClicarNoBotaoEfetuarBaixa()
        {
            gfu.CliqueBotaoEfetuarBaixa();
        }
    }
}
