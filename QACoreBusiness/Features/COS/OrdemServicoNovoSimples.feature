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
Given que seja clicado Excluir nas actions da OS
And seja inserido no textarea uma justificativa {'Cancelamento extraordinario'}
When clicar no botao Cancelar O.S.
Then a OS deve ser excluida