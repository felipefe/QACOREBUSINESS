using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace QACoreBusiness.Util
{
    class PedidoInserirItemUtil
    {

        IWebDriver driver = ChromeDriverNavegador.driver;

        public void CliqueSessaoProdutos()
        {
            ElementWait.WaitForElementXpath(driver, "//div[@id='pedido-itens-wrapper']//div[@class='collapse toggle']//h4[@class='ui header']//div[@class='ui column']").Click();
        }

        public void PesquisarProdutoSKU(string sku)
        {
            IWebElement element = ElementWait.WaitForElementXpath(driver, "//div[@id='pedido-edit-wrapper']//div[@class='ui form container']//div[@class='components']//div[@id='pedido-itens-wrapper']//div[@class='ui green segment']//div[@class='ui fields']//div[@class='four wide field']//div[@class='ui large input']//input[@name='sku']");
            element.SendKeys(sku);
        }

        public void InformarQuantidadeItem()
        {
            Thread.Sleep(3000); //espera carregar os dados do item [estoque / preço]
            IWebElement element = ElementWait.WaitForElementXpath(driver, "//div[@id='pedido-itens-wrapper']//div[@class='ui green segment']//div[@class='ui stackable row three column grid']//div[@class='sixteen wide field']//div[@class='ui large action input']//input[@name='quantidade']");
            element.Clear();
            element.SendKeys("2,00");
        }

        public void PesquisarProdutoNome(string nome)
        {
            ElementWait.WaitForElementXpath(driver, "//div[@id='pedido-edit-wrapper']//div[@class='ui form container']//div[@class='components']//div[@id='pedido-itens-wrapper']//div[@class='ui green segment']//div[@class='ui fields']//div[@class='ui large input']//input[@name='nome']").SendKeys(nome);
        }

        public void TagDeReservaEstoqueNormal()
        {
            IWebElement element = ElementWait.WaitForElementXpath(driver, "//table[@id='table-itens']//tbody//tr//td//div[@class='ui left']//div[@class='ui circular grey label sui-tooltip']");
            Assert.Equal("Normal", element.Text);
        }

        public void TagDeReservaEstoqueSemReserva()
        {
            IWebElement element = ElementWait.WaitForElementXpath(driver, "//table[@id='table-itens']//tbody//tr//td//div[@class='ui left']//div[@class='ui circular violet label sui-tooltip']");
            Assert.Equal("Sem reserva", element.Text);
        }

        public void MensagemItemAdicionadoSucesso()
        {
            ElementWait.WaitForElementXpath(driver, "//div[@class='ui basic unpadded segment']//table[@id='table-itens']");
            IWebElement element = ElementWait.WaitForElementXpath(driver, "//div[@class='iziToast-body']//div[@class='iziToast-texts']//p[@class='iziToast-message slideIn']");
            Assert.Equal("Itens adicionados ao pedido com sucesso.", element.Text);
        }

        public void CliqueAdicionarItem()
        {
            ElementWait.WaitForElementXpath(driver, "//div[@id='pedido-itens-wrapper']//div[@class='ui green segment']//div[@class='ui stackable row three column grid']//div[@class='sixteen wide field']//div[@class='ui large action input']//button[@class='ui right labeled icon button']").Click();
        }
    }
}
