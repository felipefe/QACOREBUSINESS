using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace QACoreBusiness.Util
{
    class PedidoInserirClienteUtil
    {
        IWebDriver driver = ChromeDriverNavegador.driver;
        ElementsPedido pedido;
        AbrirNavegadorUtil open;

        public PedidoInserirClienteUtil()
        {
            pedido = new ElementsPedido { Driver = driver };
            open = new AbrirNavegadorUtil();
        }

        public void PedidoStatusLançamentoEdiçao()
        {
            Assert.Equal("Lançamento / Edição", pedido.SituacaoPedido.Text );
        }

        public void CliqueEditPedido()
        {
            pedido.BotaoEditPedido.Click();
        }

        public void UrlEditPedido()
        {
            Assert.Contains(pedido.UrlContainsEditPedido, driver.Url);
        }

        public void AcessarIndexPedido()
        {
            driver.Navigate().GoToUrl(pedido.UrlIndexPedido);
        }

        public void AcessarUrlEditPedido()
        {
            Assert.Contains(pedido.UrlContainsEditPedido, driver.Url);
        }

        public void PesquisarCPCliente(decimal CP)
        {
            IWebElement element = open.WaitForElementXpath(driver, "//div[@class='ui large input']/input[@type='text'][@name='cp'][@placeholder='CPF/CNPJ']");
            element.SendKeys(CP.ToString());
        }

        public void CliqueSelecionarClientePedido()
        {
            try
            {
                IWebElement element = open.WaitForElementXpath(driver, "//div[@class='ui column right aligned six wide']//button[@class='ui large button']");
                element.Click();
            }catch(ElementClickInterceptedException e)
            {
                pedido.EditTextCPClientePedido.SendKeys(Keys.Enter);
            }
        }

        public void PesquisarNomeCliente(string nomeCliente)
        {
            IWebElement element = open.WaitForElementXpath(driver, "//div[@class='ui large input']/input[@type='text'][@name='nome'][@placeholder='Nome']");
            element.SendKeys(nomeCliente.ToString());
        }

        public void MensagemPessoaAddPedido()
        {
            IWebElement element = open.WaitForElementXpath(driver, "//strong[@class='iziToast-title slideIn']");
            Assert.Equal("Carga Completa", element.Text);
        }

        public void ClienteSituacaoNormal()
        {
            IWebElement element = open.WaitForElementXpath(driver, "//h4[@class='ui header']//div[@class='ui column right aligned']//div[@class='ui label']");
            Assert.Equal("Normal", element.Text);
        }

        public void ClienteSituacaoRestrito()
        {
            IWebElement element = open.WaitForElementXpath(driver, "//h4[@class='ui header']//div[@class='ui column right aligned']//div[@class='ui label red']");
            Assert.Equal("Restrito", element.Text);
        }
    }
}
