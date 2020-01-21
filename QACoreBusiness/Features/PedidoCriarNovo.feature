Feature: PedidoCriarNovo

Background: Estar logado no Corebusiness
Given que eu esteja logado no sistema
And que esteja no hub principal
And acesse a index de pedido

@criar_pedido
Scenario: Criar novo pedido
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
Then seja redirecionado para tela de ediçao


