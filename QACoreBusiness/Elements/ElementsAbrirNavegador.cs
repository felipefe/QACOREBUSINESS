﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QACoreBusiness.Util
{
    class ElementsAbrirNavegador
    {
        public static string URL => "http://dcbtestserver/COREBusiness";

        public IWebDriver Driver;
        public IWebElement Usuario => Driver.FindElement(By.Id("Username"));
        public IWebElement Senha => Driver.FindElement(By.Id("Password"));
        //public IWebElement BotaoEfetuarLogin => Driver.FindElement(By.CssSelector("body > div.container > div:nth-child(2) > div > form > div > div.card-action.right-align > button"));   
        //public IWebElement BotaoEfetuarLogin => Driver.FindElement(By.XPath("//button[@type='submit'][@name='action']"));
        public IWebElement MensagemLoginInvalido => Driver.FindElement(By.XPath("//div[@class='red card z-depth-4']//span[@class='card-title']"));
    }
}
