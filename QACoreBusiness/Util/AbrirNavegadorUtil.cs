using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace QACoreBusiness.Util
{

    public class AbrirNavegadorUtil
    {
        ElementsAccountLogon tela;
        IWebDriver driverNavegadorChrome;

      
        public void IniciarNavegador()
        {

            driverNavegadorChrome = ChromeDriverNavegador.driver;
            driverNavegadorChrome.Manage().Window.Maximize();
            //driverNavegadorChrome.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 3);
            tela = new ElementsAccountLogon { Driver = driverNavegadorChrome };
        }

        internal void MensagemLoginInvalido()
        {
            IWebElement msgLoginInvalido = driverNavegadorChrome.FindElement(By.XPath("//span[@class='card-title']"));
            Assert.Equal<String>("Erro ao efetuar login", msgLoginInvalido.Text);
        }

        internal void CliqueEntrarSistema()
        {
            tela.BotaoEfetuarLogin.Click();
        }

        internal void TelaDeLogin()
        {
            driverNavegadorChrome.Navigate().GoToUrl(ElementsAccountLogon.URL);
            WaitForLoad(driverNavegadorChrome, 5);
            WaitLoading(driverNavegadorChrome, 5);
        }

        internal void InsereDados()
        {
            tela.Usuario.SendKeys("DeltaconUser");
            tela.Senha.SendKeys("Delt@12345");
           
        }

        public void InsereDadosInvalidos()
        {
            tela.Usuario.SendKeys("goku");
            tela.Senha.SendKeys("cacaroto");
        }

        public void PaginaInicialCoreBusiness()
        {
            String URL = driverNavegadorChrome.Url;
            Assert.Equal<String>( ElementsAccountLogon.URL + "/Home/MosaicoV2", URL);
          
        }

        //wait
        public void WaitForLoad(IWebDriver driver, int timeoutSec)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString().Equals("complete"));
        }

        //wait
        public void WaitLoading(IWebDriver driver, int timeoutSec)
        {
            new WebDriverWait(driver, new TimeSpan(0, 0, timeoutSec)).Until(webDriver => ((IJavaScriptExecutor)webDriver).ExecuteScript("return document.readyState").Equals("complete"));
        }


        public void RealizarLogon()
        {
            IniciarNavegador();
            TelaDeLogin();
            InsereDados();
            CliqueEntrarSistema();
        }


    }

}