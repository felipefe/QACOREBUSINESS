using OpenQA.Selenium;
using QACoreBusiness.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace QACoreBusiness.Util
{
    class PedidoRemoverItemUtil
    {
        IWebDriver driver = Base.GetChromeDriver();
        ElementsCOMPedido pedido;
        int qtdItensInicial;

        public PedidoRemoverItemUtil()
        {
            pedido = new ElementsCOMPedido { chromeDriver = driver };
            qtdItensInicial = ItensInPedido();
        }

        public void PedidoTenhaItens()
        {
            Assert.True(ItensInPedido() > 0);
        }

        public void BotaoActionsItem()
        {
            pedido.ActionsItemPedido.Click();
            Thread.Sleep(1000);
        }

        public void BotaoRemoverItem()
        {
            pedido.BotaoRemoverItemPedido.Click();
        }

        public void ValidacaoItemRemovido()
        {
            if(qtdItensInicial > 1)
            {
                qtdItensInicial--;
                Assert.Equal(qtdItensInicial, ItensInPedido());
            }
            else if (qtdItensInicial == 1)
            {
                Assert.Contains("Nenhum item adicionado ao pedido", pedido.PedidoSemItens.Text);
            }
        }

        public int ItensInPedido()
        {
            return Int32.Parse(pedido.TextViewQuantidadeItensPedido.Text);
        }

    }
}
