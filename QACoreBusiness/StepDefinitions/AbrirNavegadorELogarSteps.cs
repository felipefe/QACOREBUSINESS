using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class AbrirNavegadorELogarSteps
    {
        AbrirNavegadorUtil open = new AbrirNavegadorUtil();

        [When(@"o sistema rodar")]
        public void WhenOSistemaRodar()
        {
            open.IniciarNavegador();
        }
        
        [When(@"estiver na tela de login coreBusiness")]
        public void WhenEstiverNaTelaDeLoginCoreBusiness()
        {
            open.TelaDeLogin();
        }
        
        [When(@"as informações de aceso forem inseridas")]
        public void WhenAsInformacoesDeAcesoForemInseridas()
        {
            open.InsereDados();
        }
        
        [When(@"o botão de logar for clicado")]
        public void WhenOBotaoDeLogarForClicado()
        {
            open.CliqueEntrarSistema();
        }
        
        [When(@"as informações de aceso forem inseridas erroneamente")]
        public void WhenAsInformacoesDeAcesoForemInseridasErroneamente()
        {
            open.InsereDadosInvalidos();
        }
        
        [Then(@"acessar a pagina inicial do hub de contexto")]
        public void ThenAcessarAPaginaInicialDoHubDeContexto()
        {
            open.PaginaInicialCoreBusiness();
        }
        
        [Then(@"uma mensagem de Erro ao efetuar login deve aparecer")]
        public void ThenUmaMensagemDeErroAoEfetuarLoginDeveAparecer()
        {
            open.MensagemLoginInvalido();
        }
    }
}
