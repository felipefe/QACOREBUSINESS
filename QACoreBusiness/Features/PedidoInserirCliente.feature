Feature: PedidoInserirCliente

Background: Ter um pedido criado
Given que eu tenha um pedido criado

@inserir_cliente_valido_pedido
Scenario: Inserir o cliente no pedido com sucesso
Given que eu esteja na tela de ediçao do pedido
When eu pesquisar o cliente por CP {027.703.320-90} ou por nome {felipe fernandes}
And eu clicar no cliente 
And em seguida no botao selecionar
Then uma mensagem de pessoa adicionada ao pedido deve aparecer

@inserir_cliente_restricao_pedido
Scenario: Inserir cliente com restriçao ao pedido
Given que eu esteja na tela de ediçao do pedido
When eu pesquisar o cliente por CP {237.683.859-22} ou por nome {valentina ctb}
And eu clicar no cliente 
And em seguida no botao selecionar
Then uma mensagem de pessoa adicionada ao pedido deve aparecer
And um alerta referente a situaçao é exibido