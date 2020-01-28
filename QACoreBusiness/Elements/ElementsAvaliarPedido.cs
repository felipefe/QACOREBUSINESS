using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QACoreBusiness.Elements
{
    class ElementsAvaliarPedido : ElementsBasePedido
    {

        #region URLs de Acesso
        public string UrlAvaliacaoPedido = UrlCoreBusiness + "/CRM/Avaliacao/Avaliar/";
        #endregion

        #region Avaliar Pedido
        public IWebElement ActionsAvaliarPedido => chromeDriver.FindElement(By.XPath("//div[@class='tool-items']//a[@class='popup-link tool-item gradient'][@data-content='Avaliação do Pedido']"));
        public IWebElement BotaoProsseguir => chromeDriver.FindElement(By.XPath("//div[@class='actions']//input[@class='ui large button'][@value='Prosseguir']"));
        #endregion

    }
}
