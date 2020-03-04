﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using java.lang;
using OpenQA.Selenium;
using QACoreBusiness.Elements;
using Xunit;

namespace QACoreBusiness.Util.COM
{
    class RecepcaoMercadoriaNovoViaNFeUtil
    {
        ElementsCOMRecepcaoMercadoriaWorkflow recepcao;
        IWebDriver driver;
        string auxNumRecepcao;

        public RecepcaoMercadoriaNovoViaNFeUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            recepcao = new ElementsCOMRecepcaoMercadoriaWorkflow { chromeDriver = driver };
        }


        public void CliqueBotaoNovoViaNFE()
        {
            recepcao.HeaderBotaoNovoViaNfe.Click();
            System.Threading.Thread.Sleep(1000);
        }

        public void SelecionarArquivoXML()
        {
            recepcao.FileUpload.Click();
            System.Threading.Thread.Sleep(500);
            Runtime.getRuntime().exec(recepcao.ArquivoUploadXmlRecepcao);
            System.Threading.Thread.Sleep(1000);
        }

        public void SelecionarOperacaoFiscal(string opf)
        {
            recepcao.SelectOpFiscalImportXml.Click();
            recepcao.SearchOpFiscalImportXml.SendKeys(opf);
            System.Threading.Thread.Sleep(1000);
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
            System.Threading.Thread.Sleep(1000);
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
            System.Threading.Thread.Sleep(800);
            recepcao.BotaoExcluirRecepcaoModal.Click();
            System.Threading.Thread.Sleep(700);
        }

        public void SelecionarImpostosFederais(string impFederal)
        {
            recepcao.SelectImpostoFederalEscrituracao.Click();
            recepcao.SearchImpostoFederalEscrituracao.SendKeys(impFederal);
            System.Threading.Thread.Sleep(1000);
            recepcao.SearchImpostoFederalEscrituracao.SendKeys(Keys.Enter);
        }

        public void ValidaNumeroRecepcaoExcluida()
        {
            Assert.Equal(auxNumRecepcao, recepcao.ColunaNumeroRecepcaoMercadoria.Text);
        }

        public void CliqueActionsAlterarSituacao()
        {
            System.Threading.Thread.Sleep(1000);
            recepcao.ActionsRecepcao.Click();
            recepcao.ActionsAlterarSituacao.Click();
        }

        public void SelectNovaSituacao(string situacao)
        {
            System.Threading.Thread.Sleep(1000);
            recepcao.SelectNovaSituacao.Click();
            recepcao.SearchGenerico.SendKeys(situacao);
            System.Threading.Thread.Sleep(1000);
            recepcao.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void CliqueSalvarNovaSituacao()
        {
            recepcao.SalvarNovaSituacao.Click();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
