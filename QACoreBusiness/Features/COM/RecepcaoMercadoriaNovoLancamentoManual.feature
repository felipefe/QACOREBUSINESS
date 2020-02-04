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
	And seja informado no editText a data de emissao
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
	When informar o produto SKU {'TST0002'}
	And informar no editText o valor unitario {65,000}
	And informar no editText a quantidade {10,000}
	And informar no editText o numero do lote
	And informar no editText a data de fabricacao
	And informar no editText a data de validade
	And clicar na aba de Impostos Conforme Documento de Entrada
	And informar o CFOP {1102} - Compra para comercializacao
	And informar a origem da Mercadoria {'Nacional - exceto as indicadas nos códigos 3 a 5'}
	And informar o codigo da ST {'Tributada integralmente'}
	And informar no editText o percentual da Aliquota {1,000}
	And clicar no botao de Salvar itens
	Then seja redirecionado para tela de Mercadorias da recepcao
	And o SKU do item da recepcao informado deve aparecer na tabela


@escriturar_item_mercadoria_recepcao
Scenario: Escriturar itens da recepcao
	Given que tenha uma recepcao no status {'Lançamento'}
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And tenha na coluna Escriturado do item o valor {'Não'}
	When clicar no botao da header Escriturar todos os itens automaticamente
	And seja redirecionado para index de escriturar lote fiscal
	And clicar na aba Configuração
	And selecione o CFOP {1102} Compra para Comercialização
	And clicar no botao Calcular
	Then o status do item deve mudar para {'Escriturado'}
	And quando clicar no botao Prosseguir
	And o sistema redirecionada para index de recepçao




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





