using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util.COM;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class RecepcaoMercadoriaNovoViaNFeSteps
    {

        RecepcaoMercadoriaNovoViaNFeUtil rmxml = new RecepcaoMercadoriaNovoViaNFeUtil();

        [Given(@"que eu clique no botao da header Novo Via NFe")]
        public void GivenQueEuCliqueNoBotaoDaHeaderNovoViaNFe()
        {
            rmxml.CliqueBotaoNovoViaNFE();
        }
        
        [Given(@"selecione o arquivo xml da recepcao")]
        public void GivenSelecioneOArquivoXmlDaRecepcao()
        {
            rmxml.SelecionarArquivoXML();
        }
        
        [Given(@"informe a operacao fiscal \{'(.*)'}")]
        public void GivenInformeAOperacaoFiscal(string opf)
        {
            rmxml.SelecionarOperacaoFiscal(opf);
        }
        
        [When(@"clicar no botao Iniciar importacao da NFe")]
        public void WhenClicarNoBotaoIniciarImportacaoDaNFe()
        {
            rmxml.CliqueBotaoIniciarImportacaoXML();
        }
    }
}
