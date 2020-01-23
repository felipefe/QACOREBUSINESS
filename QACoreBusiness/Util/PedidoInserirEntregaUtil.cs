using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace QACoreBusiness.Util
{
    class PedidoInserirEntregaUtil
    {
        IWebDriver driver = ChromeDriverNavegador.driver;

        public void PedidoComCliente()
        {
            IWebElement element = ElementWait.WaitForElementXpath(driver, "//div[@id='pedido-pessoa-wrapper']//div[@class='collapse toggle']//h4[@class='ui header']//div[@class='ui column']");
            Assert.DoesNotContain("Pessoa", element.Text);
        }

        public void CliqueSessaoEntrega()
        {
            ElementWait.WaitForElementXpath(driver, "//div[@class='ui green segment']//div[@class='collapse toggle']//h4[@class='ui header']//i[@class='icon truck']").Click();
        }

        public void CliqueDefinirEntrega()
        {
            ElementWait.WaitForElementXpath(driver, "//div[@class='ui green segment']//div[@class='ui placeholder segment']//div[@class='ui large primary button']").Click();
        }

        public void SelecionarTransportadora(String transportadora)
        {
            //modal entrega
            ElementWait.WaitForElementXpath(driver, "//div[@id='entrega-modal-placeholder']//form[@id='frmPedidoEntrega']");
            //elementos transportadora - clique
            ElementWait.WaitForElementXpath(driver, "//div[@class='two fields']//div[@id='IDTransportadora_auto_wrapper']//div[@class='ui select2 fluid']").Click();
            //search transportadora
            IWebElement search = ElementWait.WaitForElementXpath(driver, "//span[@class='select2-container select2-container--default select2-container--open']//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field'][@type='search']");
            search.SendKeys(transportadora);
            search.SendKeys(Keys.Enter);
        }

        public void MensagemEntregaAtualizada()
        {
            IWebElement element = ElementWait.WaitForElementXpath(driver, "//div[@class='iziToast-body']//div[@class='iziToast-texts']//p[@class='iziToast-message slideIn']");
            Assert.Equal("Os dados do pedido foram atualizados com sucesso", element.Text);
        }

        public void SelectTipoEntrega()
        {
            ElementWait.WaitForElementXpath(driver, "//div[@class='three fields']//div[@class='ui field']//select[@id='PedidoEntrega_Tipo'][@name='Tipo']").Click();
            ElementWait.WaitForElementXpath(driver, "//div[@class='three fields']//div[@class='ui field']//select[@id='PedidoEntrega_Tipo'][@name='Tipo']//option[@value='Entrega']").Click();
            
        }

        ////esse parametro dias é a quantidade de dias para a entrega a partir da data atual
        ///ou seja data atual + X dias
        public void InserirDataPrevista(int dias)
        {
            DateTime date =  DateTime.Now.AddDays(dias) ;
            ElementWait.WaitForElementXpath(driver, "//div[@class='ui large fluid input']//div[@class='floatlabel-wrapper']//input[@id='PedidoEntrega_DataPrevista'][@name='DataPrevista']").SendKeys(date.ToString("dd/MM/yyyy hh:mm"));
        }

        public void BotaoSalvarEntrega()
        {
            ElementWait.WaitForElementXpath(driver, "//div[@class='actions']//input[@class='ui large button'][@id='submit'][@value='Salvar']").Click();
        }

        public void InserirValorFrete(decimal valor)
        {
            ElementWait.WaitForElementXpath(driver, "//div[@id='PedidoEntrega_Frete_auto_wrapper']//div[@class='ui large fluid input']//div[@class='floatlabel-wrapper']//input[@id='PedidoEntrega_Frete'][@name='Frete']").SendKeys(valor.ToString());
        }

        internal void SelectTipoEntregaFutura()
        {
            ElementWait.WaitForElementXpath(driver, "//div[@class='three fields']//div[@class='ui field']//select[@id='PedidoEntrega_Tipo'][@name='Tipo']").Click();
            ElementWait.WaitForElementXpath(driver, "//div[@class='three fields']//div[@class='ui field']//select[@id='PedidoEntrega_Tipo'][@name='Tipo']//option[@value='EntregaFutura']").Click();
        }
    }
}
