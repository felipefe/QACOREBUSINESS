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
And feche o navegador quando terminar


@excluir_os_sucesso
Scenario: Excluir OS Aberta
Given que seja clicado no botao Novo Simples
And seja selecionado o tipo de OS {'Produção'}
And seja seleciona a pessoa {'Laura La Caronita'}
And seja informado no input o prazo final para {30} dias futuros
And seja informado no textarea um Resumo {'Resumidamente sintetico'}
And seja informado no textarea uma Observacao {'Observado absurdamente'}
And clicar no botao Salvar novo simples
And o sistema deve redirecionar para o edit da OS criada
And seja clicado no botao Salvar OS
And tenha uma ordem de serviço com status {'Normal'}
And coluna Itens Finalizados como {'Não'}
And que seja clicado Excluir nas actions da OS
And seja inserido no textarea uma justificativa {'Cancelamento extraordinario'}
When clicar no botao Cancelar O.S.
Then a OS deve ser excluida
And feche o navegador quando terminar


@incluir_item_os
Scenario: Inserir Receita OS
Given que seja clicado no botao Novo Simples
And seja selecionado o tipo de OS {'Produção'}
And seja seleciona a pessoa {'Laura La Caronita'}
And seja informado no input o prazo final para {30} dias futuros
And seja informado no textarea um Resumo {'Resumidamente sintetico'}
And seja informado no textarea uma Observacao {'Observado absurdamente'}
And clicar no botao Salvar novo simples
And o sistema deve redirecionar para o edit da OS criada
And seja clicado no botao Novo Item
And seja informado no select a receita {'Receita Boné Hurley'}
And seja informado o multiplicador da receita {1}
When clicar no botao Salvar item O.S
Then o sistema redireciona para /COS/OrdemServicoItem/Edit/
And feche o navegador quando terminar


@manutenção_de_itens
Scenario: Manutenção de Itens - Reservar/Separar
Given que seja clicado no botao Novo Simples
And seja selecionado o tipo de OS {'Produção'}
And seja seleciona a pessoa {'Laura La Caronita'}
And seja informado no input o prazo final para {30} dias futuros
And seja informado no textarea um Resumo {'Resumidamente sintetico'}
And seja informado no textarea uma Observacao {'Observado absurdamente'}
And clicar no botao Salvar novo simples
And o sistema deve redirecionar para o edit da OS criada
And seja clicado no botao Novo Item
And seja informado no select a receita {'Receita Boné Hurley'}
And seja informado o multiplicador da receita {1}
And clicar no botao Salvar item O.S
And o sistema redireciona para /COS/OrdemServicoItem/Edit/
And o usuário deve acessar o contexto by url {'/COS/OrdemServico'}
And tenha uma ordem de serviço com status {'Normal'}
And coluna Itens Finalizados como {'Não'}
And clique Encaminhar nas actions da OS
And selecione a situação {'Manutenção de Itens'}
And selecione o Grupo de usuário {'Administradores'}
And clique no botao Encaminhar
And valide que a situacao da OS esteja na situacao encaminhada
And que seja clicado Manutenção de Itens nas actions da OS
And seja redirecionado para /COS/Agrupador/ManutencaoItensOS/
When clicar na flag para Marcar Todos
And clicar no botao Reservar/Requisitar Insumos
And validar que a Qtd. Reservada deve ser a mesma que Qtd. Receita
And clicar na flag para Marcar Todos
And clicar no botao Separar Insumos
Then o status dos insumos devem ser {'Separado'}
And feche o navegador quando terminar

@produzir_os
Scenario: Produzir O.S/O.P
Given que seja clicado no botao Novo Simples
And seja selecionado o tipo de OS {'Produção'}
And seja seleciona a pessoa {'Laura La Caronita'}
And seja informado no input o prazo final para {30} dias futuros
And seja informado no textarea um Resumo {'Resumidamente sintetico'}
And seja informado no textarea uma Observacao {'Observado absurdamente'}
And clicar no botao Salvar novo simples
And o sistema deve redirecionar para o edit da OS criada
And seja clicado no botao Novo Item
And seja informado no select a receita {'Receita Boné Hurley'}
And seja informado o multiplicador da receita {1}
And clicar no botao Salvar item O.S
And o sistema redireciona para /COS/OrdemServicoItem/Edit/
And o usuário deve acessar o contexto by url {'/COS/OrdemServico'}
And tenha uma ordem de serviço com status {'Normal'}
And coluna Itens Finalizados como {'Não'}
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
And que seja clicado Editar nas actions da OS
And o sistema deve redirecionar para o edit da OS criada
When for clicado no botao Produzir Tudo
And confirmar clicando no botao da modal Produzir tudo(em cadeia)

