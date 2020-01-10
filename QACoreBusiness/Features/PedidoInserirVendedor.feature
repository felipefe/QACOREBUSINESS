﻿Feature: PedidoInserirVendedor

Background: Ter um pedido criado
Given que eu tenha um pedido criado

@trocar_vendedor_pedido_sucesso
Scenario: Inserir ou trocar vendedor ao pedido
Given que eu esteja na tela de ediçao do pedido
When clicar em trocar vendedor
And for redirecionado para tela de trocar vendedor pedido
And selecionar o vendedor 
And clicar no botao trocar vendedor
Then o sistema redireciona para ediçao do pedido
And uma mensagem de dados atualizados deve aparecer

@trocar_vendedor_pedido_falha
Scenario: Inserir vendedor já selecionado ao pedido
Given que eu esteja na tela de ediçao do pedido
When clicar em trocar vendedor
And for redirecionado para tela de trocar vendedor pedido
And selecionar o vendedor
And clicar no botao trocar vendedor
Then o sistema nao redireciona para ediçao do pedido
And uma mensagem para indicar um vendedor diferente do atual deve aparecer