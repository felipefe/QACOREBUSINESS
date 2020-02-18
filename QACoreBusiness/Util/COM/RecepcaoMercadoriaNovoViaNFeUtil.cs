﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using java.awt;
using java.awt.@event;
using java.lang;
using OpenQA.Selenium;
using QACoreBusiness.Elements;
using Xunit;

namespace QACoreBusiness.Util.COM
{
    class RecepcaoMercadoriaNovoViaNFeUtil
    {
        ElementsCOMRecepcaoMercadoria recepcao;
        IWebDriver driver = Base.GetChromeDriver();
        string auxNumRecepcao;

        public RecepcaoMercadoriaNovoViaNFeUtil()
        {
            recepcao = new ElementsCOMRecepcaoMercadoria { chromeDriver = driver };
        }


        public void CliqueBotaoNovoViaNFE()
        {
            recepcao.HeaderBotaoNovoViaNfe.Click();
            Thread.sleep(1000);
        }

        public void SelecionarArquivoXML()
        {
            recepcao.FileUpload.Click();
            System.Threading.Thread.Sleep(500);
            Runtime.getRuntime().exec(recepcao.ArquivoUploadXmlRecepcao);
            Thread.sleep(1000);
        }

        public void SelecionarOperacaoFiscal(string opf)
        {
            recepcao.SelectOpFiscalImportXml.Click();
            recepcao.SearchOpFiscalImportXml.SendKeys(opf);
            Thread.sleep(1000);
            recepcao.SearchOpFiscalImportXml.SendKeys(Keys.Enter);
        }

        public void ValidaGerenciarRecepcoes()
        {
            Assert.Equal(recepcao.UrlGerenciarRecepcoes, driver.Url);
        }

        public void CliqueGerenciarRecepcoes()
        {
            recepcao.HeaderBotaoGerenciarRecepcoes.Click(); 
        }

        public void ArmazenarNumeroRecepcaoExcluir()
        {
            auxNumRecepcao = recepcao.ColunaNumeroRecepcaoMercadoria.Text;
        }

        public void ValidaRedirecionamentoIDFE()
        {
            Assert.Equal(recepcao.UrlIdfeNfeImpDestinadasNativo, driver.Url);
        }

        public void SelecionarProtocoloICMS(string protocoloICMS)
        {
            recepcao.SelectProtocoloIcmsEscrituracao.Click();
            recepcao.SearchProtocoloIcmsEscrituracao.SendKeys(protocoloICMS);
            Thread.sleep(1000);
            recepcao.SearchProtocoloIcmsEscrituracao.SendKeys(Keys.Enter);
        }

        public void AlertLoteFiscalJaRecepcionado()
        {
            Assert.Contains("já recepcionado para a empresa", recepcao.TextViewLoteFiscalJaRecepcionado.Text);
        }

        public void CliqueActionsExcluirRecepcao()
        {
            recepcao.ActionsRecepcao.Click();
            recepcao.ActionsExcluirRecepcao.Click();
        }

        public void CliqueBotaoIniciarImportacaoXML()
        {
            recepcao.BotaoIniciarImportacaoNFe.Click();
        }

        public void CliqueConfirmarExcluirRecepcao()
        {
            recepcao.BotaoExcluirRecepcaoModal.Click();
        }

        public void SelecionarImpostosFederais(string impFederal)
        {
            recepcao.SelectImpostoFederalEscrituracao.Click();
            recepcao.SearchImpostoFederalEscrituracao.SendKeys(impFederal);
            Thread.sleep(1000);
            recepcao.SearchImpostoFederalEscrituracao.SendKeys(Keys.Enter);
        }

        public void ValidaNumeroRecepcaoExcluida()
        {
            Assert.Equal(auxNumRecepcao, recepcao.ColunaNumeroRecepcaoMercadoria.Text);
        }
    }
}
