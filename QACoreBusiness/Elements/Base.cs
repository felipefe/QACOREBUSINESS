using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using QACoreBusiness.Util;

namespace QACoreBusiness.Elements
{
    class Base
    {
        public static string UrlCoreBusiness => "http://dcbtestserver/COREBusiness";

        public static IWebDriver chromeDriver = new ChromeDriver(@"C:\ProjectQA\QACOREBUSINESS\webdriver");


       // public IWebElement ActionsPedido => ElementWait.WaitForElementXpath(chromeDriver, "//table[@class='ui table selectable striped coregrid']//tr//td[@class=' hidden-mobile']//div//div//a[@class='fsm-ignore']");



    }
}
