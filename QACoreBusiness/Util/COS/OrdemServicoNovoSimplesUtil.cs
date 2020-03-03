using OpenQA.Selenium;
using QACoreBusiness.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace QACoreBusiness.Util.COS
{
    class OrdemServicoNovoSimplesUtil
    {
        public IWebDriver driver;
        public ElementsCOSOrdemServico cos;
        string codigo;

        public OrdemServicoNovoSimplesUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            cos = new ElementsCOSOrdemServico { chromeDriver = driver };
        }

        public void CriarNovoSimples()
        {
            Thread.Sleep(1000);
            cos.BotaoNovoSimples.Click();
        }

        public void SelectTipoOS(string tipoOS)
        {
            cos.SelectTipoOS.Click();
            cos.SearchGenerico.SendKeys(tipoOS);
            Thread.Sleep(1000);
            cos.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void SelectPessoaOS(string pessoaOS)
        {
            cos.SelectPessoaNovoSimples.Click();
            cos.SearchGenerico.SendKeys(pessoaOS);
            Thread.Sleep(1000);
            cos.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void InserePrazoFinalNovoSimples(int dias)
        {
            cos.InputDataPrazoFinalNovoSimples.SendKeys(DateTime.Now.AddDays(dias).ToString("dd/MM/yyyy hh:mm"));
            Thread.Sleep(500);
        }

        public void InsereResumoNovoSimples(string resumo)
        {
            cos.TextAreaResumoNovoSimples.SendKeys(resumo);
        }

        public void InsereObservacaoNovoSimples(string observacao)
        {
            cos.TextAreaObervacaoNovoSimples.SendKeys(observacao);
        }

        public void CliqueSalvarNovoSimples()
        {
            Thread.Sleep(1000);
            cos.BotaoSalvarNovoSimples.Click();
        }

        public void CliqueActionsExcluirOrdemServico()
        {
            int index = 0;
            cos.ListaOS[index].FindElement(By.TagName("img[alt='Opções']")).Click();
            codigo = cos.ListaOS[index].FindElement(By.CssSelector("td:nth-child(1)")).Text;
            cos.ActionExcluir.Click();
        }

        public void ValidaOrdemServicoStatus(string status)
        {
            string statusOsPrimeiraLinha = cos.ListaOS[0].FindElement(By.TagName("td:nth-child(3)")).Text;
            Assert.Equal(status, statusOsPrimeiraLinha);
        }

        public void InserirJustificativaExcluirOS(string justificativa)
        {
            Thread.Sleep(700);
            cos.TextAreaJustificativa.SendKeys(justificativa);
        }

        public void ValidaItensIsFinalizados(string isItensFinalizados)
        {
            string itemFinalizado = cos.ListaOS[0].FindElement(By.TagName("td:nth-child(9)")).Text;
            Assert.Equal(isItensFinalizados, itemFinalizado);
        }

        public void CliqueActionsEditarOrdemServico()
        {
            Thread.Sleep(500);
            int index = 0;
            cos.ListaOS[index].FindElement(By.TagName("img[alt='Opções']")).Click();
            cos.ActionEditar.Click();
        }

        public void CliqueNovoItemOrdemServico()
        {
            Thread.Sleep(1000);
            cos.BotaoNovoItemOS.Click();
        }

        public void CliqueBotaoCancelarOS()
        {
            Thread.Sleep(500);
            cos.BotaoCancelarOS.Click();
        }

        public void SelecionarReceita(string nomeReceita)
        {
            Thread.Sleep(1500);
            cos.SelectReceitaNovoItem.Click();
            cos.SearchGenerico.SendKeys(nomeReceita);
            Thread.Sleep(1000);
            cos.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void ValidaUrlAgrupadorManutencaoItens()
        {
            Thread.Sleep(1000);
            Assert.Contains(cos.UrlAgrupadorManutencaoItens, driver.Url);
        }

        public void CliqueActionsManutencaoItensOrdemServico()
        {
            int index = 0;
            cos.ListaOS[index].FindElement(By.TagName("img[alt='Opções']")).Click();
            cos.ActionManutencaoItens.Click();
        }

        public void ValidaUrlEditOrdemServico()
        {
            Thread.Sleep(800);
            Assert.Contains(cos.UrlEditOrdemServico, driver.Url);
        }

        public void CliqueBotaoSalvarItemOS()
        {
            Thread.Sleep(1000);
            cos.BotaoSalvarItemOS.Click();
        }

        public void CliqueBotaoMarcarTodos()
        {
            cos.BotaoMarcarTodosManutencaoInsumos.Click();
        }

        public void CliqueBotaoReservarInsumos()
        {
            Thread.Sleep(800);
            cos.BotaoReservarInsumosManutencao.Click();
        }

        public void ValidaUrlOrdemServicoItemEdit()
        {
            Thread.Sleep(1000);
            Assert.Contains(cos.UrlEditItemOrdemServico, driver.Url);
        }

        public void CliqueBotaoSepararInsumos()
        {
            Thread.Sleep(800);
            cos.BotaoSepararInsumosManutencao.Click();
        }

        public void InformarMultiplicadorReceita(int multiplicador)
        {
            Thread.Sleep(500);
            cos.InputMultiplicadorReceitaNovoItem.Clear();
            cos.InputMultiplicadorReceitaNovoItem.SendKeys(Keys.ArrowRight);
            Thread.Sleep(1000);
            cos.InputMultiplicadorReceitaNovoItem.SendKeys(Insere6CasasDecimais(multiplicador).ToString());
        }


        public void ValidaExclusaoOS()
        {
            int index = 0;
            string codOS = cos.ListaOS[index].FindElement(By.CssSelector("td:nth-child(1)")).Text;
            Assert.NotEqual(codigo, codOS);
        }

        public void ValidaReservaInsumos(string isReservadoInsumo)
        {
            int insumos = cos.TabelaManutencaoItens.Count;
            int reservou = 0;
            Thread.Sleep(1000);
            foreach(IWebElement insumo in cos.TabelaManutencaoItens)
            {
                string statusReserva = insumo.FindElement(By.CssSelector("td:nth-child(6)")).Text;
                if (isReservadoInsumo.Equals(statusReserva)){ 
                    reservou++; 
                }
                Thread.Sleep(500);
            }
            Assert.Equal(insumos, reservou);
        }

        public void ValidaQntidadeReservadaInsumos()
        {
            bool reservou = true;
            Thread.Sleep(1000);
            foreach (IWebElement insumo in cos.TabelaManutencaoItens)
            {
                string QtdReceita = insumo.FindElement(By.CssSelector("td:nth-child(9)")).Text;
                string QtdReservada = insumo.FindElement(By.CssSelector("td:nth-child(10)")).Text;
                if (!QtdReceita.Equals(QtdReservada)) {
                    reservou = false;
                }
                Thread.Sleep(500);
            }
            Assert.True(reservou);
        }

        private Double Insere6CasasDecimais(int multiplicador)
        {
            return Convert.ToDouble(multiplicador * 1000000) ;
        }
    }
}
