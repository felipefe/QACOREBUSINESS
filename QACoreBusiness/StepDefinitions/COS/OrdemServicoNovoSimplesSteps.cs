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
    }
}
