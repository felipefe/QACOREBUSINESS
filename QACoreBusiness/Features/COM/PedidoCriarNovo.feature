Feature: PedidoCriarNovo

Background: Estar logado no Corebusiness
Given que eu esteja logado no sistema
And que esteja no hub principal
And clicar para acessar o contexto {'Meus Pedidos'}

@criar_pedido
Scenario: Criar novo pedido
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
Then seja redirecionado para tela de ediçao
And feche o navegador quando terminar

@efetivar_pedido_falha
Scenario: Falha efetivar pedido
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And eu clicar no botao Efetivar Pedido
Then o sistema nao redireciona para tela de pedidos
And uma alerta com as pendencias deve ser exibido 
And feche o navegador quando terminar

@criar_e_efetivar_pedido
Scenario: Criar e efetivar pedido
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And eu pesquisar no editText o cliente por CP {34816670947}
And em seguida no botao selecionar
And que eu cliquei na sessao de Entregas
And clicar no botao Definir Entrega
And informar a transportadora {'Transportadora ACME'}
And informar o tipo da entrega como {Entrega}
And inserir uma data prevista em dias {1}
And inserir o valor do frete {50.0}
And clicar em salvar
And que eu clique na sessao de Produtos
And eu pesquisar no editText o produto por SKU {'TST0001'}
And informar a quantidade no editText
And em seguida clicar no botao adicionar  
And que eu cliquei na sessao de Pagamento
And eu clicar no botao Criar Negociaçao
And inserir uma descriçao no editText {'primeira negociacao'}
And selecionar a forma de pagamento {'A vista no Dinheiro'}
And clicar no botao Salvar Negociaçao
And clicar no botao da action Trocar Vendedor
And informar o vendedor {'Vendedor Pablo Escobar'}
And clicar no botao trocar vendedor
And eu clicar no botao Efetivar Pedido
Then o sistema redireciona para index de pedidos
And a situaçao do pedido deve ser {'Avaliação'}
And feche o navegador quando terminar


@criar_e_efetivar_pedido_restricao
Scenario: Criar e efetivar pedido restrição
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And eu pesquisar no editText o cliente por CP {55918366903}
And em seguida no botao selecionar
And que eu cliquei na sessao de Entregas
And clicar no botao Definir Entrega
And informar a transportadora {'Transportadora ACME'}
And informar o tipo da entrega como {Entrega}
And inserir uma data prevista em dias {1}
And inserir o valor do frete {50.0}
And clicar em salvar
And que eu clique na sessao de Produtos
And eu pesquisar no editText o produto por SKU {'TST0001'}
And informar a quantidade no editText
And em seguida clicar no botao adicionar  
And que eu cliquei na sessao de Pagamento
And eu clicar no botao Criar Negociaçao
And inserir uma descriçao no editText {'primeira negociacao'}
And selecionar a forma de pagamento {'Boleto 30/60/90'}
And clicar no botao Salvar Negociaçao
And clicar no botao da action Trocar Vendedor
And informar o vendedor {'Vendedor Pablo Escobar'}
And clicar no botao trocar vendedor
And eu clicar no botao Efetivar Pedido
Then o sistema redireciona para index de pedidos
And a situaçao do pedido deve ser {'Avaliação'}
And feche o navegador quando terminar
