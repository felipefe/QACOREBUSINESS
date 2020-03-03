using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class PedidoConferenciaSteps
    {
        PedidoConferenciaUtil pcu = new PedidoConferenciaUtil();
        
        [Given(@"clique no botao Conferencia")]
        public void GivenCliqueNoBotaoConferencia()
        {
            pcu.CliqueActionsConferenciaPedido();
        }
        
        [Given(@"seja redirecionado para tela de WMS Conferencia")]
        public void GivenSejaRedirecionadoParaTelaDeWMSConferencia()
        {
            pcu.IndexConferenciaPedido();
        }
        
        [Given(@"o SKU seja copiado da coluna Código")]
        public void GivenOSKUSejaCopiadoDaColunaCodigo()
        {
            pcu.CopiarCodigoSKU();
        }
        
        [Given(@"seja colado no editText Código do Produto")]
        public void GivenSejaColadoNoEditTextCodigoDoProduto()
        {
            pcu.ColarCodigoSKU();
        }
        
        [Given(@"a quantidade seja copiada da coluna Qtd\. Total")]
        public void GivenAQuantidadeSejaCopiadaDaColunaQtd_Total()
        {
            pcu.CopiarQuantidadeConferencia();
        }
        
        [Given(@"seja colada no editText Quantidade")]
        public void GivenSejaColadaNoEditTextQuantidade()
        {
            pcu.ColarQuantidadeConferencia();
        }

        [Given(@"seja colada no editText Quantidade uma quantidade diferente da copiada")]
        public void GivenSejaColadaNoEditTextQuantidadeUmaQuantidadeDiferenteDaCopiada()
        {
            pcu.ColarQuantidadeErradaConferencia();
        }

        [Given(@"seja colado no editText Código do Produto um código diferente do copiado")]
        public void GivenSejaColadoNoEditTextCodigoDoProdutoUmCodigoDiferenteDoCopiado()
        {
            pcu.ColarCodigoSkuErradoConferencia();
        }

        [Given(@"eu clicar Enter")]
        public void GivenEuClicarEnter()
        {
            pcu.CliqueEnterConferir();
        }

        [Given(@"clicar no botao Concluir Processo")]
        public void GivenClicarNoBotaoConcluirProcesso()
        {
            pcu.CliqueConcluirProcessoConferencia();
        }

        [Given(@"uma mensagem de Conferência Finalizada deve aparecer")]
        public void GivenUmaMensagemDeConferenciaFinalizadaDeveAparecer()
        {
            pcu.MensagemConferenciaFinalizada();
        }

        [Given(@"o codigo sku e qtd\. total sejam copidos de suas colunas")]
        public void GivenOCodigoSkuEQtd_TotalSejamCopidosDeSuasColunas()
        {
            pcu.CopiarCodigoSkuEQtdEmMassa();
        }

        [Given(@"seja feita a conferencia desses produtos")]
        public void GivenSejaFeitaAConferenciaDessesProdutos()
        {
            pcu.ColarCodigoSkuEQtdEmMassa();
        }


        [When(@"eu clicar Enter")]
        public void WhenEuClicarEnter()
        {
            pcu.CliqueEnterConferir();
        }

        [When(@"eu clicar no botao Reiniciar Processo Conferencia")]
        public void WhenEuClicarNoBotaoReiniciarProcessoConferencia()
        {
            pcu.CliqueBotaoReiniciarConferenciaFinalizada();
        }


        [When(@"eu clicar no botao Reiniciar Processo")]
        public void WhenEuClicarNoBotaoReiniciarProcesso()
        {
            pcu.CliqueBotaoReiniciar();
        }

        [When(@"confirmar clicando no botao OK do alerta exibido")]
        public void WhenConfirmarClicandoNoBotaoOKDoAlertaExibido()
        {
            pcu.ConfirmarReiniciarConferencia();
        }

        [When(@"clicar no botao Concluir Processo")]
        public void WhenClicarNoBotaoConcluirProcesso()
        {
            pcu.CliqueConcluirProcessoConferencia();
        }

        [When(@"clicar no botao Finalizar")]
        public void WhenClicarNoBotaoFinalizar()
        {
            pcu.CliqueBotaoFinalizar();
        }

        [When(@"ser redirecionado para tela de COM Finalizar Conferencia")]
        public void WhenSerRedirecionadoParaTelaDeCOMFinalizarConferencia()
        {
            pcu.UrlFinalizarConferenciaCOM();
        }

        [When(@"clicar em Finalizar Conferencia")]
        public void WhenClicarEmFinalizarConferencia()
        {
            pcu.CliqueBotaoFinalizarConferenciaCOM();
        }

        [When(@"serei redirecionado para index de pedidos")]
        public void WhenSereiRedirecionadoParaIndexDePedidos()
        {
            pcu.ValidaUrlIndexPedido();
        }

        [When(@"clique no botao Conferencia")]
        public void WhenCliqueNoBotaoConferencia()
        {
            pcu.CliqueActionsConferenciaPedido();
        }

        [When(@"seja redirecionado para tela de WMS Conferencia")]
        public void WhenSejaRedirecionadoParaTelaDeWMSConferencia()
        {
            pcu.IndexConferenciaPedido();
        }

        [When(@"o codigo sku e qtd\. total sejam copidos de suas colunas")]
        public void WhenOCodigoSkuEQtd_TotalSejamCopidosDeSuasColunas()
        {
            pcu.CopiarCodigoSkuEQtdEmMassa();
        }

        [When(@"uma mensagem de Conferência Finalizada deve aparecer")]
        public void WhenUmaMensagemDeConferenciaFinalizadaDeveAparecer()
        {
            pcu.MensagemConferenciaFinalizada();
        }

        [When(@"o sistema deve redirecionar para tela Entrega e Remessas do Pedido")]
        public void WhenOSistemaDeveRedirecionarParaTelaEntregaERemessasDoPedido()
        {
            pcu.UrlEntregasRemessasPedidoConferido();
        }

        [When(@"seja feita a conferencia desses produtos")]
        public void WhenSejaFeitaAConferenciaDessesProdutos()
        {
            pcu.ColarCodigoSkuEQtdEmMassa();
        }


        [Then(@"clicar no botao Concluir Processo")]
        public void ThenClicarNoBotaoConcluirProcesso()
        {
            pcu.CliqueConcluirProcessoConferencia();
        }


        [Then(@"uma mensagem de conferido com sucesso deve aparecer")]
        public void ThenUmaMensagemDeConferidoComSucessoDeveAparecer()
        {
            pcu.MensagemConferenciaPedido();
        }

        [Then(@"a quantidade da coluna Qtd\. Conferida deve ser diferente da coluna Qtd\. Total")]
        public void ThenAQuantidadeDaColunaQtd_ConferidaDeveSerDiferenteDaColunaQtd_Total()
        {
            pcu.ColunaQuantidadeConferidaDivergente();
        }

        [Then(@"uma mensagem de Codigo Invalido é exibida")]
        public void ThenUmaMensagemDeCodigoInvalidoEExibida()
        {
            pcu.MensagemConferenciaCodigoErrado();
        }

        [Then(@"uma mensagem de reiniciado com sucesso deve aparecer")]
        public void ThenUmaMensagemDeReiniciadoComSucessoDeveAparecer()
        {
            pcu.MensagemProcessoReiniciado();
        }

        [Then(@"a coluna Qtd\. Conferida deve ser zero")]
        public void ThenAColunaQtd_ConferidaDeveSerZero()
        {
            pcu.ColunaQuantidadeConferidaZero();
        }

        [Then(@"uma mensagem de Conferência Finalizada deve aparecer")]
        public void ThenUmaMensagemDeConferenciaFinalizadaDeveAparecer()
        {
            pcu.MensagemConferenciaFinalizada();
        }

        [Then(@"o sistema deve redirecionar para tela Entrega e Remessas do Pedido")]
        public void ThenOSistemaDeveRedirecionarParaTelaEntregaERemessasDoPedido()
        {
            pcu.UrlEntregasRemessasPedidoConferido();
        }




    }
}
