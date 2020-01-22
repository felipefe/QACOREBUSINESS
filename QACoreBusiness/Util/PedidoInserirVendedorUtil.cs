using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace QACoreBusiness.Util
{
    class PedidoInserirVendedorUtil
    {
        IWebDriver driver = ChromeDriverNavegador.driver;
        ElementsPedido elemento;
        public PedidoInserirVendedorUtil()
        {
            elemento = new ElementsPedido { Driver = driver };
        }

        public void CliqueTrocarVendedor()
        {
            elemento.ActionTrocarVendedor.Click();

        }

        public void UrlTrocarVendedorPedido()
        {
            Assert.Contains( elemento.UrlTrocarVendedor , driver.Url);
        }

        public void VendedorJaInformado(String vendedor)
        {
            IWebElement element = ElementWait.WaitForElementXpath(driver, "//div[@id='Pedido_Vendedor_auto_wrapper']//div[@class='ui select2 fluid']//select[@id='Pedido_Vendedor']//option");
            Assert.Equal(vendedor, element.Text);

        }

        public void SelecionarVendedor(String nomeVendedor)
        {
            ElementWait.WaitForElementXpath(driver, "//div[@id = 'Pedido_Vendedor_auto_wrapper']//div[@class='ui select2 fluid']").Click();

            IWebElement element = ElementWait.WaitForElementXpath(driver,"//span[@class='select2-container select2-container--default select2-container--open']//span[@class='select2-dropdown select2-dropdown--below']//input[@class='select2-search__field'][@type='search']");
            element.SendKeys(nomeVendedor);
            element.SendKeys(Keys.Enter);

        }

        public void BotaoTrocarVendedor()
        {
            elemento.BotaoTrocarVendedor.Click();
        }

        public void UrlEdicaoPedido()
        {
            Assert.Contains(elemento.UrlContainsEditPedido, driver.Url);
        }

        public void MensagemAposInserirVendedor()
        {
            IWebElement element = ElementWait.WaitForElementXpath(driver, "//div[@class='iziToast-body']//div[@class='iziToast-texts']//p[@class='iziToast-message slideIn']");
            Assert.Equal("Os dados do pedido foram atualizados com sucesso", element.Text);
        }

        public void MensagemVendedorJaInserido()
        {
            Assert.Equal(" Favor indicar um vendedor diferente do vendedor atual.", ElementWait.WaitForElementXpath(driver, "//div[@class='ui negative message validation-summary-errors']//ul[@class='list']//li").Text);
        }
    }
}
