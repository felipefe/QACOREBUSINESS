// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace QACoreBusiness.Features.COM
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PedidoInserirNegociacaoFeature : Xunit.IClassFixture<PedidoInserirNegociacaoFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "PedidoInserirNegociacao.feature"
#line hidden
        
        public PedidoInserirNegociacaoFeature(PedidoInserirNegociacaoFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PedidoInserirNegociacao", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
testRunner.Given("que eu esteja logado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
testRunner.And("clicar para acessar o contexto {\'Meus Pedidos\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Negociacao sem cliente informado")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoInserirNegociacao")]
        [Xunit.TraitAttribute("Description", "Negociacao sem cliente informado")]
        [Xunit.TraitAttribute("Category", "inserir_negociacao_sem_cliente_definido")]
        public virtual void NegociacaoSemClienteInformado()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Negociacao sem cliente informado", null, new string[] {
                        "inserir_negociacao_sem_cliente_definido"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 10
testRunner.When("o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços" +
                    "}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
testRunner.And("fechar a primeira mensagem de dados do pedido carregado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
testRunner.And("que eu clique na sessao de Produtos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
testRunner.And("eu pesquisar no editText o produto por SKU {\'TST0001\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
testRunner.And("informar a quantidade no editText", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
testRunner.And("em seguida clicar no botao adicionar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
testRunner.And("que eu nao tenha informado o cliente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
testRunner.And("que eu cliquei na sessao de Pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
testRunner.When("eu clicar no botao Criar Negociaçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
testRunner.Then("um alerta é exibido para informar o cliente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Negociacao sem itens de pedido")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoInserirNegociacao")]
        [Xunit.TraitAttribute("Description", "Negociacao sem itens de pedido")]
        [Xunit.TraitAttribute("Category", "inserir_negociacao_sem_itens_pedido")]
        public virtual void NegociacaoSemItensDePedido()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Negociacao sem itens de pedido", null, new string[] {
                        "inserir_negociacao_sem_itens_pedido"});
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 23
testRunner.When("o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços" +
                    "}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
testRunner.And("fechar a primeira mensagem de dados do pedido carregado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
testRunner.And("eu pesquisar no editText o cliente por CP {34816670947}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
testRunner.And("em seguida no botao selecionar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
testRunner.And("nao tenha itens adicionados ao pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
testRunner.And("que eu cliquei na sessao de Pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
testRunner.When("eu clicar no botao Criar Negociaçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
testRunner.Then("um alerta é exibido sobre pedido sem itens", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Inserir negociçao ao pedido")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoInserirNegociacao")]
        [Xunit.TraitAttribute("Description", "Inserir negociçao ao pedido")]
        [Xunit.TraitAttribute("Category", "inserir_negociacao_pedido")]
        public virtual void InserirNegocicaoAoPedido()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inserir negociçao ao pedido", null, new string[] {
                        "inserir_negociacao_pedido"});
#line 34
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 35
testRunner.When("o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços" +
                    "}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
testRunner.And("fechar a primeira mensagem de dados do pedido carregado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
testRunner.And("eu pesquisar no editText o cliente por CP {34816670947}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
testRunner.And("em seguida no botao selecionar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
testRunner.And("que eu clique na sessao de Produtos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
testRunner.And("eu pesquisar no editText o produto por SKU {\'TST0001\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
testRunner.And("informar a quantidade no editText", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
testRunner.And("em seguida clicar no botao adicionar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
testRunner.And("que eu cliquei na sessao de Pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
testRunner.And("eu clicar no botao Criar Negociaçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
testRunner.And("inserir uma descriçao no editText {\'primeira negociacao\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
testRunner.And("selecionar a forma de pagamento {\'A vista no Dinheiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
testRunner.And("clicar no botao Salvar Negociaçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
testRunner.Then("o valor total geral da negociçao deve ser maior que zero", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
testRunner.And("uma mensagem de dados atualizado deve aparecer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PedidoInserirNegociacaoFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PedidoInserirNegociacaoFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
