#language:pt

#language:pt

Feature: Montar pedido

Background: Estar logado no Corebusiness
Given que usuário esteja logado

@criar_pedido
Scenario: Acessar Meus pedidos e criar o pedido
Given que o usuario esteja no hub principal
And acesse o contexto Meus Pedidos
When clicar em criar novo pedido
Then um novo pedido deve ser criado


@inserir_cliente_valido_pedido
Scenario: Inserir o cliente no pedido com sucesso
Given que eu esteja na tela de ediçao do pedido
And pesquise o cliente por CP ou nome
When eu clicar no cliente 
And em seguida no botao selecionar
Then uma mensagem de pessoa adicionada ao pedido deve aparecer

@inserir_cliente_restricao_pedido
Scenario: Inserir cliente com restriçao ao pedido
Given que eu esteja na tela de ediçao do pedido
And pesquise o cliente por CP ou nome
When eu clicar no cliente 
And em seguida no botão selecionar
Then o cliente deve ser adicionado ao pedido 
And um alerta referente a situaçao é exibido


@criar_entrega_pedido
Scenario: Criar entrega pedido
Given que eu esteja na tela de ediçao do pedido
And já tenha informado o cliente
And tenha clicado na sessão de Entregas
When clicar em definir entrega
And informar a transportadora
And informar o tipo como Entrega
And inserir uma data prevista
And inserir o valor do frete
And clicar em salvar
Then uma mensagem de dados atualizado deve aparecer


@inserir_item_valido_pedido
Scenario: Inserir item ao pedido 
Given que eu esteja na tela de ediçao do pedido
And clique na sessão de Produtos
And pesquise o produto por SKU ou nome
When eu clicar no item 
And em seguida clicar em adicionar 
Then uma mensagem de item adicionado ao pedido deve aparecer

@inserir_item_invalido_pedido
Scenario: Item nao inserido ao pedido 
Given que eu esteja na tela de ediçao do pedido
And clique na sessao de Produtos
And pesquise o produto por SKU ou nome
When eu clicar no item 
And em seguida clicar em adicionar 
Then uma mensagem de item nao adicionado ao pedido 
And uma outra mensagem com os detalhes deverao aparecer


@inserir_negociacao_pedido
Scenario: Inserir negociçao ao pedido
Given que eu esteja na tela de ediçao do pedido
And tenha itens adicionados ao pedido
And o valor do pedido seja maior que zero
And clique na sessao de Pagamento
When eu clicar em Criar Negociaçao
And inserir uma descriçao
And selecionar a forma de pagamento
And clicar em salvar negociaçao
Then o total geral da negocição deve ser maior que zero
And uma mensagem de dados atualizados deve aparecer


@trocar_vendedor_pedido_sucesso
Scenario: Inserir ou trocar vendedor ao pedido
Given que eu esteja na tela de ediçao do pedido
When clicar em trocar vendedor
And selecionar o vendedor
And clicar no botao trocar vendedor
Then o sistema redireciona para ediçao do pedido
And uma mensagem de dados atualizados deve aparecer

@trocar_vendedor_pedido_falha
Scenario: Inserir vendedor já selecionado ao pedido
Given que eu esteja na tela de ediçao do pedido
When clicar em trocar vendedor
And selecionar o vendedor
And clicar no botao trocar vendedor
Then o sistema nao redireciona para ediçao do pedido
And uma mensagem para indicar um vendedor diferente do atual deve aparecer

@efetivar_pedido_sucesso
Scenario: Efetivar pedido
Given que eu esteja na tela de ediçao do pedido
And tenha inserido o cliente
And tenha definido entrega
And tenha adicionado itens
And tenha adicionado negociaçao
When eu clicar em efetivar pedido
Then o sistema redireciona para tela de pedidos

@efetivar_pedido_falha
Scenario: Efetivar pedido
Given que eu esteja na tela de ediçao do pedido
When eu clicar em efetivar pedido
Then o sistema não redireciona para tela de pedidos
And uma alerta com as pendencias é exibido 