using System;
using MVC_Console.Controllers;
namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoControllers produtos = new ProdutoControllers();
            
            produtos.Cadastrar();

            produtos.MostrarProdutos();

        }
    }
}
