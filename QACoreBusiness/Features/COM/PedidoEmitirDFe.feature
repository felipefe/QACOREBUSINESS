﻿Feature: PedidoEmitirDFe

Background: Estar logado no Corebusiness 
			e estar na tela de pedidos
			e ter um pedido conferido
			e o serviço do coreservice esteja rodando
			e esteja em ambiente de homologação
Given que eu esteja logado no sistema
And o coreservice esteja habilitado
And ambiente de homologaçao esteja habilitado
And clicar para acessar o contexto {'Meus Pedidos'}

@emitir_documentos_fiscais
Scenario: Emitir DF-e
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
And espere por {3} segundos ate ser processado
And o codigo sku e qtd. total sejam copidos de suas colunas
And seja feita a conferencia desses produtos
And clicar no botao Concluir Processo
And clicar no botao Finalizar 
And ser redirecionado para tela de COM Finalizar Conferencia
And clicar em Finalizar Conferencia
And o sistema deve redirecionar para tela Entrega e Remessas do Pedido 
And clicar nas actions Emitir Documentos Fiscais
Then o usuário deve acessar o contexto by url {'/IDFe/NFe'}
And espere por {20} segundos ate ser processado
And a situaçãp da nota deve ser Autorizado o uso da NF-e
And feche o navegador quando terminar



@emitir_documentos_agregadores_desconto
Scenario: Emitir DF-e com IPI + Desconto
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And eu pesquisar no editText o cliente por CP {34816670947}
And em seguida no botao selecionar
And que eu cliquei na sessao de Entregas
And clicar no botao Definir Entrega
And informar a transportadora {'Transportadora ACME'}
And informar o tipo da entrega como {Entrega}
And inserir uma data prevista em dias {1}
And inserir o valor do frete {20.0}
And clicar em salvar
And espere por {3} segundos ate ser processado
And que eu clique na sessao de Produtos
And eu pesquisar no editText o produto por SKU {'TST0012'}
And informar a quantidade no editText
And em seguida clicar no botao adicionar  
And clique na header Editar Agregadores
And espere por {5} segundos ate ser processado
And informe {10} porcento de desconto no input
And clique no botao Atualizar Pedido
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
And espere por {3} segundos ate ser processado
And o codigo sku e qtd. total sejam copidos de suas colunas
And seja feita a conferencia desses produtos
And clicar no botao Concluir Processo
And clicar no botao Finalizar 
And ser redirecionado para tela de COM Finalizar Conferencia
And clicar em Finalizar Conferencia
And o sistema deve redirecionar para tela Entrega e Remessas do Pedido 
And clicar nas actions Emitir Documentos Fiscais
Then o usuário deve acessar o contexto by url {'/IDFe/NFe'}
And espere por {20} segundos ate ser processado
And a situaçãp da nota deve ser Autorizado o uso da NF-e
And feche o navegador quando terminar



@emitir_documentos_agregadores_desconto_unitario
Scenario: Emitir DF-e com IPI + Desconto como alteração no valor unitário
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And eu pesquisar no editText o cliente por CP {34816670947}
And em seguida no botao selecionar
And que eu cliquei na sessao de Entregas
And clicar no botao Definir Entrega
And informar a transportadora {'Transportadora ACME'}
And informar o tipo da entrega como {Entrega}
And inserir uma data prevista em dias {1}
And inserir o valor do frete {20.0}
And clicar em salvar
And espere por {3} segundos ate ser processado
And que eu clique na sessao de Produtos
And eu pesquisar no editText o produto por SKU {'TST0012'}
And informar a quantidade no editText
And em seguida clicar no botao adicionar  
And clique na header Editar Agregadores
And espere por {5} segundos ate ser processado
And informe {10} porcento de desconto no input
And marque a flag Aplicar Desconto como alterações do valor unitario
And clique no botao Atualizar Pedido
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
And espere por {3} segundos ate ser processado
And o codigo sku e qtd. total sejam copidos de suas colunas
And seja feita a conferencia desses produtos
And clicar no botao Concluir Processo
And clicar no botao Finalizar 
And ser redirecionado para tela de COM Finalizar Conferencia
And clicar em Finalizar Conferencia
And o sistema deve redirecionar para tela Entrega e Remessas do Pedido 
And clicar nas actions Emitir Documentos Fiscais
Then o usuário deve acessar o contexto by url {'/IDFe/NFe'}
And espere por {20} segundos ate ser processado
And a situaçãp da nota deve ser Autorizado o uso da NF-e
And feche o navegador quando terminar


@emitir_documentos_agregadores_acrescimo
Scenario: Emitir DF-e com IPI + Acrescimo
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And eu pesquisar no editText o cliente por CP {34816670947}
And em seguida no botao selecionar
And que eu cliquei na sessao de Entregas
And clicar no botao Definir Entrega
And informar a transportadora {'Transportadora ACME'}
And informar o tipo da entrega como {Entrega}
And inserir uma data prevista em dias {1}
And inserir o valor do frete {20.0}
And clicar em salvar
And espere por {3} segundos ate ser processado
And que eu clique na sessao de Produtos
And eu pesquisar no editText o produto por SKU {'TST0012'}
And informar a quantidade no editText
And em seguida clicar no botao adicionar  
And clique na header Editar Agregadores
And espere por {5} segundos ate ser processado
And informe {10} porcento de acrescimo no input
And clique no botao Atualizar Pedido
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
And espere por {3} segundos ate ser processado
And o codigo sku e qtd. total sejam copidos de suas colunas
And seja feita a conferencia desses produtos
And clicar no botao Concluir Processo
And clicar no botao Finalizar 
And ser redirecionado para tela de COM Finalizar Conferencia
And clicar em Finalizar Conferencia
And o sistema deve redirecionar para tela Entrega e Remessas do Pedido 
And clicar nas actions Emitir Documentos Fiscais
Then o usuário deve acessar o contexto by url {'/IDFe/NFe'}
And espere por {20} segundos ate ser processado
And a situaçãp da nota deve ser Autorizado o uso da NF-e
And feche o navegador quando terminar