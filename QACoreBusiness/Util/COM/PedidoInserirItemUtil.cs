using OpenQA.Selenium;
using QACoreBusiness.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace QACoreBusiness.Util
{
    class PedidoInserirItemUtil
    {

        IWebDriver driver = Base.chromeDriver;
        ElementsMontarPedido pedido;

        public PedidoInserirItemUtil()
        {
            pedido = new ElementsMontarPedido ();
        }

        public void CliqueSessaoProdutos()
        {
            pedido.SessaoProdutos.Click();
        }

        public void PesquisarProdutoSKU(string sku)
        {
            pedido.InputSKUProduto.SendKeys(sku);
        }

        public void InformarQuantidadeItem()
        {
            Thread.Sleep(3000); //espera carregar os dados do item [estoque / preço]
            pedido.InputQuantidadeItemPedido.Clear();
            pedido.InputQuantidadeItemPedido.SendKeys("2,00");
        }

        public void PesquisarProdutoNome(string nome)
        {
            pedido.InputNomeProduto.SendKeys(nome);
        }

        public void TagDeReservaEstoqueNormal()
        {
            Assert.Equal("Normal", pedido.TagReservaEstoqueNormal.Text);
        }

        public void TagDeReservaEstoqueSemReserva()
        {
            Assert.Equal("Sem reserva", pedido.TagReservaEstoqueSemReserva.Text);
        }

        public void MensagemItemAdicionadoSucesso()
        {
            ElementWait.WaitForElementXpath(driver, "//div[@class='ui basic unpadded segment']//table[@id='table-itens']");
            Assert.Equal("Itens adicionados ao pedido com sucesso.", pedido.AlertaMensagemPedidoAtualizado.Text);
        }

        public void CliqueAdicionarItem()
        {
            pedido.BotaoAddItemPedido.Click();
        }

        public void MensagemMotivoItemNaoAdicionado()
        {
            Assert.Equal("Atenção", pedido.MensagemMotivoItemNaoAdd.Text);
        }

        public void MensagemItemNaoAdicionado()
        {
            Assert.Equal("Itens não adicionados", pedido.MensagemItemNaoAdd.Text);
        }
    }
}
