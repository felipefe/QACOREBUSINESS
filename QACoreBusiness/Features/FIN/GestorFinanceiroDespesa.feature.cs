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
    public partial class GestorFinanceiroDespesaFeature : Xunit.IClassFixture<GestorFinanceiroDespesaFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "GestorFinanceiroDespesa.feature"
#line hidden
        
        public GestorFinanceiroDespesaFeature(GestorFinanceiroDespesaFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GestorFinanceiroDespesa", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [Xunit.FactAttribute(DisplayName="Baixar Parcela Dinheiro")]
        [Xunit.TraitAttribute("FeatureTitle", "GestorFinanceiroDespesa")]
        [Xunit.TraitAttribute("Description", "Baixar Parcela Dinheiro")]
        [Xunit.TraitAttribute("Category", "despesa_baixar_parcela_dinheiro")]
        public virtual void BaixarParcelaDinheiro()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Baixar Parcela Dinheiro", null, new string[] {
                        "despesa_baixar_parcela_dinheiro"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 10
 testRunner.Given("seja clicado no botao da Header Lançar Pagamento Antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.And("seja redirecionado para index de Pagto Antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("selecionar a pessoa do contrato {\'Laura La Caronita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("selecionar o plano de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("selecionar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("selecionar o meio de pagamento {\'Dinheiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("informar no input o Valor a pagar {200.0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("clicar no botao Salvar pagto antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("o sistema redireciona para index de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("um contrato de pagamento Num Doc {\'PGA\'} deve ser criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("com status {\'Quitado\'} na primeira linha da tabela de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("um contrato de credito Num Doc {\'CREPGA\'} deve ser criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("com status {\'Aberto\'} na segunda linha da tabela contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("o usuário deve acessar o contexto by url {\'/FIN/GestorFinanceiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("que clica na aba Contas a Pagar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("clique para pesquisar despesas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("clique no botao limpar filtros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("clique no botao Filtrar Despesas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("o numero de parcelas despesas filtradas seja maior que {0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("selecione a primeira parcela da lista", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("clique no botao Movimentar Parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("o valor a ser movimentado seja maior que Zero", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("clique no icone para Baixar Parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("seja redirecionado para /FIN/Contrato/ListarParcelasBaixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("clique no collapse para exibir meio pagamento parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("selecione o meio de pagamento {\'Dinheiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.When("clicar no botao Efetuar Baixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("o sistema redireciona para imprimir movimentacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.And("feche o navegador quando terminar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Baixar Parcela Abatimento")]
        [Xunit.TraitAttribute("FeatureTitle", "GestorFinanceiroDespesa")]
        [Xunit.TraitAttribute("Description", "Baixar Parcela Abatimento")]
        [Xunit.TraitAttribute("Category", "despesa_baixar_parcela_abatimento")]
        public virtual void BaixarParcelaAbatimento()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Baixar Parcela Abatimento", null, new string[] {
                        "despesa_baixar_parcela_abatimento"});
#line 42
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 43
 testRunner.Given("seja clicado no botao da Header Lançar Pagamento Antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
 testRunner.And("seja redirecionado para index de Pagto Antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("selecionar a pessoa do contrato {\'Laura La Caronita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("selecionar o plano de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("selecionar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("selecionar o meio de pagamento {\'Dinheiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("informar no input o Valor a pagar {300.0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("clicar no botao Salvar pagto antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("o sistema redireciona para index de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("um contrato de pagamento Num Doc {\'PGA\'} deve ser criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("com status {\'Quitado\'} na primeira linha da tabela de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("um contrato de credito Num Doc {\'CREPGA\'} deve ser criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.And("com status {\'Aberto\'} na segunda linha da tabela contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.And("o usuário deve acessar o contexto by url {\'/FIN/GestorFinanceiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("que clica na aba Contas a Pagar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("clique para pesquisar despesas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("clique no botao limpar filtros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("clique no botao Filtrar Despesas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("o numero de parcelas despesas filtradas seja maior que {0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("selecione a primeira parcela da lista", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("clique no botao Movimentar Parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And("o valor a ser movimentado seja maior que Zero", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.And("clique no icone para Baixar Parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.And("seja redirecionado para /FIN/Contrato/ListarParcelasBaixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.And("clique no collapse para exibir meio pagamento parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("selecione o meio de pagamento {\'Abatimento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("ache no select a parcela de crédito/abatimento que seja maior que o valor a quita" +
                    "r", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("selecione a parcela de crédito/abatimento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.When("clicar no botao Efetuar Baixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.Then("o sistema redireciona para imprimir movimentacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
 testRunner.And("feche o navegador quando terminar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Baixar Parcela Op. Bancária")]
        [Xunit.TraitAttribute("FeatureTitle", "GestorFinanceiroDespesa")]
        [Xunit.TraitAttribute("Description", "Baixar Parcela Op. Bancária")]
        [Xunit.TraitAttribute("Category", "despesa_baixar_parcela_operacao_bancaria")]
        public virtual void BaixarParcelaOp_Bancaria()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Baixar Parcela Op. Bancária", null, new string[] {
                        "despesa_baixar_parcela_operacao_bancaria"});
#line 77
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 78
 testRunner.Given("seja clicado no botao da Header Lançar Pagamento Antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 79
 testRunner.And("seja redirecionado para index de Pagto Antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("selecionar a pessoa do contrato {\'Laura La Caronita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("selecionar o plano de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("selecionar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("selecionar o meio de pagamento {\'Dinheiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.And("informar no input o Valor a pagar {400.0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.And("clicar no botao Salvar pagto antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.And("o sistema redireciona para index de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.And("um contrato de pagamento Num Doc {\'PGA\'} deve ser criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("com status {\'Quitado\'} na primeira linha da tabela de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("um contrato de credito Num Doc {\'CREPGA\'} deve ser criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("com status {\'Aberto\'} na segunda linha da tabela contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.And("o usuário deve acessar o contexto by url {\'/FIN/GestorFinanceiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("que clica na aba Contas a Pagar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("clique para pesquisar despesas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("clique no botao limpar filtros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.And("clique no botao Filtrar Despesas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.And("o numero de parcelas despesas filtradas seja maior que {0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.And("selecione a primeira parcela da lista", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.And("clique no botao Movimentar Parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.And("o valor a ser movimentado seja maior que Zero", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.And("clique no icone para Baixar Parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.And("seja redirecionado para /FIN/Contrato/ListarParcelasBaixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.And("clique no collapse para exibir meio pagamento parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.And("selecione o meio de pagamento {\'Operação Bancária\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.And("selecione a conta bancaria de pagamento {\'BB Fake\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.When("clicar no botao Efetuar Baixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 106
 testRunner.Then("o sistema redireciona para imprimir movimentacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 107
 testRunner.And("feche o navegador quando terminar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Baixar Multiplas Parcelas Dinheiro + Transferência")]
        [Xunit.TraitAttribute("FeatureTitle", "GestorFinanceiroDespesa")]
        [Xunit.TraitAttribute("Description", "Baixar Multiplas Parcelas Dinheiro + Transferência")]
        [Xunit.TraitAttribute("Category", "despesa_baixar_multiplas_parcela_dinheiro_transferencia")]
        public virtual void BaixarMultiplasParcelasDinheiroTransferencia()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Baixar Multiplas Parcelas Dinheiro + Transferência", null, new string[] {
                        "despesa_baixar_multiplas_parcela_dinheiro_transferencia"});
#line 112
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 113
 testRunner.Given("seja clicado no botao da Header Lançar Pagamento Antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 114
 testRunner.And("seja redirecionado para index de Pagto Antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.And("selecionar a pessoa do contrato {\'Laura La Caronita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.And("selecionar o plano de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.And("selecionar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.And("selecionar o meio de pagamento {\'Dinheiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.And("informar no input o Valor a pagar {500.0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.And("clicar no botao Salvar pagto antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.And("o sistema redireciona para index de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.And("um contrato de pagamento Num Doc {\'PGA\'} deve ser criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.And("com status {\'Quitado\'} na primeira linha da tabela de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.And("um contrato de credito Num Doc {\'CREPGA\'} deve ser criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.And("com status {\'Aberto\'} na segunda linha da tabela contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.And("o usuário deve acessar o contexto by url {\'/FIN/GestorFinanceiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.And("que clica na aba Contas a Pagar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.And("clique para pesquisar despesas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.And("clique no botao limpar filtros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
 testRunner.And("clique no botao Filtrar Despesas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
 testRunner.And("o numero de parcelas despesas filtradas seja maior que {0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.And("selecione a primeira parcela da lista", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.And("clique no botao Movimentar Parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.And("o valor a ser movimentado seja maior que Zero", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.And("clique no icone para Baixar Parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.And("seja redirecionado para /FIN/Contrato/ListarParcelasBaixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
 testRunner.When("clique no botao Adicionar Multiplos Meios de Pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 138
 testRunner.And("selecione o primeiro meio de pagamento {\'Dinheiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.And("ratear o valor exibido no input por {2}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
 testRunner.And("informar o planos de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
 testRunner.And("informar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
 testRunner.And("informar no input o historico {\'Multiplos meios de pagamento  - ÉusGuri\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
 testRunner.And("clicar no botao Adicionar para multiplos meios de pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
 testRunner.And("seja validado o valor do rateio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
 testRunner.And("clique no botao Adicionar Multiplos Meios de Pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
 testRunner.And("selecione o segundo meio de pagamento {\'Transferência\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 147
 testRunner.And("valide que o resto do rateio seja inserido no input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
 testRunner.And("selecione a conta bancaria do segundo meio de pagamento {\'BB Fake\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
 testRunner.And("informar o planos de contas do segundo meio {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
 testRunner.And("informar o centro de custo do segundo meio {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 151
 testRunner.And("informar no input o historico do segundo meio {\'Multiplos meios de pagamento  - É" +
                    "usGuriDeNovoPae\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
 testRunner.And("clicar no botao Adicionar para segundo multiplos meios de pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
 testRunner.And("seja validado o resto do rateio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
 testRunner.And("clicar no botao Efetuar Baixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
 testRunner.Then("o sistema redireciona para imprimir movimentacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 156
 testRunner.And("feche o navegador quando terminar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Baixar Multiplas Parcelas Dinheiro + Abatimento")]
        [Xunit.TraitAttribute("FeatureTitle", "GestorFinanceiroDespesa")]
        [Xunit.TraitAttribute("Description", "Baixar Multiplas Parcelas Dinheiro + Abatimento")]
        [Xunit.TraitAttribute("Category", "despesa_baixar_multiplas_parcela_dinheiro_abatimento")]
        public virtual void BaixarMultiplasParcelasDinheiroAbatimento()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Baixar Multiplas Parcelas Dinheiro + Abatimento", null, new string[] {
                        "despesa_baixar_multiplas_parcela_dinheiro_abatimento"});
#line 161
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 162
 testRunner.Given("seja clicado no botao da Header Lançar Pagamento Antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 163
 testRunner.And("seja redirecionado para index de Pagto Antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 164
 testRunner.And("selecionar a pessoa do contrato {\'Laura La Caronita\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 165
 testRunner.And("selecionar o plano de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 166
 testRunner.And("selecionar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 167
 testRunner.And("selecionar o meio de pagamento {\'Dinheiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 168
 testRunner.And("informar no input o Valor a pagar {550.0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 169
 testRunner.And("clicar no botao Salvar pagto antecipado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 170
 testRunner.And("o sistema redireciona para index de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 171
 testRunner.And("um contrato de pagamento Num Doc {\'PGA\'} deve ser criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 172
 testRunner.And("com status {\'Quitado\'} na primeira linha da tabela de contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 173
 testRunner.And("um contrato de credito Num Doc {\'CREPGA\'} deve ser criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 174
 testRunner.And("com status {\'Aberto\'} na segunda linha da tabela contratos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 175
 testRunner.And("o usuário deve acessar o contexto by url {\'/FIN/GestorFinanceiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 176
 testRunner.And("que clica na aba Contas a Pagar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 177
 testRunner.And("clique para pesquisar despesas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 178
 testRunner.And("clique no botao limpar filtros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 179
 testRunner.And("clique no botao Filtrar Despesas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 180
 testRunner.And("o numero de parcelas despesas filtradas seja maior que {0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 181
 testRunner.And("selecione a primeira parcela da lista", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 182
 testRunner.And("clique no botao Movimentar Parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 183
 testRunner.And("o valor a ser movimentado seja maior que Zero", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 184
 testRunner.And("clique no icone para Baixar Parcela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 185
 testRunner.And("seja redirecionado para /FIN/Contrato/ListarParcelasBaixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 186
 testRunner.When("clique no botao Adicionar Multiplos Meios de Pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 187
 testRunner.And("selecione o primeiro meio de pagamento {\'Dinheiro\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 188
 testRunner.And("ratear o valor exibido no input por {2}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 189
 testRunner.And("informar o planos de contas {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 190
 testRunner.And("informar o centro de custo {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 191
 testRunner.And("informar no input o historico {\'Multiplos meios de pagamento  - ÉusGuri\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 192
 testRunner.And("clicar no botao Adicionar para multiplos meios de pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 193
 testRunner.And("seja validado o valor do rateio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 194
 testRunner.And("clique no botao Adicionar Multiplos Meios de Pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 195
 testRunner.And("selecione o segundo meio de pagamento {\'Abatimento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 196
 testRunner.And("valide que o resto do rateio seja inserido no input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 197
 testRunner.And("informar o planos de contas do segundo meio {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 198
 testRunner.And("informar o centro de custo do segundo meio {\'Contratos Financeiros\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 199
 testRunner.And("informar no input o historico do segundo meio {\'Multiplos meios de pagamento  - É" +
                    "usGuriDeNovoPae\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 200
 testRunner.And("clicar no botao Adicionar para segundo multiplos meios de pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 201
 testRunner.And("seja validado o resto do rateio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 202
 testRunner.And("clicar no botao Vincular Parcelas de Crédito/Abatimento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 203
 testRunner.And("memorizar o valor a quitar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 204
 testRunner.And("validar que os créditos disponíveis são maiores que {0}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 205
 testRunner.And("validar que o valor total dos creditos disponiveis sao maiores que o valor a quit" +
                    "ar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 206
 testRunner.And("selecionar os creditos até o valor total selecionado ser igual ou maior que o val" +
                    "or a quitar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 207
 testRunner.And("clicar no botao Vincular creditos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 208
 testRunner.And("clicar no botao Efetuar Baixa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 209
 testRunner.Then("o sistema redireciona para imprimir movimentacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 210
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
                GestorFinanceiroDespesaFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                GestorFinanceiroDespesaFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
