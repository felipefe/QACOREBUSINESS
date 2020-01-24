Feature: PedidoInserirNegociacao

Background: Ter um pedido criado que possua item
Given que eu esteja logado no sistema
And acesse a index de pedido
And tenha um pedido criado na situaçao {Lançamento/Ediçao}
And clique para editar este pedido
And seja redirecionado para tela de ediçao

@inserir_negociacao_sem_cliente_definido
Scenario: Negociacao sem cliente informado
Given que eu nao tenha informado o cliente
And que eu cliquei na sessao de Pagamento
When eu clicar no botao Criar Negociaçao
Then um alerta é exibido para informar o cliente

@inserir_negociacao_sem_itens_pedido
Scenario: Negociacao sem itens de pedido
Given já tenha informado o cliente
And nao tenha itens adicionados ao pedido
And que eu cliquei na sessao de Pagamento
When eu clicar no botao Criar Negociaçao
Then um alerta é exibido sobre pedido sem itens


@inserir_negociacao_pedido
Scenario: Inserir negociçao ao pedido
Given já tenha informado o cliente
And valor do pedido seja maior que zero
And que eu cliquei na sessao de Pagamento
When eu clicar no botao Criar Negociaçao
And inserir uma descriçao no editText {'primeira negociacao'}
And selecionar a forma de pagamento {'A vista no Dinheiro'}
And clicar no botao Salvar Negociaçao
Then o valor total geral da negociçao deve ser maior que zero