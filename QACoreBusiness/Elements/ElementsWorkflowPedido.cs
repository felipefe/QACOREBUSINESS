using OpenQA.Selenium;
using QACoreBusiness.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QACoreBusiness.Elements
{
    class ElementsWorkflowPedido : ElementsBasePedido
    {

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
