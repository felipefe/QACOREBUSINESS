using QACoreBusiness.Util;
using System;
using TechTalk.SpecFlow;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class PedidoInserirClienteSteps
    {
        AbrirNavegadorUtil open = new AbrirNavegadorUtil();
        PedidoInserirClienteUtil pic = new PedidoInserirClienteUtil();

        [Given(@"tenha um pedido criado na situaçao \{Lançamento/Ediçao}")]
        public void GivenTenhaUmPedidoCriadoNaSituacaoLancamentoEdicao()
        {
            pic.PedidoStatusLançamentoEdiçao();
        }
        
        [Given(@"clique para editar este pedido")]
        public void GivenCliqueParaEditarEstePedido()
        {
            pic.CliqueEditPedido();
        }
        
        [Given(@"seja redirecionado para tela de ediçao")]
        public void GivenSejaRedirecionadoParaTelaDeEdicao()
        {
            pic.AcessarUrlEditPedido();
        }
        
        [When(@"eu pesquisar no editText o cliente por CP \{(.*)}")]
        public void WhenEuPesquisarNoEditTextOClientePorCP(Decimal cp)
        {
            pic.PesquisarCPCliente(cp);
        }
        
        [When(@"em seguida no botao selecionar")]
        public void WhenEmSeguidaNoBotaoSelecionar()
        {
            pic.CliqueSelecionarClientePedido();
        }
        
        [When(@"eu pesquisar no editText o cliente por nome \{'(.*)'}")]
        public void WhenEuPesquisarNoEditTextOClientePorNome(string nomeCliente)
        {
            pic.PesquisarNomeCliente(nomeCliente);
        }
        
        [Then(@"uma mensagem de pessoa adicionada ao pedido deve aparecer")]
        public void ThenUmaMensagemDePessoaAdicionadaAoPedidoDeveAparecer()
        {
             pic.MensagemPessoaAddPedido();
        }
        
        [Then(@"a situaçao do cliente deve ser \{Normal}")]
        public void ThenASituacaoDoClienteDeveSerNormal()
        {
            pic.ClienteSituacaoNormal();
        }
        
        [Then(@"um alerta referente a situaçao é exibido")]
        public void ThenUmAlertaReferenteASituacaoEExibido()
        {
            pic.ClienteSituacaoRestrito();
        }
    }
}
