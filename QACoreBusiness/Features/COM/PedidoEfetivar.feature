Feature: PedidoEfetivar

Background: Ter um pedido criado
Given que eu esteja logado no sistema
And acesse a index de pedido
And tenha um pedido criado na situaçao {Lançamento/Ediçao}
And clique para editar este pedido
And seja redirecionado para tela de ediçao

@efetivar_pedido_sucesso
Scenario: Efetivar pedido
Given tenha inserido o cliente
And tenha definido entrega
And tenha adicionado itens
And tenha adicionado negociaçao
And tenha adicionado vendedor
When eu clicar no botao Efetivar Pedido
Then o sistema redireciona para index de pedidos
And a situaçao do pedido nao deve estar em {Lançamento/Ediçao}

@efetivar_pedido_falha
Scenario: Falha efetivar pedido
When eu clicar no botao Efetivar Pedido
Then o sistema nao redireciona para tela de pedidos
And uma alerta com as pendencias deve ser exibido 