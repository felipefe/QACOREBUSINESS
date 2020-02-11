Feature: ContratoFinanceiro

Background: Ter um pedido criado
Given que eu esteja logado no sistema
And acesse a index de contratos


@create_contrato
Scenario: Criar contrato FIN sem parcelas
	Given que seja clicado no botao criar contrato
	And seja redirecionado para /Contrato/Create
	When inserir no input numero do documento 
	And selecionar a pessoa do contrato {'Laura La Caronita'}
	And selecionar a empresa do contrato {'Deltacon Informática'}
	And selecionar o plano de contas {'Comercial - vendas'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And informar no textArea um historico  {'Contrato referente venda de testes autorimatizados'}
	And selecionar a conta prevista pagamento {'BB Fake'}
	And clicar no botao salvar contrato
	Then o sistema redireciona para index de contratos
	And o status do contrato deve ser {'Incompleto'}
	And a coluna referente ao valor original {'0.00'}


@create_contrato_com_parcelas_auto
Scenario: Criar contrato FIN + parcelas AUTO
	Given que seja clicado no botao criar contrato
	And seja redirecionado para /Contrato/Create
	When inserir no input numero do documento 
	And selecionar a pessoa do contrato {'Laura La Caronita'}
	And selecionar a empresa do contrato {'Deltacon Informática'}
	And selecionar o plano de contas {'Comercial - vendas'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And informar no textArea um historico  {'Contrato referente venda de testes autorimatizados'}
	And selecionar a conta prevista pagamento {'BB Fake'}
	And clicar no botao adicionar parcelas automaticamente 
	And inserir no input o valor original da parcela R${600.0}
	And inserir no input a quantidade de {4} parcelas
	And inserir no input o intervalo de {15} dias entre parcelas
	And inserir o vencimento da primeira parcela para {15} dias futuros
	And clicar no botao salvar parcela
	Then as parcelas devem ser criadas conforme a qntdade informada
	And clicar no botao salvar contrato
	And o sistema redireciona para index de contratos
	And o status do contrato deve ser {'Aberto'}
	And a coluna referente ao valor original {'600.00'}


@create_contrato_com_parcelas_manual
Scenario: Criar contrato FIN + parcelas MANUAL
	Given que seja clicado no botao criar contrato
	And seja redirecionado para /Contrato/Create
	When inserir no input numero do documento 
	And selecionar a pessoa do contrato {'Laura La Caronita'}
	And selecionar a empresa do contrato {'Deltacon Informática'}
	And selecionar o plano de contas {'Comercial - vendas'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And informar no textArea um historico  {'Contrato referente venda de testes autorimatizados'}
	And selecionar a conta prevista pagamento {'BB Fake'}
	And clicar no botao adicionar parcelas manualmente 
	And inserir no input Valor Original R${420.0}
	And inserir no input Data de Vencimento {15} dias futuros
	And clicar no botao Adicionar parcela
	Then a parcela deve ser criadas conforme valor informado
	And clicar no botao salvar contrato
	And o sistema redireciona para index de contratos
	And o status do contrato deve ser {'Aberto'}
	And a coluna referente ao valor original {'420.0'}


@excluir_contrato_sucesso
Scenario: Excluir contrato Incompleto
Given que o status do contrato seja {'Incompleto'}
And memorize o N doc do contrato a ser excluido
When clicar nas actions Excluir / Cancelar 
And confirmar clicando no botao Excluir da modal
Then o contrato deve ser excluido

@excluir_contrato_restricao
Scenario: Excluir contrato Aberto
Given que o status do contrato seja {'Aberto'}
And memorize o N doc do contrato a ser excluido
When clicar nas actions Excluir / Cancelar 
And confirmar clicando no botao Excluir da modal
Then o contrato nao deve ser excluido motivo {'Não foi possível apagar o contrato!'}



#{'Incompleto'} contrato sem parcela
#para add em contrato que ja possua parcelas alterar para {'Aberto'}
@add_parcela_contrato_criado
Scenario: Adicionar parcela em contrato criado
Given que o status do contrato seja {'Incompleto'}
And clique nas actions Parcelas
And seja redirecionado para a index de Contrato/Parcelas
When clicar no botao Nova Parcela
And inserir no input Valor Original R${85.0}
And inserir no input Data de Vencimento com horas para {15} dias futuros
And clicar no botao salvar parcela
Then a parcela deve ser criadas validando valor e vencimento
