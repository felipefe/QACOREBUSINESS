using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class PedidoRemoverItemSteps
    {
        PedidoRemoverItemUtil pri = new PedidoRemoverItemUtil();

        [Given(@"que o pedido tenha itens")]
        public void GivenQueOPedidoTenhaItens()
        {
            pri.PedidoTenhaItens();
        }
        
        [Given(@"que eu cliquei nas action do item do pedido")]
        public void GivenQueEuCliqueiNasActionDoItemDoPedido()
        {
            pri.BotaoActionsItem();
        }
        
        [When(@"clicar no botao remover item")]
        public void WhenClicarNoBotaoRemoverItem()
        {
            pri.BotaoRemoverItem();
        }
        
        [Then(@"o item deve ser removido")]
        public void ThenOItemDeveSerRemovido()
        {
            pri.ValidacaoItemRemovido();
        }
    }
}
