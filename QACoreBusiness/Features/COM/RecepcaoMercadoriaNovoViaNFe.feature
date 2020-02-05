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
