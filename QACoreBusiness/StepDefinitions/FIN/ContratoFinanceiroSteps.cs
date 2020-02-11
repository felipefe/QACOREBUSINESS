using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util.FIN;

namespace QACoreBusiness.StepDefinitions.FIN
{
    [Binding]
    public class ContratoFinanceiroSteps
    {
        ContratoFinanceiroUtil cfu = new ContratoFinanceiroUtil();
        //private int auxQtdParcelas;

        [Given(@"acesse a index de contratos")]
        public void GivenAcesseAIndexDeContratos()
        {
            cfu.AcesseIndexContrato();
        }
        
        [Given(@"que seja clicado no botao criar contrato")]
        public void GivenQueSejaClicadoNoBotaoCriarContrato()
        {
            cfu.CliqueCriarContrato();
        }
        
        [Given(@"seja redirecionado para /Contrato/Create")]
        public void GivenSejaRedirecionadoParaContratoCreate()
        {
            cfu.ValidaUrlContratoCreate();
        }

        [Given(@"que o status do contrato seja \{'(.*)'}")]
        public void GivenQueOStatusDoContratoSeja(string status)
        {
            cfu.ValidaSituacaoContrato(status);
        }

        [Given(@"memorize o N doc do contrato a ser excluido")]
        public void GivenMemorizeONDocDoContratoASerExcluido()
        {
            cfu.MemorizarNumeroContrato();
        }

        [Given(@"clique nas actions Parcelas")]
        public void GivenCliqueNasActionsParcelas()
        {
            cfu.CliqueActionsContratoParcelas();
        }

        [Given(@"seja redirecionado para a index de Contrato/Parcelas")]
        public void GivenSejaRedirecionadoParaAIndexDeContratoParcelas()
        {
            cfu.ValidaUrlContratoParcelas();
        }

        [Given(@"seja clicado no botao da Header Lançar Pagamento Antecipado")]
        public void GivenSejaClicadoNoBotaoDaHeaderLancarPagamentoAntecipado()
        {
            cfu.CliqueLancarPagtoAntecipado();
        }

        [Given(@"seja redirecionado para index de Pagto Antecipado")]
        public void GivenSejaRedirecionadoParaIndexDePagtoAntecipado()
        {
            cfu.ValidaUrlContratoPagtoAntecipado();
        }

        [When(@"selecionar o meio de pagamento \{'(.*)'}")]
        public void WhenSelecionarOMeioDePagamento(string meioPagamento)
        {
            cfu.SelecionarMeioPagto(meioPagamento);
        }

        [When(@"informar no input o Valor a pagar \{(.*)}")]
        public void WhenInformarNoInputOValorAPagar(Decimal valor)
        {
            cfu.InserirValorPagtoAntecipado(valor);
        }

        [When(@"clicar no botao Salvar pagto antecipado")]
        public void WhenClicarNoBotaoSalvarPagtoAntecipado()
        {
            cfu.CliqueSalvarPagtoAntecipado();
        }


        [When(@"inserir no input numero do documento")]
        public void WhenInserirNoInputNumeroDoDocumento()
        {
            cfu.InserirNumeroContrato();
        }
        
        [When(@"selecionar a pessoa do contrato \{'(.*)'}")]
        public void WhenSelecionarAPessoaDoContrato(string pessoa)
        {
            cfu.SelecionarPessoaContrato(pessoa);
        }
        
        [When(@"selecionar a empresa do contrato \{'(.*)'}")]
        public void WhenSelecionarAEmpresaDoContrato(string empresa)
        {
            cfu.SelecionarEmpresaContrato(empresa);
        }
        
        [When(@"selecionar o plano de contas \{'(.*)'}")]
        public void WhenSelecionarOPlanoDeContas(string pc)
        {
            cfu.SelecionarPlanoContas(pc);
        }
        
        [When(@"selecionar o centro de custo \{'(.*)'}")]
        public void WhenSelecionarOCentroDeCusto(string cc)
        {
            cfu.SelecionarCentroCusto(cc);
        }
        
        [When(@"informar no textArea um historico  \{'(.*)'}")]
        public void WhenInformarNoTextAreaUmHistorico(string historico)
        {
            cfu.InformarHistorico(historico);
        }
        

        [When(@"selecionar a conta prevista pagamento \{'(.*)'}")]
        public void WhenSelecionarAContaPrevistaPagamento(string contaPrevista)
        {
            cfu.SelecionarContaPrevista(contaPrevista);
        }


        [When(@"clicar no botao salvar contrato")]
        public void WhenClicarNoBotaoSalvarContrato()
        {
            cfu.CliqueSalvarContrato();
        }
        
        [When(@"clicar no botao adicionar parcelas automaticamente")]
        public void WhenClicarNoBotaoAdicionarParcelasAutomaticamente()
        {
            cfu.CliqueAddParcelasAutomaticamente();
        }
        
        [When(@"inserir no input o valor original da parcela R\$\{(.*)}")]
        public void WhenInserirNoInputOValorOriginalDaParcelaR(Decimal valor)
        {
            cfu.InformarValorOriginalParcela(valor);
        }
        
        [When(@"inserir no input a quantidade de \{(.*)} parcelas")]
        public void WhenInserirNoInputAQuantidadeDeParcelas(int parcelas)
        {
            cfu.InformarQuantidadeParcelas(parcelas);
        }
        
        [When(@"inserir no input o intervalo de \{(.*)} dias entre parcelas")]
        public void WhenInserirNoInputOIntervaloDeDiasEntreParcelas(int intervalo)
        {
            cfu.InformarIntervaloEntreParcelas(intervalo);
        }
        
        [When(@"inserir o vencimento da primeira parcela para \{(.*)} dias futuros")]
        public void WhenInserirOVencimentoDaPrimeiraParcelaParaDiasFuturos(int primeiroVencimento)
        {
            cfu.InserirVencimentoPrimeiraParcela(primeiroVencimento);
        }
        
        [When(@"clicar no botao salvar parcela")]
        public void WhenClicarNoBotaoSalvarParcela()
        {
            cfu.CliqueSalvarParcelas();
        }

        [When(@"clicar nas actions Excluir / Cancelar")]
        public void WhenClicarNasActionsExcluirCancelar()
        {
            cfu.CliqueExcluirContrato();
        }

        [When(@"confirmar clicando no botao Excluir da modal")]
        public void WhenConfirmarClicandoNoBotaoExcluirDaModal()
        {
            cfu.CliqueExcluirContratoModal();
        }
        [When(@"clicar no botao adicionar parcelas manualmente")]
        public void WhenClicarNoBotaoAdicionarParcelasManualmente()
        {
            cfu.CliqueAddParcelasManualmente();
        }

        [When(@"inserir no input Valor Original R\$\{(.*)}")]
        public void WhenInserirNoInputValorOriginalR(Decimal valor)
        {
            cfu.InserirValorParcelaManualmente(valor);
        }

        [When(@"inserir no input Data de Vencimento \{(.*)} dias futuros")]
        public void WhenInserirNoInputDataDeVencimentoDiasFuturos(int dias)
        {
            cfu.InserirDataVencimentoManual(dias);
        }

        [When(@"clicar no botao Adicionar parcela")]
        public void WhenClicarNoBotaoAdicionarParcela()
        {
            cfu.CliqueBotaoAddParcelasManual();
        }

        [When(@"clicar no botao Nova Parcela")]
        public void WhenClicarNoBotaoNovaParcela()
        {
            cfu.CliqueNovaParcelaContrato();
        }

        [When(@"inserir no input Data de Vencimento com horas para \{(.*)} dias futuros")]
        public void WhenInserirNoInputDataDeVencimentoComHorasParaDiasFuturos(int vencimento)
        {
            cfu.AddVencimentoNovaParcela(vencimento);
        }

        [Then(@"o sistema redireciona para index de contratos")]
        public void ThenOSistemaRedirecionaParaIndexDeContratos()
        {
            cfu.ValidaUrlContrato();
        }
        
        [Then(@"o status do contrato deve ser \{'(.*)'}")]
        public void ThenOStatusDoContratoDeveSer(string status)
        {
            cfu.StatusContrato(status);
        }
        
        [Then(@"a coluna referente ao valor original \{'(.*)'}")]
        public void ThenAColunaReferenteAoValorOriginal(Decimal colunaValor)
        {
            cfu.ValidaColunaValor(colunaValor);
        }
        
        [Then(@"as parcelas devem ser criadas conforme a qntdade informada")]
        public void ThenAsParcelasDevemSerCriadasConformeAQntdadeInformada()
        {
            cfu.ValidaQuantidadeParcelasCriadas();
        }
        
        [Then(@"clicar no botao salvar contrato")]
        public void ThenClicarNoBotaoSalvarContrato()
        {
            cfu.CliqueSalvarContrato();
        }

        [Then(@"o contrato deve ser excluido")]
        public void ThenOContratoDeveSerExcluido()
        {
            cfu.ValidaContratoExcluido();
        }

        [Then(@"o contrato nao deve ser excluido motivo \{'(.*)'}")]
        public void ThenOContratoNaoDeveSerExcluidoMotivo(string motivo)
        {
            cfu.ContratoNPodeSerDeletado(motivo);
        }

        [Then(@"a parcela deve ser criadas conforme valor informado")]
        public void ThenAParcelaDeveSerCriadasConformeValorInformado()
        {
            cfu.ValidaParcelaCriadaManualmente();
        }

        [Then(@"a parcela deve ser criadas validando valor e vencimento")]
        public void ThenAParcelaDeveSerCriadasValidandoValorEVencimento()
        {
            cfu.ValidaNovaParcelaContrato();
        }

        [Then(@"um contrato de pagamento Num Doc \{'(.*)'} deve ser criado")]
        public void ThenUmContratoDePagamentoNumDocDeveSerCriado(string numDocPGA)
        {
            cfu.ValidaNumDocContratoPGA(numDocPGA);
        }

        [Then(@"com status \{'(.*)'} na primeira linha da tabela de contratos")]
        public void ThenComStatusNaPrimeiraLinhaDaTabelaDeContratos(string statusPGA)
        {
            cfu.ValidaStatusContratoPGA(statusPGA);
        }

        [Then(@"um contrato de credito Num Doc \{'(.*)'} deve ser criado")]
        public void ThenUmContratoDeCreditoNumDocDeveSerCriado(string numDocCREPGA)
        {
            cfu.ValidaNumDocContratoCREPGA(numDocCREPGA);
        }

        [Then(@"com status \{'(.*)'} na segunda linha da tabela contratos")]
        public void ThenComStatusNaSegundaLinhaDaTabelaContratos(string statusCREPGA)
        {
            cfu.ValidaStatusContratoCREPGA(statusCREPGA);
        }

    }
}
