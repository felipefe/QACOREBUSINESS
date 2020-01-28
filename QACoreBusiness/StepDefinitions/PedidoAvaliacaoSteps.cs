using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class PedidoAvaliacaoSteps
    {
        PedidoAvaliacaoUtil pau = new PedidoAvaliacaoUtil();

        [Given(@"tenha um pedido criado na situaçao \{Avaliaçao}")]
        public void GivenTenhaUmPedidoCriadoNaSituacaoAvaliacao()
        {
            pau.PedidoEmStatusAvaliacao();
        }
        
        [Given(@"que eu acesse as actions do pedido")]
        public void GivenQueEuAcesseAsActionsDoPedido()
        {
            pau.ActionsDoPedido();
        }
        
        [Given(@"clique no botao Avaliaçao do Pedido")]
        public void GivenCliqueNoBotaoAvaliacaoDoPedido()
        {
            pau.CliqueAvaliacaoPedido();
        }
        
        [Given(@"seja redirecionado para tela CRM Avaliar Pedido")]
        public void GivenSejaRedirecionadoParaTelaCRMAvaliarPedido()
        {
            pau.IndexAvaliarPedido();
        }
        
        [When(@"eu clicar no botao Prosseguir")]
        public void WhenEuClicarNoBotaoProsseguir()
        {
            pau.ProsseguirAvaliacao();
        }
        
        [Then(@"serei redirecionado para index de pedidos")]
        public void ThenSereiRedirecionadoParaIndexDePedidos()
        {
            pau.IndexPedidos();
        }
        
        [Then(@"a situaçao do meu pedido deve ser \{Separação}")]
        public void ThenASituacaoDoMeuPedidoDeveSerSeparacao()
        {
            pau.PedidoEmStatusSeparacao();
        }
    }
}
