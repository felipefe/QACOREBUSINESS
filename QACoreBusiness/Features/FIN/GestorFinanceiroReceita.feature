Feature: GestorFinanceiroReceita

Background: Logar e acessar gestor financeiro
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Gestor Financeiro'}


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
	And feche o navegador quando terminar

@receita_baixar_parcela_cheque
Scenario: Baixar Parcela Cheque Terceiro
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
	And selecione o meio de pagamento {'Cheque'}
	And remova a conta bancaria
	And clique no botao para incluir/cadastrar cheque
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
	And feche o navegador quando terminar


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
	And memorize o nome do cliente da parcela
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
	And selecione a pessoa responsavel/cliente parcela
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


@receita_baixar_multiplas_parcela__din_transferencia
Scenario: Baixar Multiplas Parcelas Dinheiro + Transferência
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
	And feche o navegador quando terminar



#baixa normal dando desconto sobre os juros de parcela vencida
#valor a pagar deve ser o valor original da parcela 
@receita_baixar_parcela_vencida_desconto
Scenario: Baixar Parcela Vencida C/ Desconto 
	Given o usuário deve acessar o contexto by url {'/FIN/Contrato'}
	And que seja clicado no botao criar contrato
	And seja redirecionado para /Contrato/Create
	When inserir no input numero do documento 
	And inserir no input Data de Emissao do contrato {20} dias RETROATIVOS
	And selecionar a pessoa do contrato {'Laura La Caronita'}
	And selecionar a empresa do contrato {'Deltacon Informática'}
	And selecionar o plano de contas {'Contratos Financeiros'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And informar no textArea um historico  {'Contrato com datas emissao e parcela retroativas'}
	And selecionar a conta prevista pagamento {'BB Fake'}
	And clicar no botao adicionar parcelas manualmente 
	And inserir no input Valor Original R${1994.5}
	And inserir no input Data de Vencimento {20} dias RETROATIVOS
	And clicar no botao Adicionar parcela
	And a parcela deve ser criadas conforme valor informado
	And clicar no botao salvar/criar contrato
	And o sistema redireciona para index de contratos
	And o status do contrato deve ser {'Aberto'}
	And a coluna referente ao valor original {'1994.5'}
	And o usuário deve acessar o contexto by url {'/FIN/GestorFinanceiro'}
	And que clica na aba Contas a Receber
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
	And feche o navegador quando terminar




@receita_baixar_parcela_vencida_alterar_movimento
Scenario: Baixar Parcela Vencida Alterando Movimento
	Given o usuário deve acessar o contexto by url {'/FIN/Contrato'}
	And que seja clicado no botao criar contrato
	And seja redirecionado para /Contrato/Create
	When inserir no input numero do documento 
	And inserir no input Data de Emissao do contrato {20} dias RETROATIVOS
	And selecionar a pessoa do contrato {'Laura La Caronita'}
	And selecionar a empresa do contrato {'Deltacon Informática'}
	And selecionar o plano de contas {'Contratos Financeiros'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And informar no textArea um historico  {'Contrato com datas emissao e parcela retroativas'}
	And selecionar a conta prevista pagamento {'BB Fake'}
	And clicar no botao adicionar parcelas manualmente 
	And inserir no input Valor Original R${150.0}
	And inserir no input Data de Vencimento {20} dias RETROATIVOS
	And clicar no botao Adicionar parcela
	And a parcela deve ser criadas conforme valor informado
	And clicar no botao salvar/criar contrato
	And o sistema redireciona para index de contratos
	And o status do contrato deve ser {'Aberto'}
	And a coluna referente ao valor original {'150.0'}
	And o usuário deve acessar o contexto by url {'/FIN/GestorFinanceiro'}
	And que clica na aba Contas a Receber
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
	And clicar no botao Alterar dados da baixa (todas as parcelas)
	And marcar a flag Alterar Data de Pagamento para Data de vencimento
	And clicar no botao Alterar dados baixa
	Then o valor a pagar deve ser o mesmo que valor original
	And data de vencimento e data movimento devem ser iguais
	And os juros devem ser zerados
	And clicar no botao Efetuar Baixa
	And o sistema redireciona para imprimir movimentacao
	And feche o navegador quando terminar



@substituir_parcela_contrato
Scenario: Renegociar parcela contrato
Given que clica na aba Contas a Receber
	And clique na pesquisa 
	And clique para limpar filtros
	And clique no botao Filtrar Receitas
	And o numero de parcelas filtradas seja maior que {0}
	And selecione a primeira parcela listada
	And clique no botao movimentar parcela
	And o valor a ser movimentado seja maior que zero
	And clique no botao Açoes
	And clique no botao Renegociar
	And seja redirecionado para tela de renegociacao
	And memorize o valor liquido a renegociar do input
	When clique no botao Montar Renegociacao
	And clique para adicionar parcela manualmente
	And insira no input data de vencimento data atual + {15} dias
	And clique no botao Adicionar parcela
	And valida que a parcela foi inserida na data correta
	And valida que o valor da parcela é o mesmo memorizado
	And clique no botao Gerar Renegociacao
	Then o sistema redireciona para index de visualizar contrato
	And valide o valor bruto a pagar da parcela substituida
	And feche o navegador quando terminar


@substituir_contrato
Scenario: Substituir parcela contrato
	Given que clica na aba Contas a Receber
	And clique na pesquisa 
	And clique para limpar filtros
	And clique no botao Filtrar Receitas
	And o numero de parcelas filtradas seja maior que {0}
	And selecione a primeira parcela listada
	And clique no botao movimentar parcela
	And o valor a ser movimentado seja maior que zero
	And clique no botao Açoes
	And clique no botao Substituir
	And seja redirecionado para url contains {'/FIN/Contrato/SubstituirParcelas'}
	And memorize o valor da parcela a substituir
	And clique no botao para Criar Contrato
	And selecionar o plano de contas {'Contratos Financeiros'}
	And selecionar o centro de custo {'Contratos Financeiros'}
	And memorize do input o nome do novo contrato
	And clicar no botao adicionar parcelas by modal contrato
	And clicar no botao salvar parcela by modal contrato
	When a parcela deve ser criadas conforme valor da parcela original
	And clicar no botao salvar contrato substituido
	And selecione o novo contrato inserindo o nome memorizado
	And clique no botao substituir parcelas
	Then seja redirecionado para url contains {'/FIN/Contrato/Visualizar?idContrato'}
	And feche o navegador quando terminar

	

