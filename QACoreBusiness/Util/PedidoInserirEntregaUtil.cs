using OpenQA.Selenium;
using QACoreBusiness.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace QACoreBusiness.Util
{
    class PedidoInserirEntregaUtil
    {
        IWebDriver driver = ElementsBase.chromeDriver;
        ElementsPedido pedido;

        public PedidoInserirEntregaUtil()
        {
            pedido = new ElementsPedido { Driver = driver };
        }


        public void PedidoComCliente()
        {
            Assert.DoesNotContain("Pessoa", pedido.ClientePedido.Text);
        }

        public void CliqueSessaoEntrega()
        {
            pedido.SessaoEntregas.Click();
        }

        public void CliqueDefinirEntrega()
        {
            pedido.BotaoDefinirEntrega.Click();
        }

        public void SelecionarTransportadora(String transportadora)
        {
            //modal entrega
            ElementWait.WaitForElementXpath(driver, "//div[@id='entrega-modal-placeholder']//form[@id='frmPedidoEntrega']");
            //elementos transportadora - clique
            pedido.SelectTransportadora.Click();
            //search transportadora
            pedido.SearchTransportadora.SendKeys(transportadora);
            Thread.Sleep(2000);
            pedido.SearchTransportadora.SendKeys(Keys.Enter);
            ElementWait.WaitForElementXpath(driver, "//div[@class='iziToast-capsule']//button[@type='button'][@class='iziToast-close']").Click();
        }

        public void MensagemEntregaAtualizada()
        {
            Assert.Equal("Os dados do pedido foram atualizados com sucesso", pedido.AlertaMensagemPedidoAtualizado.Text);
        }

        public void SelectTipoEntrega()
        {
            pedido.SelectTipoEntrega.Click();
            pedido.TipoEntrega.Click();
            
        }

        ////esse parametro dias é a quantidade de dias para a entrega a partir da data atual
        ///ou seja data atual + X dias
        public void InserirDataPrevista(int dias)
        {
            DateTime date =  DateTime.Now.AddDays(dias) ;
            pedido.DataPrevista.SendKeys(date.ToString("dd/MM/yyyy hh:mm"));
        }

        public void BotaoSalvarEntrega()
        {
            pedido.BotaoSalvarEntrega.Click();
        }

        public void InserirValorFrete(decimal valor)
        {
            pedido.ValorEntrega.SendKeys(valor.ToString());
        }

        internal void SelectTipoEntregaFutura()
        {
            pedido.TipoEntrega.Click();
            pedido.TipoEntregaFutura.Click();
        }
    }
}
