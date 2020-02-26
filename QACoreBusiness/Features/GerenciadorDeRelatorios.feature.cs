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
    public partial class GerenciadorDeRelatoriosFeature : Xunit.IClassFixture<GerenciadorDeRelatoriosFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "GerenciadorDeRelatorios.feature"
#line hidden
        
        public GerenciadorDeRelatoriosFeature(GerenciadorDeRelatoriosFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GerenciadorDeRelatorios", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
testRunner.And("clicar para acessar o contexto {\'Gerenciador de Relatórios\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Importar definicao de relatorio Estoque (Separacoes)")]
        [Xunit.TraitAttribute("FeatureTitle", "GerenciadorDeRelatorios")]
        [Xunit.TraitAttribute("Description", "Importar definicao de relatorio Estoque (Separacoes)")]
        [Xunit.TraitAttribute("Category", "importar_relatorio_estoque")]
        public virtual void ImportarDefinicaoDeRelatorioEstoqueSeparacoes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Importar definicao de relatorio Estoque (Separacoes)", null, new string[] {
                        "importar_relatorio_estoque"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 10
 testRunner.Given("que seja clicado no botao Definicoes de Relatorios", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.And("seja redirecionado para index de Definiçoes de Relatorios /RPT/Report", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("seja clicado no botao carregar Definicao de Relatorio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("seja clicado para fazer o upload", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("selecione o arquivo rpt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.When("clicar no botao Carregar rpt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("seja redirecionado para index de Definiçoes de Relatorios /RPT/Report", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Criar definicao de relatorio")]
        [Xunit.TraitAttribute("FeatureTitle", "GerenciadorDeRelatorios")]
        [Xunit.TraitAttribute("Description", "Criar definicao de relatorio")]
        [Xunit.TraitAttribute("Category", "criar_definicao_relatorio")]
        public virtual void CriarDefinicaoDeRelatorio()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Criar definicao de relatorio", null, new string[] {
                        "criar_definicao_relatorio"});
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 21
 testRunner.Given("que seja clicado no botao Definicoes de Relatorios", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.And("seja redirecionado para index de Definiçoes de Relatorios /RPT/Report", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("que eu tenha importado o relatorio de nome {\'Separações\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("clique nas actions deste relatorio Criar Relatorio A partir Desta Definição", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.When("clicar no botao Salvar relatorio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then("seja redirecionado para index de Gerenciador de relatorio /RPT/ReportView", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Editar definicao relatorio")]
        [Xunit.TraitAttribute("FeatureTitle", "GerenciadorDeRelatorios")]
        [Xunit.TraitAttribute("Description", "Editar definicao relatorio")]
        [Xunit.TraitAttribute("Category", "editar_definicao_relatorio")]
        public virtual void EditarDefinicaoRelatorio()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editar definicao relatorio", null, new string[] {
                        "editar_definicao_relatorio"});
#line 30
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 31
 testRunner.Given("que eu tenha relatorio de nome {\'Comissões de Vendas por Recebimento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
 testRunner.And("clique nas actions deste relatorio Editar Definiçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("seja redirecionado para tela de edicao do rpt /RPT/ReportView/EditBuilder/", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("clique na aba Colunas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.When("selecionar todas as colunas possiveis", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.And("clicar no botao Gravar denificao editada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.Then("seja redirecionado para index de Gerenciador de relatorio /RPT/ReportView", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Excluir definicao relatorio")]
        [Xunit.TraitAttribute("FeatureTitle", "GerenciadorDeRelatorios")]
        [Xunit.TraitAttribute("Description", "Excluir definicao relatorio")]
        [Xunit.TraitAttribute("Category", "excluir_definicao_relatorio")]
        public virtual void ExcluirDefinicaoRelatorio()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Excluir definicao relatorio", null, new string[] {
                        "excluir_definicao_relatorio"});
#line 41
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 42
 testRunner.Given("que eu tenha relatorio de nome {\'Comissões de Vendas por Recebimento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
 testRunner.And("clique nas actions deste relatorio Excluir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.When("confirmar clicando no botao Excluir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then("o relatorio deve ser excluido e {\'Comissões de Vendas por Recebimento\'} nao apare" +
                    "cer na lista", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Executar Relatorio")]
        [Xunit.TraitAttribute("FeatureTitle", "GerenciadorDeRelatorios")]
        [Xunit.TraitAttribute("Description", "Executar Relatorio")]
        [Xunit.TraitAttribute("Category", "executar_relatorio")]
        public virtual void ExecutarRelatorio()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Executar Relatorio", null, new string[] {
                        "executar_relatorio"});
#line 49
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 50
 testRunner.Given("que seja clicado no menu do usuario logado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
 testRunner.And("clique no botao Relatorios", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("seja redirecionado para Meus Relatorios /RPT/ReportView/UserReportViews", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("que eu tenha relatorio de nome {\'Comissões de Vendas por Recebimento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.When("clicar no botao executar relatorio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.And("ser redirecionado para Parametros de execucao /RPT/ReportView/OpenReportView/", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.And("clicar no botao Executar meu relatorio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.Then("o relatorio deve ser exibido em uma nova guia do navegador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                GerenciadorDeRelatoriosFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                GerenciadorDeRelatoriosFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion