Feature: PedidoInserirItem

Background: Ter um pedido criado
Given que eu tenha um pedido criado

@inserir_item_valido_pedido 
Scenario: Inserir item ao pedido 
Given que eu esteja na tela de ediçao do pedido
And clique na sessão de Produtos
When eu pesquisar o produto por SKU {QA999} ou por nome {JBL Charge 3}
And eu clicar no item 
And em seguida clicar em adicionar 
Then uma mensagem de item adicionado ao pedido deve aparecer
And sua tag de reserva estoque deve ser {Normal}

@inserir_item_sem_reserva_pedido 
Scenario: Inserir item ao pedido sem reserva
Given que eu esteja na tela de ediçao do pedido
And clique na sessão de Produtos
When eu pesquisar o produto por SKU {QA666} ou por nome {JBL Flip 4}
And eu clicar no item 
And em seguida clicar em adicionar 
Then uma mensagem de item adicionado ao pedido deve aparecer
And sua tag de reserva estoque deve ser {Sem reserva}

@inserir_item_invalido_pedido
Scenario: Item nao inserido ao pedido 
Given que eu esteja na tela de ediçao do pedido
And clique na sessão de Produtos
When eu pesquisar o produto por SKU {QA333} ou por nome {JBL GO 2}
And eu clicar no item 
And em seguida clicar em adicionar 
Then uma mensagem de item nao adicionado ao pedido 
And uma outra mensagem com os detalhes deverao aparecer