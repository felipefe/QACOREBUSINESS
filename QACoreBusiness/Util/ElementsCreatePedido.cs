using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QACoreBusiness.Util
{
    class ElementsCreatePedido
    {
        public IWebDriver Driver;
        public static string UrlIndexPedido = "http://dcbtestserver/COREBusiness/COM/Pedido";
        public static string UrlContainsEditPedido = "http://dcbtestserver/COREBusiness/COM/PedidoVue/Edit/";
        public IWebElement BotaoCriarNovo => Driver.FindElement(By.XPath("//a[@class='popup-link'][@href='/COREBusiness/COM/Pedido/Create']"));

    }
}
