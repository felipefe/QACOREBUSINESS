using QACoreBusiness.Util;
using TechTalk.SpecFlow;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class GerenciadorDeRelatoriosSteps
    {
        GerenciadorDeRelatoriosUtil gru = new GerenciadorDeRelatoriosUtil();

        [Given(@"acesse a index gerenciador de relatorios")]
        public void GivenAcesseAIndexGerenciadorDeRelatorios()
        {
            gru.AcesseContextoGerenciadorRelatorio();
        }
        
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

        [Given(@"clique nas actions deste relatorio Criar Relatorio A partir Desta Definição")]
        public void GivenCliqueNasActionsDesteRelatorioCriarRelatorioAPartirDestaDefinicao()
        {
            gru.CliqueActionsCriarRptApartirDestaDefinicao();
        }

        [Given(@"clique nas actions deste relatorio Editar Definiçao")]
        public void GivenCliqueNasActionsDesteRelatorioEditarDefinicao()
        {
            gru.CliqueActionEditarDefinicao();
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


  
    }
}
