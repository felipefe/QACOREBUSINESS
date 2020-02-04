using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util.COM;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class RecepcaoMercadoriaNovoLancamentoManualSteps
    {
        RecepcaoMercadoriaNovoLancamentoManualUtil rmlm = new RecepcaoMercadoriaNovoLancamentoManualUtil();

        [Given(@"acesse a index de recepcao de mercadoria")]
        public void GivenAcesseAIndexDeRecepcaoDeMercadoria()
        {
            rmlm.AcesseIndexRecepcao();
        }
        
        [Given(@"que seja clicado no botao Novo Lancamento Manual")]
        public void GivenQueSejaClicadoNoBotaoNovoLancamentoManual()
        {
            rmlm.CliqueNovoLancamentoManual();
        }
        
        [Given(@"seja redirecionado para tela de criar recepcao")]
        public void GivenSejaRedirecionadoParaTelaDeCriarRecepcao()
        {
            rmlm.ValidaUrlCreateRecepcao();
        }
        
        [Given(@"seja informado a operação fiscal \{'(.*)'}")]
        public void GivenSejaInformadoAOperacaoFiscal(string opf)
        {
            rmlm.SelecionarOpFiscal(opf);
        }
        
        [Given(@"seja informado no editText o fornecedor \{'(.*)'}")]
        public void GivenSejaInformadoNoEditTextOFornecedor(string fornecedor)
        {
            rmlm.SelecionarFornecedor(fornecedor);
        }
        
        [Given(@"seja informado no editText a data de recebimento \[data atual]")]
        public void GivenSejaInformadoNoEditTextADataDeRecebimentoDataAtual()
        {
            rmlm.InformarDataRecebimento();
        }
        
        [Given(@"seja informado no editText o Numero do documento")]
        public void GivenSejaInformadoNoEditTextONumeroDoDocumento()
        {
            rmlm.InformarNumDocumento();
        }
        
        [Given(@"seja informado no editText a Serie do documento \{(.*)}")]
        public void GivenSejaInformadoNoEditTextASerieDoDocumento(int serie)
        {
            rmlm.InformarSerieDocumento(serie);
        }
        
        [Given(@"seja informado no editText a data de emissao")]
        public void GivenSejaInformadoNoEditTextADataDeEmissaoDataAtual_Dias()
        {
            rmlm.InformarDataEmissao();
        }
        
        [Given(@"seja informado o modelo de documento \{'(.*)'}")]
        public void GivenSejaInformadoOModeloDeDocumento(string modeloDocumento)
        {
            rmlm.SelecionarModeloDocumento(modeloDocumento);
        }
        
        [Given(@"que tenha uma recepcao no status \{'(.*)'}")]
        public void GivenQueTenhaUmaRecepcaoNoStatus(string status)
        {
            rmlm.StatusRecepcaoMercadoria(status);
        }
        
        [Given(@"seja clicado no botao Mercadoria nas actions")]
        public void GivenSejaClicadoNoBotaoMercadoriaNasActions()
        {
            rmlm.CliqueActionsMercadorias();
        }
        
        [Given(@"seja redirecionado para tela de Mercadorias da recepcao")]
        public void GivenSejaRedirecionadoParaTelaDeMercadoriasDaRecepcao()
        {
            rmlm.ValidaUrlLoteFiscalItem();
        }
        
        [Given(@"seja clicado no botao Nova Mercadoria Recebida")]
        public void GivenSejaClicadoNoBotaoNovaMercadoriaRecebida()
        {
            rmlm.CliqueBotaoNovaMercadoriaRecebida();
        }
        
        [Given(@"seja redirecionado para criar item da recepcao")]
        public void GivenSejaRedirecionadoParaCriarItemDaRecepcao()
        {
            rmlm.ValidaUrlCreateLoteFiscalItem();
        }
        
        [Given(@"tenha na coluna Escriturado do item o valor \{'(.*)'}")]
        public void GivenTenhaNaColunaEscrituradoDoItemOValor(string isEscriturado)
        {
            rmlm.StatusItemIsEscriturado(isEscriturado);
        }
        
        [Given(@"clique nas actions para Escriturar")]
        public void GivenCliqueNasActionsParaEscriturar()
        {
            rmlm.CliqueActionsEscriturarItensLoteFiscal();
        }
        
     
        [When(@"clicar no botao Salvar")]
        public void WhenClicarNoBotaoSalvar()
        {
            rmlm.ClicarBotaoSalvarRecepcao();
        }

        [When(@"informar o produto SKU \{'(.*)'}")]
        public void WhenInformarOProdutoSKU(string sku)
        {
            rmlm.SelecionarItemLoteFiscal(sku);
        }

        [When(@"informar o CFOP \{(.*)} - Compra para comercializacao")]
        public void WhenInformarOCFOP_CompraParaComercializacao(int cfop)
        {
            rmlm.SelecionarCFOPItemLF(cfop);
        }

        [When(@"informar a origem da Mercadoria \{'(.*)'}")]
        public void WhenInformarAOrigemDaMercadoria_(string origemFiscal)
        {
            rmlm.SelecionarOrigemMercadoria(origemFiscal);
        }

        [When(@"informar o codigo da ST \{'(.*)'}")]
        public void WhenInformarOCodigoDaST_(string codigoST)
        {
            rmlm.SelecionarSTItemLF(codigoST);
        }

        [When(@"informar no editText o percentual da Aliquota \{(.*)}")]
        public void WhenInformarNoEditTextOPercentualDaAliquota(decimal aliquota)
        {
            rmlm.InformarAliquota(aliquota);
        }

        [When(@"clicar no botao de Salvar itens")]
        public void WhenClicarNoBotaoDeSalvarItens()
        {
            rmlm.CliqueSalvarItensLF();
        }


        [When(@"informar no editText o valor unitario \{(.*)}")]
        public void WhenInformarNoEditTextOValorUnitario(decimal valor)
        {
            rmlm.InformarValorUnitarioItemLoteFiscal(valor);
        }
        
        [When(@"informar no editText a quantidade \{(.*)}")]
        public void WhenInformarNoEditTextAQuantidade(decimal qtd)
        {
            rmlm.InformarQuantidadeItemLoteFiscal(qtd);
        }
        
        [When(@"informar no editText o numero do lote")]
        public void WhenInformarNoEditTextONumeroDoLote()
        {
            rmlm.InformarNumLoteFiscal();
        }
        
        [When(@"informar no editText a data de fabricacao")]
        public void WhenInformarNoEditTextADataDeFabricacao()
        {
            rmlm.InformarDataFabricacaoLF();
        }
        
        [When(@"informar no editText a data de validade")]
        public void WhenInformarNoEditTextADataDeValidade()
        {
            rmlm.InformarDataValidadeLF();
        }
        
        [When(@"clicar na aba de Impostos Conforme Documento de Entrada")]
        public void WhenClicarNaAbaDeImpostosConformeDocumentoDeEntrada()
        {
            rmlm.CliqueAbaImpostosLoteFiscalItem();
        }
        
        [When(@"clicar no botao Finalizar Lançamento de Itens")]
        public void WhenClicarNoBotaoFinalizarLancamentoDeItens()
        {
            rmlm.CliqueBotaoFinalizarLancamentoItens();
        }
        
        [When(@"marcar Eu concluí o lançamento de todos os itens")]
        public void WhenMarcarEuConcluiOLancamentoDeTodosOsItens()
        {
            rmlm.EuConcluiLancamentoTodosItens();
        }
        
        [When(@"clicar no botao Confirmar")]
        public void WhenClicarNoBotaoConfirmar()
        {
            rmlm.CliqueBotaoConfirmarLancamentoTodosItens();
        }


        [When(@"clicar no botao da header Escriturar todos os itens automaticamente")]
        public void WhenClicarNoBotaoDaHeaderEscriturarTodosOsItensAutomaticamente()
        {
            rmlm.ClicarEscriturarTodosItensAutomaticamente();
        }

        [When(@"seja redirecionado para index de escriturar lote fiscal")]
        public void WhenSejaRedirecionadoParaIndexDeEscriturarLoteFiscal()
        {
            rmlm.ValidaUrlEscriturarTodosItens();
        }

        [When(@"clicar na aba Configuração")]
        public void WhenClicarNaAbaConfiguracao()
        {
            rmlm.CliqueAbaConfiguracoesEscrituracao();
        }

        [When(@"selecione o CFOP \{(.*)} Compra para Comercialização")]
        public void WhenSelecioneOCFOPCompraParaComercializacao(int cfop)
        {
            rmlm.SelecionarCfopEscriturarItem(cfop);
        }

        [When(@"clicar no botao Calcular")]
        public void WhenClicarNoBotaoCalcular()
        {
            rmlm.CliqueBotaoCalcularEscrituracao();
        }

        [Then(@"o status do item deve mudar para \{'(.*)'}")]
        public void ThenOStatusDoItemDeveMudarPara(string statusEscriturado)
        {
            rmlm.ValidaItemEscrituradoSucesso(statusEscriturado);
        }

        [Then(@"quando clicar no botao Prosseguir")]
        public void ThenQuandoClicarNoBotaoProsseguir()
        {
            rmlm.CliqueProsseguirEscrituracao();
        }

        [Then(@"o sistema redirecionada para index de recepçao")]
        public void ThenOSistemaRedirecionadaParaIndexDeRecepcao()
        {
            rmlm.ValidaUrlIndexRecepcaoMercadoria();
        }
        
        [Then(@"o status da recepcao deve ser \{'(.*)'}")]
        public void ThenOStatusDaRecepcaoDeveSer(string status)
        {
            rmlm.ValidaStatusRecepcao(status);
        }
        
        [Then(@"seja redirecionado para tela de Mercadorias da recepcao")]
        public void ThenSejaRedirecionadoParaTelaDeMercadoriasDaRecepcao()
        {
            rmlm.ValidaUrlLoteFiscalItem();
        }
        
        [Then(@"o SKU do item da recepcao informado deve aparecer na tabela")]
        public void ThenOSKUDoItemDaRecepcaoInformadoDeveAparecerNaTabela()
        {
            rmlm.ValidaSKUItemRecepcao();
        }
       
       
    }
}
