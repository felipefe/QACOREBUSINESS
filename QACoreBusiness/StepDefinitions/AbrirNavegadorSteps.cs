using QACoreBusiness.Util;
using System;
using TechTalk.SpecFlow;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class AbrirNavegadorSteps
    {
        AbrirNavegadorUtil abrirNavegadorUtil = new AbrirNavegadorUtil();

        [When(@"o sistema rodar")]
        public void QuandoOSistemaRodar()
        {
            abrirNavegadorUtil.IniciarNavegador();
        }

        [When(@"estiver na tela de login coreBusiness")]
        public void QuandoEstiverNaTelaDeLoginCoreBusiness()
        {
            abrirNavegadorUtil.TelaDeLogin();
        }

        [When(@"as informações de aceso forem inseridas")]
        public void QuandoAsInformacoesDeAcesoForemInseridas()
        {
            abrirNavegadorUtil.InsereDados();
        }

        [When(@"o botão de logar for clicado")]
        public void QuandoOBotaoDeLogarForClicado()
        {
            abrirNavegadorUtil.CliqueEntrarSistema();
        }

        [Then(@"acessar a pagina inicial do hub de contexto")]
        public void EntaoAcessarAPaginaInicialDoHubDeContexto()
        {
            abrirNavegadorUtil.NavegadorAberto();
        }
    }
}
