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

        [Given(@"que eu clique no botao da header Gerenciar recepcoes")]
        public void GivenQueEuCliqueNoBotaoDaHeaderGerenciarRecepcoes()
        {
            rmxml.CliqueGerenciarRecepcoes();
        }

        [Given(@"seja redirecionado para index de gerenciar recepcoes")]
        public void GivenSejaRedirecionadoParaIndexDeGerenciarRecepcoes()
        {
            rmxml.ValidaGerenciarRecepcoes();
        }

        [Given(@"memorizo o numero dessa recepcao")]
        public void GivenMemorizoONumeroDessaRecepcao()
        {
            rmxml.ArmazenarNumeroRecepcaoExcluir();
        }

        [When(@"clicar no botao Iniciar importacao da NFe")]
        public void WhenClicarNoBotaoIniciarImportacaoDaNFe()
        {
            rmxml.CliqueBotaoIniciarImportacaoXML();
        }

        [When(@"selecione o protocolo ICMS de destino/empresa \{'(.*)'}")]
        public void WhenSelecioneOProtocoloICMSDeDestinoEmpresa(string protocoloICMS)
        {
            rmxml.SelecionarProtocoloICMS(protocoloICMS);
        }

        [When(@"selecione os impostos federais \{'(.*)'}")]
        public void WhenSelecioneOsImpostosFederais(string impFederal)
        {
            rmxml.SelecionarImpostosFederais(impFederal);
        }

        [When(@"clicar no botao da action para Excluir recepcao")]
        public void WhenClicarNoBotaoDaActionParaExcluirRecepcao()
        {
            rmxml.CliqueActionsExcluirRecepcao();
        }

        [When(@"clicar no botao Excluir da modal")]
        public void WhenClicarNoBotaoConfirmarDaModal()
        {
            rmxml.CliqueConfirmarExcluirRecepcao();
        }

        [Then(@"o sistema redirecionada para IDFe/NFe/ImpDestinadasNativo")]
        public void ThenOSistemaRedirecionadaParaIDFeNFeImpDestinadasNativo()
        {
            rmxml.ValidaRedirecionamentoIDFE();
        }

        [Then(@"informa que o lote fiscal ja foi recepcionado")]
        public void ThenInformaQueOLoteFiscalJaFoiRecepcionado()
        {
            rmxml.AlertLoteFiscalJaRecepcionado();
        }

        [Then(@"acessamos gerenciar recepcoes novamente")]
        public void ThenAcessamosGerenciarRecepcoesNovamente()
        {
            rmxml.CliqueGerenciarRecepcoes();
        }

        [Then(@"valido o numero memorizado dessa recepcao")]
        public void ThenValidoONumeroMemorizadoDessaRecepcao()
        {
            rmxml.ValidaNumeroRecepcaoExcluida();
        }


    }
}
