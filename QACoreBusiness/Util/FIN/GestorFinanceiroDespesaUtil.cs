﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using QACoreBusiness.Elements;
using Xunit;

namespace QACoreBusiness.Util.FIN
{
    class GestorFinanceiroDespesaUtil
    {
        IWebDriver driver;
        ElementsFINGestorFinanceiro gestor;

        public GestorFinanceiroDespesaUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            gestor = new ElementsFINGestorFinanceiro { chromeDriver = driver };
        }

        public void CliqueAbaContasPagar()
        {
            gestor.MenuContasAPagar.Click();
        }

        public void CliquePesquisarDespesas()
        {
            Thread.Sleep(1000);
            gestor.PesquisaDespesaGestorFinanceiro.Click();
            Thread.Sleep(1000);
        }

        public void CliqueLimparFiltro()
        {
            Thread.Sleep(1000);
            gestor.LimparFiltroDespesas.Click();
            Thread.Sleep(1500);
        }

        public void CliqueFiltrarDespesa()
        {
            gestor.BotaoFiltrarDespesa.Click();
            Thread.Sleep(1000);
        }

        public void ValidaQtdDespesasFiltradas(int parcelasFiltradas)
        {
            Thread.Sleep(1000);
            Assert.True(Int32.Parse(gestor.TextViewParcelasFiltradasDespesa.Text) > parcelasFiltradas);
        }

        public void SelecionarPrimeiraLinhaTabela()
        {
            Thread.Sleep(1000);
            gestor.LinhasTabelaDespesas[0].FindElement(By.CssSelector("td:nth-child(1)")).Click();
        }

        public void CliqueMovimentarParcela()
        {
            gestor.IconeMovimentarDespesasSelecionadas.Click();
        }

        public void ValidaValorMovimentacao()
        {
            Thread.Sleep(3000);
            Assert.NotEqual("0,00", gestor.TextViewValorParcelasMovimentarDespesa.Text);
        }

        public void CliqueIconeBaixarDespesa()
        {
            gestor.IconeBaixarParcelasDespesasSelecionadas.Click();
        }

        public void SelecionarContaBancariaPagamento(string contaBancaria)
        {
            gestor.SelectContaBancariaDespesa.Click();
            gestor.SearchGenerico.SendKeys(contaBancaria);
            Thread.Sleep(1000);
            gestor.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void SelectCaixaRecebidoCheque(string caixa)
        {
            Thread.Sleep(2000);
            gestor.SelectCaixaRecebido.Click();
            gestor.SearchGenerico.SendKeys(caixa);
            Thread.Sleep(2000);
            gestor.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void InformeDataEntradaChequeEmCaixa()
        {
            Thread.Sleep(1000);
            gestor.InputDataEntradaChequeEmCaixa.SendKeys(DateTime.Now.ToString("dd/MM/yyyy hh:mm"));
        }

        public void CliqueNovoLancarNovoChequeProprioViaIndex()
        {
            Thread.Sleep(2000);
            gestor.BotaoLancarChequeProprio.Click();
        }
    }
}
