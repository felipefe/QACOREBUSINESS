Feature: PedidoAvaliacao

Background: Estar logado no Corebusiness 
			e estar na tela de pedidos
			e ter um pedido em avaliaçao
Given que usuário esteja logado
And acesse o contexto de meus pedidos
And que eu tenha um pedido em situaçao de avaliçao

@avaliar_pedido
Scenario: Avaliar pedido e prosseguir
Given que eu acesse as actions do pedido
And clique no botao Avaliaçao do Pedido
And seja redirecionado para tela de avaliar pedido
When eu clicar no botao Liberar e Prosseguir
Then serei redirecionado para tela WMS Separaçao

@bloquear_pedido
Scenario: Bloquear pedido
Given que eu acesse as actions do pedido
And clique no botao Avaliaçao do Pedido
And seja redirecionado para tela de avaliar pedido
When eu clicar no botao Bloquear 
Then serei redirecionado para index de pedido
And a situaçao do pedido deve ser Não Liberado / Recusado

@cancelar_retornar_pedido_para_ediçao
Scenario: Cancelar e retornar pedido para ediçao
Given que eu acesse as actions do pedido
And clique no botao Avaliaçao do Pedido
And seja redirecionado para tela de avaliar pedido
When eu clicar no botao Cancelar e Retornar Pedido para Edição
Then serei redirecionado para index de pedido
And a situaçao do pedido deve ser Lançamento / Ediçao

