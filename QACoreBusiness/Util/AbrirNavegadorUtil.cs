﻿using System;
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
        ElementsAbrirNavegador tela;
        IWebDriver driverNavegadorChrome;

     
        public void IniciarNavegador()
        {

            driverNavegadorChrome = Base.GetChromeDriver();
            driverNavegadorChrome.Manage().Window.Maximize();

            tela = new ElementsAbrirNavegador ();
        }

        internal void MensagemLoginInvalido()
        {
            ElementWait.WaitForElementXpath(driverNavegadorChrome, "//div[@class='red card z-depth-4']//div[@class='card-content white-text']");
            Assert.Equal("Erro ao efetuar login", tela.MensagemLoginInvalido.Text);
        }

        public void CliqueEntrarSistema()
        {
            tela.BotaoEfetuarLogin.Click();
            
        }

        internal void TelaDeLogin()
        {
            driverNavegadorChrome.Navigate().GoToUrl(ElementsAbrirNavegador.UrlCoreBusiness);
            Thread.Sleep(1000);
        }

        internal void InsereDados()
        {
            ElementWait.WaitForElementXpath(driverNavegadorChrome, "//div[@class='container']//div[@class='row'][2]//div[@class='col s12 m6 offset-m3']//form");
            tela.Usuario.SendKeys("DeltaconUser");
            tela.Senha.SendKeys("Delt@12345");
           
        }

        public void InsereDadosInvalidos()
        {
            ElementWait.WaitForElementXpath(driverNavegadorChrome, "//div[@class='container']//div[@class='row'][2]//div[@class='col s12 m6 offset-m3']//form");
            tela.Usuario.SendKeys("goku");
            tela.Senha.SendKeys("cacaroto");
        }

        public void PaginaInicialCoreBusiness()
        {
            String URL = driverNavegadorChrome.Url;
            Assert.Equal(ElementsAbrirNavegador.UrlCoreBusiness + "/Home/MosaicoV2", URL);
            Thread.Sleep(500);
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