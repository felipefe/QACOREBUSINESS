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
        IWebDriver driver;
        IWebElement ParcelaCreditoAbatimento = null;
        string novoVencimento;
        string numDoc;
        string numCheque;
        string nomeCliente;
        Double auxValorAbater;
        Double auxValorRenegociar;
        Double rateioValorMultiplosMeio;
        Double auxJurosMulta;
        Double auxValorOriginal;

        public GestorFinanceiroReceitaUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            gestor = new ElementsFINGestorFinanceiro { chromeDriver = driver };
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

        public void SalvarParcelaByModalContrato()
        {
            Thread.Sleep(2000);
            gestor.BotaoSalvarParcela.Click();
        }

        public void AddParcelaByModalContrato()
        {
            Thread.Sleep(1000);
            gestor.AddParcelaContratoByModal.Click();
        }

        public void CliqueAbrirlModalCriarContrato()
        {
            Thread.Sleep(1000);
            gestor.BotaoCriarContratoByModal.Click();
            Thread.Sleep(2000);
        }

        public void CliqueBotaoAcoesSubstituir()
        {
            Thread.Sleep(1000);
            gestor.AcoesSubstituir.Click();
            int lastIndex = driver.WindowHandles.ToList().Count - 1; //lanca o driver para nova janela aberta
            driver = driver.SwitchTo().Window(driver.WindowHandles.ToList()[lastIndex]);
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

        public void ValidaVencimentoParcelaRetroativoDataAtual()
        { //nao consegui fazer como eu queria com formato pt-BR
            String texto = gestor.LinhasTabelaParcelasGestor[0].FindElement(By.CssSelector("td:nth-child(2)")).Text;
            DateTime dataVen = DateTime.ParseExact(texto, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime dataAtu = DateTime.Now;
            //falha qndo data vencimento maior q data atual
            Assert.True(DateTime.Compare(dataAtu, dataVen) > 0);
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

        public void InserirDataEmissaoCheque(int dataEmissao)
        {
            Thread.Sleep(3000);
            gestor.InputDataEmissaoCheque.SendKeys(DateTime.Now.AddDays(-dataEmissao).ToString("dd/MM/yyyy"));
        }

        public void InserirNumeroCheque()
        {
            Thread.Sleep(2000);
            numCheque = new Random().Next(1000000, 9999999).ToString();
            gestor.InputNumeroCheque.SendKeys(numCheque);
        }

        public void SelecionarEmitenteCheque(string emitente)
        {
            Thread.Sleep(1000);
            gestor.SelectBancoEmitente.Click();
            gestor.SearchGenerico.SendKeys(emitente);
            Thread.Sleep(2000);
            gestor.SearchGenerico.SendKeys(Keys.Enter);

        }

        public void InserirObservacaoCheque(string observacao)
        {
            Thread.Sleep(1000);
            gestor.TextAreaObservacao.SendKeys(observacao);
        }

        public void SelecioneChequeCriado()
        {
            Thread.Sleep(2000);
            gestor.SelectCheque.Click();
            gestor.SearchGenerico.SendKeys(numCheque);
            Thread.Sleep(2000);
            gestor.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void RemovaContaBancariaBaixa()
        {
            Thread.Sleep(1000);
            gestor.RemoverContaBancariaBaixa.Click();
        }

        public void MemorizarNomeClienteParcela()
        {
            Thread.Sleep(1000);
            nomeCliente = gestor.ParcelaABaixar.FindElement(By.CssSelector("td:nth-child(1)")).Text.Trim();
        }

        public void CliqueLancarNovoChequeTerceiro()
        {
            Thread.Sleep(2000);
            gestor.BotaoLancarChequeTerceiro.Click();
        }

        public void CliqueVincularNovoChequeMultiplosMeios()
        {
            Thread.Sleep(2000);
            gestor.BotaoVincularChequeMultiplosMeios.Click();
        }

        public void CliqueEnter()
        {
            Thread.Sleep(2000);
            gestor.InputBuscarCheques.SendKeys(Keys.Enter);
        }

        public void CliqueBotaoCadastrarNovoCheque()
        {
            Thread.Sleep(2000);
            gestor.BotaoIncluirNovoCheque.Click();
        }

        public void SelecioneEmpresaCheque(string empresa)
        {
            Thread.Sleep(1000);
            gestor.SelectEmpresaCheque.Click();
            gestor.SearchGenerico.SendKeys(empresa);
            Thread.Sleep(1500);
            gestor.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void PesquiseChequeCriado()
        {
            Thread.Sleep(1000);
            gestor.InputBuscarCheques.SendKeys(numCheque);
            Thread.Sleep(2000);
            gestor.LinhasTabelaCheques[0].FindElement(By.CssSelector("td:nth-child(1) > input:nth-child(1)")).Click();
        }

        public void SelecioneResponsavelCheque()
        {
            Thread.Sleep(1000);
            gestor.SelectResponsavelCheque.Click();
            gestor.SearchGenerico.SendKeys(nomeCliente);
            Thread.Sleep(1500);
            gestor.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void SelecioneResponsavelCheque(string cliente)
        {
            Thread.Sleep(1000);
            gestor.SelectResponsavelCheque.Click();
            gestor.SearchGenerico.SendKeys(cliente);
            Thread.Sleep(1500);
            gestor.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void InserirDataBomParaCheque()
        {
            Thread.Sleep(1000);
            gestor.InputDataBomParaCheque.SendKeys(DateTime.Now.ToString("dd/MM/yyyy"));
        }

        public void CliqueSalvarChequeModal()
        {
            Thread.Sleep(1000);
            gestor.BotaoSalvarCheque.Click();
            Thread.Sleep(2500);
        }

        public void CliqueLancarCheque()
        {
            Thread.Sleep(1500);
            gestor.BotaoLancarCheque.Click();
        }

        public void CliqueBotaoSubstituirParcela()
        {
            Thread.Sleep(1000);
            gestor.BotaoSubstituirParcela.Click();
        }

        public void SelecioneContratoSubstituto()
        {
            Thread.Sleep(3000);
            gestor.SelectContratoSubstituto.Click();
            gestor.SearchGenerico.SendKeys(numDoc);
            Thread.Sleep(1000);
            gestor.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void MemorizeNumDocContratoSubstituto()
        {
            Thread.Sleep(1000);
            numDoc = gestor.InputNumeroContratoByModal.GetAttribute("value");
        }

        public void ValidaNovaParcelaByModalContratoSubstituir()
        {
            Double pSubstituta = Double.Parse(gestor.InputValorNovaParcelaSubstituta.GetAttribute("value").Replace(".", ",").Replace(",", "."));
            Assert.Equal(auxValorRenegociar, pSubstituta);
        }

        public void MemorizeValorParcelaSubstituir()
        {
            Thread.Sleep(2000);
            auxValorRenegociar = Double.Parse(gestor.ValorParcelaSubstituir.Text);
        }

        public void AddDataVencimentoRetroativaContratoManual(int diasVencidos)
        {
            gestor.InputDataVencimentoManualmente.SendKeys(DateTime.Now.AddDays(-diasVencidos).ToString("dd/MM/yyyy"));
            Thread.Sleep(700);
        }

        public void MemorizarValorLiquidoRenegociar()
        {
            auxValorRenegociar = Double.Parse(gestor.InputValorLiquidoRenegociar.GetAttribute("value").Replace(",", "."));
        }

        public void URLRenegociacao()
        {
            int lastIndex = driver.WindowHandles.ToList().Count - 1; //obtem a quantidade de janelas abertas -1 (ou seja a ultima janela aberta)
            driver = driver.SwitchTo().Window(driver.WindowHandles.ToList()[lastIndex]);
            Assert.Contains(gestor.UrlGerarRenegociacao, driver.Url);
        }

        public void ValidaUrlVisualizarContrato()
        {
            Thread.Sleep(1500);
            int index = driver.WindowHandles.ToList().Count - 1;
            driver = driver.SwitchTo().Window(driver.WindowHandles.ToList()[index]);
            Assert.Contains(gestor.UrlVisualizarContrato, driver.Url);
        }

        public void CliqueMenuAcoes()
        {
            gestor.MenuAcoesDeMovimentacao.Click();
        }

        public void CliqueMenuRenegociar()
        {
            gestor.AcoesRenegociar.Click();
            Thread.Sleep(1000);
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
            Thread.Sleep(1800);
            gestor.BotaoEfetuarBaixa.Click();
        }

        public void SelecionarMeioPagamentoMultiplosMeios(string meioPagamento)
        {
            Thread.Sleep(800);
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

        public void DataEmissaoContratoRetroativa(int dias)
        {
            gestor.InputDataEmissaoContrato.Clear();
            Thread.Sleep(800);
            gestor.InputDataEmissaoContrato.SendKeys(DateTime.Now.AddDays(-dias).ToString("dd/MM/yyyy"));
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

        public void CliqueBotaoSalvarContratoSubstituido()
        {
            Thread.Sleep(2000);
            gestor.BotaoSalvarContratoSubstituido.Click();
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

        public void CliqueMontarRenegociacao()
        {
            gestor.BotaoMontarRenegociacao.Click();
            Thread.Sleep(1000);
        }

        public void CliqueAlterarDadosBaixaModificados()
        {
            gestor.BotaoAlterarDadosBaixa.Click();
        }

        public void CliqueAddParcelaManualRenegociacao()
        {
            Thread.Sleep(1000);
            gestor.BotaoInserirParcelaManualmente.Click();
            Thread.Sleep(1500);
        }

        public void InserirDataVencimentoContratoRenegocicao(int dias)
        {
            novoVencimento = DateTime.Now.AddDays(dias).ToString("dd/MM/yyyy");
            gestor.InputDataVencimentoParcela.SendKeys(novoVencimento);
        }

        public void CliqueSalvarParcela()
        {
            gestor.BotaoSalvarParcela.Click();
        }

        public void ClicarGravarDescontoJurosMulta()
        {
            gestor.BotaoGravarJurosMulta.Click();
        }

        public void ValidaDataInseridaParcela()
        {
            Thread.Sleep(1500);
            Assert.Equal(novoVencimento, gestor.InputDtVencNovaParcelaContratoRenegociacao.GetAttribute("value"));
        }

        public void ValidaValorInseridoParcela()
        {
            Assert.Equal(auxValorRenegociar, Double.Parse(gestor.InputValorNovaParcelaContratoRenegociacao.GetAttribute("value").Replace(",",".")));
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

        public void ValidaValorBrutoParcelaSubstituidaNoViewContrato()
        {
            string valorNovaParcela = gestor.LinhaNovaParcelaContrato.FindElement(By.CssSelector("td:nth-child(12)")).Text;
            string valorParcelaSubstituida = gestor.LinhaParcelaSubstituidaContrato.FindElement(By.CssSelector("td:nth-child(10)")).Text;
            Assert.Equal(valorNovaParcela, valorParcelaSubstituida);
        }

        public void CliqueGerarRenegociacao()
        {
            gestor.BotaoGerarRenegociacao.Click();
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

        public void InsereValorCheque(decimal valor)
        {
            Thread.Sleep(1000);
            gestor.InputValorChequeTerceiro.Clear();
            Thread.Sleep(1000);
            gestor.InputValorChequeTerceiro.SendKeys(valor.ToString());
        }

        public void ValidaNumeroChequeCadastrado()
        {
            Thread.Sleep(2000);
            string cheque = gestor.ListaChequesTerceiro[0].FindElement(By.CssSelector("td:nth-child(1)")).Text;
            Assert.Equal(numCheque, cheque);
        }

        public void CliqueActionExcluirCheque()
        {
            gestor.ListaChequesTerceiro[0].FindElement(By.CssSelector("td:nth-child(11) > div > div > a")).Click();
            Thread.Sleep(1000);
            gestor.ActionExcluirCheque.Click();
        }

        public void ConfirmeExcluirCheque()
        {
            Thread.Sleep(1000);
            gestor.BotaoExcluirCheque.Click();
        }

        public void ValidaChequeExcluido()
        {
            Thread.Sleep(3000);
            Assert.NotEqual(numCheque, gestor.ListaChequesTerceiro[0].FindElement(By.CssSelector("td:nth-child(1)")).Text);

        }

        public void ValidaStatusCheque(string status)
        {
            Thread.Sleep(1000);
            Assert.Equal(status, gestor.ListaChequesTerceiro[0].FindElement(By.CssSelector("td:nth-child(10)")).Text);
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
            Thread.Sleep(2000);
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
