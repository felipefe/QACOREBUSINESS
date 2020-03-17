using QACoreBusiness.Util.COM;
using System;
using TechTalk.SpecFlow;

namespace QACoreBusiness.StepDefinitions.COM
{
    [Binding]
    public class PedidoSegmentarSteps
    {
        PedidoSegmentarUtil segmentar = new PedidoSegmentarUtil();

        [When(@"clique nas actions para Segmentar o pedido")]
        public void WhenCliqueNasActionsParaSegmentarOPedido()
        {
            segmentar.CliqueActionsSegmentarPedido();
        }
        
        [When(@"informe a quantidade a segmentar \{(.*)}")]
        public void WhenInformeAQuantidadeASegmentar(int quantidade)
        {
            segmentar.InformeQuantidadeSegmentar(quantidade);
        }
        
        [When(@"clique no botao Segmentar")]
        public void WhenCliqueNoBotaoSegmentar()
        {
            segmentar.CliqueBotaoSegmentar();
        }
        
        [Then(@"valide que a quantidade segmentada seja inserida no novo pedido")]
        public void ThenValideQueAQuantidadeSegmentadaSejaInseridaNoNovoPedido()
        {
            segmentar.ValidarQuantidadeSegmentada();
        }
    }
}
