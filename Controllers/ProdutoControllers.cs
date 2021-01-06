using System.Collections.Generic;
using MVC_Console.Model;
using MVC_Console.View;

namespace MVC_Console.Controllers
{
    public class ProdutoControllers
    {
        Produto produtoModel = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void MostrarProdutos()
        {
            List<Produto> lista = produtoModel.Ler();
            produtoView.ListarTodos(lista);
        }

        public void Cadastrar()
        {
            produtoModel.Inserir(produtoView.CadastrarProduto());
        }
        
          
        
    }
}