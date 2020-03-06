Feature: ContratoFinanceiro

Background: logar e acessar index contratos
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Contratos'}

@create_contrato_com_parcelas_auto
Scenario: Criar contrato FIN + parcelas AUTO
	Given que seja clicado no botao criar contrato
	And seja redirecionado para /Contrato/Create
	When inserir no input numero do documento 
	And selecionar a pessoa do contrato {'Laura La Caronita'}
	And selecionar a empresa do contrato {'Deltacon Informática'}
	And selecionar o plano de contas {'Contratos Financeiros'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And informar no textArea um historico  {'Contrato referente venda de testes autorimatizados'}
	And selecionar a conta prevista pagamento {'BB Fake'}
	And clicar no botao adicionar parcelas automaticamente 
	And inserir no input o valor a pagar(futuro) da parcela R${931.5}
	And inserir no input a quantidade de {3} parcelas
	And inserir no input o intervalo de {15} dias entre parcelas
	And inserir o vencimento da primeira parcela para {15} dias futuros
	And clicar no botao salvar parcela
	Then as parcelas devem ser criadas conforme a qntdade informada
	And clicar no botao salvar/criar contrato
	And o sistema redireciona para index de contratos
	And o status do contrato deve ser {'Aberto'}
	And a coluna referente ao valor original {'931.5'}
	And feche o navegador quando terminar


@create_contrato_com_parcelas_manual
Scenario: Criar contrato FIN + parcelas MANUAL
	Given que seja clicado no botao criar contrato
	And seja redirecionado para /Contrato/Create
	When inserir no input numero do documento 
	And selecionar a pessoa do contrato {'Laura La Caronita'}
	And selecionar a empresa do contrato {'Deltacon Informática'}
	And selecionar o plano de contas {'Contratos Financeiros'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And informar no textArea um historico  {'Contrato referente venda de testes autorimatizados'}
	And selecionar a conta prevista pagamento {'BB Fake'}
	And clicar no botao adicionar parcelas manualmente 
	And inserir no input Valor Original R${420.0}
	And inserir no input Data de Vencimento {15} dias futuros
	And clicar no botao Adicionar parcela
	Then a parcela deve ser criadas conforme valor informado
	And clicar no botao salvar/criar contrato
	And o sistema redireciona para index de contratos
	And o status do contrato deve ser {'Aberto'}
	And a coluna referente ao valor original {'420.0'}
	And feche o navegador quando terminar


@excluir_contrato_restricao
Scenario: Excluir contrato Aberto
	Given que seja clicado no botao criar contrato
	And seja redirecionado para /Contrato/Create
	When inserir no input numero do documento 
	And selecionar a pessoa do contrato {'Laura La Caronita'}
	And selecionar a empresa do contrato {'Deltacon Informática'}
	And selecionar o plano de contas {'Contratos Financeiros'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And informar no textArea um historico  {'Contrato referente venda de testes autorimatizados'}
	And selecionar a conta prevista pagamento {'BB Fake'}
	And clicar no botao adicionar parcelas manualmente 
	And inserir no input Valor Original R${420.0}
	And inserir no input Data de Vencimento {15} dias futuros
	And clicar no botao Adicionar parcela
	And a parcela deve ser criadas conforme valor informado
	And clicar no botao salvar/criar contrato
	And o sistema redireciona para index de contratos
	And o status do contrato deve ser {'Aberto'}
	And a coluna referente ao valor original {'420.0'}
	And memorize o N doc do contrato a ser excluido
	And clicar nas actions Excluir / Cancelar 
	And confirmar clicando no botao Excluir da modal
	Then o contrato deve ser excluido
	And feche o navegador quando terminar


@lancar_pagamento_antecipado
Scenario: Lançar Pagto Antecipado 
Given seja clicado no botao da Header Lançar Pagamento Antecipado
And seja redirecionado para index de Pagto Antecipado
When selecionar a pessoa do contrato {'Laura La Caronita'}
And selecionar o plano de contas {'Contratos Financeiros'}
And selecionar o centro de custo {'Contratos Financeiros'}
And selecionar o meio de pagamento {'Dinheiro'}
And informar no input o Valor a pagar {600.0}
And clicar no botao Salvar pagto antecipado
Then o sistema redireciona para index de contratos
And um contrato de pagamento Num Doc {'PGA'} deve ser criado
And com status {'Quitado'} na primeira linha da tabela de contratos
And um contrato de credito Num Doc {'CREPGA'} deve ser criado
And com status {'Aberto'} na segunda linha da tabela contratos
And feche o navegador quando terminar


#IMPLEMENTAR ESSE CENARIO QUANDO FOR MELHORADO ESTA ACAO NO SISTEMA
#ATUALMENTE DESPESA E RECEITA NAO EXCLUEM MAS PROCESSA EXCLUSAO
#SERA INCLUIDO UMA MENSAGEM SOBRE NAO EXCLUSAO
#IMPLEMENTEI AQUI COM CONTRATO ANTECIPADO MAS DEVE SER RECEITA OU DESPESA

#@excluir_contrato_quitado
#Scenario: Restrição ao excluir contrato Quitado
#Given seja clicado no botao da Header Lançar Pagamento Antecipado
#And seja redirecionado para index de Pagto Antecipado
#When selecionar a pessoa do contrato {'Laura La Caronita'}
#And selecionar o plano de contas {'Contratos Financeiros'}
#And selecionar o centro de custo {'Contratos Financeiros'}
#And selecionar o meio de pagamento {'Dinheiro'}
#And informar no input o Valor a pagar {600.0}
#And clicar no botao Salvar pagto antecipado
#And o sistema redireciona para index de contratos
#And um contrato de pagamento Num Doc {'PGA'} deve ser criado
#And com status {'Quitado'} na primeira linha da tabela de contratos
#And um contrato de credito Num Doc {'CREPGA'} deve ser criado
#And com status {'Aberto'} na segunda linha da tabela contratos
#And memorize o N doc do contrato a ser excluido
#Then clicar nas actions Excluir / Cancelar 
#And confirmar clicando no botao Excluir da modal
#And o contrato nao deve ser excluido motivo {''}
#And feche o navegador quando terminar


@lancar_despesa_contrato
Scenario: Lançar Despesa
	Given que seja clicado no botao Lançar Despesa
	And seja redirecionado para /FIN/DespesaReceita/Create?tipoPC=D
	When inserir no input numero do documento 
	And selecionar a pessoa do contrato {'Laura La Caronita'}
	And selecionar o plano de contas {'Contratos - Despesa'}
	And inserir no input Valor Original R${70.0}
	And inserir no input Valor Pago R${70.0}
	And selecionar o meio de pagamento {'Dinheiro'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And informar no textArea um historico  {'Contrato despesa'}
	And clicar no botao salvar contrato
	Then o sistema redireciona para index de contratos
	And o status do contrato deve ser {'Quitado'}
	And a coluna referente ao valor original {'70.0'}
	And feche o navegador quando terminar


@lancar_receita_contrato
Scenario: Lançar Receita
	Given que seja clicado no botao Lançar Receita
	And seja redirecionado para /FIN/DespesaReceita/Create?tipoPC=C
	When inserir no input numero do documento 
	And selecionar a pessoa do contrato {'Laura La Caronita'}
	And selecionar o plano de contas {'Contratos Financeiros'}
	And inserir no input Valor Original R${420.0}
	And inserir no input Valor Pago R${420.0}
	And selecionar o meio de pagamento {'Dinheiro'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And informar no textArea um historico  {'Contrato receita'}
	And clicar no botao salvar contrato
	Then o sistema redireciona para index de contratos
	And o status do contrato deve ser {'Quitado'}
	And a coluna referente ao valor original {'420.0'}
	And feche o navegador quando terminar



	
#@create_contrato
#Scenario: Criar contrato FIN sem parcelas
#	Given que seja clicado no botao criar contrato
#	And seja redirecionado para /Contrato/Create
#	When inserir no input numero do documento 
#	And selecionar a pessoa do contrato {'Laura La Caronita'}
#	And selecionar a empresa do contrato {'Deltacon Informática'}
#	And selecionar o plano de contas {'Contratos Financeiros'}
#	And selecionar o centro de custo {'Contratos Financeiros'}
#	And informar no textArea um historico  {'Contrato referente venda de testes autorimatizados'}
#	And selecionar a conta prevista pagamento {'BB Fake'}
#	And clicar no botao salvar/criar contrato
#	And o sistema redireciona para index de contratos
#	And o status do contrato deve ser {'Incompleto'}
#	And a coluna referente ao valor original {'0.00'}
#	And clique nas actions Parcelas
#	And seja redirecionado para a index de Contrato/Parcelas
#	And clicar no botao Nova Parcela
#	And inserir no input Valor Original R${85.0}
#	And inserir no input Data de Vencimento com horas para {15} dias futuros
#	And clicar no botao salvar parcela
#	Then a parcela deve ser criadas validando valor e vencimento


#@excluir_contrato_sucesso
#Scenario: Excluir contrato Incompleto
#Given que o status do contrato seja {'Incompleto'}
#And memorize o N doc do contrato a ser excluido
#When clicar nas actions Excluir / Cancelar 
#And confirmar clicando no botao Excluir da modal
#Then o contrato deve ser excluido