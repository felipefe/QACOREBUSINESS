using OpenQA.Selenium;
using QACoreBusiness.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QACoreBusiness.Elements
{
    class ElementsCOSOrdemServico : Base
    {       // public IWebElement  => ElementWait.WaitForElementXpath(chromeDriver, "");

        #region URLs de Acesso
        public string UrlOrdemServico => UrlCoreBusiness + "/COS/OrdemServico";
        public string UrlEditOrdemServico => UrlCoreBusiness + "/COS/OrdemServico/Edit/";
        public string UrlEditItemOrdemServico => UrlCoreBusiness + "/COS/OrdemServicoItem/Edit/";
        public string UrlAgrupadorManutencaoItens => UrlCoreBusiness + "/COS/Agrupador/ManutencaoItensOS/";
        #endregion

        #region Index Ordem Serviço
        public IWebElement BotaoNovoSimples => ElementWait.WaitForElementXpath(chromeDriver, "//a[@data-content='Novo Simples...']");
        public List<IWebElement> ListaOS => chromeDriver.FindElements(By.XPath("//table[@class='ui table selectable striped coregrid']//tbody//tr")).ToList();
        #endregion

        #region Novo Simples
        public IWebElement SelectPessoaNovoSimples => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='OrdemServico_Pessoa_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement InputDataPrazoFinalNovoSimples => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='OrdemServico_PrazoFinal']");
        public IWebElement TextAreaResumoNovoSimples => ElementWait.WaitForElementXpath(chromeDriver, "//textarea[@id='OrdemServico_Resumo']");
        public IWebElement TextAreaObervacaoNovoSimples => ElementWait.WaitForElementXpath(chromeDriver, "//textarea[@id='OrdemServico_Observacao']");
        public IWebElement BotaoSalvarNovoSimples => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Salvar']");
        public IWebElement SelectTipoOS => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='OrdemServico_Tipo_auto_wrapper']//div[@class='ui select2 fluid']");
        public IWebElement ActionExcluir => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@data-content='Excluir']");
        public IWebElement TextAreaJustificativa => ElementWait.WaitForElementXpath(chromeDriver, "//textarea[@id='OrdemServico_JustificativaCancelamento']");
        public IWebElement BotaoCancelarOS => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Cancelar O.S.']");

        #endregion


        #region Edit Ordem Servico
        public IWebElement ActionEditar => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@data-content='Editar']");
        public IWebElement BotaoNovoItemOS => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='tabItens']//h3//div[@class='ui basic tiny button']");
        public IWebElement SelectReceitaNovoItem => ElementWait.WaitForElementXpath(chromeDriver, "//span[@id='select2-OrdemServicoItem_Item-container']");
        public IWebElement InputMultiplicadorReceitaNovoItem => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='OrdemServicoItem_MultiplicadorReceita']");
        public IWebElement BotaoSalvarItemOS => ElementWait.WaitForElementXpath(chromeDriver, "//form[@action='/COREBusiness/COS/OrdemServicoItem/Create']//input[@value='Salvar']");
        #endregion

        #region Edit Ordem Servico Item
        public IWebElement AbaResultadosOSI => ElementWait.WaitForElementXpath(chromeDriver, "//a[@id='tab-menu-tabResultados']");
        public List<IWebElement> ListaInsumosOS => chromeDriver.FindElements(By.XPath("//div[@id='divProdutos']//table//tbody//tr")).ToList();
        public List<IWebElement> ListaResultadoOS => chromeDriver.FindElements(By.XPath("//div[@id='divResultados']//table//tbody//tr")).ToList();
        #endregion

        #region
        public IWebElement ActionManutencaoItens => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@data-content='Manutenção de Itens da O.S./O.P.']");
        public IWebElement BotaoMarcarTodosManutencaoInsumos => ElementWait.WaitForElementXpath(chromeDriver, "//div[contains(text(),'Marcar Todos')]");
        public IWebElement BotaoReservarInsumosManutencao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Reservar/Requisitar Insumos']");
        public IWebElement BotaoSepararInsumosManutencao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Separar Insumos']");
        public List<IWebElement> TabelaManutencaoItens => chromeDriver.FindElements(By.XPath("//div[@id='divInsumos']//table//tbody//tr")).ToList();
        #endregion

    }
}
