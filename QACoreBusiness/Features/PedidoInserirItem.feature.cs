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
namespace QACoreBusiness.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PedidoInserirItemFeature : Xunit.IClassFixture<PedidoInserirItemFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "PedidoInserirItem.feature"
#line hidden
        
        public PedidoInserirItemFeature(PedidoInserirItemFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PedidoInserirItem", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
testRunner.And("acesse a index de pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 6
testRunner.And("tenha um pedido criado na situaçao {Lançamento/Ediçao}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
testRunner.And("clique para editar este pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
testRunner.And("seja redirecionado para tela de ediçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Inserir item com reserva ao pedido por sku")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoInserirItem")]
        [Xunit.TraitAttribute("Description", "Inserir item com reserva ao pedido por sku")]
        [Xunit.TraitAttribute("Category", "inserir_item_pedido_por_sku")]
        public virtual void InserirItemComReservaAoPedidoPorSku()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inserir item com reserva ao pedido por sku", null, new string[] {
                        "inserir_item_pedido_por_sku"});
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 12
testRunner.Given("que eu clique na sessao de Produtos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
testRunner.When("eu pesquisar no editText o produto por SKU {\'TST0001\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
testRunner.And("informar a quantidade no editText", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
testRunner.And("em seguida clicar no botao adicionar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
testRunner.Then("uma mensagem de item adicionado ao pedido deve aparecer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
testRunner.And("sua tag de reserva estoque deve ser {Normal}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Inserir item com reserva ao pedido por nome")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoInserirItem")]
        [Xunit.TraitAttribute("Description", "Inserir item com reserva ao pedido por nome")]
        [Xunit.TraitAttribute("Category", "inserir_item_pedido_por_nome")]
        public virtual void InserirItemComReservaAoPedidoPorNome()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inserir item com reserva ao pedido por nome", null, new string[] {
                        "inserir_item_pedido_por_nome"});
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 21
testRunner.Given("que eu clique na sessao de Produtos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
testRunner.When("eu pesquisar no editText o produto por nome {\'Boné Oakley\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
testRunner.And("informar a quantidade no editText", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
testRunner.And("em seguida clicar no botao adicionar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
testRunner.Then("uma mensagem de item adicionado ao pedido deve aparecer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
testRunner.And("sua tag de reserva estoque deve ser {Normal}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Inserir item ao pedido sem reserva")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoInserirItem")]
        [Xunit.TraitAttribute("Description", "Inserir item ao pedido sem reserva")]
        [Xunit.TraitAttribute("Category", "inserir_item_sem_reserva_pedido")]
        public virtual void InserirItemAoPedidoSemReserva()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inserir item ao pedido sem reserva", null, new string[] {
                        "inserir_item_sem_reserva_pedido"});
#line 29
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 30
testRunner.Given("que eu clique na sessao de Produtos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
testRunner.When("eu pesquisar no editText o produto por SKU {\'TST0003\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
testRunner.And("informar a quantidade no editText", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
testRunner.And("em seguida clicar no botao adicionar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
testRunner.Then("uma mensagem de item adicionado ao pedido deve aparecer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
testRunner.And("sua tag de reserva estoque deve ser {Sem reserva}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Item nao inserido ao pedido")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoInserirItem")]
        [Xunit.TraitAttribute("Description", "Item nao inserido ao pedido")]
        [Xunit.TraitAttribute("Category", "inserir_item_invalido_pedido")]
        public virtual void ItemNaoInseridoAoPedido()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Item nao inserido ao pedido", null, new string[] {
                        "inserir_item_invalido_pedido"});
#line 38
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 39
testRunner.Given("que eu clique na sessao de Produtos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
testRunner.When("eu pesquisar no editText o produto por SKU {\'TST0004\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
testRunner.And("informar a quantidade no editText", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
testRunner.And("em seguida clicar no botao adicionar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
testRunner.Then("uma mensagem de item nao adicionado ao pedido deve aparecer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
testRunner.And("uma outra mensagem com os detalhes deve aparecer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PedidoInserirItemFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PedidoInserirItemFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
