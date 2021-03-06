﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using QACoreBusiness.Elements;
using Xunit;
using System.Threading;

namespace QACoreBusiness.Util
{
    class SituacaoDosServidoresUtil
    {
        IWebDriver driver;
        ElementsSituacaoServidores servidor;

        public SituacaoDosServidoresUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            servidor = new ElementsSituacaoServidores { chromeDriver = driver };
        }

        public void SituacaoAtualCoreService(string situacao)
        {
            if (servidor.ColunaSituacaoServidores.Text.Equals("Running"))
                return;
            else
                CliqueIniciarOuPararCoreService();
            Thread.Sleep(1500);
            Assert.Equal(situacao, servidor.ColunaSituacaoServidores.Text);
        }

        public void ValidarURLServiceStatus()
        {
            Assert.Contains(servidor.UrlSituacaoServidores, driver.Url);
        }

        public void CliqueIniciarOuPararCoreService()
        {
            servidor.BotaoPlayStopCoreService.Click();
        }

        public void NovaSitualCoreService(string novaSituacao)
        {
            if (novaSituacao.Equals("Running"))
                return;
            else
                Assert.Equal(novaSituacao, servidor.ColunaSituacaoServidores.Text);
        }

        public void CliqueBotaoLimpar()
        {
            servidor.BotaoLimparCoreService.Click();
        }

        public void CliqueConfirmaçaoModal()
        {
            servidor.BotaoSimModalConfirmarLimpeza.Click();
        }

        public void ValidarUrlUserTask()
        {
            Assert.Contains(servidor.UrlLimparMensagensCoreService, driver.Url);
        }

        public void ProgressoLimparCoreService()
        {
            Assert.Equal("100%", servidor.ProgressoLimpeza.Text);
        }

        public void CliqueBotaoVoltar()
        {
            servidor.BotaoVoltarPagina.Click();
        }

        public void isHabilitadoCoreService()
        {
            driver.Navigate().GoToUrl(servidor.UrlSituacaoServidores);
            SituacaoAtualCoreService("Running");
            driver.Navigate().GoToUrl(servidor.UrlCoreBusiness);
        }
    }
}
