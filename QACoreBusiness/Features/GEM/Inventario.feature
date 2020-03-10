Feature: Inventario

Background: acesse a index de inventario
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Inventários'}


@realizar_inventario
Scenario: Realizar Inventario
Given memorize a numeracao do ultimo invetario
When seja clicado no botao Novo inventario
And selecione a empresa {'Deltacon Informática'}
And insira no input o Nome do inventario 
And clique no botao Criar
And valide que o inventario foi criado
And clique no botao Produtos das actions
And clique no botao Incluir Produto
And selecionar o produto {'TST0012'}
And desmarque a opção vincular todos os lotes
And clique no botao criar produto
And clique no botao voltar
And clique no botao Iniciar execução das actions
And clique no botao Iniciar da modal
And informe a quantidade {5} a ser inventariada para todos os produtos
And clique no botao Concluir Execucao
And selecione a op fiscal {'Inventário'} do inventario
And selecione cfop {'Compra para industrialização'} do inventario
And selecione a origem {'Nacional - exceto as indicadas nos códigos 3 a 5'} do inventario
And selecione a situaçao do lote {'Disponível para operações de Entrada e Saída'} inventariado
And clique no botao Resolver
And espere por {4} segundos ate ser processado
Then o status do inventario deve ser {'Finalizado'}
And feche o navegador quando terminar