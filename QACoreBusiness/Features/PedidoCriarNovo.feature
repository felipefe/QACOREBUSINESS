﻿Feature: PedidoCriarNovo

Background: Estar logado no Corebusiness
Given que usuário esteja logado
And que esteja no hub principal
And acesse o contexto Meus Pedidos

@criar_pedido
Scenario: Criar novo pedido
When o usuario clicar no botao Criar Novo Pedido
Then um novo pedido deve ser criado
And ser redirecionado para tela de ediçao do pedido

