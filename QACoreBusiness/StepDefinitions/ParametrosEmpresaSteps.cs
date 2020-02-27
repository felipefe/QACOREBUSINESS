using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class ParametrosEmpresaSteps
    {
        ParametrosEmpresaUtil peu = new ParametrosEmpresaUtil();
        
        [Given(@"seja redirecionado para url \{/IDFe/Empresa/}")]
        public void GivenSejaRedirecionadoParaUrlIDFeEmpresa()
        {
            peu.ValidaUrlContextoEmpresa();
        }
        
        [Given(@"clique no botao dos Parametros da Empresa")]
        public void GivenCliqueNoBotaoDosParametrosDaEmpresa()
        {
            peu.CliqueAcessoParametrosEmpresa();
        }
        
        [Given(@"seja redirecionado para url dos parametros \{/Parametro/ParametrosEmpresa/}")]
        public void GivenSejaRedirecionadoParaUrlDosParametrosParametroParametrosEmpresa()
        {
            peu.ValidaUrlParametrosEmpresa();
        }

        [Given(@"que eu clique para editar o parametro Configurações de Emissão de NF-e")]
        public void GivenQueEuCliqueParaEditarOParametroConfiguracoesDeEmissaoDeNF_E()
        {
            peu.CliqueEditarParametroNFE();
        }

        [Given(@"esteja na tela de ediçao do parametro \{'(.*)'}")]
        public void GivenEstejaNaTelaDeEdicaoDoParametro(string nomeParametro)
        {
            peu.ValidaEdicaoParametro(nomeParametro);
        }

        [When(@"selecionar \{'(.*)'}")]
        public void WhenSelecionar(string ambienteEmissao)
        {
            peu.SelecionarAmbienteEmissao(ambienteEmissao);
        }


        [When(@"clicar no botao salvar")]
        public void WhenClicarNoBotaoSalvar()
        {
            peu.CliqueSalvarParametro();
        }

        [When(@"que eu clique para editar o parametro Configurações de Emissão de NF-e")]
        public void WhenQueEuCliqueParaEditarOParametroConfiguracoesDeEmissaoDeNF_E()
        {
            peu.CliqueEditarParametroNFE();
        }
        
        [When(@"esteja na tela de ediçao do parametro \{'(.*)'}")]
        public void WhenEstejaNaTelaDeEdicaoDoParametro(string parametro)
        {
            peu.ValidaEdicaoParametro(parametro);
        }
        
        [Then(@"Ambiente de Testes ou Homologacao deve estar selecionado no select Ambiente de Emissao")]
        public void ThenAmbienteDeTestesOuHomologacaoDeveEstarSelecionadoNoSelectAmbienteDeEmissao()
        {
            peu.AmbienteHomologacaoSelecionado();
        }

        [Then(@"serei redirecionado para url dos parametros \{/Parametro/ParametrosEmpresa/}")]
        public void ThenSereiRedirecionadoParaUrlDosParametrosParametroParametrosEmpresa()
        {
            peu.ValidaUrlParametrosEmpresa();
        }

        [Then(@"a coluna valor do parametro Config\. NF-e deve ser Ambiente de Testes ou Homologaçao")]
        public void ThenAColunaValorDoParametroConfig_NF_EDeveSerAmbienteDeTestesOuHomologacao()
        {
            peu.ColunaComValorDoAmbienteEmissaoAtual();
        }



    }
}
