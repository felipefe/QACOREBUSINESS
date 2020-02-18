using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using QACoreBusiness.Util;
using System.IO;
using System.Reflection;

namespace QACoreBusiness.Elements
{
    class Base
    {
        public static string UrlCoreBusiness => "http://dcbtestserver/COREBusiness";

        public static string PathLocalProject = Path.GetDirectoryName(Uri.UnescapeDataString((new UriBuilder(Assembly.GetExecutingAssembly().CodeBase)).Path));

        public static IWebDriver chromeDriver = new ChromeDriver(PathLocalProject + @"\webdriver");

        public static IWebDriver GetChromeDriver() => new ChromeDriver(PathLocalProject + @"\webdriver");

    }
}
