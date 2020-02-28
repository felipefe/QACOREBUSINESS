using OpenQA.Selenium;
using QACoreBusiness.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace QACoreBusiness.Util.COS
{
    class OrdemServicoNovoSimplesUtil
    {
        public IWebDriver driver;
        public ElementsCOSOrdemServico cos;
        string codigo;

        public OrdemServicoNovoSimplesUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            cos = new ElementsCOSOrdemServico { chromeDriver = driver };
        }

        public void CriarNovoSimples()
        {
            Thread.Sleep(1000);
            cos.BotaoNovoSimples.Click();
        }

        public void SelectTipoOS(string tipoOS)
        {
            cos.SelectTipoOS.Click();
            cos.SearchGenerico.SendKeys(tipoOS);
            Thread.Sleep(1000);
            cos.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void SelectPessoaOS(string pessoaOS)
        {
            cos.SelectPessoaNovoSimples.Click();
            cos.SearchGenerico.SendKeys(pessoaOS);
            Thread.Sleep(1000);
            cos.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void InserePrazoFinalNovoSimples(int dias)
        {
            cos.InputDataPrazoFinalNovoSimples.SendKeys(DateTime.Now.AddDays(dias).ToString("dd/MM/yyyy hh:mm"));
            Thread.Sleep(500);
        }

        public void InsereResumoNovoSimples(string resumo)
        {
            cos.TextAreaResumoNovoSimples.SendKeys(resumo);
        }

        public void InsereObservacaoNovoSimples(string observacao)
        {
            cos.TextAreaObervacaoNovoSimples.SendKeys(observacao);
        }

        public void CliqueSalvarNovoSimples()
        {
            Thread.Sleep(1000);
            cos.BotaoSalvarNovoSimples.Click();
        }

        public void CliqueActionsExcluirOrdemServico()
        {
            int index = 0;
            cos.ListaOS[index].FindElement(By.TagName("img[alt='Opções']")).Click();
            codigo = cos.ListaOS[index].FindElement(By.CssSelector("td:nth-child(1)")).Text;
            cos.ActionExcluir.Click();
        }

        public void InserirJustificativaExcluirOS(string justificativa)
        {
            Thread.Sleep(700);
            cos.TextAreaJustificativa.SendKeys(justificativa);
        }

        public void CliqueBotaoCancelarOS()
        {
            Thread.Sleep(500);
            cos.BotaoCancelarOS.Click();
        }

        public void ValidaUrlEditOrdemServico()
        {
            Thread.Sleep(800);
            Assert.Contains(cos.UrlEditOrdemServico, driver.Url);
        }

        public void ValidaExclusaoOS()
        {
            int index = 0;
            string codOS = cos.ListaOS[index].FindElement(By.CssSelector("td:nth-child(1)")).Text;
            Assert.NotEqual(codigo, codOS);
        }
    }
}
