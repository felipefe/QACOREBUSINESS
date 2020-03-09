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
Scenario: Produzir O.S/O.P (Executar Tudo)
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
When for clicado no botao Executar Tudo
And desmarque a opção Tentar Finalizar itens
And confirmar clicando no botao Confirmar Execuções da modal
And espere por {10} segundos ate ser processado
And o usuário deve acessar o contexto by url {'/COS/OrdemServico'}
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
And espere por {3} segundos ate ser processado
And clique no botao da Header Gerenciar O.S
Then valide a OS memorizada
And o status final da OS deve ser {'Finalizada'}
And feche o navegador quando terminar


@produzir_ordem_servico
Scenario: Produzir O.S/O.P (Produzir Tudo)
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
And confirmar clicando no botao Produzir tudo(em cadeia)
And espere por {5} segundos ate ser processado
And clique para editar item de OS
And clique no botao Concluir Item
And confirme clicando no botao Concluir da modal
And o usuário deve acessar o contexto by url {'/COS/OrdemServico'}
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
And espere por {3} segundos ate ser processado
And clique no botao da Header Gerenciar O.S
Then valide a OS memorizada
And o status final da OS deve ser {'Finalizada'}
And feche o navegador quando terminar



@alterar_qtd_insumos_ao_reservar
Scenario: Manutenção de Itens - Alterar Qtd. dos Insumos ao Reservar
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
And informar no input a Qtd Reservar {3.5}
And marcar a flag Alterar Qtd. dos Insumos ao Reservar
And clicar no botao Reservar/Requisitar Insumos
Then validar que a Qtd. Reservada deve ser a mesma que Qtd. Total
And feche o navegador quando terminar


@reservar_qtd_menor_sugerida
Scenario: Manutenção de Itens - Reservar Qtd Menor/Parcial 
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
And informar no input a Qtd Reservar {0.4}
And clicar no botao Reservar/Requisitar Insumos
Then validar que a Qtd. a Reservar + Qtd. Reservada deve ser a mesma que Qtd. Total
And feche o navegador quando terminar


@recepcao_triangular
Scenario: Operação Triangular
	Given o usuário deve acessar o contexto by url {'/COM/LoteFiscal'}
	And memorizar o ultimo inventario
	And que seja clicado no botao Novo Lancamento Manual
	And seja redirecionado para tela de criar recepcao	
	And seja informado a operação fiscal {'Operação Triangular'}
	And seja informado no editText o fornecedor {'New Era Fornecedor LTDA'}
	And seja informado no editText a data de recebimento [data atual]
	And seja informado no editText o Numero do documento 
	And seja informado no editText a Serie do documento {1}
	And seja informado no editText a data de emissao
	And seja informado o modelo de documento {'Nota Fiscal modelo 1 ou 1-A'}
	And selecione o contratante do processo {'Laura La Caronita'}
	And clicar no botao Salvar
	And o sistema redirecionada para index de recepçao
	And que tenha uma recepcao no status {'Lançamento'}
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And seja clicado no botao Nova Mercadoria Recebida
	And seja redirecionado para criar item da recepcao
	When informar o produto SKU {'TST0011'}
	And informar no editText o valor unitario {65}
	And informar no editText a quantidade {2}
	And informar no editText o numero do lote
	And informar no editText a data de fabricacao
	And informar no editText a data de validade
	And clicar na aba de Impostos Conforme Documento de Entrada
	And informar o CFOP 5924 - {'Remessa para industrialização por conta e ordem do adquirente da mercadoria, quando esta não transitar pelo estabelecimento do adquirente'}
	And informar a origem da Mercadoria {'Nacional - exceto as indicadas nos códigos 3 a 5'}
	And informar o codigo da ST {'Tributada integralmente'}
	And informar no editText o percentual da Aliquota {1}
	And clicar no botao de Salvar itens
	And seja redirecionado para tela de Mercadorias da recepcao
	And o SKU do item da recepcao informado deve aparecer na tabela
	And tenha na coluna Escriturado do item o valor {'Não'}
	And clicar no botao da header Escriturar todos os itens automaticamente
	And seja redirecionado para index de escriturar lote fiscal
	And clicar na aba Configuração
	And selecione o CFOP {1924} Compra para Comercialização
	And clicar no botao Calcular
	And o status do item deve mudar para {'Escriturado'}
	And quando clicar no botao Prosseguir
	And o sistema redirecionada para index de recepçao
	And seja clicado no botao Mercadoria nas actions
	And seja redirecionado para tela de Mercadorias da recepcao
	And tenha na coluna Escriturado do item o valor {'Sim'}
	And clicar no botao Finalizar Lançamento de Itens
	And marcar Eu concluí o lançamento de todos os itens
	And clicar no botao Confirmar
	And o sistema redirecionada para index de recepçao
	And o status da recepcao deve ser {'Conferência Física'}
	And seja clicado no botao Conferencia Fisica de Recebimento nas actions
	And seja redirecionado para tela de WMS Conferencia
	And o SKU seja copiado da coluna Código
	And seja colado no editText Código do Produto
	And a quantidade seja copiada da coluna Qtd. Total 
	And seja colada no editText Quantidade
	And eu clicar Enter
	And clicar no botao Concluir Processo
	And clicar no botao Finalizar 
	And ser redirecionado para tela de COM Conferencia Fisica da Recepcao
	And clicar no botao Concluir
	Then o sistema redirecionada para index de recepçao
	And o status da recepcao deve ser {'Aguardando Finalização'} 
	And seja clicado no botao Finalizar Recebimento nas actions
	And seja redirecionado para tela de Finalizar recepcao
	And clicar no botao Finalizar Recepcao
	And o sistema redirecionada para index de recepçao
	And que eu clique no botao da header Gerenciar recepcoes
	And seja redirecionado para index de gerenciar recepcoes
	And que tenha uma recepcao no status {'Finalizado'}
	And clicar no botao da action Industrialização do lote recebido
	And seja redirecionado para url contains {'/COS/OrdemServico/IndustrializacaoLoteRecebido'}
	And selecione os produtos para criar produçao
	And clique no botao Criar Produção
	And selecione a receita {'Receita Triangular Boné Hurley'}
	And clique no botao OK da modal de criar produção
	And seja redirecionado para url contains {'/COM/LoteFiscalProducao/CreateIndividual?idLoteFiscal'}
	And clique no botao Salvar producao de lote
	And clique no botao Industrializar
	And seja redirecionado para url contains {'/COS/OrdemServico/Edit/'}
	And o usuário deve acessar o contexto by url {'/COS/OrdemServico'}
