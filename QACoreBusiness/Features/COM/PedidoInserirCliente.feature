Feature: PedidoInserirCliente

Background: Ter um pedido criado
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Meus Pedidos'}


@inserir_cp_cliente_valido_pedido
Scenario: Inserir o cliente por CP no pedido com sucesso
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And fechar a primeira mensagem de dados do pedido carregado
And eu pesquisar no editText o cliente por CP {34816670947}
And em seguida no botao selecionar
Then uma mensagem de pessoa adicionada ao pedido deve aparecer
And a situaçao do cliente deve ser {Normal}

@inserir_nome_cliente_valido_pedido
Scenario: Inserir o cliente por nome no pedido com sucesso
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And fechar a primeira mensagem de dados do pedido carregado
And eu pesquisar no editText o cliente por nome {'Valentina La Ferrugem'}
And em seguida no botao selecionar
Then uma mensagem de pessoa adicionada ao pedido deve aparecer
And a situaçao do cliente deve ser {Normal}

@inserir_cliente_restrito_pedido
Scenario: Inserir cliente com restriçao ao pedido
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And fechar a primeira mensagem de dados do pedido carregado
And eu pesquisar no editText o cliente por nome {'Luiz Inacio da Silva - Restrição'}
And em seguida no botao selecionar
Then uma mensagem de pessoa adicionada ao pedido deve aparecer
And um alerta referente a situaçao é exibido