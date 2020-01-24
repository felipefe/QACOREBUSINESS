using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QACoreBusiness.Util
{
    class ElementsPedido
    {
        //Criar Pedido
        public IWebDriver Driver;
        public string UrlIndexPedido = "http://dcbtestserver/COREBusiness/COM/Pedido";
        public string UrlContainsEditPedido = "http://dcbtestserver/COREBusiness/COM/PedidoVue/Edit/";
        public IWebElement BotaoCriarNovo => ElementWait.WaitForElementXpath(Driver, "//a[@class='popup-link'][@href='/COREBusiness/COM/Pedido/Create']");

        //Inserir Cliente
        public IWebElement SituacaoPedido => ElementWait.WaitForElementXpath(Driver, "//table//tbody//tr[1]//td[9][@class='left aligned'][@data-field='Status']");
        public IWebElement BotaoEditPedido => ElementWait.WaitForElementXpath(Driver, "//table//tbody//tr[1]//td[11][@class=' hidden-mobile']/a[@data-content='Editar']");
        public IWebElement EditTextCPClientePedido => ElementWait.WaitForElementXpath(Driver, "//div[@class='ui large input']/input[@type='text'][@name='cp'][@placeholder='CPF/CNPJ']");
        public IWebElement EditTextNomeCliente => ElementWait.WaitForElementXpath(Driver, "//div[@class='ui large input']/input[@type='text'][@name='nome'][@placeholder='Nome']");
        public IWebElement AlertaMensagemPedidoAtualizado => ElementWait.WaitForElementXpath(Driver, "//div[@class='iziToast-body']//div[@class='iziToast-texts']//p[@class='iziToast-message slideIn']");
        public IWebElement SituacaoNormal => ElementWait.WaitForElementXpath(Driver, "//h4[@class='ui header']//div[@class='ui column right aligned']//div[@class='ui label']");
        public IWebElement SituacaoRestrito => ElementWait.WaitForElementXpath(Driver, "//h4[@class='ui header']//div[@class='ui column right aligned']//div[@class='ui label red']");
        public IWebElement BotaoSelecionarCliente => ElementWait.WaitForElementXpath(Driver, "//div[@class='ui column right aligned six wide']//button[@class='ui large button']");

        //Inserir Entrega
        public IWebElement ClientePedido => ElementWait.WaitForElementXpath(Driver, "//div[@id='pedido-pessoa-wrapper']//div[@class='collapse toggle']//h4[@class='ui header']//div[@class='ui column']");
        public IWebElement SessaoEntregas => ElementWait.WaitForElementXpath(Driver, "//div[@class='ui green segment']//div[@class='collapse toggle']//h4[@class='ui header']//i[@class='icon truck']");
        public IWebElement BotaoDefinirEntrega => ElementWait.WaitForElementXpath(Driver, "//div[@class='ui green segment']//div[@class='ui placeholder segment']//div[@class='ui large primary button']");
        public IWebElement SelectTransportadora => ElementWait.WaitForElementXpath(Driver, "//div[@class='two fields']//div[@id='IDTransportadora_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement SearchTransportadora => ElementWait.WaitForElementXpath(Driver, "//span[@class='select2-container select2-container--default select2-container--open']//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field'][@type='search']");
        public IWebElement SelectTipoEntrega => ElementWait.WaitForElementXpath(Driver, "//div[@class='three fields']//div[@class='ui field']//select[@id='PedidoEntrega_Tipo'][@name='Tipo']");
        public IWebElement TipoEntrega => ElementWait.WaitForElementXpath(Driver, "//div[@class='three fields']//div[@class='ui field']//select[@id='PedidoEntrega_Tipo'][@name='Tipo']//option[@value='Entrega']");
        public IWebElement TipoEntregaFutura => ElementWait.WaitForElementXpath(Driver, "//div[@class='three fields']//div[@class='ui field']//select[@id='PedidoEntrega_Tipo'][@name='Tipo']//option[@value='EntregaFutura']");
        public IWebElement DataPrevista => ElementWait.WaitForElementXpath(Driver, "//div[@class='ui large fluid input']//div[@class='floatlabel-wrapper']//input[@id='PedidoEntrega_DataPrevista'][@name='DataPrevista']");
        public IWebElement ValorEntrega => ElementWait.WaitForElementXpath(Driver, "//div[@id='PedidoEntrega_Frete_auto_wrapper']//div[@class='ui large fluid input']//div[@class='floatlabel-wrapper']//input[@id='PedidoEntrega_Frete'][@name='Frete']");
        public IWebElement BotaoSalvarEntrega => ElementWait.WaitForElementXpath(Driver, "//div[@class='actions']//input[@class='ui large button'][@id='submit'][@value='Salvar']");

        //item pedido
        public IWebElement SessaoProdutos => ElementWait.WaitForElementXpath(Driver, "//div[@id='pedido-itens-wrapper']//div[@class='collapse toggle']//h4[@class='ui header']//div[@class='ui column']");
        public IWebElement EditTextSKUProduto => ElementWait.WaitForElementXpath(Driver, "//div[@id='pedido-edit-wrapper']//div[@class='ui form container']//div[@class='components']//div[@id='pedido-itens-wrapper']//div[@class='ui green segment']//div[@class='ui fields']//div[@class='four wide field']//div[@class='ui large input']//input[@name='sku']");
        public IWebElement EditTextNomeProduto => ElementWait.WaitForElementXpath(Driver, "//div[@id='pedido-edit-wrapper']//div[@class='ui form container']//div[@class='components']//div[@id='pedido-itens-wrapper']//div[@class='ui green segment']//div[@class='ui fields']//div[@class='ui large input']//input[@name='nome']");
        public IWebElement EditTextQuantidadeItemPedido => ElementWait.WaitForElementXpath(Driver, "//div[@id='pedido-itens-wrapper']//div[@class='ui green segment']//div[@class='ui stackable row three column grid']//div[@class='sixteen wide field']//div[@class='ui large action input']//input[@name='quantidade']");
        public IWebElement TagReservaEstoqueNormal => ElementWait.WaitForElementXpath(Driver, "//table[@id='table-itens']//tbody//tr//td//div[@class='ui left']//div[@class='ui circular grey label sui-tooltip']");
        public IWebElement TagReservaEstoqueSemReserva => ElementWait.WaitForElementXpath(Driver, "//table[@id='table-itens']//tbody//tr//td//div[@class='ui left']//div[@class='ui circular violet label sui-tooltip']");
        public IWebElement BotaoAddItemPedido => ElementWait.WaitForElementXpath(Driver, "//div[@id='pedido-itens-wrapper']//div[@class='ui green segment']//div[@class='ui stackable row three column grid']//div[@class='sixteen wide field']//div[@class='ui large action input']//button[@class='ui right labeled icon button']");
        public IWebElement MensagemItemNaoAdd => ElementWait.WaitForElementXpath(Driver, "//div[@class='iziToast-capsule'][1]//div[@class='iziToast-body']//div[@class='iziToast-texts']//strong[@class='iziToast-title slideIn']");
        public IWebElement MensagemMotivoItemNaoAdd => ElementWait.WaitForElementXpath(Driver, "//div[@class='iziToast-capsule'][2]//div[@class='iziToast-body']//div[@class='iziToast-texts']//strong[@class='iziToast-title slideIn']");

        //trocar vendedor    
        public IWebElement ActionTrocarVendedor => Driver.FindElement(By.XPath("//div[@class='actions']//a[@class='popup-link'][@data-content='Trocar Vendedor']"));
        public String UrlTrocarVendedor = "http://dcbtestserver/COREBusiness/COM/Pedido/TrocarVendedor";
        public IWebElement SelectVendedorInformado => ElementWait.WaitForElementXpath(Driver, "//div[@id='Pedido_Vendedor_auto_wrapper']//div[@class='ui select2 fluid']//span[@class='selection']//span[@id='select2-Pedido_Vendedor-container']");
        public IWebElement SelectVendedor => ElementWait.WaitForElementXpath(Driver, "//div[@id = 'Pedido_Vendedor_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement SearchInformarVendedor => ElementWait.WaitForElementXpath(Driver, "//span[@class='select2-container select2-container--default select2-container--open']//span[@class='select2-dropdown select2-dropdown--below']//input[@class='select2-search__field'][@type='search']");
        public IWebElement BotaoTrocarVendedor => ElementWait.WaitForElementXpath(Driver, "//div[@class='actions']//input[@class='ui large button'][@type='submit'][@value='Trocar']");
        public IWebElement AlertaVendedorJaInserido => ElementWait.WaitForElementXpath(Driver, "//div[@class='ui negative message validation-summary-errors']//ul[@class='list']//li");


        //negociação
        public IWebElement ClienteSemPedido => ElementWait.WaitForElementXpath(Driver, "//div[@id='pedido-pessoa-wrapper']//form[@class='ui form']//h4[@class='ui header']");
        public IWebElement SessaoPagamento => ElementWait.WaitForElementXpath(Driver, "//div[@class='pusher page']//section[@id='main']//div[@id='pageMain']//div[@id='pageContent']//div[@id='pedido-edit-wrapper']//div[@class='ui form container']//div[@class='components']//div[@class='ui green segment'][3]//div[@class='collapse toggle']//h4[@class='ui header']");
        public IWebElement PedidoSemItens => ElementWait.WaitForElementXpath(Driver, "//div[@id='pedido-itens-wrapper']//div[@class='ui green placeholder segment']//div[@class='ui icon header']");
        public IWebElement ValorPedido => ElementWait.WaitForElementXpath(Driver, "//div[@class='ui grid']//div[@class='right floated right aligned four wide column']//div[@class='ui statistic small']//div[@class='value']");
        public IWebElement BotaoCriarNegociacao => ElementWait.WaitForElementXpath(Driver, "//div[@class='ui green segment']//div[@class='ui placeholder segment']//div[@class='ui large primary button']");
        public IWebElement AlertaNegociacaoPedidoSemCliente => ElementWait.WaitForElementXpath(Driver, "//div[@class='ui stackable column grid']//div[@class='ui negative icon message']//div[@class='content']");
        public IWebElement AlertaNegociacaoPedidoSemItens => ElementWait.WaitForElementXpath(Driver, "//div[@class='ui stackable grid']//div[@class='row']//div[@class='ui column']//div[@class='ui warning  message']");
        public IWebElement EditTextDescricaoNegociacao => ElementWait.WaitForElementXpath(Driver, "//div[@id='NegociacaoParte_Descricao_auto_wrapper']//div[@class='ui large fluid input']//div[@class='floatlabel-wrapper']//input[@id='NegociacaoParte_Descricao']");
        public IWebElement BotaoSalvarNegociacao => ElementWait.WaitForElementXpath(Driver, "//form[@action='/COREBusiness/COM/Negociacao/CreateParte']//div[@class='actions']//input[@id='submit'][@value='Salvar']");
        public IWebElement SelectFormaPagamento => ElementWait.WaitForElementXpath(Driver, "//div[@id='NegociacaoParte_FormaPagamento_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement SearchFormaPagamento => ElementWait.WaitForElementXpath(Driver, "//span[@class='select2-dropdown select2-dropdown--below']//span[@class='select2-search select2-search--dropdown']//input[@class='select2-search__field'][@type='search']");
        public IWebElement ValorTotalGeralLiquidoNegociacao => ElementWait.WaitForElementXpath(Driver, "//div[@class='ui green segment']//table[@class='ui stackable celled structured table']//tfoot//tr//th[@class='right aligned'][2]");

    }
}
