Feature: AbrirNavegadorELogar

@abrir_sistema_login
Scenario: abrir navegador e realizar login
When o sistema rodar
And estiver na tela de login coreBusiness
And as informações de aceso forem inseridas
And o botão de logar for clicado
Then acessar a pagina inicial do hub de contexto


@abrir_sistema_login_invalido
Scenario: abrir navegador e inserir login invalido
When o sistema rodar
And estiver na tela de login coreBusiness
And as informações de aceso forem inseridas erroneamente
And o botão de logar for clicado
Then uma mensagem de Erro ao efetuar login deve aparecer

@logado_acesse_contexto
Scenario: logado e acesse o contexto
Given que eu esteja logado no sistema
When clicar para acessar o contexto {'Meus Pedidos'}
Then sistema deve redirecionar a pagina


@logado_contexto_deslogar
Scenario: logado e deslogar
Given que eu esteja logado no sistema
And clicar para acessar o contexto {'Meus Pedidos'}
When clicar para Sair do sistema
Then redireciona para tela de login do corebusiness