Feature: GestorFinanceiro

Background: Logar e acessar gestor financeiro
Given que eu esteja logado no sistema
And acesse a index gestor financeiro


@baixar_parcela_dinheiro
Scenario: Baixar Parcela
	Given que clica na aba Contas a Receber
	And clique na pesquisa 
	And clique para limpar filtros
	And clique no botao Filtrar Receitas
	And o numero de parcelas filtradas seja maior que zero
	And selecione a primeira parcela listada
	And clique no botao movimentar parcela
	And o valor a ser movimentado seja maior que zero
	And clique no icone Baixar Parcela
	And seja redirecionado para /FIN/Contrato/ListarParcelasBaixa
	And clique no collapse para exibir meio pagamento parcela
	And selecione o meio de pagamento {'Dinheiro'}
	When clicar no botao Efetuar Baixa
	Then o sistema redireciona para imprimir movimentacao

