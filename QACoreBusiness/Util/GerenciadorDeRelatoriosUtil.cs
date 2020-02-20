using java.lang;
using OpenQA.Selenium;
using QACoreBusiness.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace QACoreBusiness.Util
{
    class GerenciadorDeRelatoriosUtil
    {
        IWebDriver driver = Base.chromeDriver;
        IWebElement relatorioEdit = null;
        ElementsRPTGerenciadorDeRelatorios rpt;
        int indexContainerAction;

        public GerenciadorDeRelatoriosUtil()
        {
            rpt = new ElementsRPTGerenciadorDeRelatorios();
        }

        public void AcesseContextoGerenciadorRelatorio()
        {
            rpt.ContextoGerenciadoRelatorios.Click();
            System.Threading.Thread.Sleep(1000);
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

        public void CliqueActionEditarDefinicao()
        {
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
                    IWebElement elemento = coluna.FindElement(By.CssSelector("div.fitted.ui.toggle.checkbox > label"));
                    System.Threading.Thread.Sleep(600);
                    elemento.Click();
                }
                categoriaColunas.Click();
                System.Threading.Thread.Sleep(1000);
            }
        }

        public void ValidaRelatorioFoiExcluido(string nome)
        {
            int achou = 0;
            foreach(IWebElement report in rpt.RelatoriosImportados)
            {
                if (nome.Equals(report.FindElement(By.CssSelector("td:nth-child(1)")).Text))
                    achou++;
            }
            Assert.True(achou==0);
        }

        public void CliqueActionsCriarRptApartirDestaDefinicao()
        {
            if (relatorioEdit != null)
            {
                relatorioEdit.FindElement(By.CssSelector("td:nth-child(6)")).Click();
                rpt.ListaContainerActions[indexContainerAction].FindElement(By.TagName("a[data-content='Criar Relatório a partir desta definição']")).Click() ;
            }
        }

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
