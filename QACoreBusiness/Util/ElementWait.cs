using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace QACoreBusiness.Util
{
    class ElementWait
    {
        //wait
        public static IWebElement WaitForElementXpath(IWebDriver driver, String xpath)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(xpath)));
        }

        //wait
        public static IWebElement WaitForElementToBeClickable(IWebDriver driver, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            return wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        //wait
        public static bool WaitTextToBePresentInElement(IWebDriver driver, IWebElement element, String texto)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            return wait.Until(ExpectedConditions.TextToBePresentInElement(element, texto));
        }

        //wait
        public static void WaitForLoad(IWebDriver driver, int timeoutSec)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString().Equals("complete"));
        }

        //wait
        public static void WaitLoading(IWebDriver driver, int timeoutSec)
        {
            new WebDriverWait(driver, new TimeSpan(0, 0, timeoutSec)).Until(webDriver => ((IJavaScriptExecutor)webDriver).ExecuteScript("return document.readyState").Equals("complete"));
        }

    }
}
