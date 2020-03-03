using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class PedidoAvaliacaoSteps
    {
        PedidoAvaliacaoUtil pau = new PedidoAvaliacaoUtil();
        
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

        [Given(@"um dos motivos seja \{'(.*)'}")]
        public void GivenUmDosMotivosSeja(string motivoUm)
        {
            pau.MotivoUm(motivoUm);
        }

        [Given(@"outro motivo seja \{'(.*)'}")]
        public void GivenOutroMotivoSeja(string motivoDois)
        {
            pau.MotivoDois(motivoDois);
        }

        [When(@"eu clicar no botao Efetivar Pedido")]
        public void WhenEuClicarNoBotaoEfetivarPedido()
        {
            pau.CliqueEfetivarPedido();
        }


        [When(@"o sistema redireciona para index de pedidos")]
        public void WhenOSistemaRedirecionaParaIndexDePedidos()
        {
            pau.ValidaUrlIndexPedido();
        }

        [When(@"a situaçao do pedido deve ser \{'(.*)'}")]
        public void WhenASituacaoDoPedidoDeveSer(string status)
        {
            pau.SituacaoPedido(status);
        }

        [When(@"que eu acesse as actions do pedido")]
        public void WhenQueEuAcesseAsActionsDoPedido()
        {
            pau.ActionsDoPedido();
        }

        [When(@"clique no botao Avaliaçao do Pedido")]
        public void WhenCliqueNoBotaoAvaliacaoDoPedido()
        {
            pau.CliqueAvaliacaoPedido();
        }

        [When(@"seja redirecionado para tela CRM Avaliar Pedido")]
        public void WhenSejaRedirecionadoParaTelaCRMAvaliarPedido()
        {
            pau.IndexAvaliarPedido();
        }

        [When(@"um dos motivos seja \{'(.*)'}")]
        public void WhenUmDosMotivosSeja(string motivoUm)
        {
            pau.MotivoUm(motivoUm);
        }

        [When(@"outro motivo seja \{'(.*)'}")]
        public void WhenOutroMotivoSeja(string motivoDois)
        {
            pau.MotivoDois(motivoDois);
        }


        [When(@"eu clicar no botao Prosseguir")]
        public void WhenEuClicarNoBotaoProsseguir()
        {
            pau.ProsseguirAvaliacao();
        }

        [When(@"eu clicar no botao Bloquear")]
        public void WhenEuClicarNoBotaoBloquear()
        {
            pau.CliqueBotaoBloquear();
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

        [Then(@"serei redirecionado para index de pedido")]
        public void ThenSereiRedirecionadoParaIndexDePedido()
        {
            pau.ValidaUrlIndexPedido();
        }

        [Then(@"a situaçao do pedido deve ser \{'(.*)'}")]
        public void ThenASituacaoDoPedidoDeveSer(string status)
        {
            pau.SituacaoPedido(status);
        }
    }
}
