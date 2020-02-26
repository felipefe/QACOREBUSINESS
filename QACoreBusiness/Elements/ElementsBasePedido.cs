using OpenQA.Selenium;
using QACoreBusiness.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace QACoreBusiness.Elements
{
    class ElementsBasePedido : Base
    {
        public string UrlIndexPedido => UrlCoreBusiness + "/COM/Pedido";
        public IWebElement SituacaoPedido => ElementWait.WaitForElementXpath(chromeDriver, "//table//tbody//tr[1]//td[9][@class='left aligned'][@data-field='Status']");
        public IWebElement ActionsPedido => ElementWait.WaitForElementXpath(chromeDriver, "//table[@class='ui table selectable striped coregrid']//tr[1]//td[@class=' hidden-mobile']//div//div//a[@class='fsm-ignore']");
        public IWebElement AlertaMensagemPedidoAtualizado => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='iziToast-body']//div[@class='iziToast-texts']//p[@class='iziToast-message slideIn']");
        public IWebElement CloseAlertaPedidoAtualizado => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='iziToast-capsule']//button[@type='button'][@class='iziToast-close']");
    }
}
