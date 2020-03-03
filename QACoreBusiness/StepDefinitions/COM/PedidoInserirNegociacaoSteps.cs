using QACoreBusiness.Util;
using System;
using TechTalk.SpecFlow;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class PedidoInserirNegociacaoSteps
    {
        PedidoInserirNegociacaoUtil pin = new PedidoInserirNegociacaoUtil();

        
        [Given(@"que eu cliquei na sessao de Pagamento")]
        public void GivenQueEuCliqueiNaSessaoDePagamento()
        {
            pin.SessaoPagamento();
        }
                
        [Given(@"valor do pedido seja maior que zero")]
        public void GivenValorDoPedidoSejaMaiorQueZero()
        {
            pin.ValorPedidoMaiorQueZero();
        }

        [When(@"que eu nao tenha informado o cliente")]
        public void WhenQueEuNaoTenhaInformadoOCliente()
        {
            pin.PedidoSemCliente();
        }

        [When(@"nao tenha itens adicionados ao pedido")]
        public void WhenNaoTenhaItensAdicionadosAoPedido()
        {
            pin.PedidoSemItens();
        }



        [When(@"eu clicar no botao Criar Negociaçao")]
        public void WhenEuClicarNoBotaoCriarNegociacao()
        {
            pin.CliqueCriarNegociacao();
        }
        
        [When(@"inserir uma descriçao no editText \{'(.*)'}")]
        public void WhenInserirUmaDescricaoNoEditText(string descricao)
        {
            pin.DescricaoNegociacaoPedido(descricao);
        }
        
        [When(@"selecionar a forma de pagamento \{'(.*)'}")]
        public void WhenSelecionarAFormaDePagamento(string fp)
        {
            pin.SelecionarFormaPagamento(fp);
        }
        
        [When(@"clicar no botao Salvar Negociaçao")]
        public void WhenClicarNoBotaoSalvarNegociacao()
        {
            pin.SalvarNegociacao();
        }
        
        [Then(@"um alerta é exibido para informar o cliente")]
        public void ThenUmAlertaEExibidoParaInformarOCliente()
        {
            pin.AlertaPedidoSemCliente();
        }
        
        [Then(@"um alerta é exibido sobre pedido sem itens")]
        public void ThenUmAlertaEExibidoSobrePedidoSemItens()
        {
            pin.AlertaPedidoSemItens();
        }
        
        [Then(@"o valor total geral da negociçao deve ser maior que zero")]
        public void ThenOValorTotalGeralDaNegocicaoDeveSerMaiorQueZero()
        {
            pin.TotalGeralLiquidoNegociacao();
        }

        [Then(@"uma mensagem de campo obrigatorio deve aparecer \{'(.*)'}")]
        public void ThenUmaMensagemDeCampoObrigatorioDeveAparecer(string mensagem)
        {
            pin.NegociacaoSemFormaPagamento(mensagem);
        }

    }
}
