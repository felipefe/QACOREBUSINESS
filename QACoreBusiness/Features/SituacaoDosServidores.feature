Feature: SituacaoDosServidores
	

Background: Habilitar o COREService
Given que eu esteja logado no sistema
And acesse a index de Situacao dos Servidores
And seja redirecionado para URL de situacao dos servidores


@habilitar_coreservice
Scenario: Habilitar o COREService
Given que a situacao do coreservice seja {'Stopped'}
When eu clicar para Iniciar o Serviço
Then a situacao deve ser alterada para {'Running'}

@reiniciar_coreservice
Scenario: Reiniciar o COREService
Given que a situacao do coreservice seja {'Running'}
And eu clicar para Parar o Serviço
And a situacao ser alterada para {'Stopped'}
When eu clicar para Iniciar o Serviço
Then a situacao deve ser alterada para {'Running'}


#And eu clique no botao Limpar Mensagens do COREService
#And confirme clicando sim na popup aberta
#And seja redirecionado para tela UserTask
#And o progresso de limpar hisporico seja 100%
#And clique no botao voltar
#And seja redirecionado para URL de situacao dos servidores

