using OpenQA.Selenium;
using QACoreBusiness.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace QACoreBusiness.Util
{
    class ElementsAbrirNavegador : Base
    {
        
        public IWebElement Usuario => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='card-content']//div[@class='input-field'][1]//input[@id='UserName']");
        public IWebElement Senha => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='card-content']//div[@class='input-field'][2]//input[@id='Password']");
        public IWebElement BotaoEfetuarLogin => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='grey lighten-5 card z-depth-4 animated zoomInDown']//button[@type='submit'][@name='action']");
        public IWebElement MensagemLoginInvalido => chromeDriver.FindElement(By.XPath("//div[@class='red card z-depth-4']//span[@class='card-title']"));
    }
}
