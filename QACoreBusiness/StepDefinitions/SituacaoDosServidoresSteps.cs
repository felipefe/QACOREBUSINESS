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

        [Given(@"acesse a index de Situacao dos Servidores")]
        public void GivenAcesseAIndexDeSituacaoDosServidores()
        {
            ssu.IndexSituacaoServidores();
        }

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
            Thread.Sleep(1000);
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
        
        [Then(@"a situacao deve ser alterada para \{'(.*)'}")]
        public void ThenASituacaoDeveSerAlteradaPara(string novaSituacao)
        {
            ssu.NovaSitualCoreService(novaSituacao);
        }

    }
}
