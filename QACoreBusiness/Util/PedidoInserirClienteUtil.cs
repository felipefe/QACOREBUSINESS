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

        public void PedidoStatusLançamentoEdiçao()
        {

            Assert.Equal("Lançamento / Edição", pedido.SituacaoPedido.Text);

        }

        //sleep aqui evita que o selenium execute mto rapido e capture a primeira mensagem ao editar o pedido
        //queremos a segunda mensagem de pessoa adicionada com sucesso que ocorrera mais adiante
        public void AcessarUrlEditPedido()
        {
            Assert.Contains(pedido.UrlContainsEditPedido, driver.Url);
            Thread.Sleep(4000);      
        }

        public void PesquisarCPCliente(decimal CP)
        {
            pedido.EditTextCPClientePedido.SendKeys(CP.ToString());
        }

        public void CliqueSelecionarClientePedido()
        {
                pedido.BotaoSelecionarCliente.Click();
        }

        public void PesquisarNomeCliente(string nomeCliente)
        {
            pedido.EditTextNomeCliente.SendKeys(nomeCliente.ToString());
        }

        public void MensagemPessoaAddPedido()
        {
            //bool achou = ElementWait.WaitTextToBePresentInElement(driver, ElementWait.WaitForElementXpath(driver, "//div[@class='iziToast-body']//div[@class='iziToast-texts']//p[@class='iziToast-message slideIn']"), "A pessoa do pedido foi alterada com sucesso.");
            //Assert.True(achou);
            Assert.Equal("A pessoa do pedido foi alterada com sucesso.", pedido.MensagemPessoaAddPedido.Text);

        }

        public void ClienteSituacaoNormal()
        {
            Assert.Equal("Normal", pedido.SituacaoNormal.Text);
        }

        public void ClienteSituacaoRestrito()
        {
            Assert.Equal("Restrito", pedido.SituacaoRestrito.Text);
        }
    }
}
