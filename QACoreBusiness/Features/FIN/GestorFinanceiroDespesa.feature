﻿Feature: GestorFinanceiroDespesa

Background: Logar e acessar gestor financeiro
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Contratos'}


@despesa_baixar_parcela_dinheiro
Scenario: Baixar Parcela Dinheiro
	Given seja clicado no botao da Header Lançar Pagamento Antecipado
	And seja redirecionado para index de Pagto Antecipado
	And selecionar a pessoa do contrato {'Laura La Caronita'}
	And selecionar o plano de contas {'Contratos Financeiros'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And selecionar o meio de pagamento {'Dinheiro'}
	And informar no input o Valor a pagar {200.0}
	And clicar no botao Salvar pagto antecipado
	And o sistema redireciona para index de contratos
	And um contrato de pagamento Num Doc {'PGA'} deve ser criado
	And com status {'Quitado'} na primeira linha da tabela de contratos
	And um contrato de credito Num Doc {'CREPGA'} deve ser criado
	And com status {'Aberto'} na segunda linha da tabela contratos
	And o usuário deve acessar o contexto by url {'/FIN/GestorFinanceiro'}
	And que clica na aba Contas a Pagar
	And clique para pesquisar despesas
	And clique no botao limpar filtros
	And clique no botao Filtrar Despesas
	And o numero de parcelas despesas filtradas seja maior que {0}
	And selecione a primeira parcela da lista
	And clique no botao Movimentar Parcela
	And o valor a ser movimentado seja maior que Zero
	And clique no icone para Baixar Parcela
	And seja redirecionado para /FIN/Contrato/ListarParcelasBaixa
	And clique no collapse para exibir meio pagamento parcela
	And selecione o meio de pagamento {'Dinheiro'}
	When clicar no botao Efetuar Baixa
	Then o sistema redireciona para imprimir movimentacao
	And feche o navegador quando terminar


@despesa_baixar_parcela_abatimento
Scenario: Baixar Parcela Abatimento
	Given seja clicado no botao da Header Lançar Pagamento Antecipado
	And seja redirecionado para index de Pagto Antecipado
	And selecionar a pessoa do contrato {'Laura La Caronita'}
	And selecionar o plano de contas {'Contratos Financeiros'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And selecionar o meio de pagamento {'Dinheiro'}
	And informar no input o Valor a pagar {50.0}
	And clicar no botao Salvar pagto antecipado
	And o sistema redireciona para index de contratos
	And um contrato de pagamento Num Doc {'PGA'} deve ser criado
	And com status {'Quitado'} na primeira linha da tabela de contratos
	And um contrato de credito Num Doc {'CREPGA'} deve ser criado
	And com status {'Aberto'} na segunda linha da tabela contratos
	And o usuário deve acessar o contexto by url {'/FIN/GestorFinanceiro'}
	And que clica na aba Contas a Pagar
	And clique para pesquisar despesas
	And clique no botao limpar filtros
	And clique no botao Filtrar Despesas
	And o numero de parcelas despesas filtradas seja maior que {0}
	And selecione a primeira parcela da lista
	And clique no botao Movimentar Parcela
	And o valor a ser movimentado seja maior que Zero
	And clique no icone para Baixar Parcela
	And seja redirecionado para /FIN/Contrato/ListarParcelasBaixa
	And clique no collapse para exibir meio pagamento parcela
	And selecione o meio de pagamento {'Abatimento'}
	And ache no select a parcela de crédito/abatimento que seja maior que o valor a quitar
	And selecione a parcela de crédito/abatimento
	When clicar no botao Efetuar Baixa
	Then o sistema redireciona para imprimir movimentacao
	And feche o navegador quando terminar


@despesa_baixar_parcela_operacao_bancaria
Scenario: Baixar Parcela Op. Bancária
	Given seja clicado no botao da Header Lançar Pagamento Antecipado
	And seja redirecionado para index de Pagto Antecipado
	And selecionar a pessoa do contrato {'Laura La Caronita'}
	And selecionar o plano de contas {'Contratos Financeiros'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And selecionar o meio de pagamento {'Dinheiro'}
	And informar no input o Valor a pagar {400.0}
	And clicar no botao Salvar pagto antecipado
	And o sistema redireciona para index de contratos
	And um contrato de pagamento Num Doc {'PGA'} deve ser criado
	And com status {'Quitado'} na primeira linha da tabela de contratos
	And um contrato de credito Num Doc {'CREPGA'} deve ser criado
	And com status {'Aberto'} na segunda linha da tabela contratos
	And o usuário deve acessar o contexto by url {'/FIN/GestorFinanceiro'}
	And que clica na aba Contas a Pagar
	And clique para pesquisar despesas
	And clique no botao limpar filtros
	And clique no botao Filtrar Despesas
	And o numero de parcelas despesas filtradas seja maior que {0}
	And selecione a primeira parcela da lista
	And clique no botao Movimentar Parcela
	And o valor a ser movimentado seja maior que Zero
	And clique no icone para Baixar Parcela
	And seja redirecionado para /FIN/Contrato/ListarParcelasBaixa
	And clique no collapse para exibir meio pagamento parcela
	And selecione o meio de pagamento {'Operação Bancária'}
	And selecione a conta bancaria de pagamento {'BB Fake'}
	When clicar no botao Efetuar Baixa
	Then o sistema redireciona para imprimir movimentacao
	And feche o navegador quando terminar



@despesa_baixar_multiplas_parcela_dinheiro_transferencia
Scenario: Baixar Multiplas Parcelas Dinheiro + Transferência
	Given seja clicado no botao da Header Lançar Pagamento Antecipado
	And seja redirecionado para index de Pagto Antecipado
	And selecionar a pessoa do contrato {'Laura La Caronita'}
	And selecionar o plano de contas {'Contratos Financeiros'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And selecionar o meio de pagamento {'Dinheiro'}
	And informar no input o Valor a pagar {500.0}
	And clicar no botao Salvar pagto antecipado
	And o sistema redireciona para index de contratos
	And um contrato de pagamento Num Doc {'PGA'} deve ser criado
	And com status {'Quitado'} na primeira linha da tabela de contratos
	And um contrato de credito Num Doc {'CREPGA'} deve ser criado
	And com status {'Aberto'} na segunda linha da tabela contratos
	And o usuário deve acessar o contexto by url {'/FIN/GestorFinanceiro'}
	And que clica na aba Contas a Pagar
	And clique para pesquisar despesas
	And clique no botao limpar filtros
	And clique no botao Filtrar Despesas
	And o numero de parcelas despesas filtradas seja maior que {0}
	And selecione a primeira parcela da lista
	And clique no botao Movimentar Parcela
	And o valor a ser movimentado seja maior que Zero
	And clique no icone para Baixar Parcela
	And seja redirecionado para /FIN/Contrato/ListarParcelasBaixa
	When clique no botao Adicionar Multiplos Meios de Pagamento
	And selecione o primeiro meio de pagamento {'Dinheiro'}
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
	And feche o navegador quando terminar



@despesa_baixar_multiplas_parcela_dinheiro_abatimento
Scenario: Baixar Multiplas Parcelas Dinheiro + Abatimento
	Given seja clicado no botao da Header Lançar Pagamento Antecipado
	And seja redirecionado para index de Pagto Antecipado
	And selecionar a pessoa do contrato {'Laura La Caronita'}
	And selecionar o plano de contas {'Contratos Financeiros'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And selecionar o meio de pagamento {'Dinheiro'}
	And informar no input o Valor a pagar {550.0}
	And clicar no botao Salvar pagto antecipado
	And o sistema redireciona para index de contratos
	And um contrato de pagamento Num Doc {'PGA'} deve ser criado
	And com status {'Quitado'} na primeira linha da tabela de contratos
	And um contrato de credito Num Doc {'CREPGA'} deve ser criado
	And com status {'Aberto'} na segunda linha da tabela contratos
	And o usuário deve acessar o contexto by url {'/FIN/GestorFinanceiro'}
	And que clica na aba Contas a Pagar
	And clique para pesquisar despesas
	And clique no botao limpar filtros
	And clique no botao Filtrar Despesas
	And o numero de parcelas despesas filtradas seja maior que {0}
	And selecione a primeira parcela da lista
	And clique no botao Movimentar Parcela
	And o valor a ser movimentado seja maior que Zero
	And clique no icone para Baixar Parcela
	And seja redirecionado para /FIN/Contrato/ListarParcelasBaixa
	When clique no botao Adicionar Multiplos Meios de Pagamento
	And selecione o primeiro meio de pagamento {'Dinheiro'}
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
	And feche o navegador quando terminar



@despesa_baixar_parcela_cheque
Scenario: Baixar Parcela Cheque Proprio
	Given seja clicado no botao da Header Lançar Pagamento Antecipado
	And seja redirecionado para index de Pagto Antecipado
	And selecionar a pessoa do contrato {'Laura La Caronita'}
	And selecionar o plano de contas {'Contratos Financeiros'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And selecionar o meio de pagamento {'Dinheiro'}
	And informar no input o Valor a pagar {200.0}
	And clicar no botao Salvar pagto antecipado
	And o sistema redireciona para index de contratos
	And um contrato de pagamento Num Doc {'PGA'} deve ser criado
	And com status {'Quitado'} na primeira linha da tabela de contratos
	And um contrato de credito Num Doc {'CREPGA'} deve ser criado
	And com status {'Aberto'} na segunda linha da tabela contratos
	And o usuário deve acessar o contexto by url {'/FIN/GestorFinanceiro'}
	And que clica na aba Contas a Pagar
	And clique para pesquisar despesas
	And clique no botao limpar filtros
	And clique no botao Filtrar Despesas
	And o numero de parcelas despesas filtradas seja maior que {0}
	And selecione a primeira parcela da lista
	And clique no botao Movimentar Parcela
	And o valor a ser movimentado seja maior que Zero
	And clique no icone para Baixar Parcela
	And seja redirecionado para /FIN/Contrato/ListarParcelasBaixa
	And clique no collapse para exibir meio pagamento parcela
	And memorize o nome do cliente da parcela
	And selecione o meio de pagamento {'Cheque'}
	And clique no botao para incluir/cadastrar cheque
	And selecione o caixa recebido ('Caixa')
	And informe a data de entrada do cheque em caixa
	And informe a data de emissao {7} dias retroativos
	And informe a data bom para {data atual}
	And informe o numero do cheque
	And selecione o banco {'Banco do Brasil'}
	And informe alguma observaçao {'Cheque dos guri'}
	And clique no botao Salvar cheque
	And clique no collapse para exibir meio pagamento parcela
	And selecione o cheque criado
	When clicar no botao Efetuar Baixa
	Then o sistema redireciona para imprimir movimentacao
	And feche o navegador quando terminar



@despesa_baixar_multiplas_parcela_cheque_abatimento
Scenario: Baixar Multiplas Parcelas Cheque Proprio + Abatimento
	Given seja clicado no botao da Header Lançar Pagamento Antecipado
	And seja redirecionado para index de Pagto Antecipado
	And selecionar a pessoa do contrato {'Laura La Caronita'}
	And selecionar o plano de contas {'Contratos Financeiros'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And selecionar o meio de pagamento {'Dinheiro'}
	And informar no input o Valor a pagar {550.0}
	And clicar no botao Salvar pagto antecipado
	And o sistema redireciona para index de contratos
	And um contrato de pagamento Num Doc {'PGA'} deve ser criado
	And com status {'Quitado'} na primeira linha da tabela de contratos
	And um contrato de credito Num Doc {'CREPGA'} deve ser criado
	And com status {'Aberto'} na segunda linha da tabela contratos
	And o usuário deve acessar o contexto by url {'/FIN/GestorFinanceiro'}
	And que clica na aba Contas a Pagar
	And clique para pesquisar despesas
	And clique no botao limpar filtros
	And clique no botao Filtrar Despesas
	And o numero de parcelas despesas filtradas seja maior que {0}
	And selecione a primeira parcela da lista
	And clique no botao Movimentar Parcela
	And o valor a ser movimentado seja maior que Zero
	And clique no icone para Baixar Parcela
	And seja redirecionado para /FIN/Contrato/ListarParcelasBaixa
	When clique no botao Adicionar Multiplos Meios de Pagamento
	And selecione o primeiro meio de pagamento {'Cheque'}
	And ratear o valor exibido no input por {2}
	And informar o planos de contas {'Contratos Financeiros'}
	And informar o centro de custo {'Contratos Financeiros'}
	And informar no input o historico {'Multiplos meios de pagamento  - ÉusGuri'}
	And clicar no botao Adicionar para multiplos meios de pagamento
	And seja validado o valor do rateio
	And clique no botao Vincular documento cheque
	And clique enter para listar as opçoes cheques
	And clique no botao para incluir cheque
	And selecione a empresa responsavel {'Deltacon Informática'}
	And selecione o caixa recebido ('Caixa')
	And informe a data de entrada do cheque em caixa
	And informe a data de emissao {7} dias retroativos
	And informe a data bom para {data atual}
	And informe o numero do cheque
	And selecione o banco {'Banco do Brasil'}
	And informe alguma observaçao {'Cheque dos guri'}
	And clique no botao Salvar cheque
	And pesquise o numero do cheque criado
	And clicar no botao Vincular creditos
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
	And feche o navegador quando terminar