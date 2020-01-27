using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class PedidoEfetivarSteps
    {
        PedidoEfetivarUtil peu = new PedidoEfetivarUtil();

        [Given(@"tenha inserido o cliente")]
        public void GivenTenhaInseridoOCliente()
        {
            peu.PedidoComCliente();
        }
        
        [Given(@"tenha definido entrega")]
        public void GivenTenhaDefinidoEntrega()
        {
            peu.PedidoComEntrega();
        }
        
        [Given(@"tenha adicionado itens")]
        public void GivenTenhaAdicionadoItens()
        {
            peu.PedidoComItens();
        }
        
        [Given(@"tenha adicionado negociaçao")]
        public void GivenTenhaAdicionadoNegociacao()
        {
            peu.PedidoComNegociacao();
        }
        
        [Given(@"tenha adicionado vendedor")]
        public void GivenTenhaAdicionadoVendedor()
        {
            peu.PedidoComVendedor();
        }
        
        [When(@"eu clicar no botao Efetivar Pedido")]
        public void WhenEuClicarNoBotaoEfetivarPedido()
        {
            peu.CliqueEfetivarPedido();
        }
        
        [Then(@"o sistema redireciona para index de pedidos")]
        public void ThenOSistemaRedirecionaParaIndexDePedidos()
        {
            peu.RedirecionaIndexPedidos();
        }
        
        [Then(@"a situaçao do pedido nao deve estar em \{Lançamento/Ediçao}")]
        public void ThenASituacaoDoPedidoNaoDeveEstarEmLancamentoEdicao()
        {
            peu.SituaçaoPedido();
        }
        
        [Then(@"o sistema nao redireciona para tela de pedidos")]
        public void ThenOSistemaNaoRedirecionaParaTelaDePedidos()
        {
            peu.NaoRedirecionaIndexPEdidos();
        }
        
        [Then(@"uma alerta com as pendencias deve ser exibido")]
        public void ThenUmaAlertaComAsPendenciasDeveSerExibido()
        {
            peu.AlertaPendenciasPedido();
        }
    }
}
