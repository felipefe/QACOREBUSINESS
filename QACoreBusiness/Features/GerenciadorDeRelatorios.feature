Feature: GerenciadorDeRelatorios

Background: Logar e acessar gestor financeiro
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Gerenciador de Relatórios'}


@importar_relatorio_estoque
Scenario: Importar definicao de relatorio Estoque (Separacoes)
	Given que seja clicado no botao Definicoes de Relatorios
	And seja redirecionado para index de Definiçoes de Relatorios /RPT/Report
	And seja clicado no botao carregar Definicao de Relatorio
	And seja clicado para fazer o upload
	And selecione o arquivo rpt
	When clicar no botao Carregar rpt
	Then seja redirecionado para index de Definiçoes de Relatorios /RPT/Report


@criar_definicao_relatorio
Scenario: Criar definicao de relatorio
	Given que seja clicado no botao Definicoes de Relatorios
	And seja redirecionado para index de Definiçoes de Relatorios /RPT/Report
	And que eu tenha importado o relatorio de nome {'Separações'}
	And clique nas actions deste relatorio Criar Relatorio A partir Desta Definição
	When clicar no botao Salvar relatorio
	Then seja redirecionado para index de Gerenciador de relatorio /RPT/ReportView


@editar_definicao_relatorio
Scenario: Editar definicao relatorio
	Given que eu tenha relatorio de nome {'Comissões de Vendas por Recebimento'}
	And clique nas actions deste relatorio Editar Definiçao
	And seja redirecionado para tela de edicao do rpt /RPT/ReportView/EditBuilder/
	And clique na aba Colunas
	When selecionar todas as colunas possiveis
	And clicar no botao Gravar denificao editada
	Then seja redirecionado para index de Gerenciador de relatorio /RPT/ReportView


@excluir_definicao_relatorio
Scenario: Excluir definicao relatorio
	Given que eu tenha relatorio de nome {'Comissões de Vendas por Recebimento'}
	And clique nas actions deste relatorio Excluir
	When confirmar clicando no botao Excluir
	Then o relatorio deve ser excluido e {'Comissões de Vendas por Recebimento'} nao aparecer na lista


@executar_relatorio
Scenario: Executar Relatorio
	Given que seja clicado no menu do usuario logado
	And clique no botao Relatorios
	And seja redirecionado para Meus Relatorios /RPT/ReportView/UserReportViews
	And que eu tenha relatorio de nome {'Comissões de Vendas por Recebimento'}
	When clicar no botao executar relatorio
	And ser redirecionado para Parametros de execucao /RPT/ReportView/OpenReportView/
	And clicar no botao Executar meu relatorio
	Then o relatorio deve ser exibido em uma nova guia do navegador





