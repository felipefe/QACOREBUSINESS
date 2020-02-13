Feature: GestorFinanceiro

Background: Logar e acessar gestor financeiro
Given que eu esteja logado no sistema
And acesse a index gestor financeiro


@baixar_parcela_dinheiro
Scenario: Baixar Parcela Receita Dinheiro
	Given que clica na aba Contas a Receber
	And clique na pesquisa 
	And clique para limpar filtros
	And clique no botao Filtrar Receitas
	And o numero de parcelas filtradas seja maior que {0}
	And selecione a primeira parcela listada
	And clique no botao movimentar parcela
	And o valor a ser movimentado seja maior que zero
	And clique no icone Baixar Parcela
	And seja redirecionado para /FIN/Contrato/ListarParcelasBaixa
	And clique no collapse para exibir meio pagamento parcela
	And selecione o meio de pagamento {'Dinheiro'}
	When clicar no botao Efetuar Baixa
	Then o sistema redireciona para imprimir movimentacao


@baixar_parcela_abatimento
Scenario: Baixar Parcela Receita Abatimento
	Given que clica na aba Contas a Receber
	And clique na pesquisa 
	And clique para limpar filtros
	And clique no botao Filtrar Receitas
	And o numero de parcelas filtradas seja maior que {0}
	And selecione a primeira parcela listada
	And clique no botao movimentar parcela
	And o valor a ser movimentado seja maior que zero
	And clique no icone Baixar Parcela
	And seja redirecionado para /FIN/Contrato/ListarParcelasBaixa
	And clique no collapse para exibir meio pagamento parcela
	And selecione o meio de pagamento {'Abatimento'}
	And ache no select a parcela de crédito/abatimento que seja maior que o valor a quitar
	And selecione a parcela de crédito/abatimento
	When clicar no botao Efetuar Baixa
	Then o sistema redireciona para imprimir movimentacao


@baixar_multiplas_parcela_dinheiro
Scenario: Baixar Multiplas Parcelas Receita Dinheiro
	Given que clica na aba Contas a Receber
	And clique na pesquisa 
	And clique para limpar filtros
	And clique no botao Filtrar Receitas
	And o numero de parcelas filtradas seja maior que {2}
	And selecione a primeira parcela listada
	And selecione a segunda parcela listada
	And clique no botao movimentar parcela
	And o valor a ser movimentado seja maior que zero
	And clique no icone Baixar Parcela
	And seja redirecionado para /FIN/Contrato/ListarParcelasBaixa
	And clique no botao Adicionar Multiplos Meios de Pagamento
	When selecione o meio de pagamento {'Dinheiro'}
	And informar o planos de contas {'Contratos Financeiros'}
	And informar o centro de custo {'Contratos Financeiros'}
	And informar no input o historico {'Multiplos meios de pagamento  - ÉusGuri'}
	And clicar no botao Adicionar para multiplos meios de pagamento
	And clicar no botao Efetuar Baixa
	Then o sistema redireciona para imprimir movimentacao


@baixar_multiplas_parcela_abatimento
Scenario: Baixar Multiplas Parcelas Receita Abatimento
	Given que clica na aba Contas a Receber
	And clique na pesquisa 
	And clique para limpar filtros
	And clique no botao Filtrar Receitas
	And o numero de parcelas filtradas seja maior que {1}
	And selecione a primeira parcela listada
	And selecione a segunda parcela listada
	And clique no botao movimentar parcela
	And o valor a ser movimentado seja maior que zero
	And clique no icone Baixar Parcela
	And seja redirecionado para /FIN/Contrato/ListarParcelasBaixa
	And clique no botao Adicionar Multiplos Meios de Pagamento
	When selecione o meio de pagamento {'Abatimento'}
	And informar o planos de contas {'Contratos Financeiros'}
	And informar o centro de custo {'Contratos Financeiros'}
	And informar no input o historico {'Multiplos meios de pagamento  - ÉusGuri'}
	And clicar no botao Adicionar para multiplos meios de pagamento
	And clicar no botao Vincular Parcelas de Crédito/Abatimento
	And memorizar o valor a quitar
	And validar que os créditos disponíveis são maiores que {0}
	And validar que o valor total dos creditos disponiveis sao maiores que o valor a quitar
	And selecionar os creditos até o valor total selecionado ser igual ou maior que o valor a quitar
	And clicar no botao Vincular creditos 
	And clicar no botao Efetuar Baixa
	Then o sistema redireciona para imprimir movimentacao
