Feature: PedidoInserirVendedor

Background: Ter um pedido criado
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Meus Pedidos'}


@inserir_vendedor_pedido_sucesso
Scenario: Inserir ou trocar vendedor ao pedido
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And fechar a primeira mensagem de dados do pedido carregado
And clicar no botao da action Trocar Vendedor
And for redirecionado para tela de trocar vendedor pedido
And informar o vendedor {'Vendedor Pablo Escobar'}
And clicar no botao trocar vendedor
Then o sistema redireciona para ediçao do pedido
And uma mensagem de dados carregados deve aparecer
And feche o navegador quando terminar


@trocar_vendedor_pedido_falha
Scenario: Inserir vendedor já selecionado ao pedido
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And fechar a primeira mensagem de dados do pedido carregado
And clicar no botao da action Trocar Vendedor
And for redirecionado para tela de trocar vendedor pedido
And informar o vendedor {'Vendedor Pablo Escobar'}
And clicar no botao trocar vendedor
And o sistema redireciona para ediçao do pedido
And clicar no botao da action Trocar Vendedor
When informar o vendedor {'Vendedor Pablo Escobar'}
And clicar no botao trocar vendedor
Then o sistema nao redireciona para ediçao do pedido
And uma mensagem para indicar um vendedor diferente do atual deve aparecer
And feche o navegador quando terminar