using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util.COM;

namespace QACoreBusiness.StepDefinitions.COM
{
    [Binding]
    public class PedidoEmitirDFeSteps
    {
        PedidoEmitirDFeUtil pdfeu = new PedidoEmitirDFeUtil();
        
        [Given(@"o coreservice esteja habilitado")]
        public void GivenOCoreserviceEstejaHabilitado()
        {
            pdfeu.CoreServiceHabilitado();
        }
        
        [Given(@"ambiente de homologaçao esteja habilitado")]
        public void GivenAmbienteDeHomologacaoEstejaHabilitado()
        {
            pdfeu.AmbienteHomologacao();
        }
        
        [When(@"clicar no botao Emitir Documentos Fiscais")]
        public void WhenClicarNoBotaoEmitirDocumentosFiscais()
        {
            pdfeu.CliqueEmitirDFE();
        }

        [When(@"clicar nas actions Emitir Documentos Fiscais")]
        public void WhenClicarNasActionsEmitirDocumentosFiscais()
        {
            pdfeu.CliqueEmitirDocumentoFiscal();
        }


        [Then(@"o usuário deve acessar o contexto de NF-e Emitidas")]
        public void ThenOUsuarioDeveAcessarOContextoDeNF_EEmitidas()
        {
            pdfeu.AcessoContextoNFE();
        }
        
        [Then(@"a situaçãp da nota deve ser Autorizado o uso da NF-e")]
        public void ThenASituacapDaNotaDeveSerAutorizadoOUsoDaNF_E()
        {
            pdfeu.SituacaoNFE();
        }

        [Then(@"o valor exibido na coluna deve ser o mesmo do pedido")]
        public void ThenOValorExibidoNaColunaDeveSerOMesmoDoPedido()
        {
            pdfeu.ComparaValorPedidoNota();
        }

    }
}
