﻿using QACoreBusiness.Util.COM;
using System;
using TechTalk.SpecFlow;

namespace QACoreBusiness.StepDefinitions.COM
{
    [Binding]
    public class RecepcaoMercadoriaNovoLancamentoManualSteps
    {
        RecepcaoMercadoriaNovoLancamentoManualUtil rmmanual = new RecepcaoMercadoriaNovoLancamentoManualUtil();

        [Given(@"acesse a index de recepcao de mercadoria")]
        public void GivenAcesseAIndexDeRecepcaoDeMercadoria()
        {
            rmmanual.AcesseIndexRecepcao();
        }
        
        [Given(@"que seja clicado no botao Novo Lancamento Manual")]
        public void GivenQueSejaClicadoNoBotaoNovoLancamentoManual()
        {
            rmmanual.CliqueNovoLancamentoManual();
        }
        
        [Given(@"seja redirecionado para tela de criar recepcao")]
        public void GivenSejaRedirecionadoParaTelaDeCriarRecepcao()
        {
            rmmanual.ValidaUrlCreateRecepcao();
        }
        
        [Given(@"seja informado a operação fiscal \{'(.*)'}")]
        public void GivenSejaInformadoAOperacaoFiscal(string opf)
        {
            rmmanual.SelecionarOpFiscal(opf);
        }
        
        [Given(@"seja informado no editText o fornecedor \{'(.*)'}")]
        public void GivenSejaInformadoNoEditTextOFornecedor(string fornecedor)
        {
            rmmanual.SelecionarFornecedor(fornecedor);
        }
        
        [Given(@"seja informado no editText a data de recebimento \[data atual]")]
        public void GivenSejaInformadoNoEditTextADataDeRecebimentoDataAtual()
        {
            rmmanual.InformarDataRecebimento();
        }
        
        [Given(@"seja informado no editText o Numero do documento")]
        public void GivenSejaInformadoNoEditTextONumeroDoDocumento()
        {
            rmmanual.InformarNumDocumento();
        }
        
        [Given(@"seja informado no editText a Serie do documento \{(.*)}")]
        public void GivenSejaInformadoNoEditTextASerieDoDocumento(int serie)
        {
            rmmanual.InformarSerieDocumento(serie);
        }
        
        [Given(@"seja informado no editText a data de emissao")]
        public void GivenSejaInformadoNoEditTextADataDeEmissao()
        {
            rmmanual.InformarDataEmissao();
        }
        
        [Given(@"seja informado o modelo de documento \{'(.*)'}")]
        public void GivenSejaInformadoOModeloDeDocumento(string modeloDocumento)
        {
            rmmanual.SelecionarModeloDocumento(modeloDocumento);
        }
        
        [Given(@"que tenha uma recepcao no status \{'(.*)'}")]
        public void GivenQueTenhaUmaRecepcaoNoStatus(string status)
        {
            rmmanual.StatusRecepcaoMercadoria(status);
        }
        
        [Given(@"seja clicado no botao Mercadoria nas actions")]
        public void GivenSejaClicadoNoBotaoMercadoriaNasActions()
        {
            rmmanual.CliqueActionsMercadorias();
        }
        
        [Given(@"seja redirecionado para tela de Mercadorias da recepcao")]
        public void GivenSejaRedirecionadoParaTelaDeMercadoriasDaRecepcao()
        {
            rmmanual.ValidaUrlLoteFiscalItem();
        }
        
        [Given(@"seja clicado no botao Nova Mercadoria Recebida")]
        public void GivenSejaClicadoNoBotaoNovaMercadoriaRecebida()
        {
            rmmanual.CliqueBotaoNovaMercadoriaRecebida();
        }
        
        [Given(@"seja redirecionado para criar item da recepcao")]
        public void GivenSejaRedirecionadoParaCriarItemDaRecepcao()
        {
            rmmanual.ValidaUrlCreateLoteFiscalItem();
        }
        
        [Given(@"tenha na coluna Escriturado do item o valor \{'(.*)'}")]
        public void GivenTenhaNaColunaEscrituradoDoItemOValor(string isEscriturado)
        {
            rmmanual.StatusItemIsEscriturado(isEscriturado);
        }

        [Given(@"seja clicado no botao Conferencia Fisica de Recebimento nas actions")]
        public void GivenSejaClicadoNoBotaoConferenciaFisicaDeRecebimentoNasActions()
        {
            rmmanual.CliqueActionsConferenciaFisicaRecebimento();
        }

        [Given(@"seja clicado no botao Finalizar Recebimento nas actions")]
        public void GivenSejaClicadoNoBotaoFinalizarRecebimentoNasActions()
        {
            rmmanual.CliqueActionsFinalizarRecebimento();
        }

        [Given(@"seja redirecionado para tela de Finalizar recepcao")]
        public void GivenSejaRedirecionadoParaTelaDeFinalizarRecepcao()
        {
            rmmanual.ValidaUrlFinalizarRecepcao();
        }

        [When(@"clicar no botao Salvar")]
        public void WhenClicarNoBotaoSalvar()
        {
            rmmanual.ClicarBotaoSalvarRecepcao();
        }
        
        [When(@"informar o produto SKU \{'(.*)'}")]
        public void WhenInformarOProdutoSKU(string sku)
        {
            rmmanual.SelecionarItemLoteFiscal(sku);
        }
        
        [When(@"informar no editText o valor unitario \{(.*)}")]
        public void WhenInformarNoEditTextOValorUnitario(Decimal valor)
        {
            rmmanual.InformarValorUnitarioItemLoteFiscal(valor);
        }
        
        [When(@"informar no editText a quantidade \{(.*)}")]
        public void WhenInformarNoEditTextAQuantidade(Decimal qtd)
        {
            rmmanual.InformarQuantidadeItemLoteFiscal(qtd);
        }
        
        [When(@"informar no editText o numero do lote")]
        public void WhenInformarNoEditTextONumeroDoLote()
        {
            rmmanual.InformarNumLoteFiscal();
        }
        
        [When(@"informar no editText a data de fabricacao")]
        public void WhenInformarNoEditTextADataDeFabricacao()
        {
            rmmanual.InformarDataFabricacaoLF();
        }
        
        [When(@"informar no editText a data de validade")]
        public void WhenInformarNoEditTextADataDeValidade()
        {
            rmmanual.InformarDataValidadeLF();
        }
        
        [When(@"clicar na aba de Impostos Conforme Documento de Entrada")]
        public void WhenClicarNaAbaDeImpostosConformeDocumentoDeEntrada()
        {
            rmmanual.CliqueAbaImpostosLoteFiscalItem();
        }
        

        [When(@"informar o CFOP (.*) - \{'(.*)'}")]
        public void WhenInformarOCFOP_(int cfop, string nomeCFOP)
        {
            rmmanual.SelecionarCFOPItemLF(nomeCFOP);
        }


        [When(@"informar a origem da Mercadoria \{'(.*)'}")]
        public void WhenInformarAOrigemDaMercadoria(string origemFiscal)
        {
            rmmanual.SelecionarOrigemMercadoria(origemFiscal);
        }
        
        [When(@"informar o codigo da ST \{'(.*)'}")]
        public void WhenInformarOCodigoDaST(string codigoST)
        {
            rmmanual.SelecionarSTItemLF(codigoST);
        }
        
        [When(@"informar no editText o percentual da Aliquota \{(.*)}")]
        public void WhenInformarNoEditTextOPercentualDaAliquota(Decimal aliquota)
        {
            rmmanual.InformarAliquota(aliquota);
        }
        
        [When(@"clicar no botao de Salvar itens")]
        public void WhenClicarNoBotaoDeSalvarItens()
        {
            rmmanual.CliqueSalvarItensLF();
        }
        
        [When(@"clicar no botao da header Escriturar todos os itens automaticamente")]
        public void WhenClicarNoBotaoDaHeaderEscriturarTodosOsItensAutomaticamente()
        {
            rmmanual.ClicarEscriturarTodosItensAutomaticamente();
        }
        
        [When(@"seja redirecionado para index de escriturar lote fiscal")]
        public void WhenSejaRedirecionadoParaIndexDeEscriturarLoteFiscal()
        {
            rmmanual.ValidaUrlEscriturarTodosItens();
        }
        
        [When(@"clicar na aba Configuração")]
        public void WhenClicarNaAbaConfiguracao()
        {
            rmmanual.CliqueAbaConfiguracoesEscrituracao();
        }
        
        [When(@"selecione o CFOP \{(.*)} Compra para Comercialização")]
        public void WhenSelecioneOCFOPCompraParaComercializacao(int cfop)
        {
            rmmanual.SelecionarCfopEscriturarItem(cfop);
        }
        

        [When(@"clicar no botao Calcular")]
        public void WhenClicarNoBotaoCalcular()
        {
            rmmanual.CliqueBotaoCalcularEscrituracao();
        }
        
        [When(@"clicar no botao Finalizar Lançamento de Itens")]
        public void WhenClicarNoBotaoFinalizarLancamentoDeItens()
        {
            rmmanual.CliqueBotaoFinalizarLancamentoItens();
        }
        
        [When(@"marcar Eu concluí o lançamento de todos os itens")]
        public void WhenMarcarEuConcluiOLancamentoDeTodosOsItens()
        {
            rmmanual.EuConcluiLancamentoTodosItens();
        }
        
        [When(@"clicar no botao Confirmar")]
        public void WhenClicarNoBotaoConfirmar()
        {
            rmmanual.CliqueBotaoConfirmarLancamentoTodosItens();
        }

        [When(@"ser redirecionado para tela de COM Conferencia Fisica da Recepcao")]
        public void WhenSerRedirecionadoParaTelaDeCOMConferenciaFisicaDaRecepcao()
        {
            rmmanual.ValidaUrlConferenciaFisicaLoteFiscalItem();
        }

        [When(@"clicar no botao Concluir")]
        public void WhenClicarNoBotaoConcluir()
        {
            rmmanual.CliqueBotaoConcluirConferenciaRecepcao();
        }


        [When(@"clicar no botao Finalizar Recepcao")]
        public void WhenClicarNoBotaoFinalizarRecepcao()
        {
            rmmanual.CliqueBotaoFinalizarRecepcao();
        }

        [Then(@"o sistema redirecionada para index de recepçao")]
        public void ThenOSistemaRedirecionadaParaIndexDeRecepcao()
        {
            rmmanual.ValidaUrlIndexRecepcaoMercadoria();
        }
        
        [Then(@"o status da recepcao deve ser \{'(.*)'}")]
        public void ThenOStatusDaRecepcaoDeveSer(string status)
        {
            rmmanual.ValidaStatusRecepcao(status);
        }
        
        [Then(@"seja redirecionado para tela de Mercadorias da recepcao")]
        public void ThenSejaRedirecionadoParaTelaDeMercadoriasDaRecepcao()
        {
            rmmanual.ValidaUrlLoteFiscalItem();
        }
        
        [Then(@"o SKU do item da recepcao informado deve aparecer na tabela")]
        public void ThenOSKUDoItemDaRecepcaoInformadoDeveAparecerNaTabela()
        {
            rmmanual.ValidaSKUItemRecepcao();
        }
        
        [Then(@"o status do item deve mudar para \{'(.*)'}")]
        public void ThenOStatusDoItemDeveMudarPara(string statusEscriturado)
        {
            rmmanual.ValidaItemEscrituradoSucesso(statusEscriturado);
        }
        
        [Then(@"quando clicar no botao Prosseguir")]
        public void ThenQuandoClicarNoBotaoProsseguir()
        {
            rmmanual.CliqueProsseguirEscrituracao();
        }
    }
}
