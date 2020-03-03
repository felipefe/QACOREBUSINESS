Feature: PedidoInserirItem

Background: Ter um pedido criado
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Meus Pedidos'}


@inserir_item_pedido_por_sku 
Scenario: Inserir item com reserva ao pedido por sku
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And fechar a primeira mensagem de dados do pedido carregado
And que eu clique na sessao de Produtos
And eu pesquisar no editText o produto por SKU {'TST0001'}
And informar a quantidade no editText
And em seguida clicar no botao adicionar  
Then uma mensagem de item adicionado ao pedido deve aparecer
And sua tag de reserva estoque deve ser {'Normal'}

@inserir_item_pedido_por_nome 
Scenario: Inserir item com reserva ao pedido por nome
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And fechar a primeira mensagem de dados do pedido carregado
And que eu clique na sessao de Produtos
And eu pesquisar no editText o produto por nome {'Boné Oakley'}
And informar a quantidade no editText
And em seguida clicar no botao adicionar 
Then uma mensagem de item adicionado ao pedido deve aparecer
And sua tag de reserva estoque deve ser {'Normal'}

@inserir_item_sem_reserva_pedido 
Scenario: Inserir item ao pedido sem reserva
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And fechar a primeira mensagem de dados do pedido carregado
And que eu clique na sessao de Produtos
And eu pesquisar no editText o produto por SKU {'TST0003'}
And informar a quantidade no editText
And em seguida clicar no botao adicionar 
Then uma mensagem de item adicionado ao pedido deve aparecer
And sua tag de reserva estoque deve ser {'Sem reserva'}

@inserir_item_invalido_pedido
Scenario: Item nao inserido ao pedido 
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And fechar a primeira mensagem de dados do pedido carregado
And que eu clique na sessao de Produtos
And eu pesquisar no editText o produto por SKU {'TST0004'} 
And informar a quantidade no editText
And em seguida clicar no botao adicionar 
Then uma mensagem de item nao adicionado ao pedido deve aparecer
And uma outra mensagem com os detalhes deve aparecer