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
	And feche o navegador quando terminar

@criar_definicao_relatorio
Scenario: Criar definicao de relatorio (Separacoes)
	Given que seja clicado no botao Definicoes de Relatorios
	And seja redirecionado para index de Definiçoes de Relatorios /RPT/Report
	And seja clicado no botao carregar Definicao de Relatorio
	And seja clicado para fazer o upload
	And selecione o arquivo rpt
	When clicar no botao Carregar rpt
	And seja redirecionado para index de Definiçoes de Relatorios /RPT/Report
	And clique nas actions relatorio ('Separações') Criar Relatorio A partir Desta Definição
	And clicar no botao Salvar relatorio
	Then seja redirecionado para index de Gerenciador de relatorio /RPT/ReportView
	And feche o navegador quando terminar

@editar_definicao_relatorio
Scenario: Editar definicao relatorio
	Given que eu tenha relatorio de nome {'Separações'}
	And clique nas actions relatorio {'Separações'} Editar Definiçao
	And seja redirecionado para tela de edicao do rpt /RPT/ReportView/EditBuilder/
	And clique na aba Colunas
	When selecionar todas as colunas possiveis
	And clicar no botao Gravar denificao editada
	Then seja redirecionado para index de Gerenciador de relatorio /RPT/ReportView
	And feche o navegador quando terminar

@executar_relatorio
Scenario: Executar Relatorio
	Given que seja clicado no botao Definicoes de Relatorios
	And seja redirecionado para index de Definiçoes de Relatorios /RPT/Report
	And seja clicado no botao carregar Definicao de Relatorio
	And seja clicado para fazer o upload
	And selecione o arquivo rpt
	And clicar no botao Carregar rpt
	And seja redirecionado para index de Definiçoes de Relatorios /RPT/Report
	And clique nas actions relatorio ('Separações') Criar Relatorio A partir Desta Definição
	And clicar no botao Salvar relatorio
	And seja redirecionado para index de Gerenciador de relatorio /RPT/ReportView
	And clique nas actions relatorio {'Separações'} Editar Definiçao
	And seja redirecionado para tela de edicao do rpt /RPT/ReportView/EditBuilder/
	And clique na aba Colunas
	And selecionar todas as colunas possiveis
	And clicar no botao Gravar denificao editada
	And seja redirecionado para index de Gerenciador de relatorio /RPT/ReportView
	And que seja clicado no menu do usuario logado
	And clique no botao Relatorios
	And seja redirecionado para Meus Relatorios /RPT/ReportView/UserReportViews
	And que eu tenha relatorio de nome {'Separações'}
	When clicar no botao executar relatorio
	And ser redirecionado para Parametros de execucao /RPT/ReportView/OpenReportView/
	And clicar no botao Executar meu relatorio
	Then o relatorio deve ser exibido em uma nova guia do navegador
	And feche o navegador quando terminar

@validar_definicao_relatorio
Scenario: Validar colunas personalizadas definicao relatorio
	Given que eu tenha relatorio de nome {'Clientes sem Vendas'}
	And clique nas actions relatorio {'Clientes sem Vendas'} Editar Definiçao
	And seja redirecionado para tela de edicao do rpt /RPT/ReportView/EditBuilder/
	And clique na aba Colunas
	And memorize as colunas marcadas do Editar Definicao
	And que seja clicado no menu do usuario logado
	And clique no botao Relatorios
	And seja redirecionado para Meus Relatorios /RPT/ReportView/UserReportViews
	And que eu tenha relatorio de nome {'Clientes sem Vendas'}
	When clicar no botao executar relatorio
	And ser redirecionado para Parametros de execucao /RPT/ReportView/OpenReportView/
	And clique na aba Colunas
	Then as colunas marcadas devem ser as mesmas do Editar Definicao
	And feche o navegador quando terminar


#@excluir_definicao_relatorio
#Scenario: Excluir definicao relatorio
#	Given que eu tenha relatorio de nome {'Separações'}
#	And clique nas actions deste relatorio Excluir
#	When confirmar clicando no botao Excluir
#	Then o relatorio deve ser excluido e {'Separações'} nao aparecer na lista



