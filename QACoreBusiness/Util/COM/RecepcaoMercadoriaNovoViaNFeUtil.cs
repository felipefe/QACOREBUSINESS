using System;
using System.IO;
using System.Reflection;
using java.awt;
using java.awt.@event;
using java.lang;
using OpenQA.Selenium;
using QACoreBusiness.Elements;

namespace QACoreBusiness.Util.COM
{
    class RecepcaoMercadoriaNovoViaNFeUtil
    {
        ElementsWorkflowRecepcaoMercadoria recepcao;
        IWebDriver driver = Base.chromeDriver;

        public RecepcaoMercadoriaNovoViaNFeUtil()
        {
            recepcao = new ElementsWorkflowRecepcaoMercadoria();
        }


        public void CliqueBotaoNovoViaNFE()
        {
            recepcao.HeaderBotaoNovoViaNfe.Click();
            System.Threading.Thread.Sleep(1000);
        }

        public void SelecionarArquivoXML()
        {
            recepcao.FileUpload.Click();
            System.Threading.Thread.Sleep(500);
            Runtime.getRuntime().exec(recepcao.ArquivoUploadXmlRecepcao);
            System.Threading.Thread.Sleep(1000);
        }

        public void SelecionarOperacaoFiscal(string opf)
        {
            recepcao.SelectOpFiscalImportXml.Click();
            recepcao.SearchOpFiscalImportXml.SendKeys(opf);
            System.Threading.Thread.Sleep(1000);
            recepcao.SearchOpFiscalImportXml.SendKeys(Keys.Enter);
        }

        public void CliqueBotaoIniciarImportacaoXML()
        {
            recepcao.BotaoIniciarImportacaoNFe.Click();
        }

    }
}
