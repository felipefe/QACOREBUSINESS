using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QACoreBusiness.Util
{
    class ElementsPedido
    {
        //Criar Pedido
        public IWebDriver Driver;
        public string UrlIndexPedido = "http://dcbtestserver/COREBusiness/COM/Pedido";
        public string UrlContainsEditPedido = "http://dcbtestserver/COREBusiness/COM/PedidoVue/Edit/";
        public IWebElement BotaoCriarNovo => Driver.FindElement(By.XPath("//a[@class='popup-link'][@href='/COREBusiness/COM/Pedido/Create']"));

        //Inserir Cliente
        public IWebElement SituacaoPedido => Driver.FindElement(By.XPath("//table/tbody/tr[1]/td[9][@class='left aligned'][@data-field='Status']"));
        public IWebElement BotaoEditPedido => Driver.FindElement(By.XPath("//table/tbody/tr[1]/td[11][@class=' hidden-mobile']/a[@data-content='Editar']"));
        //public IWebElement EditTextCPClientePedido => Driver.FindElement(By.CssSelector("#pedido-pessoa-wrapper > form > div.large.two.fields > div.five.wide.field > div > input[type=text]"));
        public IWebElement EditTextCPClientePedido => Driver.FindElement(By.XPath("//div[@class='ui large input']/input[@type='text'][@name='cp'][@placeholder='CPF/CNPJ']"));
        public IWebElement BotaoSelecionarClientePedido => Driver.FindElement(By.XPath("//div[@class='ui column right aligned six wide']//button[@class='ui large button']"));
        public IWebElement MensagemPessoaAddPedido => Driver.FindElement(By.XPath("//strong[@class='iziToast-title slideIn']"));
        public IWebElement SituacaoNormal => Driver.FindElement(By.XPath("//h4[@class='ui header']//div[@class='ui column right aligned']//div[@class='ui label']"));

        //Inserir Entrega
        //public IWebElement ClientePedido => Driver.FindElement(By.XPath(""));
        //public IWebElement ClientePedido => Driver.FindElement(By.XPath("//div[@id='pedido-pessoa-wrapper']//div[@class='collapse toggle']//h4[@class='ui header']//div[@class='ui column right aligned']"));
        // public IWebElement SessaoEntregas => ElementWait.WaitForElementToBeClickable(Driver, Driver.FindElement(By.XPath("//div[@class='ui green segment']//div[@class='collapse toggle']//h4[@class='ui header']//i[@class='icon truck']")));
        //public IWebElement BotaoDefinirEntrega => Driver.FindElement(By.XPath(""));
        //public IWebElement SelectTransportadora => Driver.FindElement(By.XPath("//span[@class='select2 select2-container select2-container--default select2-container--below']//span[@class='select2-selection select2-selection--single'][@role='combobox']"));
        //public IWebElement SearchTransportadora => Driver.FindElement(By.XPath("//span[@class='select2-container select2-container--default select2-container--open']//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field'][@type='search']"));
        //public IWebElement SelectEntrega => Driver.FindElement(By.XPath(""));
        //public IWebElement TipoEntrega => Driver.FindElement(By.XPath("//div[@class='three fields']//div[@class='ui field']//select[@id='PedidoEntrega_Tipo'][@name='Tipo']//option[@value='Entrega']"));
        //public IWebElement TipoEntregaFutura => Driver.FindElement(By.XPath("//div[@class='three fields']//div[@class='ui field']//select[@id='PedidoEntrega_Tipo'][@name='Tipo']//option[@value='EntregaFutura']"));
        //public IWebElement DataPrevista => Driver.FindElement(By.XPath("//div[@class='ui large fluid input']//div[@class='floatlabel-wrapper']//input[@id='PedidoEntrega_DataPrevista'][@name='DataPrevista']"));
        //public IWebElement ValorEntrega => Driver.FindElement(By.XPath("//div[@id='PedidoEntrega_Frete_auto_wrapper']//div[@class='ui large fluid input']//div[@class='floatlabel-wrapper']//input[@id='PedidoEntrega_Frete'][@name='Frete']"));
        // public IWebElement BotaoSalvarEntrega => Driver.FindElement(By.XPath("//div[@class='actions']//input[@class='ui large button'][@id='submit'][@value='Salvar']"));


        //trocar vendedor    
        public IWebElement ActionTrocarVendedor => Driver.FindElement(By.XPath("//div[@class='actions']//a[@class='popup-link'][@data-content='Trocar Vendedor']"));
        public String UrlTrocarVendedor = "http://dcbtestserver/COREBusiness/COM/Pedido/TrocarVendedor?idPedido=";
        public IWebElement BotaoTrocarVendedor => Driver.FindElement(By.XPath("//div[@class='actions']//input[@id='396387460785426765614'][@type='submit'][@value='Trocar']"));
    }
}
