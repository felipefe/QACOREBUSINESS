using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Threading;

namespace QACoreBusiness.Util
{
    class PedidoInserirClienteUtil
    {
        IWebDriver driver = ChromeDriverNavegador.driver;
        ElementsPedido pedido;

        public PedidoInserirClienteUtil()
        {
            pedido = new ElementsPedido { Driver = driver };
        }

        public void CliqueEditPedido()
        {      
            ElementWait.WaitForElementXpath(driver, "//table//tbody//tr[1]//td[11][@class=' hidden-mobile']/a[@data-content='Editar']").Click();
        }

        public void UrlEditPedido()
        {
            Assert.Contains(pedido.UrlContainsEditPedido, driver.Url);
        }

        public void AcessarIndexPedido()
        {   
            driver.Navigate().GoToUrl(pedido.UrlIndexPedido);
        }

        public void PedidoStatusLançamentoEdiçao()
        {

            IWebElement element = ElementWait.WaitForElementXpath(driver, "//table//tbody//tr[1]//td[9][@class='left aligned'][@data-field='Status']");
            Assert.Equal("Lançamento / Edição", element.Text);

        }

        public void AcessarUrlEditPedido()
        {
            Assert.Contains(pedido.UrlContainsEditPedido, driver.Url);
            Thread.Sleep(4000); 
            //esse sleep evita que o selenium execute mto rapido e capture a primeira mensagem ao editar o pedido
            //queremos a segunda mensagem de pessoa adicionada com sucesso que ocorrera mais adiante
        }

        public void PesquisarCPCliente(decimal CP)
        {
            IWebElement element = ElementWait.WaitForElementXpath(driver, "//div[@class='ui large input']/input[@type='text'][@name='cp'][@placeholder='CPF/CNPJ']");
            element.SendKeys(CP.ToString());
        }

        public void CliqueSelecionarClientePedido()
        {
                IWebElement element = ElementWait.WaitForElementXpath(driver, "//div[@class='ui column right aligned six wide']//button[@class='ui large button']");
                element.Click();
        }

        public void PesquisarNomeCliente(string nomeCliente)
        {
            IWebElement element = ElementWait.WaitForElementXpath(driver, "//div[@class='ui large input']/input[@type='text'][@name='nome'][@placeholder='Nome']");
            element.SendKeys(nomeCliente.ToString());
        }

        //esse metodo ta errado tem que validar com a mensagem de sucesso
        public void MensagemPessoaAddPedido()
        {
            //bool achou = ElementWait.WaitTextToBePresentInElement(driver, ElementWait.WaitForElementXpath(driver, "//div[@class='iziToast-body']//div[@class='iziToast-texts']//p[@class='iziToast-message slideIn']"), "A pessoa do pedido foi alterada com sucesso.");
            //Assert.True(achou);

            IWebElement element = ElementWait.WaitForElementXpath(driver, "//div[@class='iziToast-body']//div[@class='iziToast-texts']//p[@class='iziToast-message slideIn']");
            Assert.Equal("A pessoa do pedido foi alterada com sucesso.", element.Text);

        }

        public void ClienteSituacaoNormal()
        {
            IWebElement element = ElementWait.WaitForElementXpath(driver, "//h4[@class='ui header']//div[@class='ui column right aligned']//div[@class='ui label']");
            Assert.Equal("Normal", element.Text);
        }

        public void ClienteSituacaoRestrito()
        {
            IWebElement element = ElementWait.WaitForElementXpath(driver, "//h4[@class='ui header']//div[@class='ui column right aligned']//div[@class='ui label red']");
            Assert.Equal("Restrito", element.Text);
        }
    }
}
