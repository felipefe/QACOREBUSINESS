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
    class GestorFinanceiroReceitaUtil
    {
        ElementsFINGestorFinanceiro gestor;
        IWebDriver driver = Base.chromeDriver;
        Double auxValorAbater;
        IWebElement ParcelaCreditoAbatimento = null;

        public GestorFinanceiroReceitaUtil()
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
            Thread.Sleep(1500);
        }

        public void CliqueLimparFiltros()
        {
            gestor.LimparFiltroReceitas.Click();
            Thread.Sleep(500);
        }

        public void CliqueFiltrarReceitas()
        {
            gestor.BotaoFiltrarReceitas.Click();
            Thread.Sleep(1000);
        }

        public void ValidaQuantidadeParcelasReceitasFiltradas(int quantidadeParcelas)
        {
            Thread.Sleep(1000);
            Assert.True(Int32.Parse(gestor.TextViewParcelasFiltradas.Text) > quantidadeParcelas);
        }

        public void SelecionarPrimeiraParcelaListada()
        {
            gestor.LinhasTabelaParcelasGestor[0].FindElement(By.CssSelector("td:nth-child(1)")).Click();
        }

        public void SelecionarSegundaParcelaListada()
        {
            gestor.LinhasTabelaParcelasGestor[1].FindElement(By.CssSelector("td:nth-child(1)")).Click();
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
            gestor.SearchGenerico.SendKeys(meioPagamento);
            Thread.Sleep(1000);
            gestor.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void CliqueBotaoAdicionarMultiplosMeiosPagamento()
        {
            gestor.BotaoAddMultiplosMeiosPagto.Click();
            Thread.Sleep(1000);
        }

        public void SelecionarParcelaAbatimentoSeHouver()
        {
            
            ParcelaCreditoAbatimento.Click();
        }

        public void FindParcelaCredito()
        {
            Double valorPagar = Double.Parse(gestor.ValorPagarParcelaBaixa.Text.Replace("R$ ", "").Replace(".", "").Replace(",", "."));
            gestor.SelectParcelaAbatimento.Click();
            Thread.Sleep(2000);

            foreach (IWebElement parcela in gestor.ParcelasCreditoParaAbatimentoUnico)
            {
                String[] separado = parcela.Text.Split("$");
                Double valorParcela = Double.Parse(separado[1].Replace(" ", ""));
                if (valorParcela >= valorPagar)
                {
                    ParcelaCreditoAbatimento = parcela;
                }
            }
            //aqui falha qndo nao encontra credito para pagar
            Assert.NotNull(ParcelaCreditoAbatimento);
        }

        public void SelecionarContaBancaria(string conta)
        {
            gestor.SelectContaBancaria.Click();
            gestor.SearchGenerico.SendKeys(conta);
            Thread.Sleep(1000);
            gestor.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void CliqueBotaoEfetuarBaixa()
        {
            Thread.Sleep(1000);
            gestor.BotaoEfetuarBaixa.Click();
        }

        public void SelecionarMeioPagamentoMultiplosMeios(string meioPagamento)
        {
            gestor.SelectMeioPagamentoMultiplosMeios.Click();
            gestor.SearchGenerico.SendKeys(meioPagamento);
            Thread.Sleep(1000);
            gestor.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void ValidaUrlImprimirMovimentacao()
        {
            Thread.Sleep(1000);
            Assert.Equal(gestor.UrlImprimirMovimentacao, driver.Url);
        }

        public void SelecionarPlanoContasMultiplosMeios(string pC)
        {
            gestor.SelectPlanoContasMultiplosMeios.Click();
            gestor.SearchGenerico.SendKeys(pC);
            Thread.Sleep(1000);
            gestor.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void InputHistoricoMultiplosMeioPagto(string historico)
        {
            gestor.InputHistoricoMultiplosMeiosPagto.SendKeys(historico);
        }

        public void CliqueSalvarMultiplosMeiosPagto()
        {
            gestor.BotaoSalvarMultiplosMeiosPagto.Click();
            Thread.Sleep(1500);
        }

        public void CliqueVincularParcelasAbatimento()
        {
            gestor.BotaoVincularParcelaAbatimento.Click();
        }

        public void MemorizarValorAbater()
        {
            string substituida = gestor.ValorParcelasAbatimento.Text.Replace("Valor", "").Replace(".", "").Replace(",",".");
            auxValorAbater = Double.Parse(substituida);
        }

        public void ValidaTotalCreditosEValorQuitar()
        {
            string valorTotalCreditos = gestor.ValorTotalParcelasCredito.Text.Replace("Total : R$ ", "").Replace(".", "").Replace(",", ".");
            Assert.True(Double.Parse(valorTotalCreditos) >= auxValorAbater);
        }

        public void SelecionarParcelasDeAbatimento()
        {
            int index = 0;
            Double valTotalSelecionado;
            do
            {
                gestor.LinhasTabelaCreditosAbatimento[index++].FindElement(By.CssSelector("td:nth-child(1)")).FindElement(By.TagName("input[type='checkbox']")).Click();
                string valorTotalSelecionado = gestor.ValorTotalCreditosSelecionado.Text.Replace("Total Selecionado : R$ ", "").Replace(".", "").Replace(",", ".");
                valTotalSelecionado = Double.Parse(valorTotalSelecionado);
            } while (valTotalSelecionado < auxValorAbater);
            Thread.Sleep(1000);
            Assert.True(valTotalSelecionado >= auxValorAbater);

        }

        public void ValidaQuantidadeCreditos(int qntidade)
        {
            string creditos = gestor.CreditosDisponiveisAbatimento.Text.Replace("Créditos diponíveis: ", "");
            Assert.True(Int32.Parse(creditos) > qntidade);
        }

        public void CliqueSalvarCreditosSelecionados()
        {
            gestor.BotaoSalvarParcelaSelecionadasAbatimento.Click();
        }

        public void SelecionarCentroCustoMultiplosMeios(string cC)
        {
            gestor.SelectCentroCustoMultiplosMeios.Click();
            gestor.SearchGenerico.SendKeys(cC);
            Thread.Sleep(1000);
            gestor.SearchGenerico.SendKeys(Keys.Enter);
        }
    }
}
