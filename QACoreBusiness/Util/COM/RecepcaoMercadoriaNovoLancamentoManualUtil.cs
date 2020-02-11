using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using QACoreBusiness.Elements;
using Xunit;

namespace QACoreBusiness.Util.COM
{
    class RecepcaoMercadoriaNovoLancamentoManualUtil
    {
        ElementsWorkflowRecepcaoMercadoria recepcao;
        IWebDriver driver = Base.chromeDriver;
        string auxSKUItemLF;

        public RecepcaoMercadoriaNovoLancamentoManualUtil()
        {
            recepcao = new ElementsWorkflowRecepcaoMercadoria();
        }

        public void AcesseIndexRecepcao()
        {
            recepcao.ContextoRecepcaoMercadoria.Click();
            Thread.Sleep(1000);
        }

        public void CliqueNovoLancamentoManual()
        {
            recepcao.BotaoNovoLancamentoManual.Click();
        }

        public void ValidaUrlCreateRecepcao()
        {
            Assert.Equal(recepcao.UrlCreateRecepcaoMercadoria, driver.Url);
        }

        public void SelecionarOpFiscal(string opf)
        {
            recepcao.SelectOperacaoFiscal.Click();
            recepcao.SearchOperacaoFiscal.SendKeys(opf);
            Thread.Sleep(1000);
            recepcao.SearchOperacaoFiscal.SendKeys(Keys.Enter);
            Thread.Sleep(500); //esse sleep garante que esse select seja fechado antes de localizar o select do fornecedor logo abaixo
        }

        public void SelecionarFornecedor(string fornecedor)
        {
            recepcao.SelectFornecedor.Click();
            recepcao.SearchFornecedor.SendKeys(fornecedor);
            Thread.Sleep(1000);
            recepcao.SearchFornecedor.SendKeys(Keys.Enter);
        }

        public void InformarDataRecebimento()
        {
            recepcao.InputDataRecebimento.SendKeys(DateTime.Now.ToString("dd/MM/yyyy hh:mm"));
        }

        public void InformarNumDocumento()
        {
            recepcao.InputNumeroDocumento.SendKeys(new Random().Next(100000, 999999).ToString());
        }

        public void InformarSerieDocumento(int serie)
        {
            recepcao.InputSerieDocumento.SendKeys(serie.ToString());
        }

        //retroativo -2 dias
        public void InformarDataEmissao()
        {
            DateTime dataEmissao = DateTime.Now.AddDays(-2);
            recepcao.InputDataEmissao.SendKeys(dataEmissao.ToString("dd/MM/yyyy hh:mm"));
        }

        public void SelecionarModeloDocumento(string modeloDocumento)
        {
            recepcao.SelectModeloDocumento.Click();
            recepcao.SearchModeloDocumento.SendKeys(modeloDocumento);
            Thread.Sleep(500);
            recepcao.SearchModeloDocumento.SendKeys(Keys.Enter);
        }

        public void ClicarBotaoSalvarRecepcao()
        {
            recepcao.BotaoSalvarRecepcao.Click();
        }

        public void ValidaUrlIndexRecepcaoMercadoria()
        {
            Assert.Equal(recepcao.UrlRecepcaoMercadoria, driver.Url);
        }

        public void StatusRecepcaoMercadoria(string status)
        {
            Assert.Equal(status, recepcao.ColunaStatusRecepcaoMercadoria.Text);
        }

        public void CliqueActionsMercadorias()
        {
            recepcao.ActionsRecepcao.Click();
            recepcao.ActionsMercadoriaItem.Click();
        }

        public void ValidaStatusRecepcao(string status)
        {
            Assert.Equal(status, recepcao.ColunaStatusRecepcaoMercadoria.Text);
        }

        public void ValidaUrlLoteFiscalItem()
        {
            Assert.Contains(recepcao.UrlLoteFiscalItem, driver.Url);
        }

        public void CliqueBotaoNovaMercadoriaRecebida()
        {
            recepcao.BotaoCriarNovaMercadoriaItem.Click();
        }

        public void ValidaUrlCreateLoteFiscalItem()
        {
            Assert.Contains(recepcao.UrlCreateLoteFiscalItem, driver.Url);
        }

        public void StatusItemIsEscriturado(string isEscriturado)
        {
            Assert.Equal(isEscriturado, recepcao.ColunaItemIsEscriturado.Text);
        }

        public void CliqueActionsConferenciaFisicaRecebimento()
        {
            recepcao.ActionsRecepcao.Click();
            recepcao.ActionsConferenciaFisicaRecebimento.Click();
        }

        public void CliqueActionsFinalizarRecebimento()
        {
            recepcao.ActionsRecepcao.Click();
            recepcao.ActionsFinalizarRecebimento.Click();
        }

        public void CliqueActionsEscriturarItensLoteFiscal()
        {
            recepcao.ActionsEscriturarItens.Click();
        }

        public void ValidaUrlFinalizarRecepcao()
        {
            Assert.Contains(recepcao.UrlFinalizarRecepcao, driver.Url);
        }

        public void ValidaUrlEscriturarItemLoteFiscal()
        {
            Assert.Equal(recepcao.UrlEscriturarItens, driver.Url);
        }

        public void SelecionarItemLoteFiscal(string sku)
        {
            recepcao.SelectProdutoRecebido.Click();
            recepcao.SearchProdutoRecebido.SendKeys(sku);
            Thread.Sleep(1000);
            recepcao.SearchProdutoRecebido.SendKeys(Keys.Enter);
            auxSKUItemLF = sku;
        }

        public void SelecionarCFOPItemLF(string cfop)
        {
            recepcao.SelectCFOPItemLF.Click();
            recepcao.SearchCFOPItemLF.SendKeys(cfop);
            Thread.Sleep(2000);
            recepcao.SearchCFOPItemLF.SendKeys(Keys.Enter);
        }

        public void SelecionarOrigemMercadoria(string origemFiscal)
        {
            recepcao.SelectOrigemItemLF.Click();
            recepcao.SearchOrigemItemLF.SendKeys(origemFiscal.ToString());
            Thread.Sleep(1000);
            recepcao.SearchOrigemItemLF.SendKeys(Keys.Enter);
        }

        public void SelecionarSTItemLF(string codigoST)
        {
            recepcao.SelectSTItemLF.Click();
            recepcao.SearchSTItemLF.SendKeys(codigoST.ToString());
            Thread.Sleep(1000);
            recepcao.SearchSTItemLF.SendKeys(Keys.Enter);
        }

        public void CliqueSalvarItensLF()
        {
            recepcao.BotaoSalvarMercadoriaItem.Click();
            recepcao.BotaoSalvarMercadoriaItem.Click();
        }

        public void InformarAliquota(decimal aliquota)
        {
            recepcao.InputAliquotaItemLF.SendKeys(aliquota.ToString());
        }

        public void InformarValorUnitarioItemLoteFiscal(decimal valor)
        {
            recepcao.InputValorUnitario.SendKeys(valor.ToString());
        }

        public void InformarQuantidadeItemLoteFiscal(decimal qtd)
        {
            recepcao.InputQuantidade.SendKeys(qtd.ToString());
        }

        public void InformarNumLoteFiscal()
        {
            recepcao.InputNumLoteFiscal.SendKeys(new Random().Next(100000,999999).ToString());
        }

        public void InformarDataFabricacaoLF()
        {
            recepcao.InputDtFabricacao.SendKeys(DateTime.Now.AddDays(-5).ToString("dd/MM/yyyy")); //fabricado 5 dias atras
        }

        public void InformarDataValidadeLF()
        {
            recepcao.InputDtValidade.SendKeys(DateTime.Now.AddYears(5).ToString("dd/MM/yyyy")); //5 anos de validade
        }

        public void CliqueAbaImpostosLoteFiscalItem()
        {
            recepcao.AbaImpostosLFI.Click();
        }

        public void CliqueBotaoFinalizarLancamentoItens()
        {
            recepcao.HeaderBotaoFinalizarLancamento.Click();
        }

        public void ValidaSKUItemRecepcao()
        {
            Assert.Equal(auxSKUItemLF, recepcao.ColunaSkuLoteFiscalItem.Text);
        }

        public void EuConcluiLancamentoTodosItens()
        {
            recepcao.FlagConfirmarLançamentoTodosItens.Click();
        }

        public void CliqueBotaoConfirmarLancamentoTodosItens()
        {
            recepcao.BotaoConfirmarLancamentoTodosItens.Click();
        }

        public void ClicarEscriturarTodosItensAutomaticamente()
        {
            recepcao.HeaderBotaoEscriturarTodos.Click();
        }

        public void ValidaUrlEscriturarTodosItens()
        {
            Assert.Contains(recepcao.UrlEscriturarItens, driver.Url);
        }

        public void CliqueAbaConfiguracoesEscrituracao()
        {
            recepcao.AbaConfiguracaoEscriturar.Click();
        }

        public void SelecionarCfopEscriturarItem(int cfop)
        {
            recepcao.SelectCfopEscrituracao.Click();
            recepcao.SearchCfopEscrituracao.SendKeys(cfop.ToString());
            Thread.Sleep(1000);
            recepcao.SearchCfopEscrituracao.SendKeys(Keys.Enter);
        }

        public void CliqueBotaoCalcularEscrituracao()
        {
            recepcao.BotaoCalcularEscrituracao.Click();
        }

        public void ValidaItemEscrituradoSucesso(string statusEscriturado)
        {
            Assert.Equal("Escriturado", recepcao.StatusEscrituracao.Text);
        }

        public void CliqueProsseguirEscrituracao()
        {
            recepcao.BotaoProsseguirEscrituracao.Click();
        }

        public void ValidaUrlConferenciaFisicaLoteFiscalItem()
        {
            Thread.Sleep(1000);
            Assert.Contains(recepcao.UrlConferenciaFisicaLF, driver.Url);
        }

        public void CliqueBotaoConcluirConferenciaRecepcao()
        {
            recepcao.BotaoConcluirConferenciaRecepcao.Click();
        }

        public void CliqueBotaoFinalizarRecepcao()
        {
            recepcao.BotaoFinalizarRecepcao.Click();
        }
    }
}
