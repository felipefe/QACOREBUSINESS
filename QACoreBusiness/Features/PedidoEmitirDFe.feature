Feature: PedidoEmitirDFe

Background: Estar logado no Corebusiness 
			e estar na tela de pedidos
			e ter um pedido em emissao de documentos fiscais
			e o serviço do coreservice esteja rodando
			e esteja em ambiente de homologação
Given que usuario esteja logado
And acesse o contexto de meus pedidos
And que eu tenha um pedido em situaçao de emissao de documentos fiscais
And o serviço coreservice esteja rodando
And esteja em ambiente de homologacao
#verificar situacao para coreservice e ambiente de homologaçao

@emitir_documentos_fiscais
Scenario: Emitir documento fiscal
Given que eu acesse as actions do pedido
When clicar no botao Emitir Documentos Fiscais
Then o pedido deve ir para Gerenciar Pedidos
And a situaçao deve ser alterada para Operaçao Concluida
#validar situaçao desse cenario apos clicar em emitir DFe


@emitir_documentos_fiscais_monitorado
Scenario: Emitir documento fiscal monitorado
Given que eu acesse as actions do pedido
When clicar no botao Emitir Documentos Fiscais
And acessar as action do pedido novamente
And clicar no botao Documentos Fiscais Gerados
And ser redirecionado para tela COM Documentos de Venda
Then a situaçao de venda deste pedido deve ser Autorizado o uso da NF-e