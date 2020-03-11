using OpenQA.Selenium;
using QACoreBusiness.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace QACoreBusiness.Util.COM
{
    class RequisitarUtil
    {
        ElementsCOMPedido pedido;
        ElementsCOSOrdemServico cos;
        IWebDriver driver;
        string numPedido;
        string numOS;

        public RequisitarUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            pedido = new ElementsCOMPedido { chromeDriver = driver };
            cos = new ElementsCOSOrdemServico { chromeDriver = driver };
        }

        public void CliqueRequisitarItensNaoReservados()
        {
            pedido.BotaoRequisitarItens.Click();
            Thread.Sleep(2000);
        }

        public void CliqueExecutarGerarRequisicoes()
        {
            pedido.BotaoExecutarRequisicoes.Click();
        }

        public void ArmazeneNumeroPedido()
        {
            Thread.Sleep(500);
            numPedido = pedido.TituloPedido.Text.Replace(" - Venda de Mercadorias e Serviços", "");
        }

        public void ValideRequicaoGeradaByNumPedido()
        {
            Thread.Sleep(500);
            string numPed = pedido.ListaRequisicoes[0].FindElement(By.CssSelector("td:nth-child(11)")).Text;
            Assert.Equal(numPedido.Replace("/", "-"), numPed);
        }

        public void ValidaRequisicaoGeradaBySituacao(string situacao)
        {
            Thread.Sleep(500);
            Assert.Equal(situacao, pedido.ListaRequisicoes[0].FindElement(By.CssSelector("td:nth-child(9)")).Text);
        }

        public void CliqueGerarOSProducao()
        {
            Thread.Sleep(500);
            pedido.ListaRequisicoes[0].FindElement(By.CssSelector("td:nth-child(14) > div > div > a > img")).Click();
            Thread.Sleep(500);
            pedido.BotaoGerarOSProducao.Click();
        }

        public void CliqueGerarProducaoModal()
        {
            Thread.Sleep(1500);
            pedido.BotaoGerarProducaoModal.Click();
        }

        public void CliqueActionsDetalhesRequisicao()
        {
            Thread.Sleep(2000);
            pedido.ListaRequisicoes[0].FindElement(By.CssSelector("td:nth-child(14) > div > div > a > img")).Click();
            Thread.Sleep(500);
            pedido.BotaoDetalhesRequisicao.Click();
        }

        public void MemorizeNumeroOSGerada()
        {
            string[] textoSeparado = pedido.DetalhesRequisicaoNumeroOSGerada.Text.Split(" ");
            numOS = textoSeparado[0];
        }

        public void ValideNumeroOSGerada()
        {
            Thread.Sleep(1000);
            string codigoOS = cos.ListaOS[0].FindElement(By.CssSelector("td:nth-child(1)")).Text;
            Assert.Equal(numOS, codigoOS);
        }
    }
}
