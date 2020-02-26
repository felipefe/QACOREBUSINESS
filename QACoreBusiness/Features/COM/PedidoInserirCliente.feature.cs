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
    public partial class PedidoInserirClienteFeature : Xunit.IClassFixture<PedidoInserirClienteFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "PedidoInserirCliente.feature"
#line hidden
        
        public PedidoInserirClienteFeature(PedidoInserirClienteFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PedidoInserirCliente", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 6
testRunner.And("tenha um pedido criado na situaçao {\'Lançamento / Edição\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
        
        [Xunit.FactAttribute(DisplayName="Inserir o cliente por CP no pedido com sucesso")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoInserirCliente")]
        [Xunit.TraitAttribute("Description", "Inserir o cliente por CP no pedido com sucesso")]
        [Xunit.TraitAttribute("Category", "inserir_cp_cliente_valido_pedido")]
        public virtual void InserirOClientePorCPNoPedidoComSucesso()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inserir o cliente por CP no pedido com sucesso", null, new string[] {
                        "inserir_cp_cliente_valido_pedido"});
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 12
testRunner.When("eu pesquisar no editText o cliente por CP {34816670947}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
testRunner.And("em seguida no botao selecionar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
testRunner.Then("uma mensagem de pessoa adicionada ao pedido deve aparecer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
testRunner.And("a situaçao do cliente deve ser {Normal}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Inserir o cliente por nome no pedido com sucesso")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoInserirCliente")]
        [Xunit.TraitAttribute("Description", "Inserir o cliente por nome no pedido com sucesso")]
        [Xunit.TraitAttribute("Category", "inserir_nome_cliente_valido_pedido")]
        public virtual void InserirOClientePorNomeNoPedidoComSucesso()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inserir o cliente por nome no pedido com sucesso", null, new string[] {
                        "inserir_nome_cliente_valido_pedido"});
#line 18
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 19
testRunner.When("eu pesquisar no editText o cliente por nome {\'Valentina La Ferrugem\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
testRunner.And("em seguida no botao selecionar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
testRunner.Then("uma mensagem de pessoa adicionada ao pedido deve aparecer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
testRunner.And("a situaçao do cliente deve ser {Normal}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Inserir cliente com restriçao ao pedido")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoInserirCliente")]
        [Xunit.TraitAttribute("Description", "Inserir cliente com restriçao ao pedido")]
        [Xunit.TraitAttribute("Category", "inserir_cliente_restrito_pedido")]
        public virtual void InserirClienteComRestricaoAoPedido()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inserir cliente com restriçao ao pedido", null, new string[] {
                        "inserir_cliente_restrito_pedido"});
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 26
testRunner.When("eu pesquisar no editText o cliente por nome {\'Luiz Inacio da Silva - Restrição\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
testRunner.And("em seguida no botao selecionar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
testRunner.Then("uma mensagem de pessoa adicionada ao pedido deve aparecer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
testRunner.And("um alerta referente a situaçao é exibido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PedidoInserirClienteFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PedidoInserirClienteFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
