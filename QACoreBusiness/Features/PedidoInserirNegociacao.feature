Feature: PedidoInserirNegociacao

Background: Ter um pedido criado que possua item
Given que eu tenha um pedido criado
And que eu esteja na tela de ediçao do pedido
And o pedido possua itens
And valor liquido maior que zero

@inserir_negociacao_pedido
Scenario: Inserir negociçao ao pedido
Given que eu cliquei na sessao de Pagamento
When eu clicar no botao Criar Negociaçao
And inserir uma descriçao no editText
And selecionar a forma de pagamento {Avista - Dinheiro}
And clicar no botao Salvar Negociaçao
Then o valor total geral da negociçao deve ser maior que zero
And uma mensagem de dados atualizados deve aparecer