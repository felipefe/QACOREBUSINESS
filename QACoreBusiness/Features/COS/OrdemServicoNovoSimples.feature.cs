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
namespace QACoreBusiness.Features.COS
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class OrdemServicoNovoSimplesFeature : Xunit.IClassFixture<OrdemServicoNovoSimplesFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "OrdemServicoNovoSimples.feature"
#line hidden
        
        public OrdemServicoNovoSimplesFeature(OrdemServicoNovoSimplesFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "OrdemServicoNovoSimples", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
testRunner.And("clicar para acessar o contexto {\'Processos (Ordens de Serviço/Produção)\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Criar OS Novo Simples")]
        [Xunit.TraitAttribute("FeatureTitle", "OrdemServicoNovoSimples")]
        [Xunit.TraitAttribute("Description", "Criar OS Novo Simples")]
        [Xunit.TraitAttribute("Category", "criar_novo_simples")]
        public virtual void CriarOSNovoSimples()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Criar OS Novo Simples", null, new string[] {
                        "criar_novo_simples"});
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 9
testRunner.Given("que seja clicado no botao Novo Simples", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
testRunner.And("seja selecionado o tipo de OS {\'Produção\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
testRunner.And("seja seleciona a pessoa {\'Laura La Caronita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
testRunner.And("seja informado no input o prazo final para {30} dias futuros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
testRunner.And("seja informado no textarea um Resumo {\'Resumidamente sintetico\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
testRunner.And("seja informado no textarea uma Observacao {\'Observado absurdamente\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
testRunner.When("clicar no botao Salvar novo simples", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
testRunner.Then("o sistema deve redirecionar para o edit da OS criada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Excluir OS Aberta")]
        [Xunit.TraitAttribute("FeatureTitle", "OrdemServicoNovoSimples")]
        [Xunit.TraitAttribute("Description", "Excluir OS Aberta")]
        [Xunit.TraitAttribute("Category", "excluir_os_sucesso")]
        public virtual void ExcluirOSAberta()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Excluir OS Aberta", null, new string[] {
                        "excluir_os_sucesso"});
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 21
testRunner.Given("tenha uma ordem de serviço com status {\'Normal\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
testRunner.And("coluna Itens Finalizados como {\'Não\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
testRunner.And("que seja clicado Excluir nas actions da OS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
testRunner.And("seja inserido no textarea uma justificativa {\'Cancelamento extraordinario\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
testRunner.When("clicar no botao Cancelar O.S.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
testRunner.Then("a OS deve ser excluida", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Inserir Receita OS")]
        [Xunit.TraitAttribute("FeatureTitle", "OrdemServicoNovoSimples")]
        [Xunit.TraitAttribute("Description", "Inserir Receita OS")]
        [Xunit.TraitAttribute("Category", "incluir_item_os")]
        public virtual void InserirReceitaOS()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inserir Receita OS", null, new string[] {
                        "incluir_item_os"});
#line 30
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 31
testRunner.Given("tenha uma ordem de serviço com status {\'Normal\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
testRunner.And("coluna Itens Finalizados como {\'Não\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
testRunner.And("que seja clicado Editar nas actions da OS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
testRunner.And("seja clicado no botao Novo Item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
testRunner.And("seja informado no select a receita {\'Receita Boné Hurley\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
testRunner.And("seja informado o multiplicador da receita {1}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
testRunner.When("clicar no botao Salvar item O.S", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
testRunner.Then("o sistema redireciona para /COS/OrdemServicoItem/Edit/", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Manutenção de Itens - Reservar/Separar")]
        [Xunit.TraitAttribute("FeatureTitle", "OrdemServicoNovoSimples")]
        [Xunit.TraitAttribute("Description", "Manutenção de Itens - Reservar/Separar")]
        [Xunit.TraitAttribute("Category", "manutenção_de_itens")]
        public virtual void ManutencaoDeItens_ReservarSeparar()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Manutenção de Itens - Reservar/Separar", null, new string[] {
                        "manutenção_de_itens"});
#line 42
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 43
testRunner.Given("tenha uma ordem de serviço com status {\'Normal\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
testRunner.And("coluna Itens Finalizados como {\'Não\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
testRunner.And("que seja clicado Manutenção de Itens nas actions da OS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
testRunner.And("seja redirecionado para /COS/Agrupador/ManutencaoItensOS/", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
testRunner.When("clicar no botao Marcar Todos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
testRunner.And("clicar no botao Reservar/Requisitar Insumos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
testRunner.And("clicar no botao Marcar Todos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
testRunner.And("clicar no botao Separar Insumos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
testRunner.Then("o status dos insumos devem ser {\'Separado\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
testRunner.And("a Qtd. Reservada igual a Qtd. Receita", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                OrdemServicoNovoSimplesFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                OrdemServicoNovoSimplesFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
