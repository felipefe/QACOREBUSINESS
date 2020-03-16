using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util.COM;

namespace QACoreBusiness.StepDefinitions.COM
{
    [Binding]
    public class RequisicoesSteps
    {
        RequisitarUtil ru = new RequisitarUtil();

        [When(@"clique no botao da header Requisitar itens não reservados")]
        public void WhenCliqueNoBotaoDaHeaderRequisitarItensNaoReservados()
        {
            ru.CliqueRequisitarItensNaoReservados();
        }

        [When(@"clique no botao executar para gerar requisiçoes")]
        public void WhenCliqueNoBotaoExecutarParaGerarRequisicoes()
        {
            ru.CliqueExecutarGerarRequisicoes();
        }

        [When(@"armazene o numero do pedido")]
        public void WhenArmazeneONumeroDoPedido()
        {
            ru.ArmazeneNumeroPedido();
        }

        [When(@"valide a requisição gerada atraves do numero do pedido")]
        public void WhenValideARequisicaoGeradaAtravesDoNumeroDoPedido()
        {
            ru.ValideRequicaoGeradaByNumPedido();
        }

        [When(@"a situacao da requisicao deve ser \{'(.*)'}")]
        public void WhenASituacaoDaRequisicaoDeveSer(string situacao)
        {
            ru.ValidaRequisicaoGeradaBySituacao(situacao);
        }

        [When(@"clique nas actions Gerar OS de Producao")]
        public void WhenCliqueNasActionsGerarOSDeProducao()
        {
            ru.CliqueGerarOSProducao();
        }

        [When(@"confirme clicando no botao Gerar Producao da modal")]
        public void WhenConfirmeClicandoNoBotaoGerarProducaoDaModal()
        {
            ru.CliqueGerarProducaoModal();
        }

        [When(@"clique nas actions Detalhes da Requisicao")]
        public void WhenCliqueNasActionsDetalhesDaRequisicao()
        {
            ru.CliqueActionsDetalhesRequisicao();
        }

        [When(@"memorize o numero da OS Gerada pela requicao")]
        public void WhenMemorizeONumeroDaOSGeradaPelaRequicao()
        {
            ru.MemorizeNumeroOSGerada();
        }

        [When(@"valide o numero da OS Gerada pela requisicao")]
        public void WhenValideONumeroDaOSGeradaPelaRequisicao()
        {
            ru.ValideNumeroOSGerada();
        }

        [When(@"armazene o codigo da requisicao")]
        public void WhenArmazeneOCodigoDaRequisicao()
        {
            ru.ArmazeneCodigoRequisicao();
        }

        [Then(@"validar o numero da requisicao armazenada")]
        public void ThenValidarONumeroDaRequisicaoArmazenada()
        {
            ru.ValidaNumRequisicaoAtendida();
        }

        [Then(@"a situacao da requisicao deve ser \{'(.*)'}")]
        public void ThenASituacaoDaRequisicaoDeveSer(string situacao)
        {
            ru.ValidaRequisicaoGeradaBySituacao(situacao);
        }

    }
}
