Feature: PedidoSeparacao

Background: Estar logado no Corebusiness 
			e estar na tela de pedidos
			e ter um pedido em separaçao
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Meus Pedidos'}
And tenha um pedido criado na situaçao {'Separação'}

@separar_itens_pedido
Scenario: Separar itens pedido
Given que eu acesse as actions do pedido
And clique no botao Separaçao
And seja redirecionado para tela WMS Separaçao
And clique no botao Definir todos
And uma mensagem de sucesso aparecera {'Modificado o responsável de todos os itens.'}
And depois clicar no botao Marcar Todos
And uma mensagem de sucesso deve aparecer {'Os itens foram marcados como separados.'}
When eu clicar no botao Finalizar
And ser redicionado para a tela COM Finalizar Separaçao
And clicar no botao Finalizar Separaçao
Then serei redirecionado para index de pedidos
And a situaçao do pedido deve ser {'Conferência'}