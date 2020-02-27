﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using QACoreBusiness.Elements;
using Xunit;

namespace QACoreBusiness.Util.COM
{
    class PedidoEmitirDFeUtil
    {
        public ElementsCOMPedidoWorkflow pedido;
        public ElementsNotasFiscaisEletronicasEmitidas nfee;
        public ParametrosEmpresaUtil parametro;
        public SituacaoDosServidoresUtil servidor;
        public string auxValorPedido;
        IWebDriver driver;

        public PedidoEmitirDFeUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            pedido = new ElementsCOMPedidoWorkflow { chromeDriver = driver };
            nfee = new ElementsNotasFiscaisEletronicasEmitidas { chromeDriver = driver };
            servidor = new SituacaoDosServidoresUtil();
            parametro = new ParametrosEmpresaUtil();
        }

        public void CoreServiceHabilitado()
        {
            servidor.isHabilitadoCoreService();
        }

        public void AmbienteHomologacao()
        {
            parametro.isHomologacao();
        }

        public void CliqueEmitirDFE()
        {
            pedido.ActionsEmitirDFePedido.Click();
        }

        public void AcessoContextoNFE()
        {
            driver.Navigate().GoToUrl(nfee.UrlNFEEmitidas);
        }

        //espero 10seg ate a nota ser validada entao atualizo a pagina para pegar o status autorizado
        public void SituacaoNFE()
        {
            Thread.Sleep(10000);
            driver.Navigate().Refresh();
            Assert.True(ElementWait.WaitTextToBePresentInElement(driver, nfee.ColunaUsoAutorizadoNFE, "Autorizado o uso da NF-e"));
        }

        internal void ComparaValorPedidoNota()
        {
            Assert.Equal(auxValorPedido, nfee.ColunaValorNFE.Text);
        }
    }
}
