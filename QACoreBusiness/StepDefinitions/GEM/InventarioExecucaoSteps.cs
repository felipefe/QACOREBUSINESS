using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util.GEM;

namespace QACoreBusiness.StepDefinitions.GEM
{
    [Binding]
    public class InventarioExecucaoSteps
    {
        InventarioExecucaoUtil ieu = new InventarioExecucaoUtil();


        [Given(@"memorize a numeracao do ultimo invetario")]
        public void GivenMemorizeANumeracaoDoUltimoInvetario()
        {
            ieu.MemorizarNomeUltimoInventario();
        }

        [When(@"seja clicado no botao Novo inventario")]
        public void WhenSejaClicadoNoBotaoNovoInventario()
        {
            ieu.CliqueBotaoNovoInventario();
        }

        [When(@"selecione a empresa \{'(.*)'}")]
        public void WhenSelecioneAEmpresa(string empresa)
        {
            ieu.SelecioneEmpresa(empresa);
        }

        [When(@"insira no input o Nome do inventario")]
        public void WhenInsiraNoInputONomeDoInventario()
        {
            ieu.InformeNomeInventario();
        }

        [When(@"clique no botao Criar")]
        public void WhenCliqueNoBotaoCriar()
        {
            ieu.CliqueBotaoCriar();
        }

        [When(@"valide que o inventario foi criado")]
        public void WhenValideQueOInventarioFoiCriado()
        {
            ieu.ValidaNomeInventarioCriado();
        }

        [When(@"clique no botao Produtos das actions")]
        public void WhenCliqueNoBotaoProdutosDasActions()
        {
            ieu.CliqueBotaoProdutosActions();
        }

        [When(@"clique no botao Incluir Produto")]
        public void WhenCliqueNoBotaoIncluirProduto()
        {
            ieu.CliqueIncluirProduto();
        }

        [When(@"selecionar o produto \{'(.*)'}")]
        public void WhenSelecionarOProduto(string produto)
        {
            ieu.SelecioneProduto(produto);
        }

        [When(@"clique no botao criar")]
        public void WhenCliqueNoBotaoSalvarProduto()
        {
            ieu.CliqueBotaoCriarProduto();
        }

        [When(@"desmarque a opção vincular todos os lotes")]
        public void WhenDesmarqueAOpcaoVincularTodosOsLotes()
        {
            ieu.FlagVincularTodosLotes();
        }

        [When(@"clique no botao Iniciar execução das actions")]
        public void WhenCliqueNoBotaoIniciarExecucaoDasActions()
        {
            ieu.CliqueBotaoIniciarExecucao();
        }

        [When(@"clique no botao Iniciar da modal")]
        public void WhenCliqueNoBotaoIniciarDaModal()
        {
            ieu.CliqueBotaoIniciarExecucaoModal();
        }

        [When(@"informe a quantidade \{(.*)} a ser inventariada para todos os produtos")]
        public void WhenInformeAQuantidadeASerInventariadaParaTodosOsProdutos(int quantidade)
        {
            ieu.InformeQuantidadeInvetariada(quantidade);
        }

        [When(@"clique no botao Concluir Execucao")]
        public void WhenCliqueNoBotaoConcluirExecucao()
        {
            ieu.CliqueBotaoConcluirProcesso();
        }

        [When(@"selecione a op fiscal \{'(.*)'} do inventario")]
        public void WhenSelecioneAOpFiscalDoInventario(string opFiscal)
        {
            ieu.SelecioneOpFiscalInvestario(opFiscal);
        }

        [When(@"selecione cfop \{'(.*)'} do inventario")]
        public void WhenSelecioneCfopDoInventario(string cfop)
        {
            ieu.SelectCFOPInventario(cfop);
        }

        [When(@"selecione a origem \{'(.*)'} do inventario")]
        public void WhenSelecioneAOrigemDoInventario(string origem)
        {
            ieu.SelectOrigemInvetario(origem);
        }

        [When(@"selecione a situaçao do lote \{'(.*)'} inventariado")]
        public void WhenSelecioneASituacaoDoLoteInventariado(string situacao)
        {
            ieu.SelectSituacaoInventario(situacao);
        }

        [When(@"clique no botao Resolver")]
        public void WhenCliqueNoBotaoResolver()
        {
            ieu.CliqueBotaoResolver();
        }


        [Then(@"o status do inventario deve ser \{'(.*)'}")]
        public void ThenOStatusDoInventarioDeveSer(string status)
        {
            ieu.ValidaStatusInventario(status);
        }
    }
}
