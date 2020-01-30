using QACoreBusiness.Util;
using System;
using TechTalk.SpecFlow;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class PedidoInserirEntregaSteps
    {
        PedidoInserirEntregaUtil pie = new PedidoInserirEntregaUtil();

        [Given(@"já tenha informado o cliente")]
        public void GivenJaTenhaInformadoOCliente()
        {
            pie.PedidoComCliente();
        }

        [Given(@"que eu cliquei na sessao de Entregas")]
        public void GivenQueEuCliqueiNaSessaoDeEntregas()
        {
            pie.CliqueSessaoEntrega();
        }

        [When(@"clicar no botao Definir Entrega")]
        public void WhenClicarNoBotaoDefinirEntrega()
        {
            pie.CliqueDefinirEntrega();
        }

        [When(@"informar a transportadora \{'(.*)'}")]
        public void WhenInformarATransportadora(string transportadora)
        {
            pie.SelecionarTransportadora(transportadora);
        }

        [When(@"informar o tipo da entrega como \{Entrega}")]
        public void WhenInformarOTipoDaEntregaComoEntrega()
        {
            pie.SelectTipoEntrega();
        }

        [When(@"inserir uma data prevista em dias \{(.*)}")]
        public void WhenInserirUmaDataPrevistaEmDias(int dias)
        {
            pie.InserirDataPrevista(dias);
        }


        [When(@"inserir o valor do frete \{(.*)}")]
        public void WhenInserirOValorDoFrete(Decimal valor)
        {
            pie.InserirValorFrete(valor);
        }

        [When(@"clicar em salvar")]
        public void WhenClicarEmSalvar()
        {
            pie.BotaoSalvarEntrega();
        }

        [When(@"informar o tipo da entrega como \{Entrega Futura}")]
        public void WhenInformarOTipoDaEntregaComoEntregaFutura()
        {
            pie.SelectTipoEntregaFutura();
        }

        [Then(@"uma mensagem de dados atualizado deve aparecer")]
        public void ThenUmaMensagemDeDadosAtualizadoDeveAparecer()
        {
            pie.MensagemEntregaAtualizada();
        }
    }
}
