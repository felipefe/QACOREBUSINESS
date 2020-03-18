Feature: PedidoAvaliacao

Background: Estar logado no Corebusiness 
			e estar na tela de pedidos
			e ter um pedido em avaliaçao
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Meus Pedidos'}


@avaliar_pedido
Scenario: Avaliar pedido
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And eu pesquisar no editText o cliente por CP {34816670947}
And em seguida no botao selecionar
And que eu cliquei na sessao de Entregas
And clicar no botao Definir Entrega
And informar a transportadora {'Transportadora ACME'}
And informar o tipo da entrega como {Entrega}
And inserir uma data prevista em dias {1}
And inserir o valor do frete {50.0}
And clicar em salvar
And espere por {3} segundos ate ser processado
And que eu clique na sessao de Produtos
And eu pesquisar no editText o produto por SKU {'TST0001'}
And informar a quantidade no editText
And em seguida clicar no botao adicionar  
And que eu cliquei na sessao de Pagamento
And eu clicar no botao Criar Negociaçao
And inserir uma descriçao no editText {'primeira negociacao'}
And selecionar a forma de pagamento {'A vista no Dinheiro'}
And clicar no botao Salvar Negociaçao
And espere por {3} segundos ate ser processado
And eu clicar no botao Efetivar Pedido
And o sistema redireciona para index de pedidos
And a situaçao do pedido deve ser {'Avaliação'}
And que eu acesse as actions do pedido
And clique no botao Avaliaçao do Pedido
And seja redirecionado para tela CRM Avaliar Pedido
And eu clicar no botao Prosseguir
Then serei redirecionado para index de pedidos
And a situaçao do pedido deve ser {'Separação'}
And feche o navegador quando terminar




@bloquear_pedido
Scenario: Bloquear pedido
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And eu pesquisar no editText o cliente por nome {'Luiz Inacio da Silva - Restrição'}
And em seguida no botao selecionar
And que eu cliquei na sessao de Entregas
And clicar no botao Definir Entrega
And informar a transportadora {'Transportadora ACME'}
And informar o tipo da entrega como {Entrega}
And inserir uma data prevista em dias {1}
And inserir o valor do frete {50.0}
And clicar em salvar
And espere por {3} segundos ate ser processado
And que eu clique na sessao de Produtos
And eu pesquisar no editText o produto por SKU {'TST0001'}
And informar a quantidade no editText
And em seguida clicar no botao adicionar  
And que eu cliquei na sessao de Pagamento
And eu clicar no botao Criar Negociaçao
And inserir uma descriçao no editText {'primeira negociacao'}
And selecionar a forma de pagamento {'Boleto 30/60/90'}
And clicar no botao Salvar Negociaçao
And espere por {3} segundos ate ser processado
And eu clicar no botao Efetivar Pedido
And o sistema redireciona para index de pedidos
And a situaçao do pedido deve ser {'Avaliação'}
And que eu acesse as actions do pedido
And clique no botao Avaliaçao do Pedido
And seja redirecionado para tela CRM Avaliar Pedido
And um dos motivos seja {'Pedido possui parte da negociação a prazo'}
And outro motivo seja {'Cliente com situação restrita para vendas à prazo'}
And eu clicar no botao Bloquear 
Then serei redirecionado para index de pedido
And a situaçao do pedido deve ser {'Não Liberado / Recusado'}
And feche o navegador quando terminar

#@cancelar_retornar_pedido_para_ediçao
#Scenario: Cancelar e retornar pedido para ediçao
#Given que eu acesse as actions do pedido
#And clique no botao Avaliaçao do Pedido
#And seja redirecionado para tela de avaliar pedido
#When eu clicar no botao Cancelar e Retornar Pedido para Edição
#Then serei redirecionado para index de pedido
#And a situaçao do pedido deve ser Lançamento / Ediçao

