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
    public partial class RecepcaoMercadoriaNovoViaNFeFeature : Xunit.IClassFixture<RecepcaoMercadoriaNovoViaNFeFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "RecepcaoMercadoriaNovoViaNFe.feature"
#line hidden
        
        public RecepcaoMercadoriaNovoViaNFeFeature(RecepcaoMercadoriaNovoViaNFeFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "RecepcaoMercadoriaNovoViaNFe", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
testRunner.And("clicar para acessar o contexto {\'Recepção de Mercadorias e Serviços\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Importar XML Recepção")]
        [Xunit.TraitAttribute("FeatureTitle", "RecepcaoMercadoriaNovoViaNFe")]
        [Xunit.TraitAttribute("Description", "Importar XML Recepção")]
        [Xunit.TraitAttribute("Category", "recepcao_mercadoria_novo_via_nfe")]
        public virtual void ImportarXMLRecepcao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Importar XML Recepção", null, new string[] {
                        "recepcao_mercadoria_novo_via_nfe"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 10
 testRunner.Given("que eu clique no botao da header Novo Via NFe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.And("selecione o arquivo xml da recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("informe a operacao fiscal {\'Recepção de Mercadoria\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.When("clicar no botao Iniciar importacao da NFe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("o status da recepcao deve ser {\'Lançamento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.And("clicar no botao da action para Excluir recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("clicar no botao Excluir da modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("o sistema redirecionada para index de recepçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("feche o navegador quando terminar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Escriturar itens da recepcao")]
        [Xunit.TraitAttribute("FeatureTitle", "RecepcaoMercadoriaNovoViaNFe")]
        [Xunit.TraitAttribute("Description", "Escriturar itens da recepcao")]
        [Xunit.TraitAttribute("Category", "escriturar_itens_xml")]
        public virtual void EscriturarItensDaRecepcao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Escriturar itens da recepcao", null, new string[] {
                        "escriturar_itens_xml"});
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 24
 testRunner.Given("que eu clique no botao da header Novo Via NFe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
 testRunner.And("selecione o arquivo xml da recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("informe a operacao fiscal {\'Recepção de Mercadoria\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("clicar no botao Iniciar importacao da NFe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("que tenha uma recepcao no status {\'Lançamento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("seja clicado no botao Mercadoria nas actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("seja redirecionado para tela de Mercadorias da recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("tenha na coluna Escriturado do item o valor {\'Não\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.When("clicar no botao da header Escriturar todos os itens automaticamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.And("seja redirecionado para index de escriturar lote fiscal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("clicar na aba Configuração", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("selecione o CFOP {1102} Compra para Comercialização", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("selecione o protocolo ICMS de destino/empresa {\'ICMS_SC_01\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("selecione os impostos federais {\'Impostos Federais - Compra para comercialização\'" +
                    "}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("clicar no botao Calcular", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.Then("o status do item deve mudar para {\'Escriturado\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.And("quando clicar no botao Prosseguir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("o sistema redirecionada para index de recepçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("clicar no botao da action para Excluir recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("clicar no botao Excluir da modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("o sistema redirecionada para index de recepçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("feche o navegador quando terminar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Finalizar lancamento de itens escriturados")]
        [Xunit.TraitAttribute("FeatureTitle", "RecepcaoMercadoriaNovoViaNFe")]
        [Xunit.TraitAttribute("Description", "Finalizar lancamento de itens escriturados")]
        [Xunit.TraitAttribute("Category", "finalizar_lancamento_itens_escriturados")]
        public virtual void FinalizarLancamentoDeItensEscriturados()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Finalizar lancamento de itens escriturados", null, new string[] {
                        "finalizar_lancamento_itens_escriturados"});
#line 49
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 50
 testRunner.Given("que eu clique no botao da header Novo Via NFe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
 testRunner.And("selecione o arquivo xml da recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("informe a operacao fiscal {\'Recepção de Mercadoria\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("clicar no botao Iniciar importacao da NFe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("que tenha uma recepcao no status {\'Lançamento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.And("seja clicado no botao Mercadoria nas actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.And("seja redirecionado para tela de Mercadorias da recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("tenha na coluna Escriturado do item o valor {\'Não\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.When("clicar no botao da header Escriturar todos os itens automaticamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.And("seja redirecionado para index de escriturar lote fiscal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("clicar na aba Configuração", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("selecione o CFOP {1102} Compra para Comercialização", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("selecione o protocolo ICMS de destino/empresa {\'ICMS_SC_01\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("selecione os impostos federais {\'Impostos Federais - Compra para comercialização\'" +
                    "}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And("clicar no botao Calcular", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.Then("o status do item deve mudar para {\'Escriturado\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
 testRunner.And("quando clicar no botao Prosseguir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.And("o sistema redirecionada para index de recepçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("o status da recepcao deve ser {\'Lançamento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("seja clicado no botao Mercadoria nas actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("seja redirecionado para tela de Mercadorias da recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("tenha na coluna Escriturado do item o valor {\'Sim\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And("clicar no botao Finalizar Lançamento de Itens", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("marcar Eu concluí o lançamento de todos os itens", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And("clicar no botao Confirmar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("o sistema redirecionada para index de recepçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And("o status da recepcao deve ser {\'Conferência Física\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And("clique nas actions para Alterar Situação", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("selecione a situaçao {\'Lançamento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("clique no botao Salvar situacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("o sistema redirecionada para index de recepçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("clicar no botao da action para Excluir recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("clicar no botao Excluir da modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("o sistema redirecionada para index de recepçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.And("feche o navegador quando terminar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Finalizar recepcao de mercadoria")]
        [Xunit.TraitAttribute("FeatureTitle", "RecepcaoMercadoriaNovoViaNFe")]
        [Xunit.TraitAttribute("Description", "Finalizar recepcao de mercadoria")]
        [Xunit.TraitAttribute("Category", "finalizar_recepcao_mercadoria")]
        public virtual void FinalizarRecepcaoDeMercadoria()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Finalizar recepcao de mercadoria", null, new string[] {
                        "finalizar_recepcao_mercadoria"});
#line 88
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 89
testRunner.Given("que eu clique no botao da header Novo Via NFe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 90
 testRunner.And("selecione o arquivo xml da recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.And("informe a operacao fiscal {\'Recepção de Mercadoria\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("clicar no botao Iniciar importacao da NFe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("que tenha uma recepcao no status {\'Lançamento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("seja clicado no botao Mercadoria nas actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.And("seja redirecionado para tela de Mercadorias da recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.And("tenha na coluna Escriturado do item o valor {\'Não\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.When("clicar no botao da header Escriturar todos os itens automaticamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.And("seja redirecionado para index de escriturar lote fiscal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.And("clicar na aba Configuração", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.And("selecione o CFOP {1102} Compra para Comercialização", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.And("selecione o protocolo ICMS de destino/empresa {\'ICMS_SC_01\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.And("selecione os impostos federais {\'Impostos Federais - Compra para comercialização\'" +
                    "}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.And("clicar no botao Calcular", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.Then("o status do item deve mudar para {\'Escriturado\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 105
 testRunner.And("quando clicar no botao Prosseguir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.And("o sistema redirecionada para index de recepçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.And("o status da recepcao deve ser {\'Lançamento\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.And("seja clicado no botao Mercadoria nas actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.And("seja redirecionado para tela de Mercadorias da recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.And("tenha na coluna Escriturado do item o valor {\'Sim\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.And("clicar no botao Finalizar Lançamento de Itens", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.And("marcar Eu concluí o lançamento de todos os itens", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.And("clicar no botao Confirmar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
 testRunner.And("o sistema redirecionada para index de recepçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.And("o status da recepcao deve ser {\'Conferência Física\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.And("seja clicado no botao Conferencia Fisica de Recebimento nas actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.And("seja redirecionado para tela de WMS Conferencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.And("o codigo sku e qtd. total sejam copidos de suas colunas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.And("seja feita a conferencia desses produtos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.And("clicar no botao Concluir Processo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.And("uma mensagem de conferido com sucesso deve aparecer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.And("clicar no botao Finalizar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.And("ser redirecionado para tela de COM Conferencia Fisica da Recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.And("clicar no botao Concluir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.And("o sistema redirecionada para index de recepçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.And("o status da recepcao deve ser {\'Aguardando Finalização\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.And("seja clicado no botao Finalizar Recebimento nas actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.And("seja redirecionado para tela de Finalizar recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.And("clicar no botao Finalizar Recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
 testRunner.And("o sistema redirecionada para index de recepçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
 testRunner.And("que eu clique no botao da header Gerenciar recepcoes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.And("seja redirecionado para index de gerenciar recepcoes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.And("que tenha uma recepcao no status {\'Finalizado\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.And("memorizo o numero dessa recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.And("clicar no botao da action para Excluir recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.And("clicar no botao Excluir da modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
 testRunner.And("o sistema redirecionada para index de recepçao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.And("acessamos gerenciar recepcoes novamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.And("valido o numero memorizado dessa recepcao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
 testRunner.And("o status da recepcao deve ser {\'Cancelado\'}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
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
                RecepcaoMercadoriaNovoViaNFeFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RecepcaoMercadoriaNovoViaNFeFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
