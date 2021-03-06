﻿using OpenQA.Selenium;
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
        public IWebDriver chromeDriver;
        public static string PathLocalProject = Path.GetDirectoryName(Uri.UnescapeDataString((new UriBuilder(Assembly.GetExecutingAssembly().CodeBase)).Path));
        public static IWebDriver GetChromeDriver() => new ChromeDriver(PathLocalProject + @"\webdriver");

        public string UrlCoreBusiness => "http://dcbtestserver/COREBusiness";
        public string UrlLoginCoreBusiness => UrlCoreBusiness + "/Account/LogOn";
       
        public IWebElement Usuario => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='card-content']//div[@class='input-field'][1]//input[@id='UserName']");
        public IWebElement Senha => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='card-content']//div[@class='input-field'][2]//input[@id='Password']");
        public IWebElement BotaoEfetuarLogin => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='grey lighten-5 card z-depth-4 animated zoomInDown']//button[@type='submit'][@name='action']");
        public IWebElement MenuUsuarioLogado => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='user-menu']");
        public IWebElement MensagemLoginInvalido => chromeDriver.FindElement(By.XPath("//div[@class='red card z-depth-4']//span[@class='card-title']"));
        public IWebElement MenuUsuarioLogadoSair => ElementWait.WaitForElementXpath(chromeDriver, "//div//a[@href='/COREBusiness/Account/LogOff']");
        public IWebElement SearchGenerico => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field']");
        public IWebElement BotaoVoltarPagina => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//img[@title='Voltar para página anterior']");


        #region FIN
        public IWebElement InputDataVencimentoManualmente => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='ContratoParcela_Vencimento']");
        public IWebElement InputVencimentoPrimeiraParcelaContrato => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='Contrato_DataPrimeiraParcela']");
        public IWebElement InputDataEmissaoContrato => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='Contrato_Emissao']");
        #endregion


        //#region XXX
        //public IWebElement  => ElementWait.WaitForElementXpath(chromeDriver, "");
        //public IWebElement  => ElementWait.WaitForElementXpath(chromeDriver, "");
        //public IWebElement  => ElementWait.WaitForElementXpath(chromeDriver, "");
        //public IWebElement  => ElementWait.WaitForElementXpath(chromeDriver, "");
        //#endregion

    }
}
