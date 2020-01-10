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
    public partial class PedidoEfetivarFeature : Xunit.IClassFixture<PedidoEfetivarFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "PedidoEfetivar.feature"
#line hidden
        
        public PedidoEfetivarFeature(PedidoEfetivarFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PedidoEfetivar", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
testRunner.Given("que eu tenha um pedido criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Efetivar pedido")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoEfetivar")]
        [Xunit.TraitAttribute("Description", "Efetivar pedido")]
        [Xunit.TraitAttribute("Category", "efetivar_pedido_sucesso")]
        public virtual void EfetivarPedido()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Efetivar pedido", null, new string[] {
                        "efetivar_pedido_sucesso"});
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 8
testRunner.Given("que eu esteja na tela de ediçao do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
testRunner.And("tenha inserido o cliente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
testRunner.And("tenha definido entrega", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
testRunner.And("tenha adicionado itens", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
testRunner.And("tenha adicionado negociaçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
testRunner.And("tenha adicionado vendedor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
testRunner.When("eu clicar em efetivar pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
testRunner.Then("o sistema redireciona para tela de pedidos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Falha efetivar pedido")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoEfetivar")]
        [Xunit.TraitAttribute("Description", "Falha efetivar pedido")]
        [Xunit.TraitAttribute("Category", "efetivar_pedido_falha")]
        public virtual void FalhaEfetivarPedido()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Falha efetivar pedido", null, new string[] {
                        "efetivar_pedido_falha"});
#line 18
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 19
testRunner.Given("que eu esteja na tela de ediçao do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
testRunner.When("eu clicar em efetivar pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
testRunner.Then("o sistema não redireciona para tela de pedidos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
testRunner.And("uma alerta com as pendencias é exibido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PedidoEfetivarFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PedidoEfetivarFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
