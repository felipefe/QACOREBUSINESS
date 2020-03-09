using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using QACoreBusiness.Elements;
using System.Threading;
using Xunit;

namespace QACoreBusiness.Util.GEM
{
    class InventarioExecucaoUtil
    {
        IWebDriver driver;
        ElementsGEMInvetario inventario;
        int nomeInventario;

        public InventarioExecucaoUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            inventario = new ElementsGEMInvetario { chromeDriver = driver };
        }

        public void MemorizarNomeUltimoInventario()
        {
            Thread.Sleep(1000);
            nomeInventario = Int32.Parse(inventario.ListaInvetarios[0].FindElement(By.CssSelector("td:nth-child(1)")).Text);
        }

        public void CliqueBotaoNovoInventario()
        {
            Thread.Sleep(1000);
            inventario.BotaoNovoIncluir.Click();
        }

        public void SelecioneEmpresa(string empresa)
        {
            Thread.Sleep(1000);
            inventario.SelectEmpresaInvetario.Click();
            inventario.SearchGenerico.SendKeys(empresa);
            Thread.Sleep(2000);
            inventario.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void CliqueBotaoCriar()
        {
            Thread.Sleep(1000);
            inventario.BotaoCriarModal.Click();
        }

        public void ValidaNomeInventarioCriado()
        {
            string inventarioAtual = inventario.ListaInvetarios[0].FindElement(By.CssSelector("td:nth-child(1)")).Text;
            Assert.Equal("0" + nomeInventario.ToString(), inventarioAtual);
        }

        public void CliqueBotaoProdutosActions()
        {
            Thread.Sleep(2000);
            inventario.ListaInvetarios[0].FindElement(By.TagName("img[alt='Opções']")).Click();
            Thread.Sleep(1000);
            inventario.ActionsInventarioProdutos.Click();
        }

        public void SelecioneProduto(string produto)
        {
            Thread.Sleep(1000);
            inventario.SelectProdutoInventario.Click();
            inventario.SearchGenerico.SendKeys(produto);
            Thread.Sleep(2000);
            inventario.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void FlagVincularTodosLotes()
        {
            inventario.FlagVincularTodosOsLotes.Click();
        }

        public void CliqueBotaoIniciarExecucao()
        {
            Thread.Sleep(2000);
            inventario.ListaInvetarios[0].FindElement(By.TagName("img[alt='Opções']")).Click();
            Thread.Sleep(1000);
            inventario.ActionsInvetarioIniciarExecucao.Click();
        }

        public void CliqueBotaoIniciarExecucaoModal()
        {
            Thread.Sleep(1000);
            inventario.BotaoIniciarModal.Click();
        }

        public void InformeQuantidadeInvetariada(int quantidade)
        {
            Thread.Sleep(2000);
            foreach(IWebElement produto in inventario.ListaProdutos)
            {
                IWebElement qtdInventariada = produto.FindElement(By.CssSelector("td:nth-child(6) > div > input"));
                qtdInventariada.Clear();
                Thread.Sleep(500);
                qtdInventariada.SendKeys(quantidade.ToString());
                Thread.Sleep(1000);
            }
        }

        public void SelecioneOpFiscalInvestario(string opFiscal)
        {
            
        }

        public void CliqueBotaoConcluirProcesso()
        {
            inventario.BotaoConcluirExecuçao.Click();
        }

        public void CliqueBotaoCriarProduto()
        {
            Thread.Sleep(1500);
            inventario.BotaoSalvarProcessoExecutarInventario.Click();
        }

        public void CliqueIncluirProduto()
        {
            inventario.BotaoNovoIncluir.Click();
        }

        public void InformeNomeInventario()
        {
            nomeInventario++;
            inventario.InputNomeInvetario.SendKeys("0" + nomeInventario.ToString());
        }
    }
}
