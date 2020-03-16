Feature: Requisicoes

Background: Ter um pedido criado
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Meus Pedidos'}	

@inserir_item_gerar_requisicao
Scenario: Gerar Requisicao
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And eu pesquisar no editText o cliente por CP {34816670947}
And em seguida no botao selecionar
And que eu clique na sessao de Produtos
And eu pesquisar no editText o produto por SKU {'TST0013'}
And informar a quantidade no editText
And em seguida clicar no botao adicionar  
And sua tag de reserva estoque deve ser {'Sem reserva'}
And armazene o numero do pedido
And clique no botao da header Requisitar itens não reservados
And clique no botao executar para gerar requisiçoes
And o usuário deve acessar o contexto by url {'/COM/ProdutoRequisicao'}
And valide a requisição gerada atraves do numero do pedido
And a situacao da requisicao deve ser {'Solicitada'}
Then feche o navegador quando terminar


@inserir_item_sem_reserva
Scenario: Item S/ Reserva - Requisitar - Produzir
When o usuario clicar no botao Criar Novo Pedido {Nova Venda de Mercadorias e Serviços}
And eu pesquisar no editText o cliente por CP {34816670947}
And em seguida no botao selecionar
And que eu clique na sessao de Produtos
And eu pesquisar no editText o produto por SKU {'TST0013'}
And informar a quantidade no editText
And em seguida clicar no botao adicionar  
And sua tag de reserva estoque deve ser {'Sem reserva'}
And armazene o numero do pedido
And clique no botao da header Requisitar itens não reservados
And clique no botao executar para gerar requisiçoes
And o usuário deve acessar o contexto by url {'/COM/ProdutoRequisicao'}
And valide a requisição gerada atraves do numero do pedido
And a situacao da requisicao deve ser {'Solicitada'}
And armazene o codigo da requisicao
And clique nas actions Gerar OS de Producao
And confirme clicando no botao Gerar Producao da modal
And espere por {3} segundos ate ser processado
And a situacao da requisicao deve ser {'Em processo de Produção'}
And clique nas actions Detalhes da Requisicao
And memorize o numero da OS Gerada pela requicao
And o usuário deve acessar o contexto by url {'/COS/OrdemServico'}
And valide o numero da OS Gerada pela requisicao
And clique Encaminhar nas actions da OS
And selecione a situação {'Manutenção de Itens'}
And selecione o Grupo de usuário {'Administradores'}
And clique no botao Encaminhar
And valide que a situacao da OS esteja na situacao encaminhada
And que seja clicado Manutenção de Itens nas actions da OS
And seja redirecionado para /COS/Agrupador/ManutencaoItensOS/
And clicar na flag para Marcar Todos
And clicar no botao Reservar/Requisitar Insumos
And validar que a Qtd. Reservada deve ser a mesma que Qtd. Receita
And clicar na flag para Marcar Todos
And clicar no botao Separar Insumos
And o status dos insumos devem ser {'Separado'}
And o usuário deve acessar o contexto by url {'/COS/OrdemServico'}
And clique Encaminhar nas actions da OS
And selecione a situação {'Em Produção'}
And selecione o Grupo de usuário {'Administradores'}
And clique no botao Encaminhar
And valide que a situacao da OS esteja na situacao encaminhada
And clique nas actions da OS Criar Execuçoes
And seja redirecionado para url contains {'/COS/Agrupador/CriarExecucoes/'}
And confirme clicando no botao Criar Execuçoes
And que seja clicado Editar nas actions da OS
And o sistema deve redirecionar para o edit da OS criada
When clique para editar item de OS
And valide que seja criada a execuçao
And clique nas actions para Confirmar Execuçao
And clique Confirmar no botao da modal
And espere por {3} segundos ate ser processado
And clique no botao Concluir Item
And confirme clicando no botao Concluir da modal
And o usuário deve acessar o contexto by url {'/COS/OrdemServico'}
And coluna Itens Finalizados como {'Sim'}
And clique Encaminhar nas actions da OS
And selecione a situação {'Produzida'}
And selecione o Grupo de usuário {'Administradores'}
And clique no botao Encaminhar
And valide que a situacao da OS esteja na situacao encaminhada
And memorize o numero da OS
And clique nas actions Finalizar O.S/O.P
And informe no textArea uma mensagem de Conclusão {'OS Concluída 100% level hard'}
And marque a flag para Tentar Finalizar Todos os Itens
And confirme clicando no botao Finalizar OS
And espere por {8} segundos ate ser processado
And clique no botao da Header Gerenciar O.S
Then valide a OS memorizada
And o status final da OS deve ser {'Finalizada'}
And o usuário deve acessar o contexto by url {'/COM/ProdutoRequisicao'}
And validar o numero da requisicao armazenada
And a situacao da requisicao deve ser {'Solicitada'}
#mudar para atendida e continuar validando status reserva pedido