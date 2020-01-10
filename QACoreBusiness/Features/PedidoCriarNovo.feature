Feature: PedidoCriarNovo

Background: Estar logado no Corebusiness
Given que usuário esteja logado

@criar_pedido
Scenario: Acessar Meus pedidos e criar o pedido
Given que o usuario esteja no hub principal
And acesse o contexto Meus Pedidos
When clicar em criar novo pedido
Then um novo pedido deve ser criado


