Feature: PedidoInserirEntrega

Background: Ter um pedido criado com cliente adicionado
Given que eu tenha um pedido criado
And já tenha informado o cliente

@criar_entrega_pedido
Scenario: Criar entrega pedido
Given que eu esteja na tela de ediçao do pedido
And tenha clicado na sessão de Entregas
When clicar em definir entrega
And informar a transportadora {Braspress}
And informar o tipo da entrega como {Entrega}
And inserir uma data prevista {data atual + 1}
And inserir o valor do frete {50 R$}
And clicar em salvar
Then uma mensagem de dados atualizado deve aparecer

@criar_entrega_futura_pedido
Scenario: Criar entrega futura pedido
Given que eu esteja na tela de ediçao do pedido
And tenha clicado na sessão de Entregas
When clicar em definir entrega
And informar a transportadora {Braspress}
And informar o tipo da entrega como {Entrega Futura}
And inserir uma data prevista {data atual + 15}
And inserir o valor do frete {50 R$}
And clicar em salvar
Then uma mensagem de dados atualizado deve aparecer