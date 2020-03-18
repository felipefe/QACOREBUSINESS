Feature: PedidoConferencia

Background: Estar logado no Corebusiness 
			e estar na tela de pedidos
			e ter um pedido em conferencia
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Meus Pedidos'}

@conferir_item_pedido
Scenario: Conferir item pedido
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
And a situaçao do pedido deve ser {'Separação'}
And que eu acesse as actions do pedido
And clique no botao Separaçao
And seja redirecionado para tela WMS Separaçao
And clique no botao Definir todos
And uma mensagem de sucesso aparecera {'Modificado o responsável de todos os itens.'}
And depois clicar no botao Marcar Todos
And uma mensagem de sucesso deve aparecer {'Os itens foram marcados como separados.'}
And eu clicar no botao Finalizar
And ser redicionado para a tela COM Finalizar Separaçao
And clicar no botao Finalizar Separaçao
And serei redirecionado para index de pedidos
And a situaçao do pedido deve ser {'Conferência'}
And que eu acesse as actions do pedido
And clique no botao Conferencia
And seja redirecionado para tela de WMS Conferencia
And o codigo sku e qtd. total sejam copidos de suas colunas
And seja feita a conferencia desses produtos
Then clicar no botao Concluir Processo
And  uma mensagem de conferido com sucesso deve aparecer
And feche o navegador quando terminar


@concluir_conferencia
Scenario: Concluir processo de conferencia
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
And a situaçao do pedido deve ser {'Separação'}
And que eu acesse as actions do pedido
And clique no botao Separaçao
And seja redirecionado para tela WMS Separaçao
And clique no botao Definir todos
And uma mensagem de sucesso aparecera {'Modificado o responsável de todos os itens.'}
And depois clicar no botao Marcar Todos
And uma mensagem de sucesso deve aparecer {'Os itens foram marcados como separados.'}
And eu clicar no botao Finalizar
And ser redicionado para a tela COM Finalizar Separaçao
And clicar no botao Finalizar Separaçao
And serei redirecionado para index de pedidos
And a situaçao do pedido deve ser {'Conferência'}
And que eu acesse as actions do pedido
And clique no botao Conferencia
And seja redirecionado para tela de WMS Conferencia
And o codigo sku e qtd. total sejam copidos de suas colunas
And seja feita a conferencia desses produtos
And clicar no botao Concluir Processo
And clicar no botao Finalizar 
And ser redirecionado para tela de COM Finalizar Conferencia
And clicar em Finalizar Conferencia
Then o sistema deve redirecionar para tela Entrega e Remessas do Pedido 
And feche o navegador quando terminar

@conferir_e_reiniciar_processo
Scenario: Conferir e reiniciar processo
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
And a situaçao do pedido deve ser {'Separação'}
And que eu acesse as actions do pedido
And clique no botao Separaçao
And seja redirecionado para tela WMS Separaçao
And clique no botao Definir todos
And uma mensagem de sucesso aparecera {'Modificado o responsável de todos os itens.'}
And depois clicar no botao Marcar Todos
And uma mensagem de sucesso deve aparecer {'Os itens foram marcados como separados.'}
And eu clicar no botao Finalizar
And ser redicionado para a tela COM Finalizar Separaçao
And clicar no botao Finalizar Separaçao
And serei redirecionado para index de pedidos
And a situaçao do pedido deve ser {'Conferência'}
And que eu acesse as actions do pedido
And clique no botao Conferencia
And seja redirecionado para tela de WMS Conferencia
And o codigo sku e qtd. total sejam copidos de suas colunas
And seja feita a conferencia desses produtos
And clicar no botao Concluir Processo
And uma mensagem de Conferência Finalizada deve aparecer
And eu clicar no botao Reiniciar Processo Conferencia
And confirmar clicando no botao OK do alerta exibido
Then a coluna Qtd. Conferida deve ser zero
And feche o navegador quando terminar











#@conferir_e_concluir_todo_processo_conferencia
#Scenario:  Conferir e concluir todo processo de conferencia
#Given que eu acesse as actions do pedido
#And clique no botao Conferencia
#And seja redirecionado para tela de WMS Conferencia
#And o codigo sku e qtd. total sejam copidos de suas colunas
#And seja feita a conferencia desses produtos
#And clicar no botao Concluir Processo
#When clicar no botao Finalizar 
#And ser redirecionado para tela de COM Finalizar Conferencia
#And clicar em Finalizar Conferencia
#Then o sistema deve redirecionar para tela Entrega e Remessas do Pedido
#
#
#@conferir_quantidade_errada
#Scenario: Conferir quantidade errada
#Given que eu acesse as actions do pedido
#And clique no botao Conferencia
#And seja redirecionado para tela de WMS Conferencia
#And o SKU seja copiado da coluna Código
#And seja colado no editText Código do Produto
#And a quantidade seja copiada da coluna Qtd. Total 
#And seja colada no editText Quantidade uma quantidade diferente da copiada
#When eu clicar Enter
#Then a quantidade da coluna Qtd. Conferida deve ser diferente da coluna Qtd. Total
#
#
#@conferir_codigo_errado
#Scenario: Conferir codigo errado
#Given que eu acesse as actions do pedido
#And clique no botao Conferencia
#And seja redirecionado para tela de WMS Conferencia
#And o SKU seja copiado da coluna Código
#And seja colado no editText Código do Produto um código diferente do copiado
#And a quantidade seja copiada da coluna Qtd. Total 
#And seja colada no editText Quantidade
#When eu clicar Enter
#Then uma mensagem de Codigo Invalido é exibida
#
#
#@reiniciar_conferencia_finalizada
#Scenario: Reiniciar conferencia finalizada
#Given que eu acesse as actions do pedido
#And clique no botao Conferencia
#And seja redirecionado para tela de WMS Conferencia
#And uma mensagem de Conferência Finalizada deve aparecer
#When eu clicar no botao Reiniciar Processo Conferencia
#And confirmar clicando no botao OK do alerta exibido
#Then uma mensagem de reiniciado com sucesso deve aparecer
#And a coluna Qtd. Conferida deve ser zero



