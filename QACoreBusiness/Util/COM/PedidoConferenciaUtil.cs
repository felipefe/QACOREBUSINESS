using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using QACoreBusiness.Elements;
using Xunit;
using System.Threading;

namespace QACoreBusiness.Util
{
    class PedidoConferenciaUtil
    {
        IWebDriver driver;
        ElementsCOMPedidoWorkflow conferencia;
        private string auxSKU;
        private string auxQtd;
        List<string> conferenciasSKUProduto = new List<string>();
        List<string> conferenciasQTDProduto = new List<string>();

        public PedidoConferenciaUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            conferencia = new ElementsCOMPedidoWorkflow { chromeDriver = driver };
        }

        public void CliqueActionsConferenciaPedido()
        {
            Thread.Sleep(800);
            conferencia.ActionsConferenciaPedido.Click();
        }

        public void IndexConferenciaPedido()
        {
            Assert.Contains(conferencia.UrlConferenciaPedido, driver.Url);
        }

        public void CopiarCodigoSKU()
        {
            SetCodigoProdutoConferir();
        }

        public void ColarCodigoSKU()
        {
            conferencia.EditTextCodigoProduto.SendKeys(GetCodigoProdutoConferir());
        }

        public void CopiarQuantidadeConferencia()
        {
            SetQuantidadeProdutoConferir();
        }

        public void ColarQuantidadeConferencia()
        {
            conferencia.EditTextQuantidadeProduto.SendKeys(GetQuantidadeProdutoConferir());
        }

        public void CliqueEnterConferir()
        {
            Thread.Sleep(1000);
            conferencia.EditTextQuantidadeProduto.SendKeys(Keys.Enter);
            
        }

        public void MensagemConferenciaPedido()
        {
            Assert.Contains("conferido com sucesso!", conferencia.MensagemConferidoSucesso.Text);
        }

        public void ColarQuantidadeErradaConferencia()
        {
            int aux = Int32.Parse(GetQuantidadeProdutoConferir());
            conferencia.EditTextQuantidadeProduto.SendKeys((aux+aux).ToString());
        }

        public void ColarCodigoSkuErradoConferencia()
        {
            string aux = GetCodigoProdutoConferir() + "éUsGuri";
            conferencia.EditTextCodigoProduto.SendKeys(aux);
        }

        //implementado para facilitar futuramente
        private string GetCodigoProdutoConferir()
        {
            return auxSKU;
        }

        private string GetQuantidadeProdutoConferir()
        {
            return auxQtd;
        }

        private void SetCodigoProdutoConferir()
        {
            auxSKU = conferencia.ColunaCodigoProduto.Text;
        }

        public void CliqueBotaoReiniciar()
        {
            conferencia.BotaoReiniciarProcesso.Click();
        }
        public void CliqueBotaoReiniciarConferenciaFinalizada()
        {
            conferencia.BotaoReiniciarConferenciaFinalizada.Click();
        }

        public void CopiarCodigoSkuEQtdEmMassa()
        {
            Thread.Sleep(1000);
            foreach (IWebElement linha in conferencia.LinhasTabelaHtmlConferencia)
            {
                conferenciasSKUProduto.Add(linha.FindElement(By.CssSelector("td:nth-child(2)")).Text);
                conferenciasQTDProduto.Add(linha.FindElement(By.CssSelector("td:nth-child(5)")).Text);
            }
        }

        public void ColarCodigoSkuEQtdEmMassa()
        {
            for (int i=0; i<conferenciasSKUProduto.Count; i++)
            {
                conferencia.EditTextCodigoProduto.Clear();
                conferencia.EditTextCodigoProduto.SendKeys(conferenciasSKUProduto[i]);
                conferencia.EditTextQuantidadeProduto.Clear();
                conferencia.EditTextQuantidadeProduto.SendKeys(conferenciasQTDProduto[i]);
                conferencia.EditTextQuantidadeProduto.SendKeys(Keys.Enter);  
            }
           
        }

        public void ConfirmarReiniciarConferencia()
        {
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
        }

        public void CliqueConcluirProcessoConferencia()
        {
            conferencia.BotaoConcluirProcesso.Click();
        }

        
        private void SetQuantidadeProdutoConferir()
        {
            auxQtd = conferencia.ColunaQtdTotalProduto.Text;
        }

        public void ColunaQuantidadeConferidaDivergente()
        {
            int conferir = Int32.Parse(GetQuantidadeProdutoConferir());
            int conferido = Int32.Parse(conferencia.ColunaQtdConferida.Text);
            Assert.True(conferir != conferido);
        }

        public void UrlFinalizarConferenciaCOM()
        {
            Thread.Sleep(1000);
            Assert.Contains(conferencia.UrlFinalizarConferenciaCOM, driver.Url);
        }

        public void CliqueBotaoFinalizarConferenciaCOM()
        {
            conferencia.BotaoFinalizarConferenciaCOM.Click();
        }

        public void CliqueBotaoFinalizar()
        {
            conferencia.BotaoFinalizarConferenciaWMS.Click();
        }

        public void ColunaQuantidadeConferidaZero()
        {
            Thread.Sleep(1000);
            Assert.True((Int32.Parse(conferencia.ColunaQtdConferida.Text) == 0));
        }

        public void MensagemConferenciaCodigoErrado()
        {
            Assert.Contains("não existe ou não é válido para o contexto atual da conferência", conferencia.MensagemConferidoErrado.Text);
        }

        public void MensagemProcessoReiniciado()
        {
            Assert.Contains("Processo de conferência reiniciado com sucesso", conferencia.AlertProcessosConferencia.Text);
        }

        public void MensagemConferenciaFinalizada()
        {
            Assert.Equal("Conferência Finalizada", conferencia.MensagemConferenciaFinalizada.Text);
        }

        public void UrlEntregasRemessasPedidoConferido()
        {
            Thread.Sleep(1000);
            Assert.Contains(conferencia.UrlEntregasRemessasPedidoConferido, driver.Url);
        }
    }
}
