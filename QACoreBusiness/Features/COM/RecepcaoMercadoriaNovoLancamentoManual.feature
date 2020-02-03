Feature: RecepcaoMercadoriaNovoLancamentoManual

Background: Estar logado e na index de recepção de mercadoria
Given que eu esteja logado no sistema
And acesse a index de recepcao de mercadoria


@recepcao_mercadoria_novo_lancamento_manual
Scenario: Lancar manualmente nova recepcao de mercadoria
	Given que seja clicado no botao Novo Lancamento Manual
	And seja redirecionado para tela de criar recepcao	
	And seja informado a operação fiscal {'Recepção de Mercadoria'}
	And seja informado no editText o fornecedor {'New Era Fornecedor LTDA'}
	And seja informado no editText a data de recebimento [data atual]
	And seja informado no editText o Numero do documento 
	And seja informado no editText a Serie do documento {1}
	And seja informado no editText a data de emissao [data atual - 5 dias]
	And seja informado o modelo de documento {'Nota Fiscal modelo 1 ou 1-A'}
	When clicar no botao Salvar
	Then o sistema redirecionada para index de recepçao
	And o status da recepcao deve ser {'Lançamento'}


@lancar_itens_recepcao_manual
Scenario: Lancar itens recepcao manual
	Given que tenha uma recepcao no status {'Lançamento'}
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And seja clicado no botao Nova Mercadoria Recebida
	And seja redirecionado para criar item da recepcao
	When informar o produto SKU {TST0002}
	And informar no editText o valor unitario {65,0000}
	And informar no editText a quantidade {10}
	And informar no editText o numero do lote
	And informar no editText a data de fabricacao
	And informar no editText a data de validade
	And clicar na aba de Impostos Conforme Documento de Entrada
	And informar o CFOP {1102} - Compra para comercializacao
	And informar a origem da Mercadoria 0 - {'Nacional - exceto as indicadas nos códigos 3 a 5'}
	And informar o codigo da ST 00 - {'Tributada integralmente'}
	And informar no editText o percentual da Aliquota {1}
	And clicar no botao de Salvar itens
	Then seja redirecionado para tela de Mercadorias da recepcao
	And o SKU do item da recepcao informado deve aparecer na tabela
	And a quantidade informada para o item da recepcao deve aparecer na tabela




@escriturar_item_mercadoria_recepcao
Scenario: Escriturar itens da recepcao
	Given que tenha uma recepcao no status {'Lançamento'}
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And tenha na coluna Escriturado do item o valor {'Não'}
	And clique nas actions para Escriturar 
	And seja redirecionado para tela de EscriturarProduto
	When informar o CFOP {1102} - Compra para comercializacao 
	And informar a origem da Mercadoria 0 - {'Nacional - exceto as indicadas nos códigos 3 a 5'} do ICMS
	And informar o codigo da ST 00 - {'Tributada integralmente'} do ICMS
	And informar no editText o percentual da Aliquota {1} do ICMS
	And clicar na aba PIS
	And informar o codigo da ST 01 - {'Operação Tributável com Alíquota Básica'} do PIS
	And informar o tipo de Alíquota {Alíquota em Percentual} do PIS
	And informar no editText o percentual da Aliquota {1} do PIS
	And clicar na aba COFINS
	And informar o codigo da ST 01 - {'Operação Tributável com Alíquota Básica'} do COFINS
	And informar o tipo de Alíquota {Alíquota em Percentual} do COFINS
	And informar no editText o percentual da Aliquota {1} do COFINS
	And clicar no botao Calcular Escrituraçao
	Then a base de calculo deve ser calculada para COFINS
	And clicar na aba PIS
	And a base de calculo deve ser calculada para PIS
	And clicar na aba ICMS
	And a base de calculo deve ser calculada para ICMS
	And devo clicar no botao Gravar escrituraçao
	And seja redirecionado para tela de Mercadorias da recepcao
	And o item deve aparecer como SIM na coluna escriturado



@finalizar_lancamento_itens_escriturados_recepcao
Scenario: Finalizar lancamento de itens escriturados
	Given que tenha uma recepcao no status {'Lançamento'}
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And tenha na coluna Escriturado do item o valor {'Sim'}
	When clicar no botao Finalizar Lançamento de Itens
	And marcar Eu concluí o lançamento de todos os itens
	And clicar no botao Confirmar
	Then o sistema redirecionada para index de recepçao
	And o status da recepcao deve ser {'Conferência Física'}



##conferencia fisica WMS





