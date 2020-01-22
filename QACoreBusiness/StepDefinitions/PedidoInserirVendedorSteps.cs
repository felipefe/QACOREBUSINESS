using QACoreBusiness.Util;
using System;
using TechTalk.SpecFlow;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class PedidoInserirVendedorSteps
    {
        PedidoInserirVendedorUtil piv = new PedidoInserirVendedorUtil();

        [Given(@"clicar no botao da action Trocar Vendedor")]
        public void GivenClicarNoBotaoDaActionTrocarVendedor()
        {
            piv.CliqueTrocarVendedor();
        }
        
        [Given(@"for redirecionado para tela de trocar vendedor pedido")]
        public void GivenForRedirecionadoParaTelaDeTrocarVendedorPedido()
        {
            piv.UrlTrocarVendedorPedido();
        }
        
        [Given(@"que o pedido ja tenha como vendedor \{'(.*)'}")]
        public void GivenQueOPedidoJaTenhaComoVendedor(string vendedor)
        {
            piv.VendedorJaInformado(vendedor);
        }
        
        [When(@"informar o vendedor \{'(.*)'}")]
        public void WhenInformarOVendedor(string nomeVendedor)
        {
            piv.SelecionarVendedor(nomeVendedor);
        }
        
        [When(@"clicar no botao trocar vendedor")]
        public void WhenClicarNoBotaoTrocarVendedor()
        {
            piv.BotaoTrocarVendedor();
        }
        
        [Then(@"o sistema redireciona para ediçao do pedido")]
        public void ThenOSistemaRedirecionaParaEdicaoDoPedido()
        {
            piv.UrlEdicaoPedido();
        }
        
        [Then(@"uma mensagem de dados atualizados deve aparecer")]
        public void ThenUmaMensagemDeDadosAtualizadosDeveAparecer()
        {
            piv.MensagemAposInserirVendedor();
        }
        
        [Then(@"o sistema nao redireciona para ediçao do pedido")]
        public void ThenOSistemaNaoRedirecionaParaEdicaoDoPedido()
        {
            piv.UrlTrocarVendedorPedido();
        }
        
        [Then(@"uma mensagem para indicar um vendedor diferente do atual deve aparecer")]
        public void ThenUmaMensagemParaIndicarUmVendedorDiferenteDoAtualDeveAparecer()
        {
            piv.MensagemVendedorJaInserido();
        }
    }
}
