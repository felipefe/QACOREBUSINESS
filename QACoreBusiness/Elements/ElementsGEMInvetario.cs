using OpenQA.Selenium;
using QACoreBusiness.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QACoreBusiness.Elements
{
    class ElementsGEMInvetario : Base
    {
        #region Inventario
        public IWebElement BotaoNovoIncluir => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//a[@data-content='Novo...']");
        public IWebElement SelectEmpresaInvetario => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='Inventario_Empresa_auto_wrapper']");
        public IWebElement InputNomeInvetario => ElementWait.WaitForElementXpath(chromeDriver, "//input[@id='Inventario_Nome']");
        public IWebElement BotaoCriarModal => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Criar']");
        public List<IWebElement> ListaInvetarios => chromeDriver.FindElements(By.XPath("//div[@id='pageContent']//table//tbody//tr")).ToList();
        public IWebElement ActionsInventarioProdutos => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@data-content='Produtos']");
        public IWebElement ActionsInvetarioIniciarExecucao => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='tool-items']//a[@data-content='Iniciar execução']");
        public IWebElement SelectProdutoInventario => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='InventarioProduto_Produto_auto_wrapper']");
        public IWebElement FlagVincularTodosOsLotes  => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='InventarioProduto_VincularLotes_auto_wrapper']//label");
        public IWebElement BotaoIniciarModal => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Iniciar']");
        public List<IWebElement> ListaProdutos => chromeDriver.FindElements(By.XPath("//table[@id='produtos']//tbody//tr[@class='ng-scope']")).ToList();
        public IWebElement BotaoSalvarProcessoExecutarInventario => ElementWait.WaitForElementXpath(chromeDriver, "//div[@class='actions']//input[@value='Criar']");
        public IWebElement BotaoConcluirExecuçao => ElementWait.WaitForElementXpath(chromeDriver, "//button[contains(text(),'Concluir Execução')]");
        public IWebElement SelectOpFiscalInventario => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='OPFSICAL_auto_wrapper']");
        public IWebElement SelectCFOPInventario => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='InventarioExcessoDetails_CFOPConfig_auto_wrapper']");
        public IWebElement SelectOrigemInventario => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='InventarioExcessoDetails_Origem_auto_wrapper']");
        public IWebElement SelectSituacaoLoteInvetario => ElementWait.WaitForElementXpath(chromeDriver, "//div[@id='InventarioExcessoDetails_SituacaoLoteEntrada_auto_wrapper']");
        public IWebElement BotaoResolver => ElementWait.WaitForElementXpath(chromeDriver, "//input[@value='Resolver']");
        #endregion
    }
}
