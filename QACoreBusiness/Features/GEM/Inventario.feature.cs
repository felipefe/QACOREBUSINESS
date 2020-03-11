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
namespace QACoreBusiness.Features.GEM
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class InventarioFeature : Xunit.IClassFixture<InventarioFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Inventario.feature"
#line hidden
        
        public InventarioFeature(InventarioFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Inventario", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
testRunner.And("clicar para acessar o contexto {\'Inventários\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Realizar Inventario")]
        [Xunit.TraitAttribute("FeatureTitle", "Inventario")]
        [Xunit.TraitAttribute("Description", "Realizar Inventario")]
        [Xunit.TraitAttribute("Category", "realizar_inventario")]
        public virtual void RealizarInventario()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar Inventario", null, new string[] {
                        "realizar_inventario"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 10
testRunner.Given("memorize a numeracao do ultimo invetario", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
testRunner.When("seja clicado no botao Novo inventario", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
testRunner.And("selecione a empresa {\'Deltacon Informática\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
testRunner.And("insira no input o Nome do inventario", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
testRunner.And("clique no botao Criar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
testRunner.And("valide que o inventario foi criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
testRunner.And("clique no botao Produtos das actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
testRunner.And("clique no botao Incluir Produto", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
testRunner.And("selecionar o produto {\'TST0012\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
testRunner.And("desmarque a opção vincular todos os lotes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
testRunner.And("clique no botao criar produto", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
testRunner.And("clique no botao voltar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
testRunner.And("clique no botao Iniciar execução das actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
testRunner.And("clique no botao Iniciar da modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
testRunner.And("informe a quantidade {20000} a ser inventariada para todos os produtos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
testRunner.And("clique no botao Concluir Execucao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
testRunner.And("selecione a op fiscal {\'Inventário\'} do inventario", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
testRunner.And("selecione cfop {\'Compra para industrialização\'} do inventario", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
testRunner.And("selecione a origem {\'Nacional - exceto as indicadas nos códigos 3 a 5\'} do invent" +
                    "ario", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
testRunner.And("selecione a situaçao do lote {\'Disponível para operações de Entrada e Saída\'} inv" +
                    "entariado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
testRunner.And("clique no botao Resolver", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
testRunner.And("espere por {4} segundos ate ser processado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
testRunner.Then("o status do inventario deve ser {\'Finalizado\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
testRunner.And("feche o navegador quando terminar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                InventarioFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                InventarioFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
