﻿using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class PedidoSeparacaoSteps
    {
        PedidoSeparacaoUtil psu = new PedidoSeparacaoUtil();

        [Given(@"tenha um pedido criado na situaçao \{Separaçao}")]
        public void GivenTenhaUmPedidoCriadoNaSituacaoSeparacao()
        {
            psu.SituacaoPedido();
        }
        
        [Given(@"clique no botao Separaçao")]
        public void GivenCliqueNoBotaoSeparacao()
        {
            psu.CliqueActionSeparacao();
        }
        
        [Given(@"seja redirecionado para tela WMS Separaçao")]
        public void GivenSejaRedirecionadoParaTelaWMSSeparacao()
        {
            psu.IndexSeparacaoWMS();
        }
        
        [Given(@"clique no botao Definir todos")]
        public void GivenCliqueNoBotaoDefinirTodos()
        {
            psu.CliqueBotaoDefinirTodos();
        }

        [Given(@"uma mensagem de sucesso aparecera \{'(.*)'}")]
        public void GivenUmaMensagemDeSucessoAparecera(string mensagem)
        {
            psu.MensagemModificadoResposavelSeparacao(mensagem);
        }


        [Given(@"uma mensagem de sucesso deve aparecer \{'(.*)'}")]
        public void GivenUmaMensagemDeSucessoDeveAparecer(string mensagem)
        {
            psu.MensagemSucessoSeparacao(mensagem);
        }
        
        [Given(@"depois clicar no botao Marcar Todos")]
        public void GivenDepoisClicarNoBotaoMarcarTodos()
        {
            psu.CliqueBotaoMarcarTodos();
        }
        
        [When(@"eu clicar no botao Finalizar")]
        public void WhenEuClicarNoBotaoFinalizar()
        {
            psu.CliqueBotaoFinalizarWMS();
        }
        
        [When(@"ser redicionado para a tela COM Finalizar Separaçao")]
        public void WhenSerRedicionadoParaATelaCOMFinalizarSeparacao()
        {
            psu.IndexFinalizarSeparacaoCOM();
        }
        
        [When(@"clicar no botao Finalizar Separaçao")]
        public void WhenClicarNoBotaoFinalizaoSeparacao()
        {
            psu.CliqueFinalizarSeparacaoCOM();
        }

        [When(@"clique no botao Separaçao")]
        public void WhenCliqueNoBotaoSeparacao()
        {
            psu.CliqueActionSeparacao();
        }

        [When(@"seja redirecionado para tela WMS Separaçao")]
        public void WhenSejaRedirecionadoParaTelaWMSSeparacao()
        {
            psu.IndexSeparacaoWMS();
        }

        [When(@"clique no botao Definir todos")]
        public void WhenCliqueNoBotaoDefinirTodos()
        {
            psu.CliqueBotaoDefinirTodos();
        }

        [When(@"uma mensagem de sucesso aparecera \{'(.*)'}")]
        public void WhenUmaMensagemDeSucessoAparecera(string mensagem)
        {
            psu.MensagemSucessoSeparacao(mensagem);
        }

        [When(@"depois clicar no botao Marcar Todos")]
        public void WhenDepoisClicarNoBotaoMarcarTodos()
        {
            psu.CliqueBotaoMarcarTodos();
        }

        [When(@"uma mensagem de sucesso deve aparecer \{'(.*)'}")]
        public void WhenUmaMensagemDeSucessoDeveAparecer(string mensagem)
        {
            psu.MensagemSucessoSeparacao(mensagem);
        }

    }
}
