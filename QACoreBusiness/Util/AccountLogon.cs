using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QACoreBusiness.Util
{
    class AccountLogon
    {
        public string URL => "http://192.168.0.2/COREBusiness/Account/LogOn";

        public IWebDriver Driver;
        public IWebElement Usuario => Driver.FindElement(By.Id("Username"));
        public IWebElement Senha => Driver.FindElement(By.Id("Password"));
        public IWebElement BotaoEfetuarLogin => Driver.FindElement(By.CssSelector("body > div.container > div:nth-child(2) > div > form > div > div.card-action.right-align > button"));   //XPath("//button[@type='submit'][@name='action']"));
    }
}
