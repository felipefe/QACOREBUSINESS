﻿using java.lang;
using OpenQA.Selenium;
using QACoreBusiness.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Xunit;

namespace QACoreBusiness.Util
{
    class GerenciadorDeRelatoriosUtil
    {
        IWebDriver driver;
        IWebElement relatorioEdit = null;
        ElementsRPTGerenciadorDeRelatorios rpt;
        int indexContainerAction;
        int qtdColunasRpt = 0;

        public GerenciadorDeRelatoriosUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            rpt = new ElementsRPTGerenciadorDeRelatorios { chromeDriver = driver };
        }

        public void CliqueDefinicoesDeRelatorios()
        {
            rpt.BotaoHeaderDefinicoesDeRelatorios.Click();
            System.Threading.Thread.Sleep(1000);
        }

        public void ValidaUrlDefinicoesDeRelatorios()
        {
            Assert.Equal(rpt.UrlDefinicoesRelatorios, driver.Url);
        }

        public void CliqueCarregarDefinicaoRelatorio()
        {
            rpt.BotaoCarregarDefinicaoRelatorio.Click();
            System.Threading.Thread.Sleep(1000);
        }

        public void CliqueSelectArquivoRpt()
        {
            rpt.BotaoSelecionarArquivoRpt.Click();
        }

        public void SelecionarArquivoWindowsExplorer()
        {
            System.Threading.Thread.Sleep(500);
            Runtime.getRuntime().exec(rpt.ArquivoUploadRptSeparacoes);
            System.Threading.Thread.Sleep(1000);
        }

        public void CarregarRptSelecionado()
        {
            rpt.BotaoEnviarArquivoRpt.Click();
        }

        public void RelatorioIsImportado(string nomeRelatorio)
        {
            foreach (IWebElement relatorio in rpt.RelatoriosImportados)
                if (nomeRelatorio.Equals(relatorio.FindElement(By.CssSelector("td:nth-child(2)")).Text))
                {
                    relatorioEdit = relatorio;
                    indexContainerAction = rpt.RelatoriosImportados.IndexOf(relatorioEdit);
                }
            System.Threading.Thread.Sleep(1000);
            Assert.NotNull(relatorioEdit);  
        }

        public void CliqueActionEditarDefinicao(string report)
        {
            ReportExiste(report);
            if (relatorioEdit != null)
            {
                relatorioEdit.FindElement(By.CssSelector("td:nth-child(5)")).Click();
                rpt.ListaContainerActions[indexContainerAction].FindElement(By.TagName("a[data-content='Editar Definição']")).Click();
            }
        }

        public void CliqueAbaColunasRPT()
        {
            rpt.EditDefinicaoAbaColunas.Click();
        }

        public void ValidaUrlEditarDefinicaoRpt()
        {
            Assert.Contains(rpt.UrlEditarDefinicaoRpt, driver.Url);
        }

        public void ReportExiste(string nomeRPT)
        {
            foreach (IWebElement relatorio in rpt.RelatoriosImportados)
                if (nomeRPT.Equals(relatorio.FindElement(By.CssSelector("td:nth-child(1)")).Text))
                {
                    relatorioEdit = relatorio;
                    indexContainerAction = rpt.RelatoriosImportados.IndexOf(relatorioEdit);
                }
            System.Threading.Thread.Sleep(1000);
            Assert.NotNull(relatorioEdit);
        }

        public void CliqueMenuUsuarioRelatorios()
        {
            rpt.MenuUsuarioLogadoRelatorio.Click();
        }

        public void CliqueMenuUsuarioLogado()
        {
            rpt.MenuUsuarioLogado.Click();
            System.Threading.Thread.Sleep(500);
        }

        public void MemorizarColunasMarcadas()
        {
            foreach (IWebElement categoriaColunas in rpt.EditDefinicaoColunasCategoria)
            {
                categoriaColunas.Click();
                System.Threading.Thread.Sleep(1000);
                foreach (IWebElement coluna in rpt.EditDefinicaoLinhasDeColunaSelect)
                {
                    System.Threading.Thread.Sleep(500);
                    string checkbox = coluna.FindElement(By.CssSelector("div.fitted.ui.toggle.checkbox > input")).GetAttribute("value");
                    if (checkbox.Equals("True"))
                    {
                        qtdColunasRpt++;
                    }
                }
                categoriaColunas.Click();
                System.Threading.Thread.Sleep(1000);
            }
        }

        public void ValidaUrlMeusRelatorios()
        {
            Assert.Equal(rpt.UrlMeusRelatorios, driver.Url);
        }

        public void ConfirmeExcluir()
        {
            System.Threading.Thread.Sleep(1000);
            rpt.ExcluirReport.Click();
        }

        public void ActionsExcluirRelatorio()
        {
            if (relatorioEdit != null)
            {
                relatorioEdit.FindElement(By.CssSelector("td:nth-child(5)")).Click();
                rpt.ListaContainerActions[indexContainerAction].FindElement(By.TagName("a[data-content='Excluir']")).Click();
            }
        }

        public void CliqueGravarEditDefinicaoRpt()
        {
            rpt.SalvarRptEditDefinicao.Click();
        }

        public void SelecionarColunasEditDefinicao()
        {
            foreach(IWebElement categoriaColunas in rpt.EditDefinicaoColunasCategoria)
            {
                categoriaColunas.Click();
                System.Threading.Thread.Sleep(1000);
                foreach (IWebElement coluna in rpt.EditDefinicaoLinhasDeColunaSelect)
                {
                    IWebElement div = coluna.FindElement(By.CssSelector("div.fitted.ui.toggle.checkbox"));
                    if (div.FindElement(By.TagName("input[type='checkbox']")).GetAttribute("value").Equals("False"))
                    {    div.Click();   }
                    System.Threading.Thread.Sleep(600);
                }
                categoriaColunas.Click();
                System.Threading.Thread.Sleep(1000);
            }
        }

        public void CliqueVisualizarRelatorio()
        {
            rpt.BotaoExecutarMeuRpt.Click();
        }

        public void ValidaUrlParametroExecucaoMeuRelatorio()
        {
            int indexAbaBrowser = driver.WindowHandles.ToList().Count -1;
            driver = driver.SwitchTo().Window(driver.WindowHandles.ToList()[indexAbaBrowser]);
            Assert.Contains(rpt.UrlParametrosMeuRelatorio, driver.Url);
        }

        public void ValidaExibicaoRelatorio()
        {
            int indexNovaAba = driver.WindowHandles.ToList().Count - 1;
            driver = driver.SwitchTo().Window(driver.WindowHandles.ToList()[indexNovaAba]);
            Assert.Contains("Emitido", rpt.TitleRptEmitido.Text); ;
        }

        public void ValidaColunasHabilitadas()
        {
            int colunas = 0;
            foreach (IWebElement categoriaColunas in rpt.EditDefinicaoColunasCategoria)
            {
                categoriaColunas.Click();
                System.Threading.Thread.Sleep(1000);
                colunas += rpt.EditDefinicaoLinhasDeColunaSelect.Count;
                categoriaColunas.Click();
                System.Threading.Thread.Sleep(800);
            }
            Assert.Equal(colunas, qtdColunasRpt);
        }

        public void CliqueExecutarRelatorio()
        {
            if (relatorioEdit != null)
            {
                relatorioEdit.FindElement(By.TagName("a[data-content='Executar Relatório']")).Click();
            }
        }

        public void ValidaRelatorioFoiExcluido(string nome)
        {
            bool achou = false;
            foreach(IWebElement report in rpt.RelatoriosImportados)
            {
                if (nome.Equals(report.FindElement(By.CssSelector("td:nth-child(1)")).Text))
                    achou = true;
            }
            Assert.True(!achou);
        }


        public void CliqueActionsCriarRptApartirDestaDefinicao(string reportName)
        {
            RelatorioIsImportado(reportName);
            if (relatorioEdit != null)
            {
                relatorioEdit.FindElement(By.CssSelector("td:nth-child(6)")).Click();
                rpt.ListaContainerActions[indexContainerAction].FindElement(By.TagName("a[data-content='Criar Relatório a partir desta definição']")).Click();
            }
        }


        //public void CliqueActionsCriarRptApartirDestaDefinicao(string reportName)
        //{
        //    foreach (IWebElement report in rpt.RelatoriosImportados)
        //    {
        //        if (reportName.Equals(report.FindElement(By.CssSelector("td:nth-child(2)")).Text))
        //        {
        //            report.FindElement(By.CssSelector("td:nth-child(6)")).Click();
        //            System.Threading.Thread.Sleep(800);
        //            rpt.ListaContainerActions[indexContainerAction].FindElement(By.TagName("a[data-content='Criar Relatório a partir desta definição']")).Click();
        //            break;
        //        }
        //    }
        //}

        public void SalvarRptApartirDestaDefinicao()
        {
            System.Threading.Thread.Sleep(1000);
            rpt.SalvarRptApartirDestaDefinicao.Click();
        }

        public void ValidaUrlGerenciadorDeRelatorios()
        {
            Assert.Equal(rpt.UrlIndexGerenciadorRelatorios, driver.Url);
        }
    }
}
