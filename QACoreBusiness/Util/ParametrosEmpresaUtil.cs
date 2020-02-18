using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using QACoreBusiness.Elements;
using Xunit;
using System.Threading;

namespace QACoreBusiness.Util
{
    class ParametrosEmpresaUtil
    {
        IWebDriver driver = Base.GetChromeDriver();
        ElementsParametrosEmpresa parametro;

        public ParametrosEmpresaUtil()
        {
            parametro = new ElementsParametrosEmpresa { chromeDriver = driver };
        }

        public void AcessarContextoEmpresa()
        {
            parametro.ContextoEmpresa.Click();
        }

        public void ValidaUrlContextoEmpresa()
        {
            Assert.Contains(parametro.UrlIndexEmpresa, driver.Url);
        }

        public void CliqueAcessoParametrosEmpresa()
        {
            parametro.BotaoParametrosEmpresa.Click();
        }

        public void ValidaUrlParametrosEmpresa()
        {
            Assert.Contains(parametro.UrlParametroEmpresa, driver.Url);
        }

        public void isHomologacao()
        {
            driver.Navigate().GoToUrl(parametro.UrlIndexEmpresa);
            ValidaUrlContextoEmpresa();
            CliqueAcessoParametrosEmpresa();
            CliqueEditarParametroNFE();
            AmbienteHomologacaoSelecionado();
            driver.Navigate().GoToUrl(Base.UrlCoreBusiness);
        }

        public void CliqueEditarParametroNFE()
        {
            parametro.EditParametroConfigNFE.Click();
        }

        public void ValidaEdicaoParametro(string tituloParametro)
        {
            Assert.Contains(tituloParametro, parametro.TextViewEditTituloParametro.Text);
        }

        public void AmbienteHomologacaoSelecionado()
        {
            Assert.Equal("Ambiente de Testes ou Homologação", parametro.SelectAmbienteHomologacao.Text);
        }

        public void SelecionarAmbienteEmissao(string ambienteEmissao)
        {
            parametro.SelectAmbienteHomologacao.Click();
            parametro.SearchAmbienteEmissao.SendKeys(ambienteEmissao);
            Thread.Sleep(1000);
            parametro.SearchAmbienteEmissao.SendKeys(Keys.Enter);
        }

        public void CliqueSalvarParametro()
        {
            parametro.BotaoSalvarParamConfigNFE.Click();
        }

        public void ColunaComValorDoAmbienteEmissaoAtual()
        {
            Assert.Contains("Ambiente de Testes ou Homologação", parametro.ColunaAmbienteEmissaoAtual.Text);
        }
    }
}
