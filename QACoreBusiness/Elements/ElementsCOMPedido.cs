using OpenQA.Selenium;
using QACoreBusiness.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QACoreBusiness.Elements
{
    class ElementsCOMPedido : Base
    {
        public IWebDriver chromeDriver;

        public string UrlIndexPedido = UrlCoreBusiness + "/COM/Pedido";
        public IWebElement SituacaoPedido => ElementWait.WaitForElementXpath(chromeDriver, "//table//tbody//tr[1]//td[9][@class='left aligned'][@data-field='Status']");
        public IWebElement ActionsPedido => ElementWait.WaitForElementXpath(chromeDriver, "//table[@class='ui table selectable striped coregrid']//tr[1]//td[@class=' hidden-mobile']//div//div//a[@class='fsm-ignore']");
        public IWebElement AlertaMensagemPedidoAtualizado => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='iziToast-body']//div[@class='iziToast-texts']//p[@class='iziToast-message slideIn']");
        public IWebElement CloseAlertaPedidoAtualizado => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='iziToast-capsule']//button[@type='button'][@class='iziToast-close']");


        #region URLs de Acesso
        public string UrlEditPedido = UrlCoreBusiness + "/COM/PedidoVue/Edit/";
        public string UrlTrocarVendedor = UrlCoreBusiness + "/COM/Pedido/TrocarVendedor";
        #endregion

        #region Criar Pedido
        public IWebElement BotaoCriarNovo => ElementWait.WaitForElementXpath(chromeDriver, "//a[@class='popup-link'][@href='/COREBusiness/COM/Pedido/Create']");
        #endregion

        #region Cliente Pedido
        public IWebElement BotaoEditPedido => ElementWait.WaitForElementXpath(chromeDriver, "//table//tbody//tr[1]//td[11][@class=' hidden-mobile']/a[@data-content='Editar']");
        public IWebElement InputCPClientePedido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui large input']/input[@type='text'][@name='cp'][@placeholder='CPF/CNPJ']");
        public IWebElement InputNomeCliente => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui large input']/input[@type='text'][@name='nome'][@placeholder='Nome']");
        public IWebElement SituacaoNormal => ElementWait.WaitForElementXpath(chromeDriver, "//h4[@class='ui header']//div[@class='ui column right aligned']//div[@class='ui label']");
        public IWebElement SituacaoRestrito => ElementWait.WaitForElementXpath(chromeDriver, "//h4[@class='ui header']//div[@class='ui column right aligned']//div[@class='ui label red']");
        public IWebElement BotaoSelecionarCliente => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui column right aligned six wide']//button[@class='ui large button']");

        #endregion

        #region Entrega Pedido
        public IWebElement PedidoComEntrega => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui form container']//div[@class='components']//div[@class='ui green segment'][2]//div[@class='collapse toggle']//h4[@class='ui header']");
        public IWebElement ClientePedido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='pedido-pessoa-wrapper']//div[@class='collapse toggle']//h4[@class='ui header']//div[@class='ui column']");
        public IWebElement SessaoEntregas => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui green segment']//div[@class='collapse toggle']//h4[@class='ui header']//i[@class='icon truck']");
        public IWebElement BotaoDefinirEntrega => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui green segment']//div[@class='ui placeholder segment']//div[@class='ui large primary button']");
        public IWebElement SelectTransportadora => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='two fields']//div[@id='IDTransportadora_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement SearchTransportadora => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-container select2-container--default select2-container--open']//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field'][@type='search']");
        public IWebElement SelectTipoEntrega => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='three fields']//div[@class='ui field']//select[@id='PedidoEntrega_Tipo'][@name='Tipo']");
        public IWebElement TipoEntrega => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='three fields']//div[@class='ui field']//select[@id='PedidoEntrega_Tipo'][@name='Tipo']//option[@value='Entrega']");
        public IWebElement TipoEntregaFutura => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='three fields']//div[@class='ui field']//select[@id='PedidoEntrega_Tipo'][@name='Tipo']//option[@value='EntregaFutura']");
        public IWebElement InputDataPrevista => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui large fluid input']//div[@class='floatlabel-wrapper']//input[@id='PedidoEntrega_DataPrevista']");
        public IWebElement InputValorEntrega => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='PedidoEntrega_Frete_auto_wrapper']//div[@class='ui large fluid input']//div[@class='floatlabel-wrapper']//input[@id='PedidoEntrega_Frete'][@name='Frete']");
        public IWebElement BotaoSalvarEntrega => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@class='ui large button'][@id='submit'][@value='Salvar']");
        #endregion

        #region Itens Pedido
        public IWebElement SessaoProdutos => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='pedido-itens-wrapper']//div[@class='collapse toggle']//h4[@class='ui header']//div[@class='ui column']");
        public IWebElement InputSKUProduto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='pedido-edit-wrapper']//div[@class='ui form container']//div[@class='components']//div[@id='pedido-itens-wrapper']//div[@class='ui green segment']//div[@class='ui fields']//div[@class='four wide field']//div[@class='ui large input']//input[@name='sku']");
        public IWebElement InputNomeProduto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='pedido-edit-wrapper']//div[@class='ui form container']//div[@class='components']//div[@id='pedido-itens-wrapper']//div[@class='ui green segment']//div[@class='ui fields']//div[@class='ui large input']//input[@name='nome']");
        public IWebElement InputQuantidadeItemPedido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='pedido-itens-wrapper']//div[@class='ui green segment']//div[@class='ui stackable row three column grid']//div[@class='sixteen wide field']//div[@class='ui large action input']//input[@name='quantidade']");
        public IWebElement TagReservaEstoqueNormal => ElementWait.WaitForElementXpath(chromeDriver, "//table[@id='table-itens']//tbody//tr//td//div[@class='ui left']//div[@class='ui circular grey label sui-tooltip']");
        public IWebElement TagReservaEstoqueSemReserva => ElementWait.WaitForElementXpath(chromeDriver, "//table[@id='table-itens']//tbody//tr//td//div[@class='ui left']//div[@class='ui circular violet label sui-tooltip']");
        public IWebElement BotaoAddItemPedido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='pedido-itens-wrapper']//div[@class='ui green segment']//div[@class='ui stackable row three column grid']//div[@class='sixteen wide field']//div[@class='ui large action input']//button[@class='ui right labeled icon button']");
        public IWebElement MensagemItemNaoAdd => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='iziToast-capsule'][1]//div[@class='iziToast-body']//div[@class='iziToast-texts']//strong[@class='iziToast-title slideIn']");
        public IWebElement MensagemMotivoItemNaoAdd => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='iziToast-capsule'][2]//div[@class='iziToast-body']//div[@class='iziToast-texts']//strong[@class='iziToast-title slideIn']");
        public IWebElement ActionsItemPedido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='pedido-itens-wrapper']//table[@id='table-itens']//tr//td[@class='center aligned collapsing']//div[@class='v-popover']//a[@class='tooltip-target b3']");
        public IWebElement BotaoRemoverItemPedido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='wrapper']//div[@class='tooltip-inner popover-inner']//a[@class='popup-link'][@data-content='Remover item']");
        public IWebElement TextViewQuantidadeItensPedido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui green segment']//div[@class='ui grid']//div[@class='left floated twelve wide column']//div[@class='ui statistic mini'][1]//div[@class='value']");
        #endregion

        #region Vendedor Pedido  
        public IWebElement ActionsTrocarVendedor => chromeDriver.FindElement(By.XPath("//div[@class='actions']//a[@class='popup-link'][@data-content='Trocar Vendedor']"));
        public IWebElement SelectVendedorInformado => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='Pedido_Vendedor_auto_wrapper']//div[@class='ui select2 fluid']//span[@class='selection']//span[@id='select2-Pedido_Vendedor-container']");
        public IWebElement SelectVendedor => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id = 'Pedido_Vendedor_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement SearchInformarVendedor => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-container select2-container--default select2-container--open']//span[@class='select2-dropdown select2-dropdown--below']//input[@class='select2-search__field'][@type='search']");
        public IWebElement BotaoTrocarVendedor => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@class='ui large button'][@type='submit'][@value='Trocar']");
        public IWebElement AlertaVendedorJaInserido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui negative message validation-summary-errors']//ul[@class='list']//li");
        #endregion

        #region Negociaçao Pedido
        public IWebElement ClienteSemPedido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='pedido-pessoa-wrapper']//form[@class='ui form']//h4[@class='ui header']");
        public IWebElement SessaoPagamento => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='pedido-edit-wrapper']//div[@class='ui form container']//div[@class='components']//div[@class='ui green segment'][3]//div[@class='collapse toggle']//h4[@class='ui header']");
        public IWebElement PedidoSemItens => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='pedido-itens-wrapper']//div[@class='ui green placeholder segment']//div[@class='ui icon header']");
        public IWebElement ValorPedido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui grid']//div[@class='right floated right aligned four wide column']//div[@class='ui statistic small']//div[@class='value']");
        public IWebElement BotaoCriarNegociacao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui green segment']//div[@class='ui placeholder segment']//div[@class='ui large primary button']");
        public IWebElement AlertaNegociacaoPedidoSemCliente => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui stackable column grid']//div[@class='ui negative icon message']//div[@class='content']");
        public IWebElement AlertaNegociacaoPedidoSemItens => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui stackable grid']//div[@class='row']//div[@class='ui column']//div[@class='ui warning  message']");
        public IWebElement InputDescricaoNegociacao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='NegociacaoParte_Descricao_auto_wrapper']//div[@class='ui large fluid input']//div[@class='floatlabel-wrapper']//input[@id='NegociacaoParte_Descricao']");
        public IWebElement BotaoSalvarNegociacao => ElementWait.WaitForElementXpath(chromeDriver, "//form[@action='/COREBusiness/COM/Negociacao/CreateParte']//div[@class='actions']//input[@id='submit'][@value='Salvar']");
        public IWebElement SelectFormaPagamento => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='NegociacaoParte_FormaPagamento_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement SearchFormaPagamento => ElementWait.WaitForElementXpath(chromeDriver, "//span[@class='select2-dropdown select2-dropdown--below']//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field'][@type='search']");
        public IWebElement ValorTotalGeralLiquidoNegociacao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui green segment']//table[@class='ui stackable celled structured table']//tfoot//tr//th[@class='right aligned'][2]");
        public IWebElement NegociacaoSemFormaPagamento => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui negative message validation-summary-errors']//ul[@class='list']//li");
        #endregion

        #region Efetivar Pedido
        public IWebElement ActionsEfetivarPedido => chromeDriver.FindElement(By.XPath("//div[@class='actions']//a[@class='popup-link'][@data-content='Efetivar Pedido']"));
        public IWebElement PedidoComCliente => chromeDriver.FindElement(By.XPath("//div[@id='pedido-pessoa-wrapper']//h4[@class='ui header']//div[@class='ui stackable row two column grid']//div[@class='ui column']"));
        public IWebElement PendenciasPedido => chromeDriver.FindElement(By.XPath("//div[@class='notify error notify-without-icon notify-top-right']//div[@class='notify-text']//h3"));
        #endregion


        #region URLs de Acesso
        public string UrlAvaliacaoPedido = UrlCoreBusiness + "/CRM/Avaliacao/Avaliar/";
        public string UrlSeparacaoPedido = UrlCoreBusiness + "/WMS/Separacao/Execute/";
        public string UrlCOMFinalizarSeparacao = UrlCoreBusiness + "/COM/Pedido/FinalizarPickingList/";
        public string UrlConferenciaPedido = UrlCoreBusiness + "/WMS/Conferencia/Execute/";
        public string UrlFinalizarConferenciaCOM = UrlCoreBusiness + "/COM/PedidoEntrega/FinalizarConferencia/";
        public string UrlEntregasRemessasPedidoConferido = UrlCoreBusiness + "/COM/PedidoEntrega/Index/";
        #endregion

        #region Avaliar Pedido
        public IWebElement ActionsAvaliarPedido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@class='popup-link tool-item gradient'][@data-content='Avaliação do Pedido']");
        public IWebElement BotaoProsseguir => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@class='ui large button'][@value='Prosseguir']");
        public IWebElement AvaliacaoMotivoUm => ElementWait.WaitForElementXpath(chromeDriver, "//table[@id='pedidos']//tbody//tr[1]//td[2]");
        public IWebElement AvaliacaoMotivoDois => ElementWait.WaitForElementXpath(chromeDriver, "//table[@id='pedidos']//tbody//tr[2]//td[2]");
        public IWebElement BotaoBloquear => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//div[@class='ui large red button']");

        #endregion

        #region Separar Pedido
        public IWebElement ActionsSepararPedido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@class='popup-link tool-item gradient'][@data-content='Separação']");
        public IWebElement BotaoDefinirTodos => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui red segment']//div[@class='actions']//div[@class='ui big labeled icon button orange has-tooltip']");
        public IWebElement BotaoMarcarTodos => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui yellow segment']//div[@class='actions']//div[@class='ui big labeled icon button orange has-tooltip']");
        public IWebElement BotaoFinalizarSeparacaoWMS => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//div[@class='ui big labeled green icon button has-tooltip']");
        public IWebElement BotaoFinalizarSeparacaoCOM => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@class='ui large button'][@value='Finalizar Separação']");

        #endregion

        #region Conferir Pedido
        public IWebElement ActionsConferenciaPedido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@class='popup-link tool-item gradient'][@data-content='Conferência']");
        public IWebElement BotaoReiniciarProcesso => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui grid']//div[@class='eight wide column']//button[@class='ui red large labeled icon button']");
        public IWebElement BotaoReiniciarConferenciaFinalizada => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui two column grid']//div[@class='ui red segment']//button[@class='ui red large fluid labeled icon button']");
        public IWebElement BotaoConcluirProcesso => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui grid']//div[@class='right aligned eight wide column']//button[@class='ui orange large labeled icon button']");
        public IWebElement BotaoFinalizarConferenciaWMS => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui two column grid']//div[@class='ui green segment']//button[@class='ui green large fluid labeled icon button']");
        public IWebElement BotaoFinalizarConferenciaCOM => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@class='ui large button'][@value='Finalizar conferência']");
        public IWebElement EditTextCodigoProduto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui two fields']//div[@class='ui ten wide field']//input[@placeholder='Código do Produto']");
        public IWebElement EditTextQuantidadeProduto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui two fields']//div[@class='ui six wide field']//input[@placeholder='Quantidade']");
        public IWebElement ColunaCodigoProduto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui orange segment']//table[@class='ui striped selectable definition table']//tbody//tr//td[2]");
        public IWebElement ColunaQtdTotalProduto => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui orange segment']//table[@class='ui striped selectable definition table']//tbody//tr//td[5]");
        public IWebElement ColunaQtdConferida => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui orange segment']//table[@class='ui striped selectable definition table']//tbody//tr//td[6]");
        public IWebElement MensagemConferidoSucesso => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui large bottom attached message positive']//div[@class='content']//span");
        public IWebElement MensagemConferidoErrado => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui large bottom attached message negative']//div[@class='content']//span");
        public IWebElement AlertProcessosConferencia => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='notify success notify-without-icon notify-bottom-right']//div[@class='notify-text']//p");
        public IWebElement MensagemConferenciaFinalizada => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='ui large positive icon message']//div[@class='content']//div[@class='header']");
        public List<IWebElement> LinhasTabelaHtmlConferencia => chromeDriver.FindElements(By.XPath("//tbody//tr[@class='negative']")).ToList();

        #endregion

        #region Emitir DFe
        public IWebElement ActionsEmitirDFePedido => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@class='popup-link tool-item gradient'][@data-content='Emitir Documentos Fiscais']");
        public IWebElement ColunaValorPedido => ElementWait.WaitForElementXpath(chromeDriver, "//table//tbody//tr[1]//td[10][@class='left aligned'][@data-field='ValorNegociado']");
        #endregion


    }
}
