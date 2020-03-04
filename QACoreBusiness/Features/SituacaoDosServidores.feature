Feature: SituacaoDosServidores
	

Background: Habilitar o COREService
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Situação dos Servidores'}
And seja redirecionado para URL de situacao dos servidores


@habilitar_coreservice
Scenario: Habilitar o COREService
Given que a situacao do coreservice seja {'Stopped'}
When eu clicar para Iniciar o Serviço
Then a situacao deve ser alterada para {'Running'}
And feche o navegador quando terminar

@reiniciar_coreservice
Scenario: Reiniciar o COREService
Given que a situacao do coreservice seja {'Running'}
And eu clicar para Parar o Serviço
And a situacao ser alterada para {'Stopped'}
When eu clicar para Iniciar o Serviço
Then a situacao deve ser alterada para {'Running'}
And feche o navegador quando terminar

@limpar_mensagens_coreservice
Scenario: Limpar mensagens COREService
When clicar no botao Limpar Mensagens do COREService
And confirme clicando sim na modal aberta
And seja redirecionado para tela UserTask
And aguarde ate progresso de limpar hisporico seja concluido
Then clique no botao voltar
And seja redirecionado para URL de situacao dos servidores
And feche o navegador quando terminar

