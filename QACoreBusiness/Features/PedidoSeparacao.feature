Feature: PedidoSeparacao

Background: Estar logado no Corebusiness 
			e estar na tela de pedidos
			e ter um pedido em separaçao
Given que o usuario esteja logado
And acesse o contexto de meus pedidos
And tenha um pedido em situaçao de Separaçao

@separar_itens_pedido
Scenario: Separar itens pedido
Given que eu acesse as actions do pedido
And clique no botao Separaçao
And seja redirecionado para tela WMS Separaçao
And clique no botao Definir todos
And depois clicar no botao Marcar Todos
When eu clicar no botao Finalizar
And ser redicionado para a tela COM Finalizar Separaçao
And clicar no botao Finalizao Separaçao
Then ser redirecionado para tela de WMS Conferencia