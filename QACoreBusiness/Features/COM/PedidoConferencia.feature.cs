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
    public partial class PedidoConferenciaFeature : Xunit.IClassFixture<PedidoConferenciaFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "PedidoConferencia.feature"
#line hidden
        
        public PedidoConferenciaFeature(PedidoConferenciaFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PedidoConferencia", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 6
testRunner.Given("que eu esteja logado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
testRunner.And("acesse a index de pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
testRunner.And("tenha um pedido criado na situaçao {Conferência}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Conferir item pedido")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoConferencia")]
        [Xunit.TraitAttribute("Description", "Conferir item pedido")]
        [Xunit.TraitAttribute("Category", "conferir_item_pedido")]
        public virtual void ConferirItemPedido()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Conferir item pedido", null, new string[] {
                        "conferir_item_pedido"});
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 12
testRunner.Given("que eu acesse as actions do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
testRunner.And("clique no botao Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
testRunner.And("seja redirecionado para tela de WMS Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
testRunner.And("o SKU seja copiado da coluna Código", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
testRunner.And("seja colado no editText Código do Produto", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
testRunner.And("a quantidade seja copiada da coluna Qtd. Total", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
testRunner.And("seja colada no editText Quantidade", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
testRunner.And("eu clicar Enter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
testRunner.When("clicar no botao Concluir Processo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
testRunner.Then("uma mensagem de conferido com sucesso deve aparecer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Conferir quantidade errada")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoConferencia")]
        [Xunit.TraitAttribute("Description", "Conferir quantidade errada")]
        [Xunit.TraitAttribute("Category", "conferir_quantidade_errada")]
        public virtual void ConferirQuantidadeErrada()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Conferir quantidade errada", null, new string[] {
                        "conferir_quantidade_errada"});
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 26
testRunner.Given("que eu acesse as actions do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
testRunner.And("clique no botao Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
testRunner.And("seja redirecionado para tela de WMS Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
testRunner.And("o SKU seja copiado da coluna Código", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
testRunner.And("seja colado no editText Código do Produto", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
testRunner.And("a quantidade seja copiada da coluna Qtd. Total", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
testRunner.And("seja colada no editText Quantidade uma quantidade diferente da copiada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
testRunner.When("eu clicar Enter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
testRunner.Then("a quantidade da coluna Qtd. Conferida deve ser diferente da coluna Qtd. Total", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Conferir codigo errado")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoConferencia")]
        [Xunit.TraitAttribute("Description", "Conferir codigo errado")]
        [Xunit.TraitAttribute("Category", "conferir_codigo_errado")]
        public virtual void ConferirCodigoErrado()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Conferir codigo errado", null, new string[] {
                        "conferir_codigo_errado"});
#line 38
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 39
testRunner.Given("que eu acesse as actions do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
testRunner.And("clique no botao Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
testRunner.And("seja redirecionado para tela de WMS Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
testRunner.And("o SKU seja copiado da coluna Código", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
testRunner.And("seja colado no editText Código do Produto um código diferente do copiado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
testRunner.And("a quantidade seja copiada da coluna Qtd. Total", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
testRunner.And("seja colada no editText Quantidade", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
testRunner.When("eu clicar Enter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
testRunner.Then("uma mensagem de Codigo Invalido é exibida", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Conferir e reiniciar processo")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoConferencia")]
        [Xunit.TraitAttribute("Description", "Conferir e reiniciar processo")]
        [Xunit.TraitAttribute("Category", "conferir_e_reiniciar_processo")]
        public virtual void ConferirEReiniciarProcesso()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Conferir e reiniciar processo", null, new string[] {
                        "conferir_e_reiniciar_processo"});
#line 51
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 52
testRunner.Given("que eu acesse as actions do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 53
testRunner.And("clique no botao Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
testRunner.And("seja redirecionado para tela de WMS Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
testRunner.And("o SKU seja copiado da coluna Código", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
testRunner.And("seja colado no editText Código do Produto um código diferente do copiado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
testRunner.And("eu clicar Enter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
testRunner.When("eu clicar no botao Reiniciar Processo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
testRunner.And("confirmar clicando no botao OK do alerta exibido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
testRunner.Then("uma mensagem de reiniciado com sucesso deve aparecer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
testRunner.And("a coluna Qtd. Conferida deve ser zero", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Reiniciar conferencia finalizada")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoConferencia")]
        [Xunit.TraitAttribute("Description", "Reiniciar conferencia finalizada")]
        [Xunit.TraitAttribute("Category", "reiniciar_conferencia_finalizada")]
        public virtual void ReiniciarConferenciaFinalizada()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Reiniciar conferencia finalizada", null, new string[] {
                        "reiniciar_conferencia_finalizada"});
#line 64
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 65
testRunner.Given("que eu acesse as actions do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 66
testRunner.And("clique no botao Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
testRunner.And("seja redirecionado para tela de WMS Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
testRunner.And("uma mensagem de Conferência Finalizada deve aparecer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
testRunner.When("eu clicar no botao Reiniciar Processo Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
testRunner.And("confirmar clicando no botao OK do alerta exibido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
testRunner.Then("uma mensagem de reiniciado com sucesso deve aparecer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
testRunner.And("a coluna Qtd. Conferida deve ser zero", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Concluir conferencia finalizada")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoConferencia")]
        [Xunit.TraitAttribute("Description", "Concluir conferencia finalizada")]
        [Xunit.TraitAttribute("Category", "concluir_conferencia_finalizada")]
        public virtual void ConcluirConferenciaFinalizada()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Concluir conferencia finalizada", null, new string[] {
                        "concluir_conferencia_finalizada"});
#line 75
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 76
testRunner.Given("que eu acesse as actions do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 77
testRunner.And("clique no botao Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
testRunner.And("seja redirecionado para tela de WMS Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
testRunner.And("uma mensagem de Conferência Finalizada deve aparecer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
testRunner.When("clicar no botao Finalizar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
testRunner.And("ser redirecionado para tela de COM Finalizar Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
testRunner.And("clicar em Finalizar Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
testRunner.Then("o sistema deve redirecionar para tela Entrega e Remessas do Pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Conferir e concluir todo processo de conferencia")]
        [Xunit.TraitAttribute("FeatureTitle", "PedidoConferencia")]
        [Xunit.TraitAttribute("Description", "Conferir e concluir todo processo de conferencia")]
        [Xunit.TraitAttribute("Category", "conferir_e_concluir_todo_processo_conferencia")]
        public virtual void ConferirEConcluirTodoProcessoDeConferencia()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Conferir e concluir todo processo de conferencia", null, new string[] {
                        "conferir_e_concluir_todo_processo_conferencia"});
#line 87
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 88
testRunner.Given("que eu acesse as actions do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 89
testRunner.And("clique no botao Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
testRunner.And("seja redirecionado para tela de WMS Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
testRunner.And("o SKU seja copiado da coluna Código", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
testRunner.And("seja colado no editText Código do Produto", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
testRunner.And("a quantidade seja copiada da coluna Qtd. Total", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
testRunner.And("seja colada no editText Quantidade", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
testRunner.And("eu clicar Enter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
testRunner.And("clicar no botao Concluir Processo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
testRunner.When("clicar no botao Finalizar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
testRunner.And("ser redirecionado para tela de COM Finalizar Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
testRunner.And("clicar em Finalizar Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
testRunner.Then("o sistema deve redirecionar para tela Entrega e Remessas do Pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PedidoConferenciaFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PedidoConferenciaFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion