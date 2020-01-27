using System;
using TechTalk.SpecFlow;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class PedidoAvaliacaoSteps
    {
        [Given(@"tenha um pedido criado na situaçao \{Avaliaçao}")]
        public void GivenTenhaUmPedidoCriadoNaSituacaoAvaliacao()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"que eu acesse as actions do pedido")]
        public void GivenQueEuAcesseAsActionsDoPedido()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"clique no botao Avaliaçao do Pedido")]
        public void GivenCliqueNoBotaoAvaliacaoDoPedido()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"seja redirecionado para tela CRM Avaliar Pedido")]
        public void GivenSejaRedirecionadoParaTelaCRMAvaliarPedido()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"eu clicar no botao Prosseguir")]
        public void WhenEuClicarNoBotaoProsseguir()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"serei redirecionado para index de pedidos")]
        public void ThenSereiRedirecionadoParaIndexDePedidos()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a situaçao do meu pedido deve ser \{Separação}")]
        public void ThenASituacaoDoMeuPedidoDeveSerSeparacao()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
