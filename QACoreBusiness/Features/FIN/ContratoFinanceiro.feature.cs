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
    public partial class ContratoFinanceiroFeature : Xunit.IClassFixture<ContratoFinanceiroFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ContratoFinanceiro.feature"
#line hidden
        
        public ContratoFinanceiroFeature(ContratoFinanceiroFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ContratoFinanceiro", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
testRunner.And("clicar para acessar o contexto {\'Contratos\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Criar contrato FIN + parcelas AUTO")]
        [Xunit.TraitAttribute("FeatureTitle", "ContratoFinanceiro")]
        [Xunit.TraitAttribute("Description", "Criar contrato FIN + parcelas AUTO")]
        [Xunit.TraitAttribute("Category", "create_contrato_com_parcelas_auto")]
        public virtual void CriarContratoFINParcelasAUTO()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Criar contrato FIN + parcelas AUTO", null, new string[] {
                        "create_contrato_com_parcelas_auto"});
#line 32
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 33
 testRunner.Given("que seja clicado no botao criar contrato", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
 testRunner.And("seja redirecionado para /Contrato/Create", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.When("inserir no input numero do documento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.And("selecionar a pessoa do contrato {\'Laura La Caronita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("selecionar a empresa do contrato {\'Deltacon Informática\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("selecionar o plano de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("selecionar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("informar no textArea um historico  {\'Contrato referente venda de testes autorimat" +
                    "izados\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("selecionar a conta prevista pagamento {\'BB Fake\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("clicar no botao adicionar parcelas automaticamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("inserir no input o valor a pagar(futuro) da parcela R${931.5}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("inserir no input a quantidade de {3} parcelas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("inserir no input o intervalo de {15} dias entre parcelas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("inserir o vencimento da primeira parcela para {15} dias futuros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("clicar no botao salvar parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.Then("as parcelas devem ser criadas conforme a qntdade informada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.And("clicar no botao salvar/criar contrato", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("o sistema redireciona para index de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("o status do contrato deve ser {\'Aberto\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("a coluna referente ao valor original {\'931.5\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("feche o navegador quando terminar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Criar contrato FIN + parcelas MANUAL")]
        [Xunit.TraitAttribute("FeatureTitle", "ContratoFinanceiro")]
        [Xunit.TraitAttribute("Description", "Criar contrato FIN + parcelas MANUAL")]
        [Xunit.TraitAttribute("Category", "create_contrato_com_parcelas_manual")]
        public virtual void CriarContratoFINParcelasMANUAL()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Criar contrato FIN + parcelas MANUAL", null, new string[] {
                        "create_contrato_com_parcelas_manual"});
#line 57
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 58
 testRunner.Given("que seja clicado no botao criar contrato", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
 testRunner.And("seja redirecionado para /Contrato/Create", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.When("inserir no input numero do documento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.And("selecionar a pessoa do contrato {\'Laura La Caronita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("selecionar a empresa do contrato {\'Deltacon Informática\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("selecionar o plano de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And("selecionar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.And("informar no textArea um historico  {\'Contrato referente venda de testes autorimat" +
                    "izados\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.And("selecionar a conta prevista pagamento {\'BB Fake\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.And("clicar no botao adicionar parcelas manualmente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("inserir no input Valor Original R${420.0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("inserir no input Data de Vencimento {15} dias futuros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("clicar no botao Adicionar parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.Then("a parcela deve ser criadas conforme valor informado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.And("clicar no botao salvar/criar contrato", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("o sistema redireciona para index de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And("o status do contrato deve ser {\'Aberto\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("a coluna referente ao valor original {\'420.0\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And("feche o navegador quando terminar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Excluir contrato Aberto")]
        [Xunit.TraitAttribute("FeatureTitle", "ContratoFinanceiro")]
        [Xunit.TraitAttribute("Description", "Excluir contrato Aberto")]
        [Xunit.TraitAttribute("Category", "excluir_contrato_restricao")]
        public virtual void ExcluirContratoAberto()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Excluir contrato Aberto", null, new string[] {
                        "excluir_contrato_restricao"});
#line 89
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 90
testRunner.Given("que o status do contrato seja {\'Aberto\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 91
testRunner.And("memorize o N doc do contrato a ser excluido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
testRunner.When("clicar nas actions Excluir / Cancelar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
testRunner.And("confirmar clicando no botao Excluir da modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
testRunner.Then("o contrato nao deve ser excluido motivo {\'Não foi possível apagar o contrato!\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
testRunner.And("feche o navegador quando terminar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Lançar Pagto Antecipado")]
        [Xunit.TraitAttribute("FeatureTitle", "ContratoFinanceiro")]
        [Xunit.TraitAttribute("Description", "Lançar Pagto Antecipado")]
        [Xunit.TraitAttribute("Category", "lancar_pagamento_antecipado")]
        public virtual void LancarPagtoAntecipado()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Lançar Pagto Antecipado", null, new string[] {
                        "lancar_pagamento_antecipado"});
#line 99
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 100
testRunner.Given("seja clicado no botao da Header Lançar Pagamento Antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 101
testRunner.And("seja redirecionado para index de Pagto Antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
testRunner.When("selecionar a pessoa do contrato {\'Laura La Caronita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
testRunner.And("selecionar o plano de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
testRunner.And("selecionar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
testRunner.And("selecionar o meio de pagamento {\'Dinheiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
testRunner.And("informar no input o Valor a pagar {90.50}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
testRunner.And("clicar no botao Salvar pagto antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
testRunner.Then("o sistema redireciona para index de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 109
testRunner.And("um contrato de pagamento Num Doc {\'PGA\'} deve ser criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
testRunner.And("com status {\'Quitado\'} na primeira linha da tabela de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
testRunner.And("um contrato de credito Num Doc {\'CREPGA\'} deve ser criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
testRunner.And("com status {\'Aberto\'} na segunda linha da tabela contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
testRunner.And("feche o navegador quando terminar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Lançar Despesa")]
        [Xunit.TraitAttribute("FeatureTitle", "ContratoFinanceiro")]
        [Xunit.TraitAttribute("Description", "Lançar Despesa")]
        [Xunit.TraitAttribute("Category", "lancar_despesa_contrato")]
        public virtual void LancarDespesa()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Lançar Despesa", null, new string[] {
                        "lancar_despesa_contrato"});
#line 117
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 118
 testRunner.Given("que seja clicado no botao Lançar Despesa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 119
 testRunner.And("seja redirecionado para /FIN/DespesaReceita/Create?tipoPC=D", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.When("inserir no input numero do documento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
 testRunner.And("selecionar a pessoa do contrato {\'Laura La Caronita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.And("selecionar o plano de contas {\'Contratos - Despesa\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.And("inserir no input Valor Original R${70.0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.And("inserir no input Valor Pago R${70.0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.And("selecionar o meio de pagamento {\'Dinheiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.And("selecionar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.And("informar no textArea um historico  {\'Contrato despesa\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.And("clicar no botao salvar contrato", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.Then("o sistema redireciona para index de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
 testRunner.And("o status do contrato deve ser {\'Quitado\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
 testRunner.And("a coluna referente ao valor original {\'70.0\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.And("feche o navegador quando terminar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Lançar Receita")]
        [Xunit.TraitAttribute("FeatureTitle", "ContratoFinanceiro")]
        [Xunit.TraitAttribute("Description", "Lançar Receita")]
        [Xunit.TraitAttribute("Category", "lancar_receita_contrato")]
        public virtual void LancarReceita()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Lançar Receita", null, new string[] {
                        "lancar_receita_contrato"});
#line 136
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 137
 testRunner.Given("que seja clicado no botao Lançar Receita", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 138
 testRunner.And("seja redirecionado para /FIN/DespesaReceita/Create?tipoPC=C", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.When("inserir no input numero do documento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 140
 testRunner.And("selecionar a pessoa do contrato {\'Laura La Caronita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
 testRunner.And("selecionar o plano de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
 testRunner.And("inserir no input Valor Original R${420.0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
 testRunner.And("inserir no input Valor Pago R${420.0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
 testRunner.And("selecionar o meio de pagamento {\'Dinheiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
 testRunner.And("selecionar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
 testRunner.And("informar no textArea um historico  {\'Contrato receita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 147
 testRunner.And("clicar no botao salvar contrato", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
 testRunner.Then("o sistema redireciona para index de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 149
 testRunner.And("o status do contrato deve ser {\'Quitado\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
 testRunner.And("a coluna referente ao valor original {\'420.0\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 151
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
                ContratoFinanceiroFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ContratoFinanceiroFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
