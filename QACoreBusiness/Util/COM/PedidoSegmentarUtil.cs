using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace QACoreBusiness.Util.COM
{
    class PedidoSegmentarUtil
    {
        IWebDriver driver;
        ElementsCOMPedido segmentar;
        int quantidadeSegmentou;
        List<string> skuSegmentos;

        public PedidoSegmentarUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            segmentar = new ElementsCOMPedido { chromeDriver = driver };
        }

        public void CliqueActionsSegmentarPedido()
        {
            Thread.Sleep(2000);
            segmentar.TabelaPedidos[0].FindElement(By.CssSelector("td:nth-child(13)")).Click();
            Thread.Sleep(2000);
            segmentar.ActionSegmentar.Click();
        }

        public void InformeQuantidadeSegmentar(int quantidade)
        {
            quantidadeSegmentou = quantidade;
            Thread.Sleep(2000);
            skuSegmentos = new List<string>();
            foreach(IWebElement item in segmentar.ListaItensSegmentar)
            {
                skuSegmentos.Add(item.FindElement(By.CssSelector("td:nth-child(1) > div")).Text);
                IWebElement input = item.FindElement(By.CssSelector("td:nth-child(7) > div > div > div > input"));
                input.Clear();
                Thread.Sleep(800);
                input.SendKeys(Keys.ArrowRight);
                input.SendKeys(quantidade.ToString("N4"));
                Thread.Sleep(800);
            }
        }
        

        public void CliqueBotaoSegmentar()
        {
            Thread.Sleep(800);
            segmentar.BotaoSegmentar.Click();
        }

        public void ValidarQuantidadeSegmentada()
        {
            int i = 0;
            bool falhou = false;
            foreach(IWebElement item in segmentar.TabelaItensPedido)
            {
                string sku = item.FindElement(By.CssSelector("td:nth-child(2)")).Text;
                int qtd = Int32.Parse(item.FindElement(By.CssSelector("td:nth-child(5)")).Text);
                if (!skuSegmentos[i].Equals(sku) || !qtd.Equals(quantidadeSegmentou))
                {
                    falhou = true;
                }
                i++;
            }
            Assert.False(falhou);
        }
    }

}

