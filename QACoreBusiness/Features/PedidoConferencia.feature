Feature: PedidoConferencia

Background: Estar logado no Corebusiness 
			e estar na tela de pedidos
			e ter um pedido em conferencia
Given que o usuario esteja logado
And acesse o contexto de meus pedidos
And tenha um pedido em situaçao de Conferência


@conferir_item_pedido
Scenario: Conferir item pedido
Given que eu acesse as actions do pedido
And clique no botao Conferencia
And seja redirecionado para tela de WMS Conferencia
And o SKU seja copiado da coluna Código
And seja colado no editText Código do Produto
And a quantidade seja copiada da coluna Qtd. Total 
And seja colada no editText Quantidade
When eu clicar Enter
Then  uma mensagem de conferido com sucesso deve aparecer


@conferencia_pedido_quantidade_errada
Scenario: Conferencia de pedido quantidade errada
Given que eu acesse as actions do pedido
And clique no botao Conferencia
And seja redirecionado para tela de WMS Conferencia
And o SKU seja copiado da coluna Código
And seja colado no editText Código do Produto
And a quantidade seja copiada da coluna Qtd. Total 
And seja colada no editText Quantidade uma quantidade diferente da copiada
When eu clicar Enter
Then a quantidade da coluna Qtd. Conferida deve ser diferente da coluna Qtd. Total


@conferencia_pedido_codigo_errado
Scenario: Conferencia de pedido codigo errado
Given que eu acesse as actions do pedido
And clique no botao Conferencia
And seja redirecionado para tela de WMS Conferencia
And o SKU seja copiado da coluna Código
And seja colado no editText Código do Produto um código diferente do copiado
And a quantidade seja copiada da coluna Qtd. Total 
And seja colada no editText Quantidade
When eu clicar Enter
Then uma mensagem de Codigo Invalido é exibida


@reiniciar_processo_conferencia
Scenario: Reiniciar processo conferencia pedido
Given que eu acesse as actions do pedido
And clique no botao Conferencia
And seja redirecionado para tela de WMS Conferencia
When eu clicar no botao Reiniciar Processo
And confirmar clicando no botao OK do alerta exibido
Then uma mensagem de reiniciado com sucesso deve aparecer
And a coluna Qtd. Conferida deve ser zero


@concluir_processo_conferencia_pedido
Scenario: Concluir o processo de conferencia do pedido
Given que eu acesse as actions do pedido
And clique no botao Conferencia
And seja redirecionado para tela de WMS Conferencia
And tenha conferido corretamente os itens do pedido
When clicar no botao Concluir Processo
Then uma mensagem de Conferência Finalizada deve aparecer


@finalizar_processo_conferencia_pedido
Scenario:  Finalizar o processo de conferencia do pedido
Given que eu acesse as actions do pedido
And clique no botao Conferencia
And seja redirecionado para tela de WMS Conferencia
And tenha conferido corretamente os itens do pedido
And clicar no botao Concluir Processo
When clicar no botao Finalizar 
And ser redirecionado para tela de COM Finalizar Conferencia
And clicar em Finalizar Conferencia
Then o sistema deverá redirecionar para tela Entrega e Remessas do Pedido


#################################################

#@conferencia_pedido
#Scenario: Conferencia de pedido
#Given que eu acesse as actions do pedido
#And clique no botao Conferencia
#And seja redirecionado para tela de WMS Conferencia
#And o SKU seja copiado da coluna Código
#And seja colado no editText Código do Produto
#And a quantidade seja copiada da coluna Qtd. Total 
#And seja colada no editText Quantidade
#When eu clicar Enter
#And uma mensagem de conferido com sucesso deve aparecer
#And eu clicar em Concluir processo
#And clicar em finalizar
#And ser redirecionado para tela de COM Finalizar Conferencia
#And selecionar a proxima operaçao como Emitir NFe
#Then clicar em Finalizar Conferencia
#And o sistema deverá redirecionar para tela Entrega e Remessas do Pedido







