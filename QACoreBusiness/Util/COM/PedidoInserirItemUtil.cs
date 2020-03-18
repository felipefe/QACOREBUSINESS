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

        IWebDriver driver;
        ElementsCOMPedido pedido;

        public PedidoInserirItemUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            pedido = new ElementsCOMPedido { chromeDriver = driver };
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

        public void InformarQuantidadeItem(int quantidade)
        {
            Thread.Sleep(3000); //espera carregar os dados do item [estoque / preço]
            pedido.InputQuantidadeItemPedido.Clear(); //isso aqui nao funciona neste campo
            for(int i=0; i<4; i++)
                pedido.InputQuantidadeItemPedido.SendKeys(Keys.Backspace);
            Thread.Sleep(1000);
            pedido.InputQuantidadeItemPedido.SendKeys(quantidade.ToString());
        }


        public void PesquisarProdutoNome(string nome)
        {
            pedido.InputNomeProduto.SendKeys(nome);
        }


        public void TagDeReservaItemPedido(string reserva)
        {
            pedido.FecharMensagem.Click();
            Thread.Sleep(4000);
            IWebElement item = pedido.TabelaItensPedido[pedido.TabelaItensPedido.Count - 1];
            ElementWait.WaitTextToBePresentInElement(driver, item, reserva);
            Thread.Sleep(1000);
            Assert.Equal(reserva , item.FindElement(By.CssSelector("td:nth-child(1) > div > div")).Text);
        }

        public void MensagemItemAdicionadoSucesso()
        {
            ElementWait.WaitForElementXpath(driver, "//div[@class='ui basic unpadded segment']//table[@id='table-itens']");
            Assert.Equal("Itens adicionados ao pedido com sucesso.", pedido.AlertaMensagemPedidoAtualizado.Text);
        }

        public void CliqueAdicionarItem()
        {
            Thread.Sleep(2000);
            pedido.BotaoAddItemPedido.Click();
            Thread.Sleep(800);
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
