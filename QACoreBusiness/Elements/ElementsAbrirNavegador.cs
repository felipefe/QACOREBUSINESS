using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QACoreBusiness.Util
{
    class ElementsAbrirNavegador
    {
        public static string URL => "http://dcbtestserver/COREBusiness";

        public IWebDriver Driver;
        public IWebElement Usuario => ElementWait.WaitForElementXpath(Driver, "//div[@class='card-content']//div[@class='input-field'][1]//input[@id='UserName']");
        public IWebElement Senha => ElementWait.WaitForElementXpath(Driver, "//div[@class='card-content']//div[@class='input-field'][2]//input[@id='Password']");
        public IWebElement BotaoEfetuarLogin => ElementWait.WaitForElementXpath(Driver, "//div[@class='grey lighten-5 card z-depth-4 animated zoomInDown']//button[@type='submit'][@name='action']");
        //public IWebElement BotaoEfetuarLogin => Driver.FindElement(By.XPath("//button[@type='submit'][@name='action']"));
        public IWebElement MensagemLoginInvalido => Driver.FindElement(By.XPath("//div[@class='red card z-depth-4']//span[@class='card-title']"));
    }
}
