Feature: ChequesTerceiros

Background: logar e acessar index contratos
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Cheques de terceiros'}


@lancar_novo_cheque_terceiro
Scenario: Lancar Cheque Terceiro
When clicar no botao da header Novo Cheque de Terceiro
And selecione a empresa responsavel {'Deltacon Informática'}
And selecione a pessoa responsavel {'Valentina La Ferrugem'}
And informe a data de emissao {7} dias retroativos
And informe a data bom para {data atual}
And informe o numero do cheque
And informe o valor do cheque {160.0}
And selecione o banco {'Banco do Brasil'}
And informe alguma observaçao {'Cheque dos guri'}
And clique no botao Salvar cheque
Then valide que o cheque seja criado conforme numero informado
And o status do cheque deve ser {'Cadastrado'}
And feche o navegador quando terminar


@excluir_cheque_terceiro
Scenario: Excluir Cheque Terceiro
When clicar no botao da header Novo Cheque de Terceiro
And selecione a empresa responsavel {'Deltacon Informática'}
And selecione a pessoa responsavel {'Valentina La Ferrugem'}
And informe a data de emissao {7} dias retroativos
And informe a data bom para {data atual}
And informe o numero do cheque
And informe o valor do cheque {160.0}
And selecione o banco {'Banco do Brasil'}
And informe alguma observaçao {'Cheque dos guri'}
And clique no botao Salvar cheque
Then valide que o cheque seja criado conforme numero informado
And o status do cheque deve ser {'Cadastrado'}
And clique nas actions para Excluir cheque
And confirme clicando no botao Excluir
And valide que o cheque foi excluido
And feche o navegador quando terminar
