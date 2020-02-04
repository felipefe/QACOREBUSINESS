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
    public partial class RecepcaoMercadoriaNovoLancamentoManualFeature : Xunit.IClassFixture<RecepcaoMercadoriaNovoLancamentoManualFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "RecepcaoMercadoriaNovoLancamentoManual.feature"
#line hidden
        
        public RecepcaoMercadoriaNovoLancamentoManualFeature(RecepcaoMercadoriaNovoLancamentoManualFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "RecepcaoMercadoriaNovoLancamentoManual", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
testRunner.And("acesse a index de recepcao de mercadoria", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Lancar manualmente nova recepcao de mercadoria")]
        [Xunit.TraitAttribute("FeatureTitle", "RecepcaoMercadoriaNovoLancamentoManual")]
        [Xunit.TraitAttribute("Description", "Lancar manualmente nova recepcao de mercadoria")]
        [Xunit.TraitAttribute("Category", "recepcao_mercadoria_novo_lancamento_manual")]
        public virtual void LancarManualmenteNovaRecepcaoDeMercadoria()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Lancar manualmente nova recepcao de mercadoria", null, new string[] {
                        "recepcao_mercadoria_novo_lancamento_manual"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 10
 testRunner.Given("que seja clicado no botao Novo Lancamento Manual", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.And("seja redirecionado para tela de criar recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("seja informado a operação fiscal {\'Recepção de Mercadoria\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("seja informado no editText o fornecedor {\'New Era Fornecedor LTDA\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("seja informado no editText a data de recebimento [data atual]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("seja informado no editText o Numero do documento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("seja informado no editText a Serie do documento {1}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("seja informado no editText a data de emissao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("seja informado o modelo de documento {\'Nota Fiscal modelo 1 ou 1-A\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.When("clicar no botao Salvar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("o sistema redirecionada para index de recepçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.And("o status da recepcao deve ser {\'Lançamento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Lancar itens recepcao manual")]
        [Xunit.TraitAttribute("FeatureTitle", "RecepcaoMercadoriaNovoLancamentoManual")]
        [Xunit.TraitAttribute("Description", "Lancar itens recepcao manual")]
        [Xunit.TraitAttribute("Category", "lancar_itens_recepcao_manual")]
        public virtual void LancarItensRecepcaoManual()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Lancar itens recepcao manual", null, new string[] {
                        "lancar_itens_recepcao_manual"});
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 26
 testRunner.Given("que tenha uma recepcao no status {\'Lançamento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
 testRunner.And("seja clicado no botao Mercadoria nas actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("seja redirecionado para tela de Mercadorias da recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("seja clicado no botao Nova Mercadoria Recebida", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("seja redirecionado para criar item da recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.When("informar o produto SKU {\'TST0002\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.And("informar no editText o valor unitario {65,000}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("informar no editText a quantidade {10,000}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("informar no editText o numero do lote", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("informar no editText a data de fabricacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("informar no editText a data de validade", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("clicar na aba de Impostos Conforme Documento de Entrada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("informar o CFOP {1102} - Compra para comercializacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("informar a origem da Mercadoria {\'Nacional - exceto as indicadas nos códigos 3 a " +
                    "5\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("informar o codigo da ST {\'Tributada integralmente\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("informar no editText o percentual da Aliquota {1,000}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("clicar no botao de Salvar itens", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.Then("seja redirecionado para tela de Mercadorias da recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.And("o SKU do item da recepcao informado deve aparecer na tabela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Escriturar itens da recepcao")]
        [Xunit.TraitAttribute("FeatureTitle", "RecepcaoMercadoriaNovoLancamentoManual")]
        [Xunit.TraitAttribute("Description", "Escriturar itens da recepcao")]
        [Xunit.TraitAttribute("Category", "escriturar_item_mercadoria_recepcao")]
        public virtual void EscriturarItensDaRecepcao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Escriturar itens da recepcao", null, new string[] {
                        "escriturar_item_mercadoria_recepcao"});
#line 48
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 49
 testRunner.Given("que tenha uma recepcao no status {\'Lançamento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
 testRunner.And("seja clicado no botao Mercadoria nas actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("seja redirecionado para tela de Mercadorias da recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("tenha na coluna Escriturado do item o valor {\'Não\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.When("clicar no botao da header Escriturar todos os itens automaticamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.And("seja redirecionado para index de escriturar lote fiscal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.And("clicar na aba Configuração", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.And("selecione o CFOP {1102} Compra para Comercialização", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("clicar no botao Calcular", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.Then("o status do item deve mudar para {\'Escriturado\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.And("quando clicar no botao Prosseguir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("o sistema redirecionada para index de recepçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Finalizar lancamento de itens escriturados")]
        [Xunit.TraitAttribute("FeatureTitle", "RecepcaoMercadoriaNovoLancamentoManual")]
        [Xunit.TraitAttribute("Description", "Finalizar lancamento de itens escriturados")]
        [Xunit.TraitAttribute("Category", "finalizar_lancamento_itens_escriturados_recepcao")]
        public virtual void FinalizarLancamentoDeItensEscriturados()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Finalizar lancamento de itens escriturados", null, new string[] {
                        "finalizar_lancamento_itens_escriturados_recepcao"});
#line 66
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 67
 testRunner.Given("que tenha uma recepcao no status {\'Lançamento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 68
 testRunner.And("seja clicado no botao Mercadoria nas actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("seja redirecionado para tela de Mercadorias da recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("tenha na coluna Escriturado do item o valor {\'Sim\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.When("clicar no botao Finalizar Lançamento de Itens", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.And("marcar Eu concluí o lançamento de todos os itens", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("clicar no botao Confirmar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.Then("o sistema redirecionada para index de recepçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.And("o status da recepcao deve ser {\'Aguardando Finalização\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                RecepcaoMercadoriaNovoLancamentoManualFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RecepcaoMercadoriaNovoLancamentoManualFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
