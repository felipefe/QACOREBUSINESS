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
    }
}
