Feature: PedidoSegmentar

Background: Estar logado no Corebusiness 
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Meus Pedidos'}


@segmentar_pedido
Scenario: Segmentar Pedido
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And eu pesquisar no editText o cliente por CP {34816670947}
And em seguida no botao selecionar
And que eu clique na sessao de Produtos
And eu pesquisar no editText o produto por SKU {'TST0001'}
And espere por {2} segundos ate ser processado
And informar a quantidade no editText {3}
And em seguida clicar no botao adicionar
And eu pesquisar no editText o produto por SKU {'TST0002'}
And espere por {2} segundos ate ser processado
And informar a quantidade no editText {4}
And em seguida clicar no botao adicionar
And o usuário deve acessar o contexto by url {'/COM/Pedido'}
And espere por {2} segundos ate ser processado
And a situaçao do pedido deve ser {'Lançamento / Edição'}
And clique nas actions para Segmentar o pedido
And seja redirecionado para url contains {'/COM/Pedido/Segmentar/'}
And informe a quantidade a segmentar {2}
And clique no botao Segmentar
Then seja redirecionado para url contains {'/COM/PedidoVue/Edit/'}
And valide que a quantidade segmentada seja inserida no novo pedido
And feche o navegador quando terminar

