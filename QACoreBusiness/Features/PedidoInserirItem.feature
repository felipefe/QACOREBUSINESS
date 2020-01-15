Feature: PedidoInserirItem

Background: Ter um pedido criado
Given que eu tenha um pedido criado
And esteja na tela de ediçao do pedido

@inserir_item_pedido_por_sku 
Scenario: Inserir item com reserva ao pedido por sku
Given que eu clique na sessão de Produtos
When eu pesquisar no editText o produto por SKU {TST00001}
And eu clicar no item 
And em seguida clicar em adicionar 
Then uma mensagem de item adicionado ao pedido deve aparecer
And sua tag de reserva estoque deve ser {Normal}

@inserir_item_pedido_por_nome 
Scenario: Inserir item com reserva ao pedido por nome
Given que eu clique na sessão de Produtos
When eu pesquisar no editText o produto por nome {Boné Oakley}
And eu clicar no item 
And em seguida clicar em adicionar 
Then uma mensagem de item adicionado ao pedido deve aparecer
And sua tag de reserva estoque deve ser {Normal}

@inserir_item_sem_reserva_pedido 
Scenario: Inserir item ao pedido sem reserva
Given que eu clique na sessão de Produtos
When eu pesquisar no editText o produto por SKU {TST00002} 
And eu clicar no item 
And em seguida clicar em adicionar 
Then uma mensagem de item adicionado ao pedido deve aparecer
And sua tag de reserva estoque deve ser {Sem reserva}

@inserir_item_invalido_pedido
Scenario: Item nao inserido ao pedido 
Given que eu clique na sessão de Produtos
When eu pesquisar no editText o produto por SKU {TST0003} 
And eu clicar no item 
And em seguida clicar em adicionar 
Then uma mensagem de item nao adicionado ao pedido deve aparecer
And uma outra mensagem com os detalhes deverao aparecer