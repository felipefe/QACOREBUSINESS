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
        ElementsCOMRecepcaoMercadoriaWorkflow recepcao;
        IWebDriver driver;
        string auxSKUItemLF;
        Double auxValorUnitario;
        int auxQuantidadeItem;
        double auxAliquotaICMS;
        double auxAliquotaPIS;
        double auxAliquotaCOFINS;

        public RecepcaoMercadoriaNovoLancamentoManualUtil()
        {
            driver = DriveOfDriver.GetInstanceDrive();
            recepcao = new ElementsCOMRecepcaoMercadoriaWorkflow { chromeDriver = driver };
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

        public void CliqueActionsEscriturarItemLoteFiscal()
        {
            recepcao.ActionsItem.Click();
            recepcao.ActionsEscriturarItem.Click();
        }

        public void CliqueActionsEscriturarItensLoteFiscal()
        {
            recepcao.ActionsEscriturarItens.Click();
        }

        public void ValidaUrlEscriturarItemManual()
        {
            Thread.Sleep(1000);
            Assert.Contains(recepcao.UrlEscriturarItemManual, driver.Url);
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
            recepcao.InputValorBruto.Click(); //esse clique é so para realizar os calculos da base de calculo senao ha necessidade de 2 cliques no salvar
            Thread.Sleep(500);
            recepcao.BotaoSalvarMercadoriaItem.Click();
        }

        public void InformarAliquota(decimal aliquota)
        {
            auxAliquotaICMS = decimal.ToDouble(aliquota);
            recepcao.InputAliquotaItemLF.SendKeys(Input4CasasDecimais(aliquota).ToString());
            Thread.Sleep(500);
        }

        public void InformarValorUnitarioItemLoteFiscal(decimal valor)
        {
            auxValorUnitario = decimal.ToDouble(valor);
            recepcao.InputValorUnitario.SendKeys(Input4CasasDecimais(valor).ToString());
        }

        public void InformarQuantidadeItemLoteFiscal(decimal qtd)
        {
            auxQuantidadeItem = decimal.ToInt32(qtd);
            recepcao.InputQuantidade.SendKeys(Input4CasasDecimais(qtd).ToString());
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
            Thread.Sleep(1000);
        }

        public void CliqueAbaImpostosLoteFiscalItem()
        {
            Thread.Sleep(1000);
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
            Thread.Sleep(2000);
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

        public void SelectMetodoCalculo(string metodoCalculo)
        {
            recepcao.SelectMetodoCalculo.Click();
            recepcao.SearchGenerico.SendKeys(metodoCalculo);
            Thread.Sleep(1000);
            recepcao.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void InformarValorBrutoRecepcao()
        {
            Double bruto = auxValorUnitario * auxQuantidadeItem;
            recepcao.InputValorBruto.SendKeys(Input4CasasDecimais(bruto).ToString());
            Thread.Sleep(500);
        }

        public void InformarValorLiquidoRecepcao()
        {
            Double liquido = auxValorUnitario * auxQuantidadeItem;
            recepcao.InputValorLiquido.SendKeys(Input4CasasDecimais(liquido).ToString());
            Thread.Sleep(500);
        }

        public void InformarBcICMS()
        {
            Double bc = auxValorUnitario * auxQuantidadeItem;
            recepcao.InputBCICMS.SendKeys(Input2CasasDecimais(bc).ToString());
            Thread.Sleep(500);
        }

        public void CliqueAbaPis()
        {
            recepcao.AbaPIS.Click();
            Thread.Sleep(1000);
        }

        public void SelectStPIS(string stPIS)
        {
            recepcao.SelectStPis.Click();
            recepcao.SearchGenerico.SendKeys(stPIS);
            Thread.Sleep(1000);
            recepcao.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void SelectTipoAliquotaPIS(string tipoAliquotaPIS)
        {
            recepcao.SelectTipoAliquotaPIS.Click();
            recepcao.SearchGenerico.SendKeys(tipoAliquotaPIS);
            Thread.Sleep(1000);
            recepcao.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void BaseCalculoPIS()
        {
            Double bc = auxValorUnitario * auxQuantidadeItem;
            recepcao.InputBcPIS.SendKeys(Input4CasasDecimais(bc).ToString());
        }

        public void InformarValorPIS()
        {
            Double valor = auxValorUnitario * auxQuantidadeItem;
            Double aliquota = auxAliquotaPIS / 100;
            Double calculo = valor * aliquota;
            recepcao.InputValorPIS.SendKeys(Input4CasasDecimais(calculo).ToString());
        }

        public void CliqueAbaCofins()
        {
            recepcao.AbaCOFINS.Click();
            Thread.Sleep(1000);
        }

        public void SelectStCofins(string stCofins)
        {
            recepcao.SelectStCOFINS.Click();
            recepcao.SearchGenerico.SendKeys(stCofins);
            Thread.Sleep(1000);
            recepcao.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void SelectCfopEscrituraItem(string cfopEscrituraItem)
        {
            recepcao.EscriturarSelectCFOP.Click();
            recepcao.SearchGenerico.SendKeys(cfopEscrituraItem);
            Thread.Sleep(1000);
            recepcao.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void SelectOrigemIcmsEscrituraItem(string origem)
        {
            recepcao.EscriturarSelectOrigemICMS.Click();
            recepcao.SearchGenerico.SendKeys(origem);
            Thread.Sleep(1000);
            recepcao.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void SelecionarStEscriturarItem(string stICMS)
        {
            recepcao.EscriturarSelectstIcms.Click();
            recepcao.SearchGenerico.SendKeys(stICMS);
            Thread.Sleep(1000);
            recepcao.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void InformaBaseCalculoIcmsEscrituraItem()
        {
            string bc = recepcao.InfoBaseCalculoICMS.Text.Replace("Base de Cálculo", "").Replace(".", "").Replace(",",".");
            Double val = Double.Parse(bc);
            recepcao.EscriturarInputBcICMS.SendKeys(Input4CasasDecimais(val).ToString());
        }

        public void CliqueAbaPisEscrituracao()
        {
            Thread.Sleep(500);
            recepcao.EscriturarAbaPIS.Click();
            Thread.Sleep(1000);
        }

        public void InformaValorIcmsEscrituraItem()
        {
            string c = recepcao.InfoValorICMS.Text.Replace("Valor do ICMS", "").Replace(".", "").Replace(",", ".");
            Double val = Double.Parse(c);
            recepcao.EscriturarInputValorBcICMS.SendKeys(Input4CasasDecimais(val).ToString());
        }

        public void SelecionarTipoAliquotaPIS(string tipoAliquotaPIS)
        {
            recepcao.EscriturarSelectTipoAliquotaPIS.Click();
            recepcao.SearchGenerico.SendKeys(tipoAliquotaPIS);
            Thread.Sleep(1000);
            recepcao.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void InformaAliquotaPisEscrituraItem(decimal aliquotaPIS)
        {
            recepcao.EscriturarInputAliquotaPIS.SendKeys(Input4CasasDecimais(aliquotaPIS).ToString());
        }

        public void InformaBaseCalculoPisEscrituraItem()
        {
            string bc = recepcao.InfoBaseCalculoPIS.Text.Replace("Base de Cálculo", "").Replace(".", "").Replace(",", ".");
            Double val = Double.Parse(bc);
            recepcao.EscriturarInputBcPIS.SendKeys(Input4CasasDecimais(val).ToString());
        }

        public void CliqueAbaCofinsEscriturarItem()
        {
            Thread.Sleep(500);
            recepcao.EscriturarAbaCOFINS.Click();
            Thread.Sleep(1000);
        }

        public void SelectStCofinsEscrituraItem(string st)
        {
            recepcao.EscriturarSelectStCOFINS.Click();
            recepcao.SearchGenerico.SendKeys(st);
            Thread.Sleep(1000);
            recepcao.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void SelectTipoAliquotaCofinsEscrituraItem(string tipoAliquota)
        {
            recepcao.EscriturarSelectTipoAliquotaCOFINS.Click();
            recepcao.SearchGenerico.SendKeys(tipoAliquota);
            Thread.Sleep(1000);
            recepcao.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void InformarBcCofinsEscrituraItem()
        {
            string bc = recepcao.InfoBaseCalculoCofins.Text.Replace("Base de Cálculo", "").Replace(".", "").Replace(",", ".");
            Double val = Double.Parse(bc);
            recepcao.EscriturarInputBcCOFINS.SendKeys(Input4CasasDecimais(val).ToString());
        }

        public void InformarValorCofinsEscrituraItem()
        {
            string c = recepcao.InfoValorCofins.Text.Replace("Valor", "").Replace(".", "").Replace(",", ".");
            Double val = Double.Parse(c);
            recepcao.EscriturarInputValorBcCOFINS.SendKeys(Input4CasasDecimais(val).ToString());
        }

        public void CliqueGravarEscrituracaoItem()
        {
            recepcao.BotaoGravarEscrituraManual.Click();
        }

        public void InformarAliquotaCofinsEscrituraItem(decimal aliquota)
        {
            recepcao.EscriturarInputAliquotaCOFINS.SendKeys(Input4CasasDecimais(aliquota).ToString());
        }

        public void InformarValorPisEscrituraItem()
        {
            string c = recepcao.InfoValorPIS.Text.Replace("Valor", "").Replace(".", "").Replace(",", ".");
            Double val = Double.Parse(c);
            recepcao.EscriturarInputValorBcPIS.SendKeys(Input4CasasDecimais(val).ToString());
        }

        public void SelecionarStPisEscrituraItem(string stPIS)
        {
            recepcao.EscriturarSelectStPIS.Click();
            recepcao.SearchGenerico.SendKeys(stPIS);
            Thread.Sleep(1000);
            recepcao.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void InformarAliquotaIcmsEscrituraItem(decimal aliquota)
        {
            recepcao.EscriturarInputAliquotaICMS.SendKeys(Input4CasasDecimais(aliquota).ToString());
        }

        public void SelectTipoAliquotaCofins(string tipoAliquotaCofins)
        {
            recepcao.SelectTipoAliquotaCOFINS.Click();
            recepcao.SearchGenerico.SendKeys(tipoAliquotaCofins);
            Thread.Sleep(1000);
            recepcao.SearchGenerico.SendKeys(Keys.Enter);
        }

        public void InformarBcCofins()
        {
            Double bc = auxValorUnitario * auxQuantidadeItem;
            recepcao.InputBcCofins.SendKeys(Input4CasasDecimais(bc).ToString());
        }

        public void InformarValorCofins()
        {
            Double total = auxValorUnitario * auxQuantidadeItem;
            Double aliquota = auxAliquotaCOFINS / 100;
            Double valor = total * aliquota;
            recepcao.InputValorCofins.SendKeys(Input4CasasDecimais(valor).ToString());
        }

        public void InformarAliquotaCofins(decimal aliquotaCofins)
        {
            auxAliquotaCOFINS = decimal.ToDouble(aliquotaCofins);
            recepcao.InputAliquotaCOFINS.SendKeys(Input4CasasDecimais(aliquotaCofins).ToString());
        }

        public void InformarAliquotaPIS(decimal aliquota)
        {
            auxAliquotaPIS = decimal.ToDouble(aliquota);
            recepcao.InputAliquotaPIS.SendKeys(Input4CasasDecimais(aliquota).ToString());
        }

        public void InformarValorCalculoICMS()
        {
            Double valor = auxValorUnitario * auxQuantidadeItem;
            Double aliquota = auxAliquotaICMS / 100;
            Double calculoICMS = valor * aliquota;
            calculoICMS = calculoICMS * 1.0;
            recepcao.InputValorICMS.SendKeys(calculoICMS.ToString());
        }

        public Double Input2CasasDecimais(double valor)
        {
            return valor * 10;
        }

        public Double Input4CasasDecimais(double valor)
        {
            return valor * 1000;
        }

        public Double Input4CasasDecimais(decimal valor)
        {
            return decimal.ToDouble(valor * 1000);
        }
    }
}
