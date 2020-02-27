using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util;
using System.Threading;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class SituacaoDosServidoresSteps
    {
        SituacaoDosServidoresUtil ssu = new SituacaoDosServidoresUtil();

        [Given(@"seja redirecionado para URL de situacao dos servidores")]
        public void GivenSejaRedirecionadoParaURLDeSituacaoDosServidores()
        {
            ssu.ValidarURLServiceStatus();
        }

        [Given(@"eu clicar para Parar o Serviço")]
        public void GivenEuClicarParaPararOServico()
        {
            ssu.CliqueIniciarOuPararCoreService();
        }

        [Given(@"a situacao ser alterada para \{'(.*)'}")]
        public void GivenASituacaoSerAlteradaPara(string novaSituacao)
        {
            ssu.NovaSitualCoreService(novaSituacao);
        }

        [Given(@"que a situacao do coreservice seja \{'(.*)'}")]
        public void GivenQueASituacaoDoCoreserviceSeja(string situacao)
        {
            ssu.SituacaoAtualCoreService(situacao);
        }
        
        [When(@"eu clicar para Iniciar o Serviço")]
        public void WhenEuClicarParaIniciarOServico()
        {
            ssu.CliqueIniciarOuPararCoreService();
        }

        [When(@"clicar no botao Limpar Mensagens do COREService")]
        public void WhenClicarNoBotaoLimparMensagensDoCOREService()
        {
            ssu.CliqueBotaoLimpar();
        }

        [When(@"confirme clicando sim na modal aberta")]
        public void WhenConfirmeClicandoSimNaPopupAberta()
        {
            ssu.CliqueConfirmaçaoModal();
        }

        [When(@"seja redirecionado para tela UserTask")]
        public void WhenSejaRedirecionadoParaTelaUserTask()
        {
            ssu.ValidarUrlUserTask();
        }

        [When(@"aguarde ate progresso de limpar hisporico seja concluido")]
        public void WhenAguardeAteProgressoDeLimparHisporicoSeja()
        {
            ssu.ProgressoLimparCoreService();
        }

        [Then(@"clique no botao voltar")]
        public void ThenCliqueNoBotaoVoltar()
        {
            ssu.CliqueBotaoVoltar();
        }

        [Then(@"seja redirecionado para URL de situacao dos servidores")]
        public void ThenSejaRedirecionadoParaURLDeSituacaoDosServidores()
        {
            ssu.ValidarURLServiceStatus();
        }

        [Then(@"a situacao deve ser alterada para \{'(.*)'}")]
        public void ThenASituacaoDeveSerAlteradaPara(string novaSituacao)
        {
            ssu.NovaSitualCoreService(novaSituacao);
        }

    }
}
