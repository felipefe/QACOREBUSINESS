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
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 9
 testRunner.Given("que seja clicado no botao criar contrato", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.And("seja redirecionado para /Contrato/Create", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.When("inserir no input numero do documento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.And("selecionar a pessoa do contrato {\'Laura La Caronita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("selecionar a empresa do contrato {\'Deltacon Informática\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("selecionar o plano de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("selecionar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("informar no textArea um historico  {\'Contrato referente venda de testes autorimat" +
                    "izados\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("selecionar a conta prevista pagamento {\'BB Fake\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("clicar no botao adicionar parcelas automaticamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("inserir no input o valor a pagar(futuro) da parcela R${931.5}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("inserir no input a quantidade de {3} parcelas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("inserir no input o intervalo de {15} dias entre parcelas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("inserir o vencimento da primeira parcela para {15} dias futuros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("clicar no botao salvar parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.Then("as parcelas devem ser criadas conforme a qntdade informada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.And("clicar no botao salvar/criar contrato", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("o sistema redireciona para index de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("o status do contrato deve ser {\'Aberto\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("a coluna referente ao valor original {\'931.5\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
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
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 34
 testRunner.Given("que seja clicado no botao criar contrato", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
 testRunner.And("seja redirecionado para /Contrato/Create", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.When("inserir no input numero do documento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.And("selecionar a pessoa do contrato {\'Laura La Caronita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("selecionar a empresa do contrato {\'Deltacon Informática\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("selecionar o plano de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("selecionar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("informar no textArea um historico  {\'Contrato referente venda de testes autorimat" +
                    "izados\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("selecionar a conta prevista pagamento {\'BB Fake\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("clicar no botao adicionar parcelas manualmente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("inserir no input Valor Original R${420.0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("inserir no input Data de Vencimento {15} dias futuros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("clicar no botao Adicionar parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.Then("a parcela deve ser criadas conforme valor informado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
 testRunner.And("clicar no botao salvar/criar contrato", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("o sistema redireciona para index de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("o status do contrato deve ser {\'Aberto\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("a coluna referente ao valor original {\'420.0\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
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
#line 56
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 57
 testRunner.Given("que seja clicado no botao criar contrato", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 58
 testRunner.And("seja redirecionado para /Contrato/Create", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.When("inserir no input numero do documento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.And("selecionar a pessoa do contrato {\'Laura La Caronita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("selecionar a empresa do contrato {\'Deltacon Informática\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("selecionar o plano de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("selecionar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And("informar no textArea um historico  {\'Contrato referente venda de testes autorimat" +
                    "izados\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.And("selecionar a conta prevista pagamento {\'BB Fake\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.And("clicar no botao adicionar parcelas manualmente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.And("inserir no input Valor Original R${420.0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("inserir no input Data de Vencimento {15} dias futuros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("clicar no botao Adicionar parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("a parcela deve ser criadas conforme valor informado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("clicar no botao salvar/criar contrato", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And("o sistema redireciona para index de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("o status do contrato deve ser {\'Aberto\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And("a coluna referente ao valor original {\'420.0\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("memorize o N doc do contrato a ser excluido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And("clicar nas actions Excluir / Cancelar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And("confirmar clicando no botao Excluir da modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.Then("o contrato deve ser excluido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 79
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
#line 83
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 84
testRunner.Given("seja clicado no botao da Header Lançar Pagamento Antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 85
testRunner.And("seja redirecionado para index de Pagto Antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
testRunner.When("selecionar a pessoa do contrato {\'Laura La Caronita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
testRunner.And("selecionar o plano de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
testRunner.And("selecionar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
testRunner.And("selecionar o meio de pagamento {\'Dinheiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
testRunner.And("informar no input o Valor a pagar {600.0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
testRunner.And("clicar no botao Salvar pagto antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
testRunner.Then("o sistema redireciona para index de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 93
testRunner.And("um contrato de pagamento Num Doc {\'PGA\'} deve ser criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
testRunner.And("com status {\'Quitado\'} na primeira linha da tabela de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
testRunner.And("um contrato de credito Num Doc {\'CREPGA\'} deve ser criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
testRunner.And("com status {\'Aberto\'} na segunda linha da tabela contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
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
#line 128
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 129
 testRunner.Given("que seja clicado no botao Lançar Despesa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 130
 testRunner.And("seja redirecionado para /FIN/DespesaReceita/Create?tipoPC=D", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
 testRunner.When("inserir no input numero do documento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 132
 testRunner.And("selecionar a pessoa do contrato {\'Laura La Caronita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.And("selecionar o plano de contas {\'Contratos - Despesa\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.And("inserir no input Valor Original R${70.0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.And("inserir no input Valor Pago R${70.0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.And("selecionar o meio de pagamento {\'Dinheiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
 testRunner.And("selecionar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.And("informar no textArea um historico  {\'Contrato despesa\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.And("clicar no botao salvar contrato", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
 testRunner.Then("o sistema redireciona para index de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 141
 testRunner.And("o status do contrato deve ser {\'Quitado\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
 testRunner.And("a coluna referente ao valor original {\'70.0\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
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
#line 147
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 148
 testRunner.Given("que seja clicado no botao Lançar Receita", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 149
 testRunner.And("seja redirecionado para /FIN/DespesaReceita/Create?tipoPC=C", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
 testRunner.When("inserir no input numero do documento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 151
 testRunner.And("selecionar a pessoa do contrato {\'Laura La Caronita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
 testRunner.And("selecionar o plano de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
 testRunner.And("inserir no input Valor Original R${420.0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
 testRunner.And("inserir no input Valor Pago R${420.0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
 testRunner.And("selecionar o meio de pagamento {\'Dinheiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 156
 testRunner.And("selecionar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
 testRunner.And("informar no textArea um historico  {\'Contrato receita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 158
 testRunner.And("clicar no botao salvar contrato", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 159
 testRunner.Then("o sistema redireciona para index de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 160
 testRunner.And("o status do contrato deve ser {\'Quitado\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
 testRunner.And("a coluna referente ao valor original {\'420.0\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 162
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
