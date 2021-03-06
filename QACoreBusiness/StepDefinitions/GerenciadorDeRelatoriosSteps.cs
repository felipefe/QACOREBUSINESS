﻿using QACoreBusiness.Util;
using TechTalk.SpecFlow;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class GerenciadorDeRelatoriosSteps
    {
        GerenciadorDeRelatoriosUtil gru = new GerenciadorDeRelatoriosUtil();
        
        [Given(@"que seja clicado no botao Definicoes de Relatorios")]
        public void GivenQueSejaClicadoNoBotaoDefinicoesDeRelatorios()
        {
            gru.CliqueDefinicoesDeRelatorios();
        }
        
        [Given(@"seja redirecionado para index de Definiçoes de Relatorios /RPT/Report")]
        public void GivenSejaRedirecionadoParaIndexDeDefinicoesDeRelatoriosRPTReport()
        {
            gru.ValidaUrlDefinicoesDeRelatorios();
        }
        
        [Given(@"seja clicado no botao carregar Definicao de Relatorio")]
        public void GivenSejaClicadoNoBotaoCarregarDefinicaoDeRelatorio()
        {
            gru.CliqueCarregarDefinicaoRelatorio();
        }
        
        [Given(@"seja clicado para fazer o upload")]
        public void GivenSejaClicadoParaFazerOUpload()
        {
            gru.CliqueSelectArquivoRpt();
        }
        
        [Given(@"selecione o arquivo rpt")]
        public void GivenSelecioneOArquivoRpt()
        {
            gru.SelecionarArquivoWindowsExplorer();
        }

        [Given(@"que eu tenha importado o relatorio de nome \{'(.*)'}")]
        public void GivenQueEuTenhaImportadoORelatorioDeNome(string nomeRelatorio)
        {
            gru.RelatorioIsImportado(nomeRelatorio);
        }

        [Given(@"clique nas actions relatorio \{'(.*)'} Editar Definiçao")]
        public void GivenCliqueNasActionsRelatorioEditarDefinicao(string report)
        {
            gru.CliqueActionEditarDefinicao(report);
        }


        [Given(@"seja redirecionado para tela de edicao do rpt /RPT/ReportView/EditBuilder/")]
        public void GivenSejaRedirecionadoParaTelaDeEdicaoDoRptRPTReportViewEditBuilder()
        {
            gru.ValidaUrlEditarDefinicaoRpt();
        }

        [Given(@"clique na aba Colunas")]
        public void GivenCliqueNaAbaColunas()
        {
            gru.CliqueAbaColunasRPT();
        }

        [Given(@"que eu tenha relatorio de nome \{'(.*)'}")]
        public void GivenQueEuTenhaRelatorioDeNome(string nomeRPT)
        {
            gru.ReportExiste(nomeRPT);
        }

        [Given(@"clique nas actions deste relatorio Excluir")]
        public void GivenCliqueNasActionsDesteRelatorioExcluir()
        {
            gru.ActionsExcluirRelatorio();
        }

        [Given(@"que seja clicado no menu do usuario logado")]
        public void GivenQueSejaClicadoNoMenuDoUsuarioLogado()
        {
            gru.CliqueMenuUsuarioLogado();
        }

        [Given(@"clique no botao Relatorios")]
        public void GivenCliqueNoBotaoRelatorios()
        {
            gru.CliqueMenuUsuarioRelatorios();
        }

        [Given(@"seja redirecionado para Meus Relatorios /RPT/ReportView/UserReportViews")]
        public void GivenSejaRedirecionadoParaMeusRelatoriosRPTReportViewUserReportViews()
        {
            gru.ValidaUrlMeusRelatorios();
        }

        [Given(@"memorize as colunas marcadas do Editar Definicao")]
        public void GivenMemorizeAsColunasMarcadasDoEditarDefinicao()
        {
            gru.MemorizarColunasMarcadas();
        }

        [Given(@"clicar no botao Carregar rpt")]
        public void GivenClicarNoBotaoCarregarRpt()
        {
            gru.CarregarRptSelecionado();
        }

        [Given(@"clique nas actions relatorio \('(.*)'\) Criar Relatorio A partir Desta Definição")]
        public void GivenCliqueNasActionsRelatorioCriarRelatorioAPartirDestaDefinicao(string rpt)
        {
            gru.CliqueActionsCriarRptApartirDestaDefinicao(rpt);
        }

        [Given(@"clicar no botao Salvar relatorio")]
        public void GivenClicarNoBotaoSalvarRelatorio()
        {
            gru.SalvarRptApartirDestaDefinicao();
        }

        [Given(@"seja redirecionado para index de Gerenciador de relatorio /RPT/ReportView")]
        public void GivenSejaRedirecionadoParaIndexDeGerenciadorDeRelatorioRPTReportView()
        {
            gru.ValidaUrlGerenciadorDeRelatorios();
        }

        [Given(@"selecionar todas as colunas possiveis")]
        public void GivenSelecionarTodasAsColunasPossiveis()
        {
            gru.SelecionarColunasEditDefinicao();
        }

        [Given(@"clicar no botao Gravar denificao editada")]
        public void GivenClicarNoBotaoGravarDenificaoEditada()
        {
            gru.CliqueGravarEditDefinicaoRpt();
        }


        [When(@"seja redirecionado para index de Definiçoes de Relatorios /RPT/Report")]
        public void WhenSejaRedirecionadoParaIndexDeDefinicoesDeRelatoriosRPTReport()
        {
            gru.ValidaUrlDefinicoesDeRelatorios();
        }

        [When(@"clique nas actions relatorio \('(.*)'\) Criar Relatorio A partir Desta Definição")]
        public void WhenCliqueNasActionsRelatorioCriarRelatorioAPartirDestaDefinicao(string rpt)
        {
            gru.CliqueActionsCriarRptApartirDestaDefinicao(rpt);
        }


        [When(@"clique na aba Colunas")]
        public void WhenCliqueNaAbaColunas()
        {
            gru.CliqueAbaColunasRPT();
        }

        [When(@"confirmar clicando no botao Excluir")]
        public void WhenConfirmarClicandoNoBotaoExcluir()
        {
            gru.ConfirmeExcluir();
        }

        [When(@"selecionar todas as colunas possiveis")]
        public void WhenSelecionarTodasAsColunasPossiveis()
        {
            gru.SelecionarColunasEditDefinicao();
        }

        [When(@"clicar no botao Gravar denificao editada")]
        public void WhenClicarNoBotaoGravarDenificaoEditada()
        {
            gru.CliqueGravarEditDefinicaoRpt();
        }

        [When(@"clicar no botao Carregar rpt")]
        public void WhenClicarNoBotaoCarregarRpt()
        {
            gru.CarregarRptSelecionado();
        }

        [When(@"clicar no botao Salvar relatorio")]
        public void WhenClicarNoBotaoSalvarRelatorio()
        {
            gru.SalvarRptApartirDestaDefinicao();
        }

        [When(@"clicar no botao executar relatorio")]
        public void WhenClicarNoBotaoExecutarRelatorio()
        {
            gru.CliqueExecutarRelatorio();
        }

        [When(@"ser redirecionado para Parametros de execucao /RPT/ReportView/OpenReportView/")]
        public void WhenSerRedirecionadoParaParametrosDeExecucaoRPTReportViewOpenReportView()
        {
            gru.ValidaUrlParametroExecucaoMeuRelatorio();
        }

        [When(@"clicar no botao Executar meu relatorio")]
        public void WhenClicarNoBotaoExecutarMeuRelatorio()
        {
            gru.CliqueVisualizarRelatorio();
        }

        [Then(@"o relatorio deve ser exibido em uma nova guia do navegador")]
        public void ThenORelatorioDeveSerExibidoEmUmaNovaGuiaDoNavegador()
        {
            gru.ValidaExibicaoRelatorio();
        }

        [Then(@"seja redirecionado para index de Gerenciador de relatorio /RPT/ReportView")]
        public void ThenSejaRedirecionadoParaIndexDeGerenciadorDeRelatorioRPTReportView()
        {
            gru.ValidaUrlGerenciadorDeRelatorios();
        }

        [Then(@"seja redirecionado para index de Definiçoes de Relatorios /RPT/Report")]
        public void ThenSejaRedirecionadoParaIndexDeDefinicoesDeRelatoriosRPTReport()
        {
            gru.ValidaUrlDefinicoesDeRelatorios();
        }

        [Then(@"o relatorio deve ser excluido e \{'(.*)'} nao aparecer na lista")]
        public void ThenORelatorioDeveSerExcluidoENaoAparecerNaLista(string nome)
        {
            gru.ValidaRelatorioFoiExcluido(nome);
        }

        [Then(@"as colunas marcadas devem ser as mesmas do Editar Definicao")]
        public void ThenAsColunasMarcadasDevemSerAsMesmasDoEditarDefinicao()
        {
            gru.ValidaColunasHabilitadas();
        }

    }
}
