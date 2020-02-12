using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using QACoreBusiness.Elements;
using Xunit;

namespace QACoreBusiness.Util.FIN
{
    class GestorFinanceiroUtil
    {
        ElementsFINGestorFinanceiro gestor;
        IWebDriver driver = Base.chromeDriver;

        public GestorFinanceiroUtil()
        {
            gestor = new ElementsFINGestorFinanceiro();
        }

        public void AcesseIndexGestorFinanceiro()
        {
            gestor.ContextoGestorFinanceiro.Click();
        }

        public void CliqueAbaContasReceber()
        {
            gestor.MenuContasAReceber.Click();
        }

        public void CliquePesquisaGestorFin()
        {
            gestor.PesquisaReceitaGestorFinanceiro.Click();
            Thread.Sleep(2000);
        }

        public void CliqueLimparFiltros()
        {
            gestor.LimparFiltroReceitas.Click();
            Thread.Sleep(1000);
        }

        public void CliqueFiltrarReceitas()
        {
            gestor.BotaoFiltrarReceitas.Click();
            Thread.Sleep(1000);
        }

        public void ValidaQuantidadeParcelasReceitasFiltradas()
        {
            Thread.Sleep(1000);
            Assert.True(Int32.Parse(gestor.TextViewParcelasFiltradas.Text) > 0);
        }

        public void SelecionarPrimeiraParcelaListada()
        {
            gestor.LinhasTabelaParcelasGestor[0].FindElement(By.CssSelector("td:nth-child(1)")).Click();
        }

        public void CliqueMovimentarParcelaSelecionada()
        {
            gestor.IconeMovimentarParcelasSelecionadas.Click();
        }

        public void ValidaValorParcelasSelecionadas()
        {
            Thread.Sleep(1000);
            Assert.NotEqual( "0,00" ,gestor.TextViewValorParcelasMovimentar.Text);
        }

        public void CliqueIconeBaixarParcelas()
        {
            gestor.IconeBaixarParcelasSelecionadas.Click();
        }

        //aqui o codigo fica loko
        public void ValidaRedirecionamentoListarParcelasBaixa()
        {
            //String z = driver.CurrentWindowHandle.ToString(); //obtem a janela anterior
            //List<String> tte = driver.WindowHandles.ToList(); //obtem uma lista com as janelas abertas
            //IWebDriver novo = driver.SwitchTo().Window(driver.WindowHandles.ToList()[driver.WindowHandles.ToList().Count-1]) ;
            int index = driver.WindowHandles.ToList().Count-1; //obtem a quantidade de janelas abertas -1 (ou seja a ultima janela aberta)
            driver = driver.SwitchTo().Window(driver.WindowHandles.ToList()[index]);
            Assert.Contains(gestor.UrlListaParcelasBaixa, driver.Url);
        }

        public void CliqueCollapseExibirMeioPagamentoParcela()
        {
            gestor.CollapseParcela.Click();
        }

        public void SelectMeioPagamentoBaixaParcela(string meioPagamento)
        {
            gestor.SelectMeioPagamentoPagto.Click();
            gestor.SearchMeioPagamentoPagto.SendKeys(meioPagamento);
            Thread.Sleep(1100);
            gestor.SearchMeioPagamentoPagto.SendKeys(Keys.Enter);
        }

        public void CliqueBotaoEfetuarBaixa()
        {
            gestor.BotaoEfetuarBaixa.Click();
        }

        public void ValidaUrlImprimirMovimentacao()
        {
            Thread.Sleep(1000);
            Assert.Equal(gestor.UrlImprimirMovimentacao, driver.Url);
        }
    }
}
