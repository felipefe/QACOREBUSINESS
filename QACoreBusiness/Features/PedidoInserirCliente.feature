Feature: PedidoInserirCliente

Background: Ter um pedido criado
Given que eu tenha um pedido criado
And que eu esteja na tela de ediçao do pedido

@inserir_cp_cliente_valido_pedido
Scenario: Inserir o cliente por CP no pedido com sucesso
When eu pesquisar no editText o cliente por CP {348.166.709-47}
And eu clicar no cliente listado
And em seguida no botao selecionar
Then uma mensagem de pessoa adicionada ao pedido deve aparecer

@inserir_nome_cliente_valido_pedido
Scenario: Inserir o cliente por nome no pedido com sucesso
When eu pesquisar no editText o cliente por nome {Valentina La Ferrugem}
And eu clicar no cliente listado
And em seguida no botao selecionar
Then uma mensagem de pessoa adicionada ao pedido deve aparecer

@inserir_cliente_restrito_pedido
Scenario: Inserir cliente com restriçao ao pedido
When eu pesquisar no editText o cliente por nome {Luiz Inacio da Silva - Restrição}
And eu clicar no cliente listado
And em seguida no botao selecionar
Then uma mensagem de pessoa adicionada ao pedido deve aparecer
And um alerta referente a situaçao é exibido