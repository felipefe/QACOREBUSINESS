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
    class ContratoFinanceiroUtil
    {
        ElementsFINContratos contr;
        IWebDriver driver;
        IWebElement linhaEncontradaTabela;
        private int auxQtdParcelas;
        private decimal auxValorOriginal;
        private string auxNumDocContrato;

        public ContratoFinanceiroUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            contr = new ElementsFINContratos { chromeDriver = driver };
        }

        //encontra a linha que contem o numero do status
        private IWebElement FindLinhaInTabelaByStatus(string status)
        {
            String linhaStatus;
            foreach (IWebElement linha in contr.LinhasTabelaContratosFinanceiro)
            {
                linhaStatus = linha.FindElement(By.CssSelector("td:nth-child(6)")).Text;
                if (status.Equals(linhaStatus))
                {
                    return linha;
                }
                else linhaStatus = "";
            }
            return null;
        }

        //encontra a linha que contem o numero do contrato
        // 1. uso para verificar se existe numDoc apos cenario contrato excluido
        private IWebElement FindLinhaInTabelaByNumDoc(string NumDoc)
        {
            String linhaNumDoc;
            foreach (IWebElement linha in contr.LinhasTabelaContratosFinanceiro)
            {
                linhaNumDoc = linha.FindElement(By.CssSelector("td:nth-child(1)")).Text;
                if (NumDoc.Equals(linhaNumDoc))
                {
                    return linha;
                }
                else linhaNumDoc = "";
            }
            return null;
        }

        //o problema desses 3 metodos: quando vou clicar no botao excluir da actions - esse botao nao ta dentro na tabela e linha encontrada
        //fica em outra estrutura fora de tudo oq foi encontrado ate entao
        //NÂO ESTOU USANDO ESSE METODO
        public void StatusContratoOld(string status)
        {
            linhaEncontradaTabela = FindLinhaInTabelaByStatus(status);
            if (linhaEncontradaTabela != null)
            {
                Assert.Equal(status, linhaEncontradaTabela.FindElement(By.CssSelector("td:nth-child(6)")).Text);
            }
            else Assert.NotNull(linhaEncontradaTabela); //se cai aqui nao achou contrato no status informado

        }

        public void CliqueLancarDespesas()
        {
            contr.HeaderLancarDespesa.Click();
        }

        public void ValidaUrlLancarDespesaContrato()
        {//aqui ele troca o driver pra nova janela aberta
            int index = driver.WindowHandles.ToList().Count -1;
            driver = driver.SwitchTo().Window(driver.WindowHandles.ToList()[index]);
            Assert.Equal(contr.UrlLancarDespesa, driver.Url);
        }

        public void ValidaUrlLancarReceitaContrato()
        {//aqui ele troca o driver pra nova janela aberta
            int index = driver.WindowHandles.ToList().Count - 1;
            driver = driver.SwitchTo().Window(driver.WindowHandles.ToList()[index]);
            Assert.Equal(contr.UrlLancarReceita, driver.Url);
        }

        public void CliqueLancarPagtoAntecipado()
        {
            contr.HeaderLancarPagtoAntecipado.Click();
        }

        public void ValidaUrlContratoPagtoAntecipado()
        {
            Assert.Equal(contr.UrlContratoPagtoAntecipado, driver.Url);
        }

        public void SelecionarMeioPagto(string meioPagamento)
        {
            contr.SelectMeioPagamentoPagtoAntecipado.Click();
            contr.SearchMeioPagamentoPagtoAntecipado.SendKeys(meioPagamento);
            Thread.Sleep(1500);
            contr.SearchMeioPagamentoPagtoAntecipado.SendKeys(Keys.Enter);
        }

        public void InserirValorPagtoAntecipado(decimal valor)
        {
            contr.InputValorContratoPagtoAntecipado.SendKeys(valor.ToString());
            Thread.Sleep(500);
        }


        public void CliqueSalvarPagtoAntecipado()
        {
            contr.BotaoSalvarContrato.Click();
        }

        public void CliqueActionsContratoParcelas()
        {
            contr.ActionsContrato.Click();
            contr.ActionsParcelasContrato.Click();
        }


        public void ValidaUrlContratoParcelas()
        {
            Thread.Sleep(1000);
            Assert.Contains(contr.UrlParcelasContrato, driver.Url);
        }

        public void CliqueCriarContrato()
        {
            contr.HeaderCriarContrato.Click();
        }

        public void ValidaUrlContratoCreate()
        {
            Assert.Equal(contr.UrlCreateContrato, driver.Url);
        }

        public void InserirNumeroContrato()
        {
            contr.InputNumeroContrato.SendKeys((new Random().Next(100000, 999999).ToString()));
        }

        public void SelecionarPessoaContrato(string pessoa)
        {
            contr.SelectPessoaContrato.Click();
            contr.SearchPessoaContrato.SendKeys(pessoa);
            Thread.Sleep(1000);
            contr.SearchPessoaContrato.SendKeys(Keys.Enter);
        }

        public void MemorizarNumeroContrato()
        {
            auxNumDocContrato = contr.FirstLinhaTabelaContrato.FindElement(By.CssSelector("td:nth-child(1)")).Text;
        }

        public void ValidaSituacaoContrato(string status)
        {
            StatusContrato(status);
        }

        public void SelecionarEmpresaContrato(string empresa)
        {
            contr.SelectEmpresaContrato.Click();
            contr.SearchEmpresaContrato.SendKeys(empresa);
            Thread.Sleep(1000);
            contr.SearchEmpresaContrato.SendKeys(Keys.Enter);
        }

        public void SelecionarCentroCusto(string cc)
        {
            contr.SelectCentroCusto.Click();
            contr.SearchCentroCusto.SendKeys(cc);
            Thread.Sleep(1000);
            contr.SearchCentroCusto.SendKeys(Keys.Enter);
        }

        public void SelecionarPlanoContas(string pc)
        {
            contr.SelectPlanoContas.Click();
            contr.SearchPlanoContas.SendKeys(pc);
            Thread.Sleep(1000);
            contr.SearchPlanoContas.SendKeys(Keys.Enter);
        }

        public void InformarHistorico(string historico)
        {
            contr.InputHistoricoContrato.SendKeys(historico);
        }

        public void SelecionarContaPrevista(string contaPrevista)
        {
            contr.SelectContaPrevistaPagto.Click();
            contr.SearchContaPrevistaPagto.SendKeys(contaPrevista);
            Thread.Sleep(2000);
            contr.SearchContaPrevistaPagto.SendKeys(Keys.Enter);
        }

        public void CliqueAddParcelasManualmente()
        {
            contr.BotaoAddParcelasManualmente.Click();
            Thread.Sleep(500);
        }

        public void CliqueSalvarContrato()
        {
            contr.BotaoSalvarContrato.Click();
        }

        public void InserirValorParcelaManualmente(decimal valor)
        {
            auxValorOriginal = valor;
            contr.InputValorOriginalManualmente.SendKeys(valor.ToString());
            Thread.Sleep(1000);
        }

        public void CliqueAddParcelasAutomaticamente()
        {
            contr.BotaoAddParcelasAutomaticamente.Click();
        }

        public void InserirDataVencimentoManual(int dias)
        {
            contr.InputDataVencimentoManualmente.SendKeys(DateTime.Now.AddDays(dias).ToString("dd/MM/yyyy"));
            Thread.Sleep(1000);
        }

        public void CliqueNovaParcelaContrato()
        {
            contr.BotaoHeaderContratoNovaParcela.Click();
            Thread.Sleep(500);
        }

        public void InformarValorOriginalParcela(decimal valor)
        {
            contr.InputValorOriginalParcelaContrato.SendKeys(valor.ToString());
            Thread.Sleep(1000);
        }

        public void AddVencimentoNovaParcela(int vencimento)
        {
            contr.InputDataVencimentoNovaParcela.SendKeys(DateTime.Now.AddDays(vencimento).ToString("dd/MM/yyyy hh:mm"));
            Thread.Sleep(1000);
        }

        public void InserirValorPagoContratoDespesaReceita(decimal valorPago)
        {
            contr.InputValorPagoContrato.Clear();
            contr.InputValorPagoContrato.SendKeys(valorPago.ToString());
            Thread.Sleep(1000);
        }

        public void CliqueBotaoAddParcelasManual()
        {
            contr.BotaoAddParcelasCriadas.Click();
        }

        public void CliqueBotaoCriarSalvarContrato()
        {
            contr.BotaoCriarSalvarContrato.Click();
        }

        public void InformarQuantidadeParcelas(int parcelas)
        {
            auxQtdParcelas = parcelas;
            contr.InputQntidadeParcelaContrato.SendKeys(parcelas.ToString());
            Thread.Sleep(500);
        }

        public void InformarIntervaloEntreParcelas(int intervalo)
        {
            contr.InputIntervaloDiasParcelaContrato.SendKeys(intervalo.ToString());
        }

        public void InserirVencimentoPrimeiraParcela(int primeiroVencimento)
        {
            contr.InputVencimentoPrimeiraParcelaContrato.SendKeys(DateTime.Now.AddDays(primeiroVencimento).ToString("dd/MM/yyyy"));
            Thread.Sleep(500);
        }

        public void CliqueSalvarParcelas()
        {
            contr.BotaoSalvarParcelas.Click();
            Thread.Sleep(500);
        }

        public void ValidaUrlContrato()
        {
            Thread.Sleep(500);
            Assert.Equal( contr.UrlContextoContrato, driver.Url);
        }

        public void StatusContrato(string status)
        {
            Assert.Equal(status, contr.FirstLinhaTabelaContrato.FindElement(By.CssSelector("td:nth-child(6)")).Text);
        }

        public void ValidaParcelaCriadaManualmente()
        {
            Assert.Equal(auxValorOriginal.ToString("N2"), contr.ValorParcelaManual.GetAttribute("value").Replace(',', '.'));
        }

        public void ValidaNovaParcelaContrato()
        {
            List<IWebElement> linhas = contr.TabelaContratoNovaParcela.FindElements(By.TagName("tr")).ToList();
            int lastIndex = linhas.Count - 1;
            Assert.Equal(auxValorOriginal.ToString("N2"), linhas[lastIndex].FindElement(By.CssSelector("td:nth-child(4)")).Text.Replace(',', '.'));
        }

        public void ValidaNumDocContratoPGA(string numDocPGA)
        {
            Assert.Contains(numDocPGA, contr.LinhasTabelaContratosFinanceiro[0].FindElement(By.CssSelector("td:nth-child(1)")).Text);
        }

        public void ValidaStatusContratoPGA(string statusPGA)
        {
            Assert.Equal(statusPGA, contr.LinhasTabelaContratosFinanceiro[0].FindElement(By.CssSelector("td:nth-child(6)")).Text);
        }

        public void ValidaNumDocContratoCREPGA(string numDocCREPGA)
        {
            Assert.Contains(numDocCREPGA, contr.LinhasTabelaContratosFinanceiro[1].FindElement(By.CssSelector("td:nth-child(1)")).Text);
        }

        public void ValidaColunaValor(decimal colunaValor)
        {
            Assert.Equal(colunaValor.ToString("N2") , contr.FirstLinhaTabelaContrato.FindElement(By.CssSelector("td:nth-child(7)")).Text.Replace(',','.'));
        }

        public void ValidaStatusContratoCREPGA(string statusCREPGA)
        {
            Assert.Equal(statusCREPGA, contr.LinhasTabelaContratosFinanceiro[1].FindElement(By.CssSelector("td:nth-child(6)")).Text);
        }

        public void ValidaContratoExcluido()
        {
            Assert.Null(FindLinhaInTabelaByNumDoc(auxNumDocContrato));
        }

        public void CliqueExcluirContratoModal()
        {
            Thread.Sleep(1000);
            contr.BotaoExcluirContratoModal.Click();
        }

        public void CliqueExcluirContrato()
        {
            contr.ActionsContrato.Click();
            contr.ActionsExcluirContrato.Click();
        }

        public void ValidaQuantidadeParcelasCriadas()
        {
            Thread.Sleep(1000);
            Assert.Equal(auxQtdParcelas, contr.TabelaParcelas.FindElements(By.TagName("tr")).ToList().Count);
        }

        public void ContratoNPodeSerDeletado(string motivo)
        {
            Thread.Sleep(500);
            Assert.Contains(motivo, contr.AlertaExcluirImpossivel.Text);
        }

        public void CliqueBotaoLancarReceita()
        {
            contr.HeaderLancarReceita.Click();
        }

    }
}
