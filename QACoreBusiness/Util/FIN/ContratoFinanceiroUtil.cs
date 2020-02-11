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
        ElementsBaseFinanceiro fin;
        IWebDriver driver = Base.chromeDriver;
        IWebElement linhaEncontradaTabela;
        private int auxQtdParcelas;
        private decimal auxValorOriginal;
        private string auxNumDocContrato;

        public ContratoFinanceiroUtil()
        {
            fin = new ElementsBaseFinanceiro();
        }

        //encontra a linha que contem o numero do status
        private IWebElement FindLinhaInTabelaByStatus(string status)
        {
            String linhaStatus;
            foreach (IWebElement linha in fin.LinhasTabelaContratosFinanceiro)
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
            foreach (IWebElement linha in fin.LinhasTabelaContratosFinanceiro)
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


        public void CliqueActionsContratoParcelas()
        {
            fin.ActionsContrato.Click();
            fin.ActionsParcelasContrato.Click();
        }


        public void ValidaUrlContratoParcelas()
        {
            Thread.Sleep(1000);
            Assert.Contains(fin.UrlParcelasContrato, driver.Url);
        }

        public void AcesseIndexContrato()
        {
            fin.ContextoContrato.Click();
        }

        public void CliqueCriarContrato()
        {
            fin.HeaderCriarContrato.Click();
        }

        public void ValidaUrlContratoCreate()
        {
            Assert.Equal(fin.UrlCreateContrato, driver.Url);
        }

        public void InserirNumeroContrato()
        {
            fin.InputNumeroContrato.SendKeys((new Random().Next(100000, 999999).ToString()));
        }

        public void SelecionarPessoaContrato(string pessoa)
        {
            fin.SelectPessoaContrato.Click();
            fin.SearchPessoaContrato.SendKeys(pessoa);
            Thread.Sleep(1000);
            fin.SearchPessoaContrato.SendKeys(Keys.Enter);
        }

        public void MemorizarNumeroContrato()
        {
            auxNumDocContrato = fin.FirstLinhaTabelaContrato.FindElement(By.CssSelector("td:nth-child(1)")).Text;
        }

        public void ValidaSituacaoContrato(string status)
        {
            StatusContrato(status);
        }

        public void SelecionarEmpresaContrato(string empresa)
        {
            fin.SelectEmpresaContrato.Click();
            fin.SearchEmpresaContrato.SendKeys(empresa);
            Thread.Sleep(1000);
            fin.SearchEmpresaContrato.SendKeys(Keys.Enter);
        }

        public void SelecionarCentroCusto(string cc)
        {
            fin.SelectCentroCusto.Click();
            fin.SearchCentroCusto.SendKeys(cc);
            Thread.Sleep(1000);
            fin.SearchCentroCusto.SendKeys(Keys.Enter);
        }

        public void SelecionarPlanoContas(string pc)
        {
            fin.SelectPlanoContas.Click();
            fin.SearchPlanoContas.SendKeys(pc);
            Thread.Sleep(1000);
            fin.SearchPlanoContas.SendKeys(Keys.Enter);
        }

        public void InformarHistorico(string historico)
        {
            fin.InputHistoricoContrato.SendKeys(historico);
        }

        public void SelecionarContaPrevista(string contaPrevista)
        {
            fin.SelectContaPrevistaPagto.Click();
            fin.SearchContaPrevistaPagto.SendKeys(contaPrevista);
            Thread.Sleep(2000);
            fin.SearchContaPrevistaPagto.SendKeys(Keys.Enter);
        }

        public void CliqueAddParcelasManualmente()
        {
            fin.BotaoAddParcelasManualmente.Click();
            Thread.Sleep(500);
        }

        public void CliqueSalvarContrato()
        {
            fin.BotaoSalvarContrato.Click();
        }

        public void InserirValorParcelaManualmente(decimal valor)
        {
            auxValorOriginal = valor;
            fin.InputValorOriginalManualmente.SendKeys(valor.ToString());
            Thread.Sleep(1000);
        }

        public void CliqueAddParcelasAutomaticamente()
        {
            fin.BotaoAddParcelasAutomaticamente.Click();
        }

        public void InserirDataVencimentoManual(int dias)
        {
            fin.InputDataVencimentoManualmente.SendKeys(DateTime.Now.AddDays(dias).ToString("dd/MM/yyyy"));
            Thread.Sleep(1000);
        }

        public void CliqueNovaParcelaContrato()
        {
            fin.BotaoHeaderContratoNovaParcela.Click();
            Thread.Sleep(500);
        }

        public void InformarValorOriginalParcela(decimal valor)
        {
            fin.InputValorOriginalParcelaContrato.SendKeys(valor.ToString());
            Thread.Sleep(500);
        }

        public void AddVencimentoNovaParcela(int vencimento)
        {
            fin.InputDataVencimentoNovaParcela.SendKeys(DateTime.Now.AddDays(vencimento).ToString("dd/MM/yyyy hh:mm"));
            Thread.Sleep(1000);
        }

        public void CliqueBotaoAddParcelasManual()
        {
            fin.BotaoAddParcelasCriadas.Click();
        }

        public void InformarQuantidadeParcelas(int parcelas)
        {
            auxQtdParcelas = parcelas;
            fin.InputQntidadeParcelaContrato.SendKeys(parcelas.ToString());
            Thread.Sleep(500);
        }

        public void InformarIntervaloEntreParcelas(int intervalo)
        {
            fin.InputIntervaloDiasParcelaContrato.SendKeys(intervalo.ToString());
        }

        public void InserirVencimentoPrimeiraParcela(int primeiroVencimento)
        {
            fin.InputVencimentoPrimeiraParcelaContrato.SendKeys(DateTime.Now.AddDays(primeiroVencimento).ToString("dd/MM/yyyy"));
            Thread.Sleep(500);
        }

        public void CliqueSalvarParcelas()
        {
            fin.BotaoSalvarParcelas.Click();
            Thread.Sleep(500);
        }

        public void ValidaUrlContrato()
        {
            Thread.Sleep(500);
            Assert.Equal( fin.UrlContextoContrato, driver.Url);
        }

        public void StatusContrato(string status)
        {
            Assert.Equal(status, fin.FirstLinhaTabelaContrato.FindElement(By.CssSelector("td:nth-child(6)")).Text);
        }

        public void ValidaParcelaCriadaManualmente()
        {
            Assert.Equal(auxValorOriginal.ToString("N2"), fin.ValorParcelaManual.GetAttribute("value").Replace(',', '.'));
        }

        public void ValidaNovaParcelaContrato()
        {
            List<IWebElement> linhas = fin.TabelaContratoNovaParcela.FindElements(By.TagName("tr")).ToList();
            int lastIndex = linhas.Count - 1;
            Assert.Equal(auxValorOriginal.ToString("N2"), linhas[lastIndex].FindElement(By.CssSelector("td:nth-child(4)")).Text.Replace(',', '.'));
        }

        public void ValidaColunaValor(decimal colunaValor)
        {
            Assert.Equal(colunaValor.ToString("N2") , fin.FirstLinhaTabelaContrato.FindElement(By.CssSelector("td:nth-child(7)")).Text.Replace(',','.'));
        }

        public void ValidaContratoExcluido()
        {
            Assert.Null(FindLinhaInTabelaByNumDoc(auxNumDocContrato));
        }

        public void CliqueExcluirContratoModal()
        {
            Thread.Sleep(1000);
            fin.BotaoExcluirContratoModal.Click();
        }

        public void CliqueExcluirContrato()
        {
            fin.ActionsContrato.Click();
            fin.ActionsExcluirContrato.Click();
        }

        public void ValidaQuantidadeParcelasCriadas()
        {
            Thread.Sleep(1000);
            Assert.Equal(auxQtdParcelas, fin.TabelaParcelas.FindElements(By.TagName("tr")).ToList().Count);
        }

        public void ContratoNPodeSerDeletado(string motivo)
        {
            Thread.Sleep(500);
            Assert.Contains(motivo, fin.AlertaExcluirImpossivel.Text);
        }



    }
}
