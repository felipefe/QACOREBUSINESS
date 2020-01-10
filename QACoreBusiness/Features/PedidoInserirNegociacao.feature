Feature: PedidoInserirNegociacao

Background: Ter um pedido criado que possua item
Given que eu tenha um pedido criado que possua item
And valor liquido maior que zero

@inserir_negociacao_pedido
Scenario: Inserir negociçao ao pedido
Given que eu esteja na tela de ediçao do pedido
And clique na sessao de Pagamento
When eu clicar em Criar Negociaçao
And inserir uma descriçao
And selecionar a forma de pagamento {Avista - Dinheiro}
And clicar em salvar negociaçao
Then o valor total geral da negocição deve ser maior que zero
And uma mensagem de dados atualizados deve aparecer