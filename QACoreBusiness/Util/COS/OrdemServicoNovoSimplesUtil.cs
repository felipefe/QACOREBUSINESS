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
        string situacaoEncaminhada;

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
            Thread.Sleep(2500);
            Assert.Contains(cos.UrlEditItemOrdemServico, driver.Url);
        }

        public void CliqueActionsEncaminhar()
        {
            int index = 0;
            cos.ListaOS[index].FindElement(By.TagName("img[alt='Opções']")).Click();
            cos.ActionEncaminhar.Click();
            Thread.Sleep(1500);
        }

        public void SelecioneNovaSituacao(string situacao)
        {
            situacaoEncaminhada = situacao;
            Thread.Sleep(3000);
            cos.SelectNovaSituacao.Click();
            cos.SearchGenerico.SendKeys(situacao);
            Thread.Sleep(2500);
            cos.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void CliqueBotaoEncaminhar()
        {
            Thread.Sleep(2000);
            cos.BotaoEncaminharNovaSituacaoOS.Click();
        }

        public void ValideSituacaoEncaminhadaOS()
        {
            Thread.Sleep(2000);
            String situacao = cos.ListaOS[0].FindElement(By.CssSelector("td:nth-child(5)")).Text;
            Assert.Equal(situacaoEncaminhada, situacao);
        }

        public void SelecioneGrupoUsuario(string grupo)
        {
            Thread.Sleep(1000);
            cos.InputSelectGrupoUsuario.SendKeys(grupo);
            Thread.Sleep(2000);
            cos.InputSelectGrupoUsuario.SendKeys(Keys.Enter);
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

        public void ValidaStatusSeparadoInsumos(string isSeparado)
        {
            int insumos = cos.TabelaManutencaoItens.Count;
            int reservou = 0;
            Thread.Sleep(1000);
            foreach(IWebElement insumo in cos.TabelaManutencaoItens)
            {
                string statusReserva = insumo.FindElement(By.CssSelector("td:nth-child(2)")).Text;
                if (isSeparado.Equals(statusReserva)){ 
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

        public void CliqueBotaoExecutarTudo()
        {
            Thread.Sleep(1000);
            cos.BotaoExecutarTudo.Click();
        }

        public void EspereXSegundosAteExecutarOS(int segundos)
        {
            Thread.Sleep(segundos * 1000);
        }

        public void DesmarqueTentarFinalizarItensAoExecutarTudo()
        {
            Thread.Sleep(500);
            cos.FlagFinalizarItensAoExecutarOS.Click();
        }

        private Double Insere6CasasDecimais(int multiplicador)
        {
            return Convert.ToDouble(multiplicador * 1000000) ;
        }

        public void CliqueConfirmarExecutarTudoModal()
        {
            cos.BotaoConfirmarExecucaoModal.Click();
        }

        public void InformeTextoConclusao(string conclusao)
        {
            Thread.Sleep(3000);
            cos.TextAreaConclusaoOS.SendKeys(conclusao);
        }

        public void CliqueActionsFinalizarOS()
        {
            int index = 0;
            cos.ListaOS[index].FindElement(By.TagName("img[alt='Opções']")).Click();
            cos.ActionsFinalizarOS.Click();
        }

        public void MarqueFinalizarTodosItensAoFinalizarOS()
        {
            Thread.Sleep(800);
            cos.FlagTentarFinalizarItensAoFinalizarOS.Click();
        }

        public void ConfirmarFinalizarOSModal()
        {
            Thread.Sleep(500);
            cos.BotaoFinalizarOSModal.Click();
        }

        public void CliqueHeaderGerenciarOSs()
        {
            cos.BotaoHeaderGerenciarOS.Click();
            Thread.Sleep(1500);
        }

        public void MemorizarNumeroOrdemServico()
        {
            Thread.Sleep(1000);
            codigo = cos.ListaOS[0].FindElement(By.CssSelector("td:nth-child(1)")).Text;
        }

        public void ValidaCodigoOSMemorizada()
        {
            Thread.Sleep(1000);
            string codigoOSFinalizada = cos.ListaOS[0].FindElement(By.CssSelector("td:nth-child(1)")).Text;
            Assert.Equal(codigo, codigoOSFinalizada);
        }

        public void ValidaStatusOsByGerenciarOS(string status)
        {
            Thread.Sleep(1000);
            string finalizada = cos.ListaOS[0].FindElement(By.CssSelector("td:nth-child(5)")).Text;
            Assert.Equal(status, finalizada);
        }

        public void ValidaPedidoGeradoPelaOS()
        {
            Assert.True(cos.ListaPedidosGeradosOS.Count == 1);
        }

        public void InformarQntdReservarManutencaoItens(decimal qtdReservar)
        {
            foreach(IWebElement insumo in cos.TabelaManutencaoItens)
            {
                Thread.Sleep(500);
                IWebElement inputQtdReservar = insumo.FindElement(By.CssSelector("td:nth-child(7) > div > div > input"));
                inputQtdReservar.Clear();
                Thread.Sleep(500);
                inputQtdReservar.SendKeys(Keys.ArrowRight);
                inputQtdReservar.SendKeys(Insere5CasasDecimais(qtdReservar).ToString());
            }
        }

        public void ValidaSituacaoPedidoGeradoOS(string situacao)
        {
            Assert.Equal(situacao, cos.ListaPedidosGeradosOS[0].FindElement(By.CssSelector("td:nth-child(5)")).Text);
        }

        private Double Insere5CasasDecimais(decimal num)
        {
            return Convert.ToDouble(num * 100000);
        }

        public void CliqueBotaoProduzirTudo()
        {
            Thread.Sleep(1200);
            cos.BotaoProduzirTudo.Click();
        }

        public void MarcarFlagalterarQtdDosInsumosReservar()
        {
            Thread.Sleep(500);
            cos.FlagAlterarQtdInsumosReservar.Click();
        }

        public void ConfirmeProduzirTudoModal()
        {
            Thread.Sleep(1300);
            cos.BotaoProduzirTudoEmCadeia.Click();
        }

        public void CliqueEditarItemOrdemServico()
        {
            Thread.Sleep(3000);
            int index = 0;
            cos.TabelaItensOS[index].FindElement(By.CssSelector("td:nth-child(11) > div")).Click();
            Thread.Sleep(1000);
            cos.EditarItemOS.Click();
            Thread.Sleep(1500);
        }

        public void ValidaQtdReservadaEQtdTotal()
        {
            bool reservou = true;
            Thread.Sleep(1000);
            foreach (IWebElement insumo in cos.TabelaManutencaoItens)
            {
                string QtdReservada = insumo.FindElement(By.CssSelector("td:nth-child(10)")).Text;
                string QtdTotal = insumo.FindElement(By.CssSelector("td:nth-child(11)")).Text;
                if (!QtdTotal.Equals(QtdReservada))
                {
                    reservou = false;
                }
                Thread.Sleep(500);
            }
            Assert.True(reservou);
        }

        public void ConfirmeConcluirItemModal()
        {
            Thread.Sleep(1500);
            cos.BotaoConfirmarConcluirItem.Click();
            Thread.Sleep(1500);
        }

        public void CliqueBotaoConcluirItem()
        {
            Thread.Sleep(2000);
            cos.BotaoConcluirItem.Click();
        }

        public void ValidarQtdReservarMaisReservadaIgualTotal()
        {
            bool validou = true;
            Thread.Sleep(1000);
            foreach (IWebElement insumo in cos.TabelaManutencaoItens)
            {
                string InputQtdReservar = insumo.FindElement(By.CssSelector("td:nth-child(7) > div > div > input")).GetAttribute("value");
                string QtdReservada = insumo.FindElement(By.CssSelector("td:nth-child(10)")).Text;
                string QtdTotal = insumo.FindElement(By.CssSelector("td:nth-child(11)")).Text;
                Double resultado = Double.Parse(InputQtdReservar.Replace(",",".")) + Double.Parse(QtdReservada.Replace(",", "."));
                if (!QtdTotal.Equals(resultado.ToString("N5").Replace(".",",")))
                {
                    validou = false;
                }
                Thread.Sleep(500);
            }
            Assert.True(validou);
        }

        public void ConfirmeCriarExecucoes()
        {
            Thread.Sleep(2000);
            cos.BotaoConfirmarCriarExecucao.Click();
        }

        public void CliqueActionsCriarExecucoes()
        {
            Thread.Sleep(2000);
            int index = 0;
            cos.ListaOS[index].FindElement(By.CssSelector("td:nth-child(11) > div")).Click();
            Thread.Sleep(1000);
            cos.ActionsCriarExecucao.Click();
            Thread.Sleep(1500);
        }

        public void CliqueConfirmarBotaoModal()
        {
            Thread.Sleep(2000);
            cos.BotaoConfirmarExecucao.Click();
        }

        public void CliqueActionsExecucoesConfirmar()
        {
            Thread.Sleep(1500);
            cos.ListaExecucoes[0].FindElement(By.CssSelector("td:nth-child(3)")).Click();
            Thread.Sleep(1000);
            cos.ActionConfirmarExecucao.Click();
        }

        public void ValidaCriouExecucoes()
        {
            Thread.Sleep(2000);
            Assert.True(cos.ListaExecucoes.Count > 0);
        }

        public void CliqueExecutarTriangular()
        {
            Thread.Sleep(2000);
            cos.BotaoExecutarTriangular.Click();
        }

        public void ConfirmeClicandoBotaoExecutar()
        {
            Thread.Sleep(1000);
            cos.BotaoConfirmarExecutar.Click();
        }

        public void CliqueBotaoSalvarExecucao()
        {
            Thread.Sleep(1000);
            cos.BotaoSalvarExecucao.Click();
        }

        public void MensagemExecucaoTriangularFinalizada()
        {
            ElementWait.WaitForElementXpath(driver, "//div[@class='notify-text']");
        }

        public void ValidaPedidosGeradosTriangular(int nPedidos)
        {
            Thread.Sleep(1000);
            Assert.Equal(nPedidos, cos.ListaPedidosGeradosOS.Count);
        }

        public void CliqueAquiParaVisualizarPedidos()
        {
            Thread.Sleep(1000);
            cos.BotaoCliqueAquiVerPedidos.Click();
        }

        public void FlagConfirmarExecucoes()
        {
            Thread.Sleep(2000);
            cos.FlagConfirmarExecucao.Click();
        }

        public void CliqueBotaoExecutarItemOS()
        {
            Thread.Sleep(2000);
            cos.BotaoExecutar.Click();
        }

        public void ValidaOSQueGerouPedidoViewPedido()
        {
            Thread.Sleep(1500);
            Assert.Equal(codigo, cos.NomeOSQueGerouPedidoViewPedido.Text);
        }

        public void CliqueAbaOrdensServico()
        {
            Thread.Sleep(3000);
            cos.AbaOrdensServicoPedido.Click();
        }

        public void SelectTipoOSParaTriangular(string tipoOS)
        {
            Thread.Sleep(1500);
            cos.SelectTipoOSTriangular.Click();
            cos.SearchGenerico.SendKeys(tipoOS);
            Thread.Sleep(1000);
            cos.SearchGenerico.SendKeys(Keys.Enter);

        }
    }
}
