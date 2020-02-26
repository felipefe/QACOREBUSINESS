using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using QACoreBusiness.Elements;

namespace QACoreBusiness.Util
{

    public class AbrirNavegadorUtil
    {
        private Base login;
        public  IWebDriver driverNavegadorChrome;

        public AbrirNavegadorUtil()
        {
            driverNavegadorChrome = Base.GetChromeDriver();
            login = new Base { chromeDriver = driverNavegadorChrome };        
        }

        public void AcesseIndex(string contexto)
        {
            IWebElement index = ElementWait.WaitForElementXpath(driverNavegadorChrome, "//a[@data-title='" + contexto + "']");
            Thread.Sleep(1000);
            index.Click();
        }

        public void CliqueSairSistema()
        {
            login.MenuUsuarioLogado.Click();
            Thread.Sleep(800);
            login.MenuUsuarioLogadoSair.Click();
        }

        public void IniciarNavegador()
        {
            driverNavegadorChrome.Manage().Window.Maximize();
        }

        public void MensagemLoginInvalido()
        {
            ElementWait.WaitForElementXpath(driverNavegadorChrome, "//div[@class='red card z-depth-4']//div[@class='card-content white-text']");
            Assert.Equal("Erro ao efetuar login", login.MensagemLoginInvalido.Text);
        }

        public void CliqueEntrarSistema()
        {
            login.BotaoEfetuarLogin.Click();
            
        }

        internal void TelaDeLogin()
        {
            driverNavegadorChrome.Navigate().GoToUrl(login.UrlCoreBusiness);
            Thread.Sleep(1000);
        }

        public void InsereDados()
        {
           login.Usuario.SendKeys("DeltaconUser");
            login.Senha.SendKeys("Delt@12345");
           
        }

        public void InsereDadosInvalidos()
        {
            login.Usuario.SendKeys("goku");
            login.Senha.SendKeys("cacaroto");
        }

        public void PaginaInicialCoreBusiness()
        {
            Assert.Equal(login.UrlCoreBusiness + "/Home/MosaicoV2", driverNavegadorChrome.Url);
            Thread.Sleep(500);
        }

        public void UrlNotIsHub()
        {
            Thread.Sleep(500);
            Assert.NotEqual(login.UrlCoreBusiness + "/Home/MosaicoV2", driverNavegadorChrome.Url); 
        }

        public void RealizaLogon()
        {
            IniciarNavegador();
            TelaDeLogin();
            InsereDados();
            CliqueEntrarSistema();
        }

        public void ValidaUrlLoginCore()
        {
            Assert.Equal(login.UrlLoginCoreBusiness, driverNavegadorChrome.Url);
        }
    }

}