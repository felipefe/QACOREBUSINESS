using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace QACoreBusiness.Elements
{
    class ElementsBase
    {
        public static string UrlCoreBusiness => "http://dcbtestserver/COREBusiness";

        public static IWebDriver chromeDriver = new ChromeDriver(@"C:\ProjectQA\QACOREBUSINESS\webdriver");
    }
}
