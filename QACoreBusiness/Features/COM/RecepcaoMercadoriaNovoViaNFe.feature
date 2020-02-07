Feature: RecepcaoMercadoriaNovoViaNFe
	
Background: Estar logado e na index de recepção de mercadoria
Given que eu esteja logado no sistema
And acesse a index de recepcao de mercadoria


@recepcao_mercadoria_novo_via_nfe
Scenario: Importar XML Recepção
	Given que eu clique no botao da header Novo Via NFe
	And selecione o arquivo xml da recepcao
	And informe a operacao fiscal {'Recepção de Mercadoria'}
	When clicar no botao Iniciar importacao da NFe
	Then o status da recepcao deve ser {'Lançamento'}


@escriturar_itens_xml
Scenario: Escriturar itens da recepcao
	Given que tenha uma recepcao no status {'Lançamento'}
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And tenha na coluna Escriturado do item o valor {'Não'}
	When clicar no botao da header Escriturar todos os itens automaticamente
	And seja redirecionado para index de escriturar lote fiscal
	And clicar na aba Configuração
	And selecione o CFOP {1102} Compra para Comercialização
	And selecione o protocolo ICMS de destino/empresa {'ICMS_SC_01'}
	And selecione os impostos federais {'Impostos Federais - Compra para comercialização'}
	And clicar no botao Calcular
	Then o status do item deve mudar para {'Escriturado'}
	And quando clicar no botao Prosseguir
	And o sistema redirecionada para index de recepçao


@finalizar_lancamento_itens_escriturados
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



@conferir_item_recepcao
Scenario: Conferir item recepcao 
	Given que tenha uma recepcao no status {'Conferência Física'}
	And seja clicado no botao Conferencia Fisica de Recebimento nas actions
	And seja redirecionado para tela de WMS Conferencia
	And o codigo sku e qtd. total sejam copidos de suas colunas
	And seja feita a conferencia desses produtos
	When clicar no botao Concluir Processo
	Then  uma mensagem de conferido com sucesso deve aparecer


@concluir_conferencia_finalizada
Scenario: Concluir conferencia recepcao
	Given que tenha uma recepcao no status {'Conferência Física'}
	And seja clicado no botao Conferencia Fisica de Recebimento nas actions
	And seja redirecionado para tela de WMS Conferencia
	And uma mensagem de Conferência Finalizada deve aparecer
	When clicar no botao Finalizar 
	And ser redirecionado para tela de COM Conferencia Fisica da Recepcao
	And clicar no botao Concluir
	Then o sistema redirecionada para index de recepçao
	And o status da recepcao deve ser {'Aguardando Finalização'} 


@finalizar_recepcao_mercadoria
Scenario: Finalizar recepcao de mercadoria
	Given que tenha uma recepcao no status {'Aguardando Finalização'}
	And seja clicado no botao Finalizar Recebimento nas actions
	And seja redirecionado para tela de Finalizar recepcao
	When clicar no botao Finalizar Recepcao
	Then o sistema redirecionada para index de recepçao


@importar_xml_ja_recepcionado
Scenario: Importar XML ja recepcionado
	Given que eu clique no botao da header Novo Via NFe
	And selecione o arquivo xml da recepcao
	And informe a operacao fiscal {'Recepção de Mercadoria'}
	When clicar no botao Iniciar importacao da NFe
	Then o sistema redirecionada para IDFe/NFe/ImpDestinadasNativo
	And informa que o lote fiscal ja foi recepcionado



@excluir_recepcao_mercadoria
Scenario: Excluir recepcao mercadoria
Given que eu clique no botao da header Gerenciar recepcoes
	And seja redirecionado para index de gerenciar recepcoes
	And que tenha uma recepcao no status {'Finalizado'}
	And memorizo o numero dessa recepcao
	When clicar no botao da action para Excluir recepcao
	And clicar no botao Excluir da modal
	Then o sistema redirecionada para index de recepçao
	And acessamos gerenciar recepcoes novamente
	And valido o numero memorizado dessa recepcao
	And o status da recepcao deve ser {'Cancelado'} 
