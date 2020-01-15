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
        AccountLogon tela;
        IWebDriver driverNavegadorChrome;

      
        public void IniciarNavegador()
        {

            driverNavegadorChrome = new ChromeDriver(@"C:\Users\felipe\Source\Repos\felipefe\QACOREBUSINESS\webdriver\");
            driverNavegadorChrome.Manage().Window.Maximize();

            tela = new AccountLogon { Driver = driverNavegadorChrome };

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
            driverNavegadorChrome.Navigate().GoToUrl(AccountLogon.URL);
        }

        internal void InsereDados()
        {
            tela.Usuario.SendKeys("admin");
            tela.Senha.SendKeys("1234");
           
        }

        public void InsereDadosInvalidos()
        {
            tela.Usuario.SendKeys("goku");
            tela.Senha.SendKeys("cacaroto");
        }

        public void PaginaInicialCoreBusiness()
        {
            String URL = driverNavegadorChrome.Url;
            Assert.Equal<String>( AccountLogon.URL + "/Home/MosaicoV2", URL);
          
        }

    

    }

}