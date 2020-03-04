Feature: ParametrosEmpresa
	

Background: Estar logado e acessar os parametros da empresa
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Empresas'}
And seja redirecionado para url {/IDFe/Empresa/}
And clique no botao dos Parametros da Empresa
And seja redirecionado para url dos parametros {/Parametro/ParametrosEmpresa/}


@habilitar_ambiente_homologaçao
Scenario: Habilitar ambiente de homologacao
Given que eu clique para editar o parametro Configurações de Emissão de NF-e
And esteja na tela de ediçao do parametro {'Config. NF-e'}
When selecionar {'Ambiente de Testes ou Homologação'}
And clicar no botao salvar
Then serei redirecionado para url dos parametros {/Parametro/ParametrosEmpresa/}
And a coluna valor do parametro Config. NF-e deve ser Ambiente de Testes ou Homologaçao
And feche o navegador quando terminar

@ambiente_homologacao_ja_habilitado
Scenario: Ambiente de homologacao ja habilitado
When que eu clique para editar o parametro Configurações de Emissão de NF-e
And esteja na tela de ediçao do parametro {'Config. NF-e'}
Then Ambiente de Testes ou Homologacao deve estar selecionado no select Ambiente de Emissao
And feche o navegador quando terminar