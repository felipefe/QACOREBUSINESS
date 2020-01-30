﻿Feature: PedidoAvaliacao

Background: Estar logado no Corebusiness 
			e estar na tela de pedidos
			e ter um pedido em avaliaçao
Given que eu esteja logado no sistema
And acesse a index de pedido
And tenha um pedido criado na situaçao {Avaliaçao}


@avaliar_pedido
Scenario: Avaliar pedido
Given que eu acesse as actions do pedido
And clique no botao Avaliaçao do Pedido
And seja redirecionado para tela CRM Avaliar Pedido
When eu clicar no botao Prosseguir
Then serei redirecionado para index de pedidos
And a situaçao do meu pedido deve ser {Separação}

#@bloquear_pedido
#Scenario: Bloquear pedido
#Given que eu acesse as actions do pedido
#And clique no botao Avaliaçao do Pedido
#And seja redirecionado para tela de avaliar pedido
#When eu clicar no botao Bloquear 
#Then serei redirecionado para index de pedido
#And a situaçao do pedido deve ser Não Liberado / Recusado

#@cancelar_retornar_pedido_para_ediçao
#Scenario: Cancelar e retornar pedido para ediçao
#Given que eu acesse as actions do pedido
#And clique no botao Avaliaçao do Pedido
#And seja redirecionado para tela de avaliar pedido
#When eu clicar no botao Cancelar e Retornar Pedido para Edição
#Then serei redirecionado para index de pedido
#And a situaçao do pedido deve ser Lançamento / Ediçao
