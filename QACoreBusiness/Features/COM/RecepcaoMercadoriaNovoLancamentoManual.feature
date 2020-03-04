Feature: RecepcaoMercadoriaNovoLancamentoManual

Background: Estar logado e na index de recepção de mercadoria
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Recepção de Mercadorias e Serviços'}


@recepcao_mercadoria_novo_lancamento_manual
Scenario: Criar recepcao manual de mercadoria
	Given que seja clicado no botao Novo Lancamento Manual
	And seja redirecionado para tela de criar recepcao	
	And seja informado a operação fiscal {'Recepção de Mercadoria'}
	And seja informado no editText o fornecedor {'New Era Fornecedor LTDA'}
	And seja informado no editText a data de recebimento [data atual]
	And seja informado no editText o Numero do documento 
	And seja informado no editText a Serie do documento {1}
	And seja informado no editText a data de emissao
	And seja informado o modelo de documento {'Nota Fiscal modelo 1 ou 1-A'}
	When clicar no botao Salvar
	Then o sistema redirecionada para index de recepçao
	And o status da recepcao deve ser {'Lançamento'}
	And feche o navegador quando terminar



@lancar_itens_recepcao_manual
Scenario: Lancar itens recepcao manual (Semi-automatico)
	Given que seja clicado no botao Novo Lancamento Manual
	And seja redirecionado para tela de criar recepcao	
	And seja informado a operação fiscal {'Recepção de Mercadoria'}
	And seja informado no editText o fornecedor {'New Era Fornecedor LTDA'}
	And seja informado no editText a data de recebimento [data atual]
	And seja informado no editText o Numero do documento 
	And seja informado no editText a Serie do documento {1}
	And seja informado no editText a data de emissao
	And seja informado o modelo de documento {'Nota Fiscal modelo 1 ou 1-A'}
	And clicar no botao Salvar
	And o sistema redirecionada para index de recepçao
	And que tenha uma recepcao no status {'Lançamento'}
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And seja clicado no botao Nova Mercadoria Recebida
	And seja redirecionado para criar item da recepcao
	When informar o produto SKU {'TST0002'}
	And informar no editText o valor unitario {65}
	And informar no editText a quantidade {10}
	And informar no editText o numero do lote
	And informar no editText a data de fabricacao
	And informar no editText a data de validade
	And clicar na aba de Impostos Conforme Documento de Entrada
	And informar o CFOP 1102 - {'Compra para comercialização'}
	And informar a origem da Mercadoria {'Nacional - exceto as indicadas nos códigos 3 a 5'}
	And informar o codigo da ST {'Tributada integralmente'}
	And informar no editText o percentual da Aliquota {1}
	And clicar no botao de Salvar itens
	Then seja redirecionado para tela de Mercadorias da recepcao
	And o SKU do item da recepcao informado deve aparecer na tabela
	And feche o navegador quando terminar


@escriturar_item_mercadoria_recepcao
Scenario: Escriturar itens da recepcao (Semi-automatico)
	Given que seja clicado no botao Novo Lancamento Manual
	And seja redirecionado para tela de criar recepcao	
	And seja informado a operação fiscal {'Recepção de Mercadoria'}
	And seja informado no editText o fornecedor {'New Era Fornecedor LTDA'}
	And seja informado no editText a data de recebimento [data atual]
	And seja informado no editText o Numero do documento 
	And seja informado no editText a Serie do documento {1}
	And seja informado no editText a data de emissao
	And seja informado o modelo de documento {'Nota Fiscal modelo 1 ou 1-A'}
	And clicar no botao Salvar
	And o sistema redirecionada para index de recepçao
	And que tenha uma recepcao no status {'Lançamento'}
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And seja clicado no botao Nova Mercadoria Recebida
	And seja redirecionado para criar item da recepcao
	When informar o produto SKU {'TST0002'}
	And informar no editText o valor unitario {65}
	And informar no editText a quantidade {10}
	And informar no editText o numero do lote
	And informar no editText a data de fabricacao
	And informar no editText a data de validade
	And clicar na aba de Impostos Conforme Documento de Entrada
	And informar o CFOP 1102 - {'Compra para comercialização'}
	And informar a origem da Mercadoria {'Nacional - exceto as indicadas nos códigos 3 a 5'}
	And informar o codigo da ST {'Tributada integralmente'}
	And informar no editText o percentual da Aliquota {1}
	And clicar no botao de Salvar itens
	And seja redirecionado para tela de Mercadorias da recepcao
	And o SKU do item da recepcao informado deve aparecer na tabela
	And tenha na coluna Escriturado do item o valor {'Não'}
	And clicar no botao da header Escriturar todos os itens automaticamente
	And seja redirecionado para index de escriturar lote fiscal
	And clicar na aba Configuração
	And selecione o CFOP {1102} Compra para Comercialização
	And clicar no botao Calcular
	Then o status do item deve mudar para {'Escriturado'}
	And quando clicar no botao Prosseguir
	And o sistema redirecionada para index de recepçao
	And feche o navegador quando terminar



@finalizar_lancamento_itens_escriturados
Scenario: Finalizar lancamento de itens escriturados
	Given que seja clicado no botao Novo Lancamento Manual
	And seja redirecionado para tela de criar recepcao	
	And seja informado a operação fiscal {'Recepção de Mercadoria'}
	And seja informado no editText o fornecedor {'New Era Fornecedor LTDA'}
	And seja informado no editText a data de recebimento [data atual]
	And seja informado no editText o Numero do documento 
	And seja informado no editText a Serie do documento {1}
	And seja informado no editText a data de emissao
	And seja informado o modelo de documento {'Nota Fiscal modelo 1 ou 1-A'}
	And clicar no botao Salvar
	And o sistema redirecionada para index de recepçao
	And que tenha uma recepcao no status {'Lançamento'}
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And seja clicado no botao Nova Mercadoria Recebida
	And seja redirecionado para criar item da recepcao
	When selecionar o metodo de calculado {'Manual'}
	And informar o produto SKU {'TST0002'}
	And informar no editText o valor unitario {65}
	And informar no editText a quantidade {10}
	And informar no input o valor bruto
	And informar no input o valor liquido
	And informar no editText o numero do lote
	And informar no editText a data de fabricacao
	And informar no editText a data de validade
	And clicar na aba de Impostos Conforme Documento de Entrada
	And informar o CFOP 1102 - {'Compra para comercialização'}
	And informar a origem da Mercadoria {'Nacional - exceto as indicadas nos códigos 3 a 5'}
	And informar o codigo da ST {'Tributada integralmente'}
	And informar no editText o percentual da Aliquota {1}
	And informar o valor de ICMS calculado
	And informar no input a base de calculo
	And clique na aba PIS
	And informar o codigo de ST do PIS {'Operação Tributável com Alíquota Básica'}
	And informar o tipo de Alíquota PIS {'Alíquota em Percentual'}
	And informar a % da Alíquota {1} PIS
	And informar a base de calculo do PIS
	And informar o valor calculado do PIS
	And clique na aba COFINS
	And informar o codigo de ST do COFINS {'Operação Tributável com Alíquota Básica'}
	And informar o tipo de Alíquota COFINS {'Alíquota em Percentual'}
	And informar a % da Alíquota {1} COFINS
	And informar a base de calculo do COFINS
	And informar o valor calculado do COFINS
	And clicar no botao de Salvar itens
	And seja redirecionado para tela de Mercadorias da recepcao
	And espere {15} segundos ate as mensagem de valor nao calculado sumirem
	And o SKU do item da recepcao informado deve aparecer na tabela
	And tenha na coluna Escriturado do item o valor {'Não'}
	And clique nas actions para Escriturar 
	And seja redirecionado para tela de EscriturarProduto
	And selecionar o metodo de calculado {'Manual'}
	And informar o CFOP {'Compra para comercialização'}
	And informar a origem da Mercadoria {'Nacional - exceto as indicadas nos códigos 3 a 5'} do ICMS
	And informar o codigo da ST {'Tributada integralmente'} do ICMS
	And informar no input o percentual da Aliquota {1} do ICMS
	And informar no input a base de calculo do ICMS
	And informar no input o valor ICMS
	And clicar na aba PIS
	And informar o codigo da ST {'Operação Tributável com Alíquota Básica'} do PIS
	And informar o tipo de Alíquota {'Alíquota em Percentual'} do PIS
	And informar no input o percentual da Aliquota {1} do PIS
	And informar no input a base de calculo do PIS
	And informar no input o valor PIS
	And clicar na aba COFINS
	And informar o codigo da ST {'Operação Tributável com Alíquota Básica'} do COFINS
	And informar o tipo de Alíquota {'Alíquota em Percentual'} do COFINS
	And informar no input o percentual da Aliquota {1} do COFINS
	And informar no input a base de calculo do COFINS
	And informar no input o valor COFINS
	Then clicar no botao Gravar escrituraçao
	And seja redirecionado para tela de Mercadorias da recepcao
	And tenha na coluna Escriturado do item o valor {'Sim'}
	And clicar no botao Finalizar Lançamento de Itens
	And marcar Eu concluí o lançamento de todos os itens
	And clicar no botao Confirmar
	And o sistema redirecionada para index de recepçao
	And o status da recepcao deve ser {'Conferência Física'}
	And feche o navegador quando terminar

@conferir_item_recepcao
Scenario: Conferir item recepcao 
	Given que seja clicado no botao Novo Lancamento Manual
	And seja redirecionado para tela de criar recepcao	
	And seja informado a operação fiscal {'Recepção de Mercadoria'}
	And seja informado no editText o fornecedor {'New Era Fornecedor LTDA'}
	And seja informado no editText a data de recebimento [data atual]
	And seja informado no editText o Numero do documento 
	And seja informado no editText a Serie do documento {1}
	And seja informado no editText a data de emissao
	And seja informado o modelo de documento {'Nota Fiscal modelo 1 ou 1-A'}
	And clicar no botao Salvar
	And o sistema redirecionada para index de recepçao
	And que tenha uma recepcao no status {'Lançamento'}
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And seja clicado no botao Nova Mercadoria Recebida
	And seja redirecionado para criar item da recepcao
	When informar o produto SKU {'TST0002'}
	And informar no editText o valor unitario {65}
	And informar no editText a quantidade {10}
	And informar no editText o numero do lote
	And informar no editText a data de fabricacao
	And informar no editText a data de validade
	And clicar na aba de Impostos Conforme Documento de Entrada
	And informar o CFOP 1102 - {'Compra para comercialização'}
	And informar a origem da Mercadoria {'Nacional - exceto as indicadas nos códigos 3 a 5'}
	And informar o codigo da ST {'Tributada integralmente'}
	And informar no editText o percentual da Aliquota {1}
	And clicar no botao de Salvar itens
	And seja redirecionado para tela de Mercadorias da recepcao
	And o SKU do item da recepcao informado deve aparecer na tabela
	And tenha na coluna Escriturado do item o valor {'Não'}
	And clicar no botao da header Escriturar todos os itens automaticamente
	And seja redirecionado para index de escriturar lote fiscal
	And clicar na aba Configuração
	And selecione o CFOP {1102} Compra para Comercialização
	And clicar no botao Calcular
	And o status do item deve mudar para {'Escriturado'}
	And quando clicar no botao Prosseguir
	And o sistema redirecionada para index de recepçao
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And tenha na coluna Escriturado do item o valor {'Sim'}
	And clicar no botao Finalizar Lançamento de Itens
	And marcar Eu concluí o lançamento de todos os itens
	And clicar no botao Confirmar
	And o sistema redirecionada para index de recepçao
	And o status da recepcao deve ser {'Conferência Física'}
	And seja clicado no botao Conferencia Fisica de Recebimento nas actions
	And seja redirecionado para tela de WMS Conferencia
	And o SKU seja copiado da coluna Código
	And seja colado no editText Código do Produto
	And a quantidade seja copiada da coluna Qtd. Total 
	And seja colada no editText Quantidade
	And eu clicar Enter
	And clicar no botao Concluir Processo
	And clicar no botao Finalizar 
	And ser redirecionado para tela de COM Conferencia Fisica da Recepcao
	And clicar no botao Concluir
	Then o sistema redirecionada para index de recepçao
	And o status da recepcao deve ser {'Aguardando Finalização'} 
	And feche o navegador quando terminar

@finalizar_recepcao_mercadoria
Scenario: Finalizar recepcao de mercadoria
	Given que seja clicado no botao Novo Lancamento Manual
	And seja redirecionado para tela de criar recepcao	
	And seja informado a operação fiscal {'Recepção de Mercadoria'}
	And seja informado no editText o fornecedor {'New Era Fornecedor LTDA'}
	And seja informado no editText a data de recebimento [data atual]
	And seja informado no editText o Numero do documento 
	And seja informado no editText a Serie do documento {1}
	And seja informado no editText a data de emissao
	And seja informado o modelo de documento {'Nota Fiscal modelo 1 ou 1-A'}
	And clicar no botao Salvar
	And o sistema redirecionada para index de recepçao
	And que tenha uma recepcao no status {'Lançamento'}
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And seja clicado no botao Nova Mercadoria Recebida
	And seja redirecionado para criar item da recepcao
	When informar o produto SKU {'TST0002'}
	And informar no editText o valor unitario {65}
	And informar no editText a quantidade {10}
	And informar no editText o numero do lote
	And informar no editText a data de fabricacao
	And informar no editText a data de validade
	And clicar na aba de Impostos Conforme Documento de Entrada
	And informar o CFOP 1102 - {'Compra para comercialização'}
	And informar a origem da Mercadoria {'Nacional - exceto as indicadas nos códigos 3 a 5'}
	And informar o codigo da ST {'Tributada integralmente'}
	And informar no editText o percentual da Aliquota {1}
	And clicar no botao de Salvar itens
	And seja redirecionado para tela de Mercadorias da recepcao
	And o SKU do item da recepcao informado deve aparecer na tabela
	And tenha na coluna Escriturado do item o valor {'Não'}
	And clicar no botao da header Escriturar todos os itens automaticamente
	And seja redirecionado para index de escriturar lote fiscal
	And clicar na aba Configuração
	And selecione o CFOP {1102} Compra para Comercialização
	And clicar no botao Calcular
	And o status do item deve mudar para {'Escriturado'}
	And quando clicar no botao Prosseguir
	And o sistema redirecionada para index de recepçao
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And tenha na coluna Escriturado do item o valor {'Sim'}
	And clicar no botao Finalizar Lançamento de Itens
	And marcar Eu concluí o lançamento de todos os itens
	And clicar no botao Confirmar
	And o sistema redirecionada para index de recepçao
	And o status da recepcao deve ser {'Conferência Física'}
	And seja clicado no botao Conferencia Fisica de Recebimento nas actions
	And seja redirecionado para tela de WMS Conferencia
	And o SKU seja copiado da coluna Código
	And seja colado no editText Código do Produto
	And a quantidade seja copiada da coluna Qtd. Total 
	And seja colada no editText Quantidade
	And eu clicar Enter
	And clicar no botao Concluir Processo
	And clicar no botao Finalizar 
	And ser redirecionado para tela de COM Conferencia Fisica da Recepcao
	And clicar no botao Concluir
	Then o sistema redirecionada para index de recepçao
	And o status da recepcao deve ser {'Aguardando Finalização'} 
	And seja clicado no botao Finalizar Recebimento nas actions
	And seja redirecionado para tela de Finalizar recepcao
	And clicar no botao Finalizar Recepcao
	And o sistema redirecionada para index de recepçao
	And feche o navegador quando terminar

@excluir_recepcao_mercadoria
Scenario: Excluir recepcao mercadoria
Given que seja clicado no botao Novo Lancamento Manual
	And seja redirecionado para tela de criar recepcao	
	And seja informado a operação fiscal {'Recepção de Mercadoria'}
	And seja informado no editText o fornecedor {'New Era Fornecedor LTDA'}
	And seja informado no editText a data de recebimento [data atual]
	And seja informado no editText o Numero do documento 
	And seja informado no editText a Serie do documento {1}
	And seja informado no editText a data de emissao
	And seja informado o modelo de documento {'Nota Fiscal modelo 1 ou 1-A'}
	And clicar no botao Salvar
	And o sistema redirecionada para index de recepçao
	And que tenha uma recepcao no status {'Lançamento'}
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And seja clicado no botao Nova Mercadoria Recebida
	And seja redirecionado para criar item da recepcao
	When informar o produto SKU {'TST0002'}
	And informar no editText o valor unitario {65}
	And informar no editText a quantidade {10}
	And informar no editText o numero do lote
	And informar no editText a data de fabricacao
	And informar no editText a data de validade
	And clicar na aba de Impostos Conforme Documento de Entrada
	And informar o CFOP 1102 - {'Compra para comercialização'}
	And informar a origem da Mercadoria {'Nacional - exceto as indicadas nos códigos 3 a 5'}
	And informar o codigo da ST {'Tributada integralmente'}
	And informar no editText o percentual da Aliquota {1}
	And clicar no botao de Salvar itens
	And seja redirecionado para tela de Mercadorias da recepcao
	And o SKU do item da recepcao informado deve aparecer na tabela
	And tenha na coluna Escriturado do item o valor {'Não'}
	And clicar no botao da header Escriturar todos os itens automaticamente
	And seja redirecionado para index de escriturar lote fiscal
	And clicar na aba Configuração
	And selecione o CFOP {1102} Compra para Comercialização
	And clicar no botao Calcular
	And o status do item deve mudar para {'Escriturado'}
	And quando clicar no botao Prosseguir
	And o sistema redirecionada para index de recepçao
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And tenha na coluna Escriturado do item o valor {'Sim'}
	And clicar no botao Finalizar Lançamento de Itens
	And marcar Eu concluí o lançamento de todos os itens
	And clicar no botao Confirmar
	And o sistema redirecionada para index de recepçao
	And o status da recepcao deve ser {'Conferência Física'}
	And seja clicado no botao Conferencia Fisica de Recebimento nas actions
	And seja redirecionado para tela de WMS Conferencia
	And o SKU seja copiado da coluna Código
	And seja colado no editText Código do Produto
	And a quantidade seja copiada da coluna Qtd. Total 
	And seja colada no editText Quantidade
	And eu clicar Enter
	And clicar no botao Concluir Processo
	And clicar no botao Finalizar 
	And ser redirecionado para tela de COM Conferencia Fisica da Recepcao
	And clicar no botao Concluir
	Then o sistema redirecionada para index de recepçao
	And o status da recepcao deve ser {'Aguardando Finalização'} 
	And seja clicado no botao Finalizar Recebimento nas actions
	And seja redirecionado para tela de Finalizar recepcao
	And clicar no botao Finalizar Recepcao
	And o sistema redirecionada para index de recepçao
	And que eu clique no botao da header Gerenciar recepcoes
	And seja redirecionado para index de gerenciar recepcoes
	And que tenha uma recepcao no status {'Finalizado'}
	And memorizo o numero dessa recepcao
	And clicar no botao da action para Excluir recepcao
	And clicar no botao Excluir da modal
	And o sistema redirecionada para index de recepçao
	And acessamos gerenciar recepcoes novamente
	And valido o numero memorizado dessa recepcao
	And o status da recepcao deve ser {'Cancelado'} 
	And feche o navegador quando terminar


@lancar_item_calculo_manual_de_imposto
Scenario: Lancar item calculo Manual de imposto
	Given que seja clicado no botao Novo Lancamento Manual
	And seja redirecionado para tela de criar recepcao	
	And seja informado a operação fiscal {'Recepção de Mercadoria'}
	And seja informado no editText o fornecedor {'New Era Fornecedor LTDA'}
	And seja informado no editText a data de recebimento [data atual]
	And seja informado no editText o Numero do documento 
	And seja informado no editText a Serie do documento {1}
	And seja informado no editText a data de emissao
	And seja informado o modelo de documento {'Nota Fiscal modelo 1 ou 1-A'}
	And clicar no botao Salvar
	And o sistema redirecionada para index de recepçao
	And que tenha uma recepcao no status {'Lançamento'}
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And seja clicado no botao Nova Mercadoria Recebida
	And seja redirecionado para criar item da recepcao
	When selecionar o metodo de calculado {'Manual'}
	And informar o produto SKU {'TST0002'}
	And informar no editText o valor unitario {65}
	And informar no editText a quantidade {10}
	And informar no input o valor bruto
	And informar no input o valor liquido
	And informar no editText o numero do lote
	And informar no editText a data de fabricacao
	And informar no editText a data de validade
	And clicar na aba de Impostos Conforme Documento de Entrada
	And informar o CFOP 1102 - {'Compra para comercialização'}
	And informar a origem da Mercadoria {'Nacional - exceto as indicadas nos códigos 3 a 5'}
	And informar o codigo da ST {'Tributada integralmente'}
	And informar no editText o percentual da Aliquota {1}
	And informar o valor de ICMS calculado
	And informar no input a base de calculo
	And clique na aba PIS
	And informar o codigo de ST do PIS {'Operação Tributável com Alíquota Básica'}
	And informar o tipo de Alíquota PIS {'Alíquota em Percentual'}
	And informar a % da Alíquota {1} PIS
	And informar a base de calculo do PIS
	And informar o valor calculado do PIS
	And clique na aba COFINS
	And informar o codigo de ST do COFINS {'Operação Tributável com Alíquota Básica'}
	And informar o tipo de Alíquota COFINS {'Alíquota em Percentual'}
	And informar a % da Alíquota {1} COFINS
	And informar a base de calculo do COFINS
	And informar o valor calculado do COFINS
	And clicar no botao de Salvar itens
	Then seja redirecionado para tela de Mercadorias da recepcao
	And o SKU do item da recepcao informado deve aparecer na tabela
	And feche o navegador quando terminar




@escriturar_item_mercadoria_recepcao_manual
Scenario: Escriturar item da recepcao (Manual)
	Given que seja clicado no botao Novo Lancamento Manual
	And seja redirecionado para tela de criar recepcao	
	And seja informado a operação fiscal {'Recepção de Mercadoria'}
	And seja informado no editText o fornecedor {'New Era Fornecedor LTDA'}
	And seja informado no editText a data de recebimento [data atual]
	And seja informado no editText o Numero do documento 
	And seja informado no editText a Serie do documento {1}
	And seja informado no editText a data de emissao
	And seja informado o modelo de documento {'Nota Fiscal modelo 1 ou 1-A'}
	And clicar no botao Salvar
	And o sistema redirecionada para index de recepçao
	And que tenha uma recepcao no status {'Lançamento'}
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And seja clicado no botao Nova Mercadoria Recebida
	And seja redirecionado para criar item da recepcao
	When selecionar o metodo de calculado {'Manual'}
	And informar o produto SKU {'TST0002'}
	And informar no editText o valor unitario {65}
	And informar no editText a quantidade {10}
	And informar no input o valor bruto
	And informar no input o valor liquido
	And informar no editText o numero do lote
	And informar no editText a data de fabricacao
	And informar no editText a data de validade
	And clicar na aba de Impostos Conforme Documento de Entrada
	And informar o CFOP 1102 - {'Compra para comercialização'}
	And informar a origem da Mercadoria {'Nacional - exceto as indicadas nos códigos 3 a 5'}
	And informar o codigo da ST {'Tributada integralmente'}
	And informar no editText o percentual da Aliquota {1}
	And informar o valor de ICMS calculado
	And informar no input a base de calculo
	And clique na aba PIS
	And informar o codigo de ST do PIS {'Operação Tributável com Alíquota Básica'}
	And informar o tipo de Alíquota PIS {'Alíquota em Percentual'}
	And informar a % da Alíquota {1} PIS
	And informar a base de calculo do PIS
	And informar o valor calculado do PIS
	And clique na aba COFINS
	And informar o codigo de ST do COFINS {'Operação Tributável com Alíquota Básica'}
	And informar o tipo de Alíquota COFINS {'Alíquota em Percentual'}
	And informar a % da Alíquota {1} COFINS
	And informar a base de calculo do COFINS
	And informar o valor calculado do COFINS
	And clicar no botao de Salvar itens
	And seja redirecionado para tela de Mercadorias da recepcao
	And espere {15} segundos ate as mensagem de valor nao calculado sumirem
	And o SKU do item da recepcao informado deve aparecer na tabela
	And tenha na coluna Escriturado do item o valor {'Não'}
	And clique nas actions para Escriturar 
	And seja redirecionado para tela de EscriturarProduto
	And selecionar o metodo de calculado {'Manual'}
	And informar o CFOP {'Compra para comercialização'}
	And informar a origem da Mercadoria {'Nacional - exceto as indicadas nos códigos 3 a 5'} do ICMS
	And informar o codigo da ST {'Tributada integralmente'} do ICMS
	And informar no input o percentual da Aliquota {1} do ICMS
	And informar no input a base de calculo do ICMS
	And informar no input o valor ICMS
	And clicar na aba PIS
	And informar o codigo da ST {'Operação Tributável com Alíquota Básica'} do PIS
	And informar o tipo de Alíquota {'Alíquota em Percentual'} do PIS
	And informar no input o percentual da Aliquota {1} do PIS
	And informar no input a base de calculo do PIS
	And informar no input o valor PIS
	And clicar na aba COFINS
	And informar o codigo da ST {'Operação Tributável com Alíquota Básica'} do COFINS
	And informar o tipo de Alíquota {'Alíquota em Percentual'} do COFINS
	And informar no input o percentual da Aliquota {1} do COFINS
	And informar no input a base de calculo do COFINS
	And informar no input o valor COFINS
	Then clicar no botao Gravar escrituraçao
	And seja redirecionado para tela de Mercadorias da recepcao
	And tenha na coluna Escriturado do item o valor {'Sim'}
	And feche o navegador quando terminar

