Feature: PedidoInserirEntrega

Background: Ter um pedido criado com cliente adicionado
Given que eu esteja logado no sistema
And acesse a index de pedido
And tenha um pedido criado na situaçao {Lançamento/Ediçao}
And clique para editar este pedido
And seja redirecionado para tela de ediçao
And já tenha informado o cliente

@criar_entrega_pedido
Scenario: Criar entrega pedido
Given que eu cliquei na sessao de Entregas
When clicar no botao Definir Entrega
And informar a transportadora {'Transportadora ACME'}
And informar o tipo da entrega como {Entrega}
And inserir uma data prevista em dias {1}
And inserir o valor do frete {50,00}
And clicar em salvar
Then uma mensagem de dados atualizado deve aparecer

@criar_entrega_futura_pedido
Scenario: Criar entrega futura pedido
Given que eu cliquei na sessao de Entregas
When clicar no botao Definir Entrega
And informar a transportadora {'Transportadora ACME'}
And informar o tipo da entrega como {Entrega Futura}
And inserir uma data prevista em dias {15}
And inserir o valor do frete {50,00}
And clicar em salvar
Then uma mensagem de dados atualizado deve aparecer