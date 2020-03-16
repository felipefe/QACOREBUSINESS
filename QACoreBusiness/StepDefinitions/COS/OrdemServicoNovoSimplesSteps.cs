using QACoreBusiness.Util.COS;
using System;
using TechTalk.SpecFlow;

namespace QACoreBusiness.StepDefinitions.COS
{
    [Binding]
    public class OrdemServicoNovoSimplesSteps
    {
        OrdemServicoNovoSimplesUtil osns = new OrdemServicoNovoSimplesUtil();

        [Given(@"que seja clicado no botao Novo Simples")]
        public void GivenQueSejaClicadoNoBotaoNovoSimples()
        {
            osns.CriarNovoSimples();
        }
        
        [Given(@"seja selecionado o tipo de OS \{'(.*)'}")]
        public void GivenSejaSelecionadoOTipoDeOS(string tipoOS)
        {
            osns.SelectTipoOS(tipoOS);
        }
        
        [Given(@"seja seleciona a pessoa \{'(.*)'}")]
        public void GivenSejaSelecionaAPessoa(string pessoaOS)
        {
            osns.SelectPessoaOS(pessoaOS);
        }
        
        [Given(@"seja informado no input o prazo final para \{(.*)} dias futuros")]
        public void GivenSejaInformadoNoInputOPrazoFinalParaDiasFuturos(int dias)
        {
            osns.InserePrazoFinalNovoSimples(dias);
        }
        
        [Given(@"seja informado no textarea um Resumo \{'(.*)'}")]
        public void GivenSejaInformadoNoTextareaUmResumo(string resumo)
        {
            osns.InsereResumoNovoSimples(resumo);
        }
        
        [Given(@"seja informado no textarea uma Observacao \{'(.*)'}")]
        public void GivenSejaInformadoNoTextareaUmaObservacao(string observacao)
        {
            osns.InsereObservacaoNovoSimples(observacao);
        }
        
        [Given(@"que seja clicado Excluir nas actions da OS")]
        public void GivenQueSejaClicadoExcluirNasActionsDaOS()
        {
            osns.CliqueActionsExcluirOrdemServico();
        }
        
        [Given(@"seja inserido no textarea uma justificativa \{'(.*)'}")]
        public void GivenSejaInseridoNoTextareaUmaJustificativa(string justificativa)
        {
            osns.InserirJustificativaExcluirOS(justificativa);
        }

        [Given(@"tenha uma ordem de serviço com status \{'(.*)'}")]
        public void GivenTenhaUmaOrdemDeServicoComStatus(string status)
        {
            osns.ValidaOrdemServicoStatus(status);
        }

        [Given(@"coluna Itens Finalizados como \{'(.*)'}")]
        public void GivenColunaItensFinalizadosComo(string isItensFinalizados)
        {
            osns.ValidaItensIsFinalizados(isItensFinalizados);
        }

        [Given(@"que seja clicado Editar nas actions da OS")]
        public void GivenQueSejaClicadoEditarNasActionsDaOS()
        {
            osns.CliqueActionsEditarOrdemServico();
        }

        [Given(@"seja clicado no botao Novo Item")]
        public void GivenSejaClicadoNoBotaoNovoItem()
        {
            osns.CliqueNovoItemOrdemServico();
        }

        [Given(@"seja informado no select a receita \{'(.*)'}")]
        public void GivenSejaInformadoNoSelectAReceita(string nomeReceita)
        {
            osns.SelecionarReceita(nomeReceita);
        }

        [Given(@"seja informado o multiplicador da receita \{(.*)}")]
        public void GivenSejaInformadoOMultiplicadorDaReceita(int multiplicador)
        {
            osns.InformarMultiplicadorReceita(multiplicador);
        }

        [Given(@"que seja clicado Manutenção de Itens nas actions da OS")]
        public void GivenQueSejaClicadoManutencaoDeItensNasActionsDaOS()
        {
            osns.CliqueActionsManutencaoItensOrdemServico();
        }

        [Given(@"seja redirecionado para /COS/Agrupador/ManutencaoItensOS/")]
        public void GivenSejaRedirecionadoParaCOSAgrupadorManutencaoItensOS()
        {
            osns.ValidaUrlAgrupadorManutencaoItens();
        }

        [Given(@"clicar no botao Salvar novo simples")]
        public void GivenClicarNoBotaoSalvarNovoSimples()
        {
            osns.CliqueSalvarNovoSimples();
        }

        [Given(@"o sistema deve redirecionar para o edit da OS criada")]
        public void GivenOSistemaDeveRedirecionarParaOEditDaOSCriada()
        {
            osns.ValidaUrlEditOrdemServico();
        }

        [Given(@"seja clicado no botao Salvar OS")]
        public void GivenSejaClicadoNoBotaoSalvarOS()
        {
            osns.CliqueSalvarNovoSimples();
        }

        [Given(@"clicar no botao Salvar item O\.S")]
        public void GivenClicarNoBotaoSalvarItemO_S()
        {
            osns.CliqueBotaoSalvarItemOS();
        }

        [Given(@"o sistema redireciona para /COS/OrdemServicoItem/Edit/")]
        public void GivenOSistemaRedirecionaParaCOSOrdemServicoItemEdit()
        {
            osns.ValidaUrlOrdemServicoItemEdit();
        }

        [Given(@"clique Encaminhar nas actions da OS")]
        public void GivenCliqueEncaminharNasActionsDaOS()
        {
            osns.CliqueActionsEncaminhar();
        }

        [Given(@"selecione a situação \{'(.*)'}")]
        public void GivenSelecioneASituacao(string situacao)
        {
            osns.SelecioneNovaSituacao(situacao);
        }

        [Given(@"selecione o Grupo de usuário \{'(.*)'}")]
        public void GivenSelecioneOGrupoDeUsuario(string grupo)
        {
            osns.SelecioneGrupoUsuario(grupo);
        }

        [Given(@"clique no botao Encaminhar")]
        public void GivenCliqueNoBotaoEncaminhar()
        {
            osns.CliqueBotaoEncaminhar();
        }

        [Given(@"valide que a situacao da OS esteja na situacao encaminhada")]
        public void GivenValideQueASituacaoDaOSEstejaNaSituacaoEncaminhada()
        {
            osns.ValideSituacaoEncaminhadaOS();
        }

        [Given(@"clicar na flag para Marcar Todos")]
        public void GivenClicarNaFlagParaMarcarTodos()
        {
            osns.CliqueBotaoMarcarTodos();
        }

        [Given(@"clicar no botao Reservar/Requisitar Insumos")]
        public void GivenClicarNoBotaoReservarRequisitarInsumos()
        {
            osns.CliqueBotaoReservarInsumos();
        }

        [Given(@"validar que a Qtd\. Reservada deve ser a mesma que Qtd\. Receita")]
        public void GivenValidarQueAQtd_ReservadaDeveSerAMesmaQueQtd_Receita()
        {
            osns.ValidaQntidadeReservadaInsumos();
        }

        [Given(@"clicar no botao Separar Insumos")]
        public void GivenClicarNoBotaoSepararInsumos()
        {
            osns.CliqueBotaoSepararInsumos();
        }

        [Given(@"o status dos insumos devem ser \{'(.*)'}")]
        public void GivenOStatusDosInsumosDevemSer(string status)
        {
            osns.ValidaStatusSeparadoInsumos(status);
        }

        [When(@"que seja clicado Manutenção de Itens nas actions da OS")]
        public void WhenQueSejaClicadoManutencaoDeItensNasActionsDaOS()
        {
            osns.CliqueActionsManutencaoItensOrdemServico();
        }

        [When(@"seja redirecionado para /COS/Agrupador/ManutencaoItensOS/")]
        public void WhenSejaRedirecionadoParaCOSAgrupadorManutencaoItensOS()
        {
            osns.ValidaUrlAgrupadorManutencaoItens();
        }

        [When(@"que seja clicado Editar nas actions da OS")]
        public void WhenQueSejaClicadoEditarNasActionsDaOS()
        {
            osns.CliqueActionsEditarOrdemServico();
        }

        [When(@"o status dos insumos devem ser \{'(.*)'}")]
        public void WhenOStatusDosInsumosDevemSer(string status)
        {
            osns.ValidaStatusSeparadoInsumos(status);
        }


        [When(@"clicar no botao Salvar novo simples")]
        public void WhenClicarNoBotaoSalvarNovoSimples()
        {
            osns.CliqueSalvarNovoSimples();
        }
        
        [When(@"clicar no botao Cancelar O\.S\.")]
        public void WhenClicarNoBotaoCancelarO_S_()
        {
            osns.CliqueBotaoCancelarOS();
        }

        [When(@"clicar no botao Salvar item O\.S")]
        public void WhenClicarNoBotaoSalvarItemO_S()
        {
            osns.CliqueBotaoSalvarItemOS();
        }

        [When(@"clicar no botao Reservar/Requisitar Insumos")]
        public void WhenClicarNoBotaoReservarRequisitarInsumos()
        {
            osns.CliqueBotaoReservarInsumos();
        }

        [When(@"clicar no botao Separar Insumos")]
        public void WhenClicarNoBotaoSepararInsumos()
        {
            osns.CliqueBotaoSepararInsumos();
        }

        [When(@"clicar na flag para Marcar Todos")]
        public void WhenClicarNaFlagParaMarcarTodos()
        {
            osns.CliqueBotaoMarcarTodos();
        }

        [When(@"validar que a Qtd\. Reservada deve ser a mesma que Qtd\. Receita")]
        public void WhenValidarQueAQtd_ReservadaDeveSerAMesmaQueQtd_Receita()
        {
            osns.ValidaQntidadeReservadaInsumos();
        }

        [When(@"for clicado no botao Executar Tudo")]
        public void WhenForClicadoNoBotaoExecutarTudo()
        {
            osns.CliqueBotaoExecutarTudo();
        }

        [When(@"espere por \{(.*)} segundos ate ser processado")]
        public void WhenEsperePorSegundosAteExecutarTudo(int segundos)
        {
            osns.EspereXSegundosAteExecutarOS(segundos);
        }

        [When(@"desmarque a opção Tentar Finalizar itens")]
        public void WhenDesmarqueAOpcaoTentarFinalizarItens()
        {
            osns.DesmarqueTentarFinalizarItensAoExecutarTudo();
        }

        [When(@"confirmar clicando no botao Confirmar Execuções da modal")]
        public void WhenConfirmarClicandoNoBotaoConfirmarExecucoesDaModal()
        {
            osns.CliqueConfirmarExecutarTudoModal();
        }

        [When(@"clique Encaminhar nas actions da OS")]
        public void WhenCliqueEncaminharNasActionsDaOS()
        {
            osns.CliqueActionsEncaminhar();
        }

        [When(@"selecione a situação \{'(.*)'}")]
        public void WhenSelecioneASituacao(string situacao)
        {
            osns.SelecioneNovaSituacao(situacao);
        }

        [When(@"selecione o Grupo de usuário \{'(.*)'}")]
        public void WhenSelecioneOGrupoDeUsuario(string grupo)
        {
            osns.SelecioneGrupoUsuario(grupo);
        }

        [When(@"clique no botao Encaminhar")]
        public void WhenCliqueNoBotaoEncaminhar()
        {
            osns.CliqueBotaoEncaminhar();
        }

        [When(@"valide que a situacao da OS esteja na situacao encaminhada")]
        public void WhenValideQueASituacaoDaOSEstejaNaSituacaoEncaminhada()
        {
            osns.ValideSituacaoEncaminhadaOS();
        }

        [When(@"valide que o pedido foi gerado pela OS")]
        public void WhenValideQueOPedidoFoiGeradoPelaOS()
        {
            osns.ValidaPedidoGeradoPelaOS();
        }

        [When(@"que sua situação seja \{'(.*)'}")]
        public void WhenQueSuaSituacaoSeja(string situacao)
        {
            osns.ValidaSituacaoPedidoGeradoOS(situacao);
        }


        [When(@"memorize o numero da OS")]
        public void WhenMemorizeONumeroDaOS()
        {
            osns.MemorizarNumeroOrdemServico();
        }

        [When(@"clique nas actions Finalizar O\.S/O\.P")]
        public void WhenCliqueNasActionsFinalizarO_SO_P()
        {
            osns.CliqueActionsFinalizarOS();
        }

        [When(@"informe no textArea uma mensagem de Conclusão \{'(.*)'}")]
        public void WhenInformeNoTextAreaUmaMensagemDeConclusao(string conclusao)
        {
            osns.InformeTextoConclusao(conclusao);
        }

        [When(@"marque a flag para Tentar Finalizar Todos os Itens")]
        public void WhenMarqueAFlagParaTentarFinalizarTodosOsItens()
        {
            osns.MarqueFinalizarTodosItensAoFinalizarOS();
        }

        [When(@"confirme clicando no botao Finalizar OS")]
        public void WhenConfirmeClicandoNoBotaoFinalizarOS()
        {
            osns.ConfirmarFinalizarOSModal();
        }

        [When(@"clique no botao da Header Gerenciar O\.S")]
        public void WhenCliqueNoBotaoDaHeaderGerenciarO_S()
        {
            osns.CliqueHeaderGerenciarOSs();
        }

        [When(@"informar no input a Qtd Reservar \{(.*)}")]
        public void WhenInformarNoInputAQtdReservar(decimal qtdReservar)
        {
            osns.InformarQntdReservarManutencaoItens(qtdReservar);
        }

        [When(@"for clicado no botao Produzir Tudo")]
        public void WhenForClicadoNoBotaoProduzirTudo()
        {
            osns.CliqueBotaoProduzirTudo();
        }

        [When(@"confirmar clicando no botao Produzir tudo\(em cadeia\)")]
        public void WhenConfirmarClicandoNoBotaoProduzirTudoEmCadeia()
        {
            osns.ConfirmeProduzirTudoModal();
        }

        [When(@"clique para editar item de OS")]
        public void WhenCliqueParaEditarItemDeOS()
        {
            osns.CliqueEditarItemOrdemServico();
        }

        [When(@"clique no botao Concluir Item")]
        public void WhenCliqueNoBotaoConcluirItem()
        {
            osns.CliqueBotaoConcluirItem();
        }

        [When(@"confirme clicando no botao Concluir da modal")]
        public void WhenConfirmeClicandoNoBotaoConcluirDaModal()
        {
            osns.ConfirmeConcluirItemModal();
        }

        [When(@"o sistema deve redirecionar para o edit da OS criada")]
        public void WhenOSistemaDeveRedirecionarParaOEditDaOSCriada()
        {
            osns.ValidaUrlEditOrdemServico();
        }

        [When(@"marcar a flag Alterar Qtd\. dos Insumos ao Reservar")]
        public void WhenMarcarAFlagAlterarQtd_DosInsumosAoReservar()
        {
            osns.MarcarFlagalterarQtdDosInsumosReservar();
        }

        [When(@"clique nas actions para Confirmar Execuçao")]
        public void WhenCliqueNasActionsParaConfirmarExecucao()
        {
            osns.CliqueActionsExecucoesConfirmar();
        }

        [When(@"clique nas actions da OS Criar Execuçoes")]
        public void WhenCliqueNasActionsDaOSCriarExecucoes()
        {
            osns.CliqueActionsCriarExecucoes();
        }

        [When(@"confirme clicando no botao Criar Execuçoes")]
        public void WhenConfirmeClicandoNoBotaoCriarExecucoes()
        {
            osns.ConfirmeCriarExecucoes();
        }

        [When(@"clique Confirmar no botao da modal")]
        public void WhenCliqueConfirmarNoBotaoDaModal()
        {
            osns.CliqueConfirmarBotaoModal();
        }

        [When(@"clicar no botao Executar")]
        public void WhenClicarNoBotaoExecutar()
        {
            osns.CliqueBotaoExecutarItemOS();
        }

        [When(@"marcar a flag Confirmar Execuçao")]
        public void WhenMarcarAFlagConfirmarExecucao()
        {
            osns.FlagConfirmarExecucoes();
        }

        [When(@"clicar no botao Salvar para executar")]
        public void WhenClicarNoBotaoSalvarParaExecutar()
        {
            osns.CliqueBotaoSalvarExecucao();
        }

        [When(@"valide que seja criada a execuçao")]
        public void WhenValideQueSejaCriadaAExecucao()
        {
            osns.ValidaCriouExecucoes();
        }

        [When(@"coluna Itens Finalizados como \{'(.*)'}")]
        public void WhenColunaItensFinalizadosComo(string isItensFinalizados)
        {
            osns.ValidaItensIsFinalizados(isItensFinalizados);
        }

        [Then(@"clique no botao Executar Triangular")]
        public void ThenCliqueNoBotaoExecutarTriangular()
        {
            osns.CliqueExecutarTriangular();
        }

        [Then(@"confirme clicando no botao Executar")]
        public void ThenConfirmeClicandoNoBotaoExecutar()
        {
            osns.ConfirmeClicandoBotaoExecutar();
        }

        [Then(@"uma mensagem Execução finalizada deve aparecer")]
        public void ThenUmaMensagemExecucaoFinalizadaDeveAparecer()
        {
            osns.MensagemExecucaoTriangularFinalizada();
        }

        [Then(@"valide que \{(.*)} pedidos foram gerados")]
        public void ThenValideQuePedidosForamGerados(int nPedidos)
        {
            osns.ValidaPedidosGeradosTriangular(nPedidos);
        }

        [Then(@"clique no botao CLIQUE AQUI para visualizar os pedidos gerados")]
        public void ThenCliqueNoBotaoCLIQUEAQUIParaVisualizarOsPedidosGerados()
        {
            osns.CliqueAquiParaVisualizarPedidos();
        }


        [Then(@"clique na aba Ordens de Serviço")]
        public void ThenCliqueNaAbaOrdensDeServico()
        {
            osns.CliqueAbaOrdensServico();
        }

        [Then(@"valide a OS que gerou o pedido")]
        public void ThenValideAOSQueGerouOPedido()
        {
            osns.ValidaOSQueGerouPedidoViewPedido();
        }


        [Then(@"validar que a Qtd\. Reservada deve ser a mesma que Qtd\. Total")]
        public void ThenValidarQueAQtd_ReservadaDeveSerAMesmaQueQtd_Total()
        {
            osns.ValidaQtdReservadaEQtdTotal();
        }

        [Then(@"validar que a Qtd\. a Reservar \+ Qtd\. Reservada deve ser a mesma que Qtd\. Total")]
        public void ThenValidarQueAQtd_AReservarQtd_ReservadaDeveSerAMesmaQueQtd_Total()
        {
            osns.ValidarQtdReservarMaisReservadaIgualTotal();
        }


        [Then(@"valide a OS memorizada")]
        public void ThenValideAOSMemorizada()
        {
            osns.ValidaCodigoOSMemorizada();
        }

        [Then(@"o status final da OS deve ser \{'(.*)'}")]
        public void ThenOStatusFinalDaOSDeveSer(string status)
        {
            osns.ValidaStatusOsByGerenciarOS(status);
        }

        [Then(@"o sistema redireciona para /COS/OrdemServicoItem/Edit/")]
        public void ThenOSistemaRedirecionaParaCOSOrdemServicoItemEdit()
        {
            osns.ValidaUrlOrdemServicoItemEdit();
        }

        [Then(@"o sistema deve redirecionar para o edit da OS criada")]
        public void ThenOSistemaDeveRedirecionarParaOEditDaOSCriada()
        {
            osns.ValidaUrlEditOrdemServico();
        }
        
        [Then(@"a OS deve ser excluida")]
        public void ThenAOSDeveSerExcluida()
        {
            osns.ValidaExclusaoOS();
        }

        [Then(@"o status dos insumos devem ser \{'(.*)'}")]
        public void ThenOStatusDosInsumosDevemSer(string status)
        {
            osns.ValidaStatusSeparadoInsumos(status);
        }

        [Then(@"espere por \{(.*)} segundos ate ser processado")]
        public void ThenEsperePorSegundosAteSerProcessado(int seg)
        {
            osns.EspereXSegundosAteExecutarOS(seg);
        }

        [Then(@"selecione o tipo de OS \{'(.*)'}")]
        public void ThenSelecioneOTipoDeOS(string tipoOS)
        {
            osns.SelectTipoOSParaTriangular(tipoOS);
        }


    }
}
