using QACoreBusiness.Util;
using System;
using TechTalk.SpecFlow;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class PedidoCriarNovoSteps
    {
        AbrirNavegadorUtil realizarLogin = new AbrirNavegadorUtil();
        PedidoCriarNovoUtil pedido = new PedidoCriarNovoUtil();

        [Given(@"que eu esteja logado no sistema")]
        public void GivenQueEuEstejaLogadoNoSistema()
        {
            realizarLogin.RealizarLogon();
        }
        
        [Given(@"que esteja no hub principal")]
        public void GivenQueEstejaNoHubPrincipal()
        {
            realizarLogin.PaginaInicialCoreBusiness();
        }
        
        [Given(@"acesse a index de pedido")]
        public void GivenAcesseAIndexDePedido()
        {
            pedido.AcessarIndexPedidos();
        }
        
        [When(@"o usuario clicar no botao Criar Novo Pedido \{Nova Venda de Mercadorias e Serviços}")]
        public void WhenOUsuarioClicarNoBotaoCriarNovoPedidoNovaVendaDeMercadoriasEServicos()
        {
            pedido.CriarNovoPedido();
        }
        
        [Then(@"seja redirecionado para tela de ediçao")]
        public void ThenSejaRedirecionadoParaTelaDeEdicao()
        {
            pedido.UrlEditPedido();
        }
    }
}
