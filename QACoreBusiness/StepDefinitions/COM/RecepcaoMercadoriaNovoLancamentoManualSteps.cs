﻿using QACoreBusiness.Util.COM;
using System;
using TechTalk.SpecFlow;

namespace QACoreBusiness.StepDefinitions.COM
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
        public void GivenSejaInformadoNoEditTextADataDeEmissao()
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

        [Given(@"seja clicado no botao Conferencia Fisica de Recebimento nas actions")]
        public void GivenSejaClicadoNoBotaoConferenciaFisicaDeRecebimentoNasActions()
        {
            rmlm.CliqueActionsConferenciaFisicaRecebimento();
        }

        [Given(@"seja clicado no botao Finalizar Recebimento nas actions")]
        public void GivenSejaClicadoNoBotaoFinalizarRecebimentoNasActions()
        {
            rmlm.CliqueActionsFinalizarRecebimento();
        }

        [Given(@"seja redirecionado para tela de Finalizar recepcao")]
        public void GivenSejaRedirecionadoParaTelaDeFinalizarRecepcao()
        {
            rmlm.ValidaUrlFinalizarRecepcao();
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
        
        [When(@"informar no editText o valor unitario \{(.*)}")]
        public void WhenInformarNoEditTextOValorUnitario(Decimal valor)
        {
            rmlm.InformarValorUnitarioItemLoteFiscal(valor);
        }
        
        [When(@"informar no editText a quantidade \{(.*)}")]
        public void WhenInformarNoEditTextAQuantidade(Decimal qtd)
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
        

        [When(@"informar o CFOP (.*) - \{'(.*)'}")]
        public void WhenInformarOCFOP_(int cfop, string nomeCFOP)
        {
            rmlm.SelecionarCFOPItemLF(nomeCFOP);
        }


        [When(@"informar a origem da Mercadoria \{'(.*)'}")]
        public void WhenInformarAOrigemDaMercadoria(string origemFiscal)
        {
            rmlm.SelecionarOrigemMercadoria(origemFiscal);
        }
        
        [When(@"informar o codigo da ST \{'(.*)'}")]
        public void WhenInformarOCodigoDaST(string codigoST)
        {
            rmlm.SelecionarSTItemLF(codigoST);
        }
        
        [When(@"informar no editText o percentual da Aliquota \{(.*)}")]
        public void WhenInformarNoEditTextOPercentualDaAliquota(Decimal aliquota)
        {
            rmlm.InformarAliquota(aliquota);
        }
        
        [When(@"clicar no botao de Salvar itens")]
        public void WhenClicarNoBotaoDeSalvarItens()
        {
            rmlm.CliqueSalvarItensLF();
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

        [When(@"ser redirecionado para tela de COM Conferencia Fisica da Recepcao")]
        public void WhenSerRedirecionadoParaTelaDeCOMConferenciaFisicaDaRecepcao()
        {
            rmlm.ValidaUrlConferenciaFisicaLoteFiscalItem();
        }

        [When(@"clicar no botao Concluir")]
        public void WhenClicarNoBotaoConcluir()
        {
            rmlm.CliqueBotaoConcluirConferenciaRecepcao();
        }


        [When(@"clicar no botao Finalizar Recepcao")]
        public void WhenClicarNoBotaoFinalizarRecepcao()
        {
            rmlm.CliqueBotaoFinalizarRecepcao();
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
    }
}
