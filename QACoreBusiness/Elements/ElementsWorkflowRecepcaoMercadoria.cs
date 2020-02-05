using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using OpenQA.Selenium;
using QACoreBusiness.Util;

namespace QACoreBusiness.Elements
{
    class ElementsWorkflowRecepcaoMercadoria : ElementsBaseRecepcaoMercadoria
    {
        #region Urls de Acesso
        public string UrlCreateRecepcaoMercadoria = UrlCoreBusiness + "/COM/LoteFiscal/Create";
        public string UrlCreateLoteFiscalItem = UrlCoreBusiness + "/COM/LoteFiscalItem/Create?idLote=";
        public string UrlEscriturarItens = UrlCoreBusiness + "/COM/LoteFiscal/Escriturar/";
        public string UrlFinalizarRecepcao = UrlCoreBusiness + "/COM/LoteFiscal/FinalizarRecepcao/";
        public string UrlConferenciaFisicaLF = UrlCoreBusiness + "/COM/LoteFiscal/ConferenciaFisica/";
        public string ArquivoUploadXmlRecepcao = Path.GetDirectoryName(Uri.UnescapeDataString((new UriBuilder(Assembly.GetExecutingAssembly().CodeBase)).Path)) +  "\\extras\\recepcao.exe";

        #endregion

        #region Criar Recepcao de Mercadoria
        public IWebElement SelectOperacaoFiscal => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='OPFSICAL_auto_wrapper']//div[@class='ui select2 fluid']");    
        public IWebElement SearchOperacaoFiscal => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-dropdown select2-dropdown--below']//input[@class='select2-search__field']");
        public IWebElement SelectFornecedor => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='LoteFiscal_Fornecedor_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement SearchFornecedor => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-dropdown select2-dropdown--below']//input[@class='select2-search__field']");
        public IWebElement InputDataRecebimento => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='LoteFiscal_Recebimento'][@name='Recebimento']");
        public IWebElement InputNumeroDocumento => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='LoteFiscal_NumeroDoc'][@name='NumeroDoc']");
        public IWebElement InputSerieDocumento => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='LoteFiscal_SerieDoc'][@name='SerieDoc']");
        public IWebElement InputDataEmissao => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='LoteFiscal_Emissao'][@name='Emissao']");
        public IWebElement SelectModeloDocumento => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='ModeloDoc_auto_wrapper']//div[@class='ui selec2 fluid']");
        public IWebElement SearchModeloDocumento => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-dropdown select2-dropdown--below']//input[@class='select2-search__field']");
        public IWebElement BotaoSalvarRecepcao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@class='ui large button'][@value='Salvar']");
        #endregion


        #region Criar Item de Recepcao Mercadoria
        public IWebElement ActionsMercadoriaItem => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@data-content='Mercadorias']");
        public IWebElement ActionsEscriturarItens => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[@data-content='Escriturar todos os itens automaticamente']");
        public IWebElement BotaoCriarNovaMercadoriaItem => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[@data-content='Nova mercadoria recebida']");
        public IWebElement SelectProdutoRecebido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='tabItem']//div[@id='LFI_Produto_ID_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement SearchProdutoRecebido => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-dropdown select2-dropdown--below']//input[@class='select2-search__field']");
        public IWebElement InputValorUnitario => ElementWait.WaitForElementXpath(chromeDriver, "//form[@id='frmLoteItem']//input[@id='LoteFiscalItem_ValorUnitario']");
        public IWebElement InputQuantidade => ElementWait.WaitForElementXpath(chromeDriver, "//form[@id='frmLoteItem']//input[@id='LoteFiscalItem_Quantidade']");
        public IWebElement InputNumLoteFiscal => ElementWait.WaitForElementXpath(chromeDriver, "//form[@id='frmLoteItem']//input[@id='LoteFiscalItem_NumeroLote']");
        public IWebElement InputDtFabricacao => ElementWait.WaitForElementXpath(chromeDriver, "//form[@id='frmLoteItem']//input[@id='LoteFiscalItem_Fabricacao']");
        public IWebElement InputDtValidade => ElementWait.WaitForElementXpath(chromeDriver, "//form[@id='frmLoteItem']//input[@id='LoteFiscalItem_Validade']");
        public IWebElement BotaoSalvarMercadoriaItem => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@class='ui large button'][@value='Salvar']");
        public IWebElement ColunaItemIsEscriturado => ElementWait.WaitForElementXpath(chromeDriver, "//table[@class='ui table selectable striped coregrid']//tbody//tr/td[@data-field='Escriturado']");
        public IWebElement ColunaSkuLoteFiscalItem => ElementWait.WaitForElementXpath(chromeDriver, "//table[@class='ui table selectable striped coregrid']//tbody//tr//td[@data-field='Produto.CodigoSKU']");
        public IWebElement AbaImpostosLFI => ElementWait.WaitForElementXpath(chromeDriver, "//form[@id='frmLoteItem']//div[@id='sui-tabcontext-EditProduto']//a[@id='tab-menu-tabImpostos']");
        public IWebElement SelectCFOPItemLF => ElementWait.WaitForElementXpath(chromeDriver, "//form[@id='frmLoteItem']//div[@id='LoteFiscalItemICMS_CFOP_auto_wrapper']");
        public IWebElement SearchCFOPItemLF => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field']");
        public IWebElement SelectOrigemItemLF => ElementWait.WaitForElementXpath(chromeDriver, "//form[@id='frmLoteItem']//div[@id='LoteFiscalItemICMS_Origem_auto_wrapper']");
        public IWebElement SearchOrigemItemLF => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field']");
        public IWebElement SelectSTItemLF => ElementWait.WaitForElementXpath(chromeDriver, "//form[@id='frmLoteItem']//div[@id='LoteFiscalItemICMS_CST_auto_wrapper']");
        public IWebElement SearchSTItemLF => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field']");
        public IWebElement InputAliquotaItemLF => ElementWait.WaitForElementXpath(chromeDriver, "//form[@id='frmLoteItem']//input[@id='LoteFiscalItemICMS_Percentual']");
        #endregion


        #region Escriturar
        public IWebElement HeaderBotaoEscriturarTodos => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[@data-content='Escriturar todos os itens automaticamente']");
        public IWebElement AbaConfiguracaoEscriturar => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='sui-tabcontext-escrituracao']//a[@id='tab-menu-tabConfig']");
        public IWebElement SelectCfopEscrituracao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='CFOPCEscrit_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement SearchCfopEscrituracao => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field']");
        public IWebElement BotaoCalcularEscrituracao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//div[@class='ui large button']");
        public IWebElement BotaoProsseguirEscrituracao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Prosseguir']");
        public IWebElement StatusEscrituracao => ElementWait.WaitForElementXpath(chromeDriver, "//table[@id='loteFiscal']//tbody//tr[@class='positive collapsed']//td[6]//p");
        #endregion

        #region Finalizar Lançamento Itens
        public IWebElement HeaderBotaoFinalizarLancamento => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[@data-content='Finalizar Lançamento de Itens']");
        public IWebElement FlagConfirmarLançamentoTodosItens => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='chkIfinish_auto_wrapper']//label[@for='chkIfinish']");
        public IWebElement BotaoConfirmarLancamentoTodosItens => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@class='ui large button'][@value='Confirmar']");
        #endregion


        #region Conferencia Fisica
        public IWebElement ActionsConferenciaFisicaRecebimento => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@data-content='Conferência Física de Recebimento']");
        public IWebElement BotaoConcluirConferenciaRecepcao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Concluir']");
        #endregion

        #region Finalizar Recepcao
        public IWebElement ActionsFinalizarRecebimento => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@data-content='Finalizar Recebimento']");
        public IWebElement BotaoFinalizarRecepcao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Finalizar Recepção']");
        #endregion
        

        #region
        public IWebElement HeaderBotaoNovoViaNfe => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[@data-content='Novo via NF-e']");
        public IWebElement FileUpload => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui large action input']//label[@class='ui basic large icon button']");
        public IWebElement SearchOpFiscalImportXml => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field']");
        public IWebElement SelectOpFiscalImportXml => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='OPFSICAL_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement BotaoIniciarImportacaoNFe => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Iniciar importação da NF-e']");
        #endregion


    }
}
