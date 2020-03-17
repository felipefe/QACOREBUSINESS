Feature: RecepcaoMercadoriaNovoViaNFe
	
Background: Estar logado e na index de recepção de mercadoria
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Recepção de Mercadorias e Serviços'}


@recepcao_mercadoria_novo_via_nfe
Scenario: Importar XML Recepção
	Given que eu clique no botao da header Novo Via NFe
	And selecione o arquivo xml da recepcao
	And informe a operacao fiscal {'Recepção de Mercadoria'}
	When clicar no botao Iniciar importacao da NFe
	Then o status da recepcao deve ser {'Lançamento'}
	And clicar no botao da action para Excluir recepcao
	And clicar no botao Excluir da modal
	And o sistema redirecionada para index de recepçao
	And feche o navegador quando terminar



@escriturar_itens_xml
Scenario: Escriturar itens da recepcao
	Given que eu clique no botao da header Novo Via NFe
	And selecione o arquivo xml da recepcao
	And informe a operacao fiscal {'Recepção de Mercadoria'}
	And clicar no botao Iniciar importacao da NFe
	And que tenha uma recepcao no status {'Lançamento'}
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
	And clicar no botao da action para Excluir recepcao
	And clicar no botao Excluir da modal
	And o sistema redirecionada para index de recepçao
	And feche o navegador quando terminar


@finalizar_lancamento_itens_escriturados
Scenario: Finalizar lancamento de itens escriturados
	Given que eu clique no botao da header Novo Via NFe
	And selecione o arquivo xml da recepcao
	And informe a operacao fiscal {'Recepção de Mercadoria'}
	And clicar no botao Iniciar importacao da NFe
	And que tenha uma recepcao no status {'Lançamento'}
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
	And o status da recepcao deve ser {'Lançamento'}
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And tenha na coluna Escriturado do item o valor {'Sim'}
	And clicar no botao Finalizar Lançamento de Itens
	And marcar Eu concluí o lançamento de todos os itens
	And clicar no botao Confirmar
	And o sistema redirecionada para index de recepçao
	And o status da recepcao deve ser {'Conferência Física'}
	And clique nas actions para Alterar Situação
	And selecione a situaçao {'Lançamento'}
	And clique no botao Salvar situacao
	And o sistema redirecionada para index de recepçao
	And clicar no botao da action para Excluir recepcao
	And clicar no botao Excluir da modal
	And o sistema redirecionada para index de recepçao
	And feche o navegador quando terminar


@finalizar_recepcao_mercadoria
Scenario: Finalizar recepcao de mercadoria
	Given que eu clique no botao da header Novo Via NFe
	And selecione o arquivo xml da recepcao
	And informe a operacao fiscal {'Recepção de Mercadoria'}
	And clicar no botao Iniciar importacao da NFe
	And que tenha uma recepcao no status {'Lançamento'}
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
	And o status da recepcao deve ser {'Lançamento'}
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
	And o codigo sku e qtd. total sejam copidos de suas colunas
	And seja feita a conferencia desses produtos
	And clicar no botao Concluir Processo
	And  uma mensagem de conferido com sucesso deve aparecer
	And clicar no botao Finalizar 
	And ser redirecionado para tela de COM Conferencia Fisica da Recepcao
	And clicar no botao Concluir
	And o sistema redirecionada para index de recepçao
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


#@importar_xml_ja_recepcionado
#Scenario: Importar XML ja recepcionado
#	Given que eu clique no botao da header Novo Via NFe
#	And selecione o arquivo xml da recepcao
#	And informe a operacao fiscal {'Recepção de Mercadoria'}
#	When clicar no botao Iniciar importacao da NFe
#	Then o sistema redirecionada para IDFe/NFe/ImpDestinadasNativo
#	And informa que o lote fiscal ja foi recepcionado
#	And feche o navegador quando terminar



#@excluir_recepcao_mercadoria
#Scenario: Excluir recepcao mercadoria
#Given que eu clique no botao da header Gerenciar recepcoes
#	And seja redirecionado para index de gerenciar recepcoes
#	And que tenha uma recepcao no status {'Finalizado'}
#	And memorizo o numero dessa recepcao
#	When clicar no botao da action para Excluir recepcao
#	And clicar no botao Excluir da modal
#	Then o sistema redirecionada para index de recepçao
#	And acessamos gerenciar recepcoes novamente
#	And valido o numero memorizado dessa recepcao
#	And o status da recepcao deve ser {'Cancelado'} 




#@conferir_item_recepcao
#Scenario: Conferir item recepcao 
#	Given que tenha uma recepcao no status {'Conferência Física'}
#	And seja clicado no botao Conferencia Fisica de Recebimento nas actions
#	And seja redirecionado para tela de WMS Conferencia
#	And o codigo sku e qtd. total sejam copidos de suas colunas
#	And seja feita a conferencia desses produtos
#	When clicar no botao Concluir Processo
#	Then  uma mensagem de conferido com sucesso deve aparecer
#
#
#@concluir_conferencia_finalizada
#Scenario: Concluir conferencia recepcao
#	Given que tenha uma recepcao no status {'Conferência Física'}
#	And seja clicado no botao Conferencia Fisica de Recebimento nas actions
#	And seja redirecionado para tela de WMS Conferencia
#	And uma mensagem de Conferência Finalizada deve aparecer
#	When clicar no botao Finalizar 
#	And ser redirecionado para tela de COM Conferencia Fisica da Recepcao
#	And clicar no botao Concluir
#	Then o sistema redirecionada para index de recepçao
#	And o status da recepcao deve ser {'Aguardando Finalização'} 

