Feature: PedidoRemoverItem

Background: Ter um pedido criado
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Meus Pedidos'}
And tenha um pedido criado na situaçao {'Lançamento / Edição'}
And clique para editar este pedido
And seja redirecionado para tela de ediçao

Scenario: Remover item de pedido
Given que o pedido tenha itens
And que eu cliquei nas action do item do pedido
When clicar no botao remover item
Then o item deve ser removido
And uma mensagem de dados atualizado deve aparecer