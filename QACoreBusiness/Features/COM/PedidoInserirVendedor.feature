Feature: PedidoInserirVendedor

Background: Ter um pedido criado
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Meus Pedidos'}
And tenha um pedido criado na situaçao {'Lançamento / Edição'}
And clique para editar este pedido
And seja redirecionado para tela de ediçao
And clicar no botao da action Trocar Vendedor
And for redirecionado para tela de trocar vendedor pedido

@inserir_vendedor_pedido_sucesso
Scenario: Inserir ou trocar vendedor ao pedido
When informar o vendedor {'Vendedor Pablo Escobar'}
And clicar no botao trocar vendedor
Then o sistema redireciona para ediçao do pedido
And uma mensagem de dados carregados deve aparecer

@trocar_vendedor_pedido_falha
Scenario: Inserir vendedor já selecionado ao pedido
Given que o pedido ja tenha um vendedor informado
When informar o vendedor {'Vendedor Pablo Escobar'}
And clicar no botao trocar vendedor
Then o sistema nao redireciona para ediçao do pedido
And uma mensagem para indicar um vendedor diferente do atual deve aparecer