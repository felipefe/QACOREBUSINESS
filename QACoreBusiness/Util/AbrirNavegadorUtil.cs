﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace QACoreBusiness.Util
{

    public class AbrirNavegadorUtil
    {
        AccountLogon tela;
        IWebDriver driverNavegadorChrome;

      
        public void IniciarNavegador()
        {

            driverNavegadorChrome = new ChromeDriver(@"C:\Users\felipe\Source\Repos\felipefe\QACOREBUSINESS\webdriver\");
            driverNavegadorChrome.Manage().Window.Maximize();

            tela = new AccountLogon { Driver = driverNavegadorChrome };

        }

        internal void CliqueEntrarSistema()
        {
            tela.BotaoEfetuarLogin.Click();

        }

        internal void TelaDeLogin()
        {
            driverNavegadorChrome.Navigate().GoToUrl("http://192.168.0.2/COREBusiness");
        }

        internal void InsereDados()
        {
            tela.Usuario.SendKeys("admin");
            tela.Senha.SendKeys("1234");
           
        }

        public void PaginaInicialCoreBusiness()
        {
            String URL = driverNavegadorChrome.Url;
            Assert.Equal<String>("http://192.168.0.2/COREBusiness/Home/MosaicoV2", URL);
          
        }

    }

}