using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util.FIN;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class GestorFinanceiroReceitaSteps
    {
        GestorFinanceiroReceitaUtil gfu = new GestorFinanceiroReceitaUtil();
        
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

        [Given(@"clique no botao Açoes")]
        public void GivenCliqueNoBotaoAcoes()
        {
            gfu.CliqueMenuAcoes();
        }

        [Given(@"clique no botao Renegociar")]
        public void GivenCliqueNoBotaoRenegociar()
        {
            gfu.CliqueMenuRenegociar();
        }

        [Given(@"seja redirecionado para tela de renegociacao")]
        public void GivenSejaRedirecionadoParaTelaDeRenegociacao()
        {
            gfu.URLRenegociacao();
        }

        [Given(@"memorize o valor liquido a renegociar do input")]
        public void GivenMemorizeOValorLiquidoARenegociarDoInput()
        {
            gfu.MemorizarValorLiquidoRenegociar();
        }

        [Given(@"acesse a url\{'(.*)'}")]
        public void GivenAcesseAUrlDeContratos(string url)
        {
            gfu.GoToUrl(url);
        }

        [When(@"inserir no input Data de Vencimento \{(.*)} dias RETROATIVOS")]
        public void WhenInserirNoInputDataDeVencimentoDiasRETROATIVOS(int diasVencidos)
        {
            gfu.AddDataVencimentoRetroativaContratoManual(diasVencidos);
        }

        [When(@"acesse a url\{'(.*)'}")]
        public void WhenAcesseAUrlDeContratos(string url)
        {
            gfu.GoToUrl(url);
        }

        [When(@"que clica na aba Contas a Receber")]
        public void WhenQueClicaNaAbaContasAReceber()
        {
            gfu.CliqueAbaContasReceber();
        }

        [When(@"clique na pesquisa")]
        public void WhenCliqueNaPesquisa()
        {
            gfu.CliquePesquisaGestorFin();
        }

        [When(@"clique para limpar filtros")]
        public void WhenCliqueParaLimparFiltros()
        {
            gfu.CliqueLimparFiltros();
        }

        [When(@"clique no botao Filtrar Receitas")]
        public void WhenCliqueNoBotaoFiltrarReceitas()
        {
            gfu.CliqueFiltrarReceitas();
        }

        [When(@"o numero de parcelas filtradas seja maior que \{(.*)}")]
        public void WhenONumeroDeParcelasFiltradasSejaMaiorQue(int quantidadeParcelas)
        {
            gfu.ValidaQuantidadeParcelasReceitasFiltradas(quantidadeParcelas);
        }

        [When(@"o vencimento da parcela seja retroativo a data atual")]
        public void WhenOVencimentoDaParcelaSejaRetroativoADataAtual()
        {
            gfu.ValidaVencimentoParcelaRetroativoDataAtual();
        }

        [When(@"selecione a primeira parcela listada")]
        public void WhenSelecioneAPrimeiraParcelaListada()
        {
            gfu.SelecionarPrimeiraParcelaListada();
        }

        [When(@"clique no botao movimentar parcela")]
        public void WhenCliqueNoBotaoMovimentarParcela()
        {
            gfu.CliqueMovimentarParcelaSelecionada();
        }

        [When(@"o valor a ser movimentado seja maior que zero")]
        public void WhenOValorASerMovimentadoSejaMaiorQueZero()
        {
            gfu.ValidaValorParcelasSelecionadas();
        }

        [When(@"clique no icone Baixar Parcela")]
        public void WhenCliqueNoIconeBaixarParcela()
        {
            gfu.CliqueIconeBaixarParcelas();
        }

        [When(@"seja redirecionado para /FIN/Contrato/ListarParcelasBaixa")]
        public void WhenSejaRedirecionadoParaFINContratoListarParcelasBaixa()
        {
            gfu.ValidaRedirecionamentoListarParcelasBaixa();
        }

        [When(@"clique no collapse para exibir meio pagamento parcela")]
        public void WhenCliqueNoCollapseParaExibirMeioPagamentoParcela()
        {
            gfu.CliqueCollapseExibirMeioPagamentoParcela();
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

        [When(@"inserir no input Data de Emissao do contrato \{(.*)} dias RETROATIVOS")]
        public void WhenInserirNoInputDataDeEmissaoDoContratoDiasRETROATIVOS(int dias)
        {
            gfu.DataEmissaoContratoRetroativa(dias);
        }


        [When(@"selecione o meio de pagamento \{'(.*)'}")]
        public void WhenSelecioneOMeioDePagamento(string meioPagamento)
        {
            gfu.SelectMeioPagamentoBaixaParcela(meioPagamento);
        }

        [When(@"selecione o primeiro meio de pagamento \{'(.*)'}")]
        public void WhenSelecioneOPrimeiroMeioDePagamento(string primeiroMeioPagamento)
        {
            gfu.SelecionarMeioPagamentoMultiplosMeios(primeiroMeioPagamento);
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

        [When(@"clique no botao Montar Renegociacao")]
        public void WhenCliqueNoBotaoMontarRenegociacao()
        {
            gfu.CliqueMontarRenegociacao();
        }

        [When(@"clique para adicionar parcela manualmente")]
        public void WhenCliqueParaAdicionarParcelaManualmente()
        {
            gfu.CliqueAddParcelaManualRenegociacao();
        }

        [When(@"insira no input data de vencimento data atual \+ \{(.*)} dias")]
        public void WhenInsiraNoInputDataDeVencimentoDataAtualDias(int dias)
        {
            gfu.InserirDataVencimentoContratoRenegocicao(dias);
        }

        [When(@"clique no botao Adicionar parcela")]
        public void WhenCliqueNoBotaoAdicionarParcela()
        {
            gfu.CliqueSalvarParcela();
        }

        [When(@"valida que a parcela foi inserida na data correta")]
        public void WhenValidaQueAParcelaFoiInseridaNaDataCorreta()
        {
            gfu.ValidaDataInseridaParcela();
        }

        [When(@"valida que o valor da parcela é o mesmo memorizado")]
        public void WhenValidaQueOValorDaParcelaEOMesmoMemorizado()
        {
            gfu.ValidaValorInseridoParcela();
        }

        [When(@"clique no botao Gerar Renegociacao")]
        public void WhenCliqueNoBotaoGerarRenegociacao()
        {
            gfu.CliqueGerarRenegociacao();
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

        [Then(@"o sistema redireciona para index de visualizar contrato")]
        public void ThenOSistemaRedirecionaParaIndexDeVisualizarContrato()
        {
            gfu.ValidaUrlVisualizarContrato();
        }

        [Then(@"valide o valor bruto a pagar da parcela substituida")]
        public void ThenValideOValorBrutoAPagarDaParcelaSubstituida()
        {
            gfu.ValidaValorBrutoParcelaSubstituidaNoViewContrato();
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

        [Then(@"data de vencimento e data movimento devem ser iguais")]
        public void ThenDataDeVencimentoEDataMovimentoDevemSerIguais()
        {
            gfu.ValidaDataVencimentoEMovimento();
        }

        [Then(@"os juros devem ser zerados")]
        public void ThenOsJurosDevemSerZerados()
        {
            gfu.ValidaJurosZerados();
        }

    }
}
