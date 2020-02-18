using System;
using System.Collections.Generic;
using System.Globalization;
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
        Double rateioValorMultiplosMeio;
        Double auxJurosMulta;
        Double auxValorOriginal;

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

        //aqui o codigo fica loko - passo gerenciar a nova janela aberta do navegador
        public void ValidaRedirecionamentoListarParcelasBaixa()
        {
            //String z = driver.CurrentWindowHandle.ToString(); //obtem a janela anterior
            //List<String> tte = driver.WindowHandles.ToList(); //obtem uma lista com as janelas abertas
            //IWebDriver novo = driver.SwitchTo().Window(driver.WindowHandles.ToList()[driver.WindowHandles.ToList().Count-1]) ;
            int lastIndex = driver.WindowHandles.ToList().Count-1; //obtem a quantidade de janelas abertas -1 (ou seja a ultima janela aberta)
            driver = driver.SwitchTo().Window(driver.WindowHandles.ToList()[lastIndex]);
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
            //falha qndo nao encontra credito para pagar
            Assert.NotNull(ParcelaCreditoAbatimento);
        }

        public void ValidaVencimentoParcelaRetroativoDataAtual()
        { //nao consegui fazer como eu queria com formato pt-BR
            String texto = gestor.LinhasTabelaParcelasGestor[0].FindElement(By.CssSelector("td:nth-child(2)")).Text;
            DateTime dataVen = DateTime.ParseExact( texto, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime dataAtu = DateTime.Now ;
            //falha qndo data vencimento maior q data atual
            Assert.True(DateTime.Compare( dataAtu , dataVen ) > 0);
        }

        public void SelecionarSegundoMeioPagamentoMultiplosMeios(string segundoMeio)
        {
            gestor.SelectSegundoMeioPagamentoMultiplosMeios.Click();
            gestor.SearchGenerico.SendKeys(segundoMeio);
            Thread.Sleep(1000);
            gestor.SearchGenerico.SendKeys(Keys.Enter);
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

        public void RatearValorParcela(int rateio)
        {
            Double valorRateio = Double.Parse(gestor.InputValorMultiplosMeiosPagto.GetAttribute("value").Replace(".", "").Replace(",", "."));
            rateioValorMultiplosMeio = valorRateio / rateio;
            gestor.InputValorMultiplosMeiosPagto.Clear();
            Thread.Sleep(1000);
            gestor.InputValorMultiplosMeiosPagto.SendKeys(Keys.ArrowRight + rateioValorMultiplosMeio.ToString("N2"));
            //arrowRight clica pra inserir os digitos antes da virgula no input, por padrao insere depois e caga o valor
        }

        public void SelectSegundoPlanoContasMeioPagamento(string pc)
        {
            gestor.SelectSegundoPlanoContasMultiplosMeios.Click();
            gestor.SearchGenerico.SendKeys(pc);
            Thread.Sleep(1000);
            gestor.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void SelectSegundoCentroCusto(string cc)
        {
            gestor.SelectSegundoCentroCustoMultiplosMeios.Click();
            gestor.SearchGenerico.SendKeys(cc);
            Thread.Sleep(1000);
            gestor.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void InformarSegundoHistoricoMultiplosMeios(string historico)
        {
            gestor.InputSegundoHistoricoMultiplosMeiosPagto.SendKeys(historico);
        }

        public void CliqueSalvarSegundoMeioPagamento()
        {
            gestor.BotaoSalvarSegundoMultiplosMeiosPagto.Click();
        }

        public void ValidaValorAddMultiplosMeio()
        {
            Assert.Equal(rateioValorMultiplosMeio, Double.Parse(gestor.TextViewValorAddFirstMultiplosMeios.Text.Replace(".", "").Replace(",", ".")));
        }

        public void CliqueBotaoEditarJurosMulta()
        {
            gestor.ParcelaABaixar.FindElement(By.CssSelector("td:nth-child(11)")).FindElement(By.TagName("a[title='Editar valor / Data Movimento']")).Click();
        }

        public void MemorizarValorOriginalParcela()
        {
            auxValorOriginal = Double.Parse(gestor.ValorOriginalParcelaModal.Text.Replace("Valor Original", "").Replace(".","").Replace(",","."));
        }

        public void ValidaValorLiquidoMaiorQueValorOriginal()
        {
            Double auxValorLiquido = Double.Parse(gestor.ValorLiquidoPagarParcelaModal.Text.Replace("Valor Liquido Pagar", "").Replace("R$ ", "").Replace(".", "").Replace(",", "."));
            Assert.True(auxValorLiquido > auxValorOriginal);
        }

        public void EditarValorPagarParcelaJurosMulta()
        {
            gestor.InputValorPagarDescontoJurosParcela.Clear();
            Thread.Sleep(1000);
            gestor.InputValorPagarDescontoJurosParcela.SendKeys(Keys.ArrowRight + auxValorOriginal.ToString("N2"));
            gestor.InputValorPagarDescontoJurosParcela.SendKeys(Keys.Tab);
            Thread.Sleep(1000);
        }

        public void CliqueAlterarDadosBaixaParcela()
        {
            gestor.BotaoEditarDadosBaixaParcela.Click();
            Thread.Sleep(500);
        }

        public void MarcarFlagAlterarDataMovimento()
        {
            gestor.FlagAlterarDataPagamentoParaMovimento.Click();
        }

        public void CliqueAlterarDadosBaixaModificados()
        {
            gestor.BotaoAlterarDadosBaixa.Click();
        }

        public void ClicarGravarDescontoJurosMulta()
        {
            gestor.BotaoGravarJurosMulta.Click();
        }

        public void DesabilitarFlagBaixaParcial()
        {
            gestor.FlagBaixaParcial.Click();
            Thread.Sleep(500);
        }

        public void ValorPagarIgualValorOriginal()
        {
            Double valorOriginal = Double.Parse(gestor.ParcelaABaixar.FindElement(By.CssSelector("td:nth-child(4)")).Text.Replace("R$ ", "").Replace(".", "").Replace(",", "."));
            Double valorPagar = Double.Parse(gestor.ParcelaABaixar.FindElement(By.CssSelector("td:nth-child(8)")).Text.Replace("R$ ", "").Replace(".", "").Replace(",", "."));
            Assert.Equal(valorOriginal, valorPagar);
        }

        public void ValidaValorDesconto()
        {
            Double desconto = Double.Parse(gestor.ParcelaABaixar.FindElement(By.CssSelector("td:nth-child(6)")).Text.Replace("R$ ", "").Replace(".", "").Replace(",", "."));
            Assert.Equal(auxJurosMulta, desconto);
        }

        public void ValidaDataVencimentoEMovimento()
        {
            string vencimento = gestor.ParcelaABaixar.FindElement(By.CssSelector("td:nth-child(3)")).Text;
            string movimento = gestor.ParcelaABaixar.FindElement(By.CssSelector("td:nth-child(9)")).Text;
            Assert.Equal(vencimento, movimento);
        }

        public void ValidaJurosZerados()
        {
            Assert.Equal("R$ 0,00", gestor.ParcelaABaixar.FindElement(By.CssSelector("td:nth-child(5)")).Text);
        }

        public void MemorizarValorJurosMulta()
        {
            auxJurosMulta = Double.Parse(gestor.JurosMultaParcelaModal.Text.Replace("Juros / Multa", "").Replace(".","").Replace(",","."));
        }

        public void SelecionarContaBancariaSegundoMeio(string contaBancaria)
        {
            gestor.SelectContaBancariaSegundoMeio.Click();
            gestor.SearchGenerico.SendKeys(contaBancaria);
            Thread.Sleep(1500);
            gestor.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void ValidaRestoRateioSegundoMeio()
        {
            Assert.Equal(rateioValorMultiplosMeio, Double.Parse(gestor.TextViewValorAddSecondMultiplosMeios.Text.Replace(".", "").Replace(",", ".")));
        }

        public void ValidaValorRateioInseridoInput()
        {
            Assert.Equal(rateioValorMultiplosMeio, Double.Parse(gestor.InputSegundoValorMultiplosMeiosPagto.GetAttribute("value").Replace(".", "").Replace(",", ".")));
        }

        public void SelecionarParcelasDeAbatimento()
        {
            int index = 0;
            Double valTotalSelecionado;
            do
            {
                gestor.LinhasTabelaCreditosAbatimento[index++].FindElement(By.CssSelector("td:nth-child(1)")).FindElement(By.TagName("input[type='checkbox']")).Click();
                valTotalSelecionado = Double.Parse(gestor.ValorTotalCreditosSelecionado.Text.Replace("Total Selecionado : R$ ", "").Replace(".", "").Replace(",", "."));
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
