Feature: ChequesProprios
	

Background: logar e acessar index contratos
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Cheques próprios'}

@lancar_cheque_proprio
Scenario: Lancar Cheque Proprio
When clicar no botao da header Novo Cheque Proprio
And selecione a empresa responsavel {'Deltacon Informática'}
And selecione o caixa recebido ('Caixa')
And informe a data de entrada do cheque em caixa
And informe a data de emissao {7} dias retroativos
And informe a data bom para {data atual}
And informe o numero do cheque
And informe o valor do cheque {150.0}
And selecione o banco {'Banco do Brasil'}
And informe alguma observaçao {'Cheque dos guri'}
And clique no botao Salvar cheque
Then valide que o cheque seja criado conforme numero informado
And o status do cheque deve ser {'Em Caixa (sob guarda)'}
And feche o navegador quando terminar


@excluir_cheque_proprio
Scenario: Excluir Cheque Proprio
When clicar no botao da header Novo Cheque Proprio
And selecione a empresa responsavel {'Deltacon Informática'}
And selecione o caixa recebido ('Caixa')
And informe a data de entrada do cheque em caixa
And informe a data de emissao {7} dias retroativos
And informe a data bom para {data atual}
And informe o numero do cheque
And informe o valor do cheque {150.0}
And selecione o banco {'Banco do Brasil'}
And informe alguma observaçao {'Cheque dos guri'}
And clique no botao Salvar cheque
Then valide que o cheque seja criado conforme numero informado
And o status do cheque deve ser {'Em Caixa (sob guarda)'}
And clique nas actions para Excluir cheque
And confirme clicando no botao Excluir
And o status do cheque deve ser {'Cancelado'}
And feche o navegador quando terminar