Feature: PedidoInserirEntrega

Background: Ter um pedido criado com cliente adicionado
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Meus Pedidos'}


@criar_entrega_pedido
Scenario: Criar entrega pedido
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And fechar a primeira mensagem de dados do pedido carregado
And eu pesquisar no editText o cliente por CP {34816670947}
And em seguida no botao selecionar
And que eu cliquei na sessao de Entregas
And clicar no botao Definir Entrega
And informar a transportadora {'Transportadora ACME'}
And informar o tipo da entrega como {Entrega}
And inserir uma data prevista em dias {1}
And inserir o valor do frete {50.0}
And clicar em salvar
And espere por {2} segundos ate ser processado
Then uma mensagem de dados atualizado deve aparecer
And feche o navegador quando terminar

@criar_entrega_futura_pedido
Scenario: Criar entrega futura pedido
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And fechar a primeira mensagem de dados do pedido carregado
And eu pesquisar no editText o cliente por CP {34816670947}
And em seguida no botao selecionar
And que eu cliquei na sessao de Entregas
And clicar no botao Definir Entrega
And informar a transportadora {'Transportadora ACME'}
And informar o tipo da entrega como {Entrega Futura}
And inserir uma data prevista em dias {15}
And inserir o valor do frete {50.0}
And clicar em salvar
And espere por {2} segundos ate ser processado
Then uma mensagem de dados atualizado deve aparecer
And feche o navegador quando terminar