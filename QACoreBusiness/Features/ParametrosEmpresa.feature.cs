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
    public partial class ParametrosEmpresaFeature : Xunit.IClassFixture<ParametrosEmpresaFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ParametrosEmpresa.feature"
#line hidden
        
        public ParametrosEmpresaFeature(ParametrosEmpresaFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ParametrosEmpresa", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 4
#line 5
testRunner.Given("que eu esteja logado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
testRunner.And("acesse o contexto de Empresa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
testRunner.And("seja redirecionado para url {/IDFe/Empresa/}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
testRunner.And("clique no botao dos Parametros da Empresa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
testRunner.And("seja redirecionado para url dos parametros {/Parametro/ParametrosEmpresa/}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Habilitar ambiente de homologacao")]
        [Xunit.TraitAttribute("FeatureTitle", "ParametrosEmpresa")]
        [Xunit.TraitAttribute("Description", "Habilitar ambiente de homologacao")]
        [Xunit.TraitAttribute("Category", "habilitar_ambiente_homologaçao")]
        public virtual void HabilitarAmbienteDeHomologacao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Habilitar ambiente de homologacao", null, new string[] {
                        "habilitar_ambiente_homologaçao"});
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 13
testRunner.Given("que eu clique para editar o parametro Configurações de Emissão de NF-e", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
testRunner.And("esteja na tela de ediçao do parametro {\'Config. NF-e\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
testRunner.When("selecionar {\'Ambiente de Testes ou Homologação\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
testRunner.And("clicar no botao salvar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
testRunner.Then("serei redirecionado para url dos parametros {/Parametro/ParametrosEmpresa/}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
testRunner.And("a coluna valor do parametro Config. NF-e deve ser Ambiente de Testes ou Homologaç" +
                    "ao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Ambiente de homologacao ja habilitado")]
        [Xunit.TraitAttribute("FeatureTitle", "ParametrosEmpresa")]
        [Xunit.TraitAttribute("Description", "Ambiente de homologacao ja habilitado")]
        [Xunit.TraitAttribute("Category", "ambiente_homologacao_ja_habilitado")]
        public virtual void AmbienteDeHomologacaoJaHabilitado()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ambiente de homologacao ja habilitado", null, new string[] {
                        "ambiente_homologacao_ja_habilitado"});
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 23
testRunner.When("que eu clique para editar o parametro Configurações de Emissão de NF-e", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
testRunner.And("esteja na tela de ediçao do parametro {\'Config. NF-e\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
testRunner.Then("Ambiente de Testes ou Homologacao deve estar selecionado no select Ambiente de Em" +
                    "issao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ParametrosEmpresaFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ParametrosEmpresaFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
