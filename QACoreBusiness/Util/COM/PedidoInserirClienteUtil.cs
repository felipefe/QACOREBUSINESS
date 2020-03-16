using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Threading;
using QACoreBusiness.Elements;

namespace QACoreBusiness.Util
{
    class PedidoInserirClienteUtil
    {
        public IWebDriver driver;
        ElementsCOMPedido pedido;

        public PedidoInserirClienteUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            pedido = new ElementsCOMPedido { chromeDriver = driver };
  
        }

        public void CliqueEditPedido()
        {      
            pedido.BotaoEditPedido.Click();
        }

        public void UrlEditPedido()
        {
            Assert.Contains(pedido.UrlEditPedido, driver.Url);
        }

        public void AcessarIndexPedido()
        {   
            driver.Navigate().GoToUrl(pedido.UrlIndexPedido);
        }

        public void PedidoStatusLançamentoEdiçao(String situacao)
        {

            Assert.Equal(situacao, pedido.SituacaoPedido.Text);

        }

        public void FecharMensagemCarregada()
        {
            Thread.Sleep(1000);
            pedido.FecharMensagem.Click();
        }

        //sleep aqui evita que o selenium execute mto rapido e capture a primeira mensagem ao editar o pedido
        //queremos a segunda mensagem de pessoa adicionada com sucesso que ocorrera mais adiante
        public void AcessarUrlEditPedido()
        {
            Assert.Contains(pedido.UrlEditPedido, driver.Url);
            Thread.Sleep(4000);      
        }

        public void PesquisarCPCliente(decimal CP)
        {
            pedido.InputCPClientePedido.SendKeys(CP.ToString());
        }

        public void CliqueSelecionarClientePedido()
        {
            Thread.Sleep(1000);   
            pedido.BotaoSelecionarCliente.Click();
        }

        public void PesquisarNomeCliente(string nomeCliente)
        {
            pedido.InputNomeCliente.SendKeys(nomeCliente.ToString());
        }

        public void MensagemPessoaAddPedido()
        {
            Thread.Sleep(500);
            Assert.Equal("A pessoa do pedido foi alterada com sucesso.", pedido.AlertaMensagemPedidoAtualizado.Text);
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
