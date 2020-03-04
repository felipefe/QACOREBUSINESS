Feature: PedidoSeparacao

Background: Estar logado no Corebusiness 
			e estar na tela de pedidos
			e ter um pedido em separaçao
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Meus Pedidos'}

@separar_itens_pedido
Scenario: Separar itens pedido
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
And que eu clique na sessao de Produtos
And eu pesquisar no editText o produto por SKU {'TST0001'}
And informar a quantidade no editText
And em seguida clicar no botao adicionar  
And que eu cliquei na sessao de Pagamento
And eu clicar no botao Criar Negociaçao
And inserir uma descriçao no editText {'primeira negociacao'}
And selecionar a forma de pagamento {'A vista no Dinheiro'}
And clicar no botao Salvar Negociaçao
And clicar no botao da action Trocar Vendedor
And informar o vendedor {'Vendedor Pablo Escobar'}
And clicar no botao trocar vendedor
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
Then serei redirecionado para index de pedidos
And a situaçao do pedido deve ser {'Conferência'}
And feche o navegador quando terminar