﻿using System;
using TechTalk.SpecFlow;
using QACoreBusiness.Util;

namespace QACoreBusiness.StepDefinitions
{
    [Binding]
    public class PedidoInserirItemSteps
    {
        PedidoInserirItemUtil pii = new PedidoInserirItemUtil();

        [Given(@"que eu clique na sessao de Produtos")]
        public void GivenQueEuCliqueNaSessaoDeProdutos()
        {
            pii.CliqueSessaoProdutos();
        }
        
        [When(@"eu pesquisar no editText o produto por SKU \{'(.*)'}")]
        public void WhenEuPesquisarNoEditTextOProdutoPorSKU(string sku)
        {
            pii.PesquisarProdutoSKU(sku);
        }
        
        [When(@"informar a quantidade no editText")]
        public void WhenInformarAQuantidadeNoEditText()
        {
            pii.InformarQuantidadeItem();
        }
        
        [When(@"em seguida clicar no botao adicionar")]
        public void WhenEmSeguidaClicarNoBotaoAdicionar()
        {
            pii.CliqueAdicionarItem();
        }
        
        [When(@"eu pesquisar no editText o produto por nome \{'(.*)'}")]
        public void WhenEuPesquisarNoEditTextOProdutoPorNome(string nome)
        {
            pii.PesquisarProdutoNome(nome);
        }
        
        [Then(@"uma mensagem de item adicionado ao pedido deve aparecer")]
        public void ThenUmaMensagemDeItemAdicionadoAoPedidoDeveAparecer()
        {
            pii.MensagemItemAdicionadoSucesso();
        }
        
        [Then(@"sua tag de reserva estoque deve ser \{'(.*)'}")]
        public void ThenSuaTagDeReservaEstoqueDeveSer(string reserva)
        {
            pii.TagDeReservaEstoque(reserva);
        }
        
        [Then(@"uma mensagem de item nao adicionado ao pedido deve aparecer")]
        public void ThenUmaMensagemDeItemNaoAdicionadoAoPedidoDeveAparecer()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"uma outra mensagem com os detalhes deve aparecer")]
        public void ThenUmaOutraMensagemComOsDetalhesDeveAparecer()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
