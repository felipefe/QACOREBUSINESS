using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace QACoreBusiness.Util
{
  
    public class AbrirNavegadorUtil
    {
        IWebDriver driverNavegadorChrome;

      
        public void IniciarNavegador()
        {

            driverNavegadorChrome = new ChromeDriver(@"C:\Users\CoreBusiness\source\repos\QADeltacon\QADeltacon\chromeDrive\");
            driverNavegadorChrome.Manage().Window.Maximize();

        }

        internal void CliqueEntrarSistema()
        {
       
            driverNavegadorChrome.FindElement(By.Name("action")).Click();
        }

        internal void TelaDeLogin()
        {
            driverNavegadorChrome.Navigate().GoToUrl("http://localhost/COREBusiness");
        }

        internal void InsereDados()
        {
         
            driverNavegadorChrome.FindElement(By.Id("UserName")).SendKeys("felipe");
            driverNavegadorChrome.FindElement(By.Id("Password")).SendKeys("1234");
           
        }

        public void NavegadorAberto()
        {
            Assert.Contains("Chrome", driverNavegadorChrome.ToString());
        }

    }

}