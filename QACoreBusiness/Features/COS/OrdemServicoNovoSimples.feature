Feature: OrdemServicoNovoSimples

Background: Logar e acessar gestor financeiro
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Processos (Ordens de Serviço/Produção)'}

@criar_novo_simples
Scenario: Criar OS Novo Simples
Given que seja clicado no botao Novo Simples
And seja selecionado o tipo de OS {'Produção'}
And seja seleciona a pessoa {'Laura La Caronita'}
And seja informado no input o prazo final para {30} dias futuros
And seja informado no textarea um Resumo {'Resumidamente sintetico'}
And seja informado no textarea uma Observacao {'Observado absurdamente'}
When clicar no botao Salvar novo simples
Then o sistema deve redirecionar para o edit da OS criada


@excluir_os_sucesso
Scenario: Excluir OS Aberta
Given tenha uma ordem de serviço com status {'Normal'}
And coluna Itens Finalizados como {'Não'}
And que seja clicado Excluir nas actions da OS
And seja inserido no textarea uma justificativa {'Cancelamento extraordinario'}
When clicar no botao Cancelar O.S.
Then a OS deve ser excluida


@incluir_item_os
Scenario: Inserir Receita OS
Given tenha uma ordem de serviço com status {'Normal'}
And coluna Itens Finalizados como {'Não'}
And que seja clicado Editar nas actions da OS
And seja clicado no botao Novo Item
And seja informado no select a receita {'Receita Boné Hurley'}
And seja informado o multiplicador da receita {1}
When clicar no botao Salvar item O.S
Then o sistema redireciona para /COS/OrdemServicoItem/Edit/


@manutenção_de_itens
Scenario: Manutenção de Itens - Reservar/Separar
Given tenha uma ordem de serviço com status {'Normal'}
And coluna Itens Finalizados como {'Não'}
And que seja clicado Manutenção de Itens nas actions da OS
And seja redirecionado para /COS/Agrupador/ManutencaoItensOS/
When clicar no botao Marcar Todos
And clicar no botao Reservar/Requisitar Insumos
And clicar no botao Marcar Todos
And clicar no botao Separar Insumos
Then o status dos insumos devem ser {'Separado'}
And a Qtd. Reservada igual a Qtd. Receita
