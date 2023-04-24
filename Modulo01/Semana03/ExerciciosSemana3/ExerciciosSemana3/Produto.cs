using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ExerciciosSemana3
{
    internal class Produto
    {
        public string Nome { get; set; }
        protected string Cor { get; set; }
        private double Peso { get; set; }
        private double Preco { get; set; }

        public Produto(string nome, string cor, double peso, double preco)
        {
            Nome = nome;
            Cor = cor;
            Peso = peso;
            Preco = preco;
        }
        public Produto()
        {

        }

        public void VerificarEstoque()
        {
            Console.WriteLine("Verificando estoque");
        }

        protected void Vender()
        {
            Console.WriteLine("Vendendo produto");
        }

        private void Descartar()
        {
            Console.WriteLine("Descartando produto");
        }

        protected void AlteraAtributosPrivados(double peso, double preco) 
        { 
            Peso = peso;
            Preco = preco;

            Console.WriteLine($"O valor da variável Peso de escopo da classe alterado para: {peso}\n"+
                              $"O valor da variável Preço de escopo da classe alterado para: {preco}"
                );
        }
    }
}
