Feature: PedidoEfetivar

Background: Ter um pedido criado
Given que eu tenha um pedido criado
And que eu esteja na tela de ediçao do pedido

@efetivar_pedido_sucesso
Scenario: Efetivar pedido
Given tenha inserido o cliente
And tenha definido entrega
And tenha adicionado itens
And tenha adicionado negociaçao
And tenha adicionado vendedor
When eu clicar no botao Efetivar Pedido
Then o sistema redireciona para tela de pedidos

@efetivar_pedido_falha
Scenario: Falha efetivar pedido
When eu clicar no botao Efetivar Pedido
Then o sistema não redireciona para tela de pedidos
And uma alerta com as pendencias é exibido 