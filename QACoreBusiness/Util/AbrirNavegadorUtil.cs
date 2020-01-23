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

            tela = new ElementsAbrirNavegador { Driver = driverNavegadorChrome };
        }

        internal void MensagemLoginInvalido()
        {
            ElementWait.WaitForElementXpath(driverNavegadorChrome, "//div[@class='red card z-depth-4']//div[@class='card-content white-text']");
            Assert.Equal<String>("Erro ao efetuar login", tela.MensagemLoginInvalido.Text);
        }

        public void CliqueEntrarSistema()
        {
            IWebElement element = ElementWait.WaitForElementXpath(driverNavegadorChrome, "//div[@class='grey lighten-5 card z-depth-4 animated zoomInDown']//button[@type='submit'][@name='action']");
            element.Click();
        }

        internal void TelaDeLogin()
        {
            driverNavegadorChrome.Navigate().GoToUrl(ElementsAbrirNavegador.URL);
            //ElementWait.WaitForLoad(driverNavegadorChrome, 5);
        }

        internal void InsereDados()
        {
            ElementWait.WaitForElementXpath(driverNavegadorChrome, "//div[@class='container']//div[@class='row'][2]//div[@class='col s12 m6 offset-m3']//form");
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