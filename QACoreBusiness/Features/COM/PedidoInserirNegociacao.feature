Feature: PedidoInserirNegociacao

Background: Ter um pedido criado que possua item
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Meus Pedidos'}


@inserir_negociacao_sem_cliente_definido
Scenario: Negociacao sem cliente informado
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And fechar a primeira mensagem de dados do pedido carregado
And que eu clique na sessao de Produtos
And eu pesquisar no editText o produto por SKU {'TST0001'}
And informar a quantidade no editText
And em seguida clicar no botao adicionar  
And que eu nao tenha informado o cliente
And que eu cliquei na sessao de Pagamento
When eu clicar no botao Criar Negociaçao
Then um alerta é exibido para informar o cliente
And feche o navegador quando terminar


@inserir_negociacao_sem_itens_pedido
Scenario: Negociacao sem itens de pedido
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And fechar a primeira mensagem de dados do pedido carregado
And eu pesquisar no editText o cliente por CP {34816670947}
And em seguida no botao selecionar
And nao tenha itens adicionados ao pedido
And que eu cliquei na sessao de Pagamento
When eu clicar no botao Criar Negociaçao
Then um alerta é exibido sobre pedido sem itens
And feche o navegador quando terminar


@inserir_negociacao_pedido
Scenario: Inserir negociçao ao pedido
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And fechar a primeira mensagem de dados do pedido carregado
And eu pesquisar no editText o cliente por CP {34816670947}
And em seguida no botao selecionar
And que eu clique na sessao de Produtos
And eu pesquisar no editText o produto por SKU {'TST0001'}
And informar a quantidade no editText
And em seguida clicar no botao adicionar  
And que eu cliquei na sessao de Pagamento
And eu clicar no botao Criar Negociaçao
And inserir uma descriçao no editText {'primeira negociacao'}
And selecionar a forma de pagamento {'A vista no Dinheiro'}
And espere por {2} segundos ate ser processado
And clicar no botao Salvar Negociaçao
Then o valor total geral da negociçao deve ser maior que zero
And uma mensagem de dados atualizado deve aparecer
And feche o navegador quando terminar

#@inserir_negociacao_pedido_sem_informar_fp
#Scenario: Inserir negociçao ao pedido sem inserir forma de pagamento
#Given já tenha informado o cliente
#And valor do pedido seja maior que zero
#And que eu cliquei na sessao de Pagamento
#When eu clicar no botao Criar Negociaçao
#And inserir uma descriçao no editText {'primeira negociacao'}
#And clicar no botao Salvar Negociaçao
#Then uma mensagem de campo obrigatorio deve aparecer {'This field is required.'}