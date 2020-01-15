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

