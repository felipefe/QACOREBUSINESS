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
namespace QACoreBusiness.Features.FIN
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class GestorFinanceiroFeature : Xunit.IClassFixture<GestorFinanceiroFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "GestorFinanceiro.feature"
#line hidden
        
        public GestorFinanceiroFeature(GestorFinanceiroFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GestorFinanceiro", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
testRunner.And("acesse a index gestor financeiro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Baixar Parcela Receita Dinheiro")]
        [Xunit.TraitAttribute("FeatureTitle", "GestorFinanceiro")]
        [Xunit.TraitAttribute("Description", "Baixar Parcela Receita Dinheiro")]
        [Xunit.TraitAttribute("Category", "baixar_parcela_dinheiro")]
        public virtual void BaixarParcelaReceitaDinheiro()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Baixar Parcela Receita Dinheiro", null, new string[] {
                        "baixar_parcela_dinheiro"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 10
 testRunner.Given("que clica na aba Contas a Receber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.And("clique na pesquisa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("clique para limpar filtros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("clique no botao Filtrar Receitas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("o numero de parcelas filtradas seja maior que {0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("selecione a primeira parcela listada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("clique no botao movimentar parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("o valor a ser movimentado seja maior que zero", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("clique no icone Baixar Parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("seja redirecionado para /FIN/Contrato/ListarParcelasBaixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("clique no collapse para exibir meio pagamento parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("selecione o meio de pagamento {\'Dinheiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.When("clicar no botao Efetuar Baixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("o sistema redireciona para imprimir movimentacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Baixar Parcela Receita Abatimento")]
        [Xunit.TraitAttribute("FeatureTitle", "GestorFinanceiro")]
        [Xunit.TraitAttribute("Description", "Baixar Parcela Receita Abatimento")]
        [Xunit.TraitAttribute("Category", "baixar_parcela_abatimento")]
        public virtual void BaixarParcelaReceitaAbatimento()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Baixar Parcela Receita Abatimento", null, new string[] {
                        "baixar_parcela_abatimento"});
#line 27
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 28
 testRunner.Given("que clica na aba Contas a Receber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
 testRunner.And("clique na pesquisa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("clique para limpar filtros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("clique no botao Filtrar Receitas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("o numero de parcelas filtradas seja maior que {0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("selecione a primeira parcela listada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("clique no botao movimentar parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("o valor a ser movimentado seja maior que zero", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("clique no icone Baixar Parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("seja redirecionado para /FIN/Contrato/ListarParcelasBaixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("clique no collapse para exibir meio pagamento parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("selecione o meio de pagamento {\'Abatimento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("ache no select a parcela de crédito/abatimento que seja maior que o valor a quita" +
                    "r", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("selecione a parcela de crédito/abatimento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.When("clicar no botao Efetuar Baixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then("o sistema redireciona para imprimir movimentacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Baixar Multiplas Parcelas Receita Dinheiro")]
        [Xunit.TraitAttribute("FeatureTitle", "GestorFinanceiro")]
        [Xunit.TraitAttribute("Description", "Baixar Multiplas Parcelas Receita Dinheiro")]
        [Xunit.TraitAttribute("Category", "baixar_multiplas_parcela_dinheiro")]
        public virtual void BaixarMultiplasParcelasReceitaDinheiro()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Baixar Multiplas Parcelas Receita Dinheiro", null, new string[] {
                        "baixar_multiplas_parcela_dinheiro"});
#line 47
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 48
 testRunner.Given("que clica na aba Contas a Receber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
 testRunner.And("clique na pesquisa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("clique para limpar filtros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("clique no botao Filtrar Receitas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("o numero de parcelas filtradas seja maior que {2}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("selecione a primeira parcela listada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("selecione a segunda parcela listada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.And("clique no botao movimentar parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.And("o valor a ser movimentado seja maior que zero", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("clique no icone Baixar Parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("seja redirecionado para /FIN/Contrato/ListarParcelasBaixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("clique no botao Adicionar Multiplos Meios de Pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.When("selecione o meio de pagamento {\'Dinheiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.And("informar o planos de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("informar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("informar no input o historico {\'Multiplos meios de pagamento  - ÉusGuri\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And("clicar no botao Adicionar para multiplos meios de pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.And("clicar no botao Efetuar Baixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.Then("o sistema redireciona para imprimir movimentacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Baixar Multiplas Parcelas Receita Abatimento")]
        [Xunit.TraitAttribute("FeatureTitle", "GestorFinanceiro")]
        [Xunit.TraitAttribute("Description", "Baixar Multiplas Parcelas Receita Abatimento")]
        [Xunit.TraitAttribute("Category", "baixar_multiplas_parcela_abatimento")]
        public virtual void BaixarMultiplasParcelasReceitaAbatimento()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Baixar Multiplas Parcelas Receita Abatimento", null, new string[] {
                        "baixar_multiplas_parcela_abatimento"});
#line 70
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 71
 testRunner.Given("que clica na aba Contas a Receber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 72
 testRunner.And("clique na pesquisa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("clique para limpar filtros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And("clique no botao Filtrar Receitas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("o numero de parcelas filtradas seja maior que {1}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And("selecione a primeira parcela listada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And("selecione a segunda parcela listada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("clique no botao movimentar parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("o valor a ser movimentado seja maior que zero", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("clique no icone Baixar Parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("seja redirecionado para /FIN/Contrato/ListarParcelasBaixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("clique no botao Adicionar Multiplos Meios de Pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.When("selecione o meio de pagamento {\'Abatimento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.And("informar o planos de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.And("informar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.And("informar no input o historico {\'Multiplos meios de pagamento  - ÉusGuri\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.And("clicar no botao Adicionar para multiplos meios de pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("clicar no botao Vincular Parcelas de Crédito/Abatimento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("memorizar o valor a quitar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("validar que os créditos disponíveis são maiores que {0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.And("validar que o valor total dos creditos disponiveis sao maiores que o valor a quit" +
                    "ar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("selecionar os creditos até o valor total selecionado ser igual ou maior que o val" +
                    "or a quitar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("clicar no botao Vincular creditos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("clicar no botao Efetuar Baixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.Then("o sistema redireciona para imprimir movimentacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                GestorFinanceiroFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                GestorFinanceiroFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
