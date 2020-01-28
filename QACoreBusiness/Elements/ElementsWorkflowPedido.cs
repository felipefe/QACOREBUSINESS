using OpenQA.Selenium;
using QACoreBusiness.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace QACoreBusiness.Elements
{
    class ElementsWorkflowPedido : ElementsBasePedido
    {

        #region URLs de Acesso
        public string UrlAvaliacaoPedido = UrlCoreBusiness + "/CRM/Avaliacao/Avaliar/";
        public string UrlSeparacaoPedido = UrlCoreBusiness + "/WMS/Separacao/Execute/";
        public string UrlCOMFinalizarSeparacao = UrlCoreBusiness + "/COM/Pedido/FinalizarPickingList/";
        #endregion

        #region Avaliar Pedido
        public IWebElement ActionsAvaliarPedido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@class='popup-link tool-item gradient'][@data-content='Avaliação do Pedido']");
        public IWebElement BotaoProsseguir => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@class='ui large button'][@value='Prosseguir']");
        #endregion

        #region Separar Pedido
        public IWebElement ActionsSepararPedido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@class='popup-link tool-item gradient'][@data-content='Separação']");
        public IWebElement BotaoDefinirTodos => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui red segment']//div[@class='actions']//div[@class='ui big labeled icon button orange has-tooltip']");
        public IWebElement BotaoMarcarTodos => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui yellow segment']//div[@class='actions']//div[@class='ui big labeled icon button orange has-tooltip']");
        public IWebElement BotaoFinalizarSeparacaoWMS => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//div[@class='ui big labeled green icon button has-tooltip']");
        public IWebElement BotaoFinalizarSeparacaoCOM => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@class='ui large button'][@value='Finalizar Separação']");

        #endregion

    }
}
