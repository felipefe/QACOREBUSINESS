Feature: PedidoEmitirDFe

Background: Estar logado no Corebusiness 
			e estar na tela de pedidos
			e ter um pedido conferido
			e o serviço do coreservice esteja rodando
			e esteja em ambiente de homologação
Given que eu esteja logado no sistema
And o coreservice esteja habilitado
And ambiente de homologaçao esteja habilitado
And clicar para acessar o contexto {'Meus Pedidos'}
And tenha um pedido criado na situaçao {'Conferido'}


@emitir_documentos_fiscais
Scenario: Emitir documento fiscal
Given que eu acesse as actions do pedido
When clicar no botao Emitir Documentos Fiscais
Then o usuário deve acessar o contexto de NF-e Emitidas
And a situaçãp da nota deve ser Autorizado o uso da NF-e
And o valor exibido na coluna deve ser o mesmo do pedido


