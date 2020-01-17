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

        [Given(@"que usuário esteja logado")]
        public void GivenQueUsuarioEstejaLogado()
        {
            realizarLogin.RealizarLogon();
        }
        
        [Given(@"que esteja no hub principal")]
        public void GivenQueEstejaNoHubPrincipal()
        {
            realizarLogin.PaginaInicialCoreBusiness();
        }
        
        [Given(@"acesse o contexto Meus Pedidos")]
        public void GivenAcesseOContextoMeusPedidos()
        {
            pedido.AcessarIndexPedidos();
        }
        
        [When(@"o usuario clicar no botao Criar Novo Pedido \{Nova Venda de Mercadorias e Serviços}")]
        public void WhenOUsuarioClicarNoBotaoCriarNovoPedidoNovaVendaDeMercadoriasEServicos()
        {
            pedido.CriarNovoPedido();
        }
        
        [Then(@"deve ser redirecionado para tela de ediçao do pedido")]
        public void ThenDeveSerRedirecionadoParaTelaDeEdicaoDoPedido()
        {
            pedido.UrlEditPedido();
        }
    }
}
