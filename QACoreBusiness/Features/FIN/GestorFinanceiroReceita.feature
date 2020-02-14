Feature: GestorFinanceiroReceita

Background: Logar e acessar gestor financeiro
Given que eu esteja logado no sistema
And acesse a index gestor financeiro


@receita_baixar_parcela_dinheiro
Scenario: Baixar Parcela Dinheiro
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


@receita_baixar_parcela_abatimento
Scenario: Baixar Parcela Abatimento
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


@receita_baixar_multiplas_parcela_dinheiro_abatimento
Scenario: Baixar Multiplas Parcelas Dinheiro + Abatimento
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
	When clique no botao Adicionar Multiplos Meios de Pagamento
	And selecione o meio de pagamento {'Dinheiro'}
	And ratear o valor exibido no input por {2}
	And informar o planos de contas {'Contratos Financeiros'}
	And informar o centro de custo {'Contratos Financeiros'}
	And informar no input o historico {'Multiplos meios de pagamento  - ÉusGuri'}
	And clicar no botao Adicionar para multiplos meios de pagamento
	And seja validado o valor do rateio
	And clique no botao Adicionar Multiplos Meios de Pagamento
	And selecione o segundo meio de pagamento {'Abatimento'}
	And valide que o resto do rateio seja inserido no input
	And informar o planos de contas do segundo meio {'Contratos Financeiros'}
	And informar o centro de custo do segundo meio {'Contratos Financeiros'}
	And informar no input o historico do segundo meio {'Multiplos meios de pagamento  - ÉusGuriDeNovoPae'}
	And clicar no botao Adicionar para segundo multiplos meios de pagamento
	And seja validado o resto do rateio
	And clicar no botao Vincular Parcelas de Crédito/Abatimento
	And memorizar o valor a quitar
	And validar que os créditos disponíveis são maiores que {0}
	And validar que o valor total dos creditos disponiveis sao maiores que o valor a quitar
	And selecionar os creditos até o valor total selecionado ser igual ou maior que o valor a quitar
	And clicar no botao Vincular creditos 
	And clicar no botao Efetuar Baixa
	Then o sistema redireciona para imprimir movimentacao


@receita_baixar_multiplas_parcela_cheque_abatimento
Scenario: Baixar Multiplas Parcelas Cheque + Abatimento
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
	When clique no botao Adicionar Multiplos Meios de Pagamento
	And selecione o meio de pagamento {'Cheque'}
	And ratear o valor exibido no input por {2}
	And informar o planos de contas {'Contratos Financeiros'}
	And informar o centro de custo {'Contratos Financeiros'}
	And informar no input o historico {'Multiplos meios de pagamento  - ÉusGuri'}
	And clicar no botao Adicionar para multiplos meios de pagamento
	And seja validado o valor do rateio
	And clique no botao Adicionar Multiplos Meios de Pagamento
	And selecione o segundo meio de pagamento {'Abatimento'}
	And valide que o resto do rateio seja inserido no input
	And informar o planos de contas do segundo meio {'Contratos Financeiros'}
	And informar o centro de custo do segundo meio {'Contratos Financeiros'}
	And informar no input o historico do segundo meio {'Multiplos meios de pagamento  - ÉusGuriDeNovoPae'}
	And clicar no botao Adicionar para segundo multiplos meios de pagamento
	And seja validado o resto do rateio
	And clicar no botao Vincular Parcelas de Crédito/Abatimento
	And memorizar o valor a quitar
	And validar que os créditos disponíveis são maiores que {0}
	And validar que o valor total dos creditos disponiveis sao maiores que o valor a quitar
	And selecionar os creditos até o valor total selecionado ser igual ou maior que o valor a quitar
	And clicar no botao Vincular creditos 
	And clicar no botao Efetuar Baixa
	Then o sistema redireciona para imprimir movimentacao

@receita_baixar_multiplas_parcela__cheque_transferencia
Scenario: Baixar Multiplas Parcelas Cheque + Transferência
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
	When clique no botao Adicionar Multiplos Meios de Pagamento
	And selecione o meio de pagamento {'Cheque'}
	And ratear o valor exibido no input por {2}
	And informar o planos de contas {'Contratos Financeiros'}
	And informar o centro de custo {'Contratos Financeiros'}
	And informar no input o historico {'Multiplos meios de pagamento  - ÉusGuri'}
	And clicar no botao Adicionar para multiplos meios de pagamento
	And seja validado o valor do rateio
	And clique no botao Adicionar Multiplos Meios de Pagamento
	And selecione o segundo meio de pagamento {'Transferência'}
	And valide que o resto do rateio seja inserido no input
	And selecione a conta bancaria do segundo meio de pagamento {'BB Fake'}
	And informar o planos de contas do segundo meio {'Contratos Financeiros'}
	And informar o centro de custo do segundo meio {'Contratos Financeiros'}
	And informar no input o historico do segundo meio {'Multiplos meios de pagamento  - ÉusGuriDeNovoPae'}
	And clicar no botao Adicionar para segundo multiplos meios de pagamento
	And seja validado o resto do rateio
	And clicar no botao Efetuar Baixa
	Then o sistema redireciona para imprimir movimentacao

@receita_baixar_parcela_operacao_bancaria
Scenario: Baixar Parcela Transferência Bancária
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
	And selecione o meio de pagamento {'Transferência'}
	And selecione a conta bancaria {'BB Fake'}
	When clicar no botao Efetuar Baixa
	Then o sistema redireciona para imprimir movimentacao



#baixa normal dando desconto sobre os juros de parcela vencida
#valor a pagar deve ser o valor original da parcela 
@receita_baixar_parcela_vencida_desconto
Scenario: Baixar Parcela Vencida C/ Desconto 
	Given que clica na aba Contas a Receber
	And clique na pesquisa 
	And clique para limpar filtros
	And clique no botao Filtrar Receitas
	And o numero de parcelas filtradas seja maior que {0}
	And o vencimento da parcela seja retroativo a data atual
	And selecione a primeira parcela listada
	And clique no botao movimentar parcela
	And o valor a ser movimentado seja maior que zero
	And clique no icone Baixar Parcela
	And seja redirecionado para /FIN/Contrato/ListarParcelasBaixa
	And clique no collapse para exibir meio pagamento parcela
	And selecione o meio de pagamento {'Dinheiro'}
	When clicar no botao Editar Valor / Data Movimento
	And memorizar o valor do juros/multa
	And memorizar o valor original da parcela
	And validar que o valor liquido a pagar seja maior que o valor original da parcela
	And alterar o valor a pagar para o valor original
	And desabilitar a flag de baixa parcial
	And clicar no botao Gravar
	Then o valor a pagar deve ser o mesmo que valor original
	And o valor do desconto deve ser o mesmo memorizado anteriormente
	And clicar no botao Efetuar Baixa
	And o sistema redireciona para imprimir movimentacao




@receita_baixar_parcela_vencida_alterar_movimento
Scenario: Baixar Parcela Vencida Alterando Movimento
	Given que clica na aba Contas a Receber
	And clique na pesquisa 
	And clique para limpar filtros
	And clique no botao Filtrar Receitas
	And o numero de parcelas filtradas seja maior que {0}
	And o vencimento da parcela seja retroativo a data atual
	And selecione a primeira parcela listada
	And clique no botao movimentar parcela
	And o valor a ser movimentado seja maior que zero
	And clique no icone Baixar Parcela
	And seja redirecionado para /FIN/Contrato/ListarParcelasBaixa
	And clique no collapse para exibir meio pagamento parcela
	And selecione o meio de pagamento {'Dinheiro'}
	When clicar no botao Alterar dados da baixa (todas as parcelas)
	And marcar a flag Alterar Data de Pagamento para Data de vencimento
	And clicar no botao Alterar dados baixa
	Then o valor a pagar deve ser o mesmo que valor original
	And data de vencimento e data movimento devem ser iguais
	And os juros devem ser zerados
	And clicar no botao Efetuar Baixa
	And o sistema redireciona para imprimir movimentacao