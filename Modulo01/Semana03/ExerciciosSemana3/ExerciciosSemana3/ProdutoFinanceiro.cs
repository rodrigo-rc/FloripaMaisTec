using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana3
{
    internal class ProdutoFinanceiro : Produto
    {
        public ProdutoFinanceiro() { }
        
        public void Acesso()
        {
            ProdutoFinanceiro produto = new ProdutoFinanceiro();
            produto.Nome = "Celular";
            produto.Cor = "Vermelho";

            Console.WriteLine($"Produto: {produto.Nome} Cor: {produto.Cor}");

            produto.Vender();
            produto.VerificarEstoque();
            produto.AlteraAtributosPrivados(99, 100.0);
        }
    }
}
