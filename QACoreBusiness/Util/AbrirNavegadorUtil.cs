using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;
using SeleniumExtras.WaitHelpers;

namespace QACoreBusiness.Util
{

    public class AbrirNavegadorUtil
    {
        ElementsAbrirNavegador tela;
        IWebDriver driverNavegadorChrome;

      
        public void IniciarNavegador()
        {

            driverNavegadorChrome = ChromeDriverNavegador.driver;
            driverNavegadorChrome.Manage().Window.Maximize();
            //driverNavegadorChrome.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 3);
            tela = new ElementsAbrirNavegador { Driver = driverNavegadorChrome };
        }

        internal void MensagemLoginInvalido()
        {
            Assert.Equal<String>("Erro ao efetuar login", tela.MensagemLoginInvalido.Text);
        }

        public void CliqueEntrarSistema()
        {
            IWebElement element = ElementWait.WaitForElementXpath(driverNavegadorChrome, "//button[@type='submit'][@name='action']");
            element.Click();
        }

        internal void TelaDeLogin()
        {
            driverNavegadorChrome.Navigate().GoToUrl(ElementsAbrirNavegador.URL);
            ElementWait.WaitForLoad(driverNavegadorChrome, 5);
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
            Assert.Equal<String>( ElementsAbrirNavegador.URL + "/Home/MosaicoV2", URL);
          
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