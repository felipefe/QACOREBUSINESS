Feature: PedidoConferencia

Background: Estar logado no Corebusiness 
			e estar na tela de pedidos
			e ter um pedido em conferencia
Given que eu esteja logado no sistema
And acesse a index de pedido
And tenha um pedido criado na situaçao {Conferência}

@conferir_item_pedido
Scenario: Conferir item pedido
Given que eu acesse as actions do pedido
And clique no botao Conferencia
And seja redirecionado para tela de WMS Conferencia
And o SKU seja copiado da coluna Código
And seja colado no editText Código do Produto
And a quantidade seja copiada da coluna Qtd. Total 
And seja colada no editText Quantidade
And eu clicar Enter
When clicar no botao Concluir Processo
Then  uma mensagem de conferido com sucesso deve aparecer


@conferir_quantidade_errada
Scenario: Conferir quantidade errada
Given que eu acesse as actions do pedido
And clique no botao Conferencia
And seja redirecionado para tela de WMS Conferencia
And o SKU seja copiado da coluna Código
And seja colado no editText Código do Produto
And a quantidade seja copiada da coluna Qtd. Total 
And seja colada no editText Quantidade uma quantidade diferente da copiada
When eu clicar Enter
Then a quantidade da coluna Qtd. Conferida deve ser diferente da coluna Qtd. Total


@conferir_codigo_errado
Scenario: Conferir codigo errado
Given que eu acesse as actions do pedido
And clique no botao Conferencia
And seja redirecionado para tela de WMS Conferencia
And o SKU seja copiado da coluna Código
And seja colado no editText Código do Produto um código diferente do copiado
And a quantidade seja copiada da coluna Qtd. Total 
And seja colada no editText Quantidade
When eu clicar Enter
Then uma mensagem de Codigo Invalido é exibida


@conferir_e_reiniciar_processo
Scenario: Conferir e reiniciar processo
Given que eu acesse as actions do pedido
And clique no botao Conferencia
And seja redirecionado para tela de WMS Conferencia
And o SKU seja copiado da coluna Código
And seja colado no editText Código do Produto um código diferente do copiado
And eu clicar Enter
When eu clicar no botao Reiniciar Processo
And confirmar clicando no botao OK do alerta exibido
Then uma mensagem de reiniciado com sucesso deve aparecer
And a coluna Qtd. Conferida deve ser zero

@reiniciar_conferencia_finalizada
Scenario: Reiniciar conferencia finalizada
Given que eu acesse as actions do pedido
And clique no botao Conferencia
And seja redirecionado para tela de WMS Conferencia
And uma mensagem de Conferência Finalizada deve aparecer
When eu clicar no botao Reiniciar Processo Conferencia
And confirmar clicando no botao OK do alerta exibido
Then uma mensagem de reiniciado com sucesso deve aparecer
And a coluna Qtd. Conferida deve ser zero

@concluir_conferencia_finalizada
Scenario: Concluir conferencia finalizada
Given que eu acesse as actions do pedido
And clique no botao Conferencia
And seja redirecionado para tela de WMS Conferencia
And uma mensagem de Conferência Finalizada deve aparecer
When clicar no botao Finalizar 
And ser redirecionado para tela de COM Finalizar Conferencia
And clicar em Finalizar Conferencia
Then o sistema deve redirecionar para tela Entrega e Remessas do Pedido 


@conferir_e_concluir_todo_processo_conferencia
Scenario:  Conferir e concluir todo processo de conferencia
Given que eu acesse as actions do pedido
And clique no botao Conferencia
And seja redirecionado para tela de WMS Conferencia
And o SKU seja copiado da coluna Código
And seja colado no editText Código do Produto
And a quantidade seja copiada da coluna Qtd. Total 
And seja colada no editText Quantidade
And eu clicar Enter
And clicar no botao Concluir Processo
When clicar no botao Finalizar 
And ser redirecionado para tela de COM Finalizar Conferencia
And clicar em Finalizar Conferencia
Then o sistema deve redirecionar para tela Entrega e Remessas do Pedido


