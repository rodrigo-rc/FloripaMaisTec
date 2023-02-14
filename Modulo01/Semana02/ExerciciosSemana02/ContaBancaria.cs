using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using ExerciciosSemana02.Enums;

namespace ExerciciosSemana02
{
    public class ContaBancaria
    {
        // EXERCÍCIO 3

        //Defina uma classe chamada ContaBancaria com os seguintes atributos: número, agência, nome do titular, saldo, tipo de conta.

        //Descrição:

        //O exercício consiste na criação de uma classe para criar um conta bancária.Os atributos da classe devem ser os seguintes:

        //numero;
        //agencia;
        //nome do titular;
        //saldo - deve iniciar em 0;
        //tipo de conta - deve ser um Enum com duas opções válidas: CORRENTE ou POUPANCA;


        public int numero;
        public int agencia;
        public string nomeDoTitular;
        public double saldo = 0;
        public TipoContaEnum tipoDeConta;

        //EXERCÍCIO 4

        // Crie um método dentro da classe ContaBancaria que permita fazer depósito de valores nesta conta.Pontos importantes a serem observados:

        // O valor de depósito deve ser recebido como parâmetro no método;
        // O valor a ser depositado deve ser maior do que 0;
        // Obs: este exercício é uma continuação do exercício 3. Faça ele antes de começar este.

        public void Deposito(double deposito)
        {
            if (deposito > 0)
            {
                saldo += deposito;
            }
            else
            {
                Console.WriteLine("O valor a ser depositado deve ser maior do que 0");
            }
        }

        //EXERCÍCIO 5

        // Crie um método dentro da classe ContaBancaria que permita fazer saque de valores nesta conta.Pontos importantes a serem observados:

        //O valor de saque deve ser recebido como parâmetro no método;
        //O valor a ser sacado deve ser maior do que 0;
        //O valor de saque não pode ser maior que o saldo atual da conta;

        public void Saque(double saque)
        {
            if (saque <= 0) 
            {
                Console.WriteLine("O valor a ser sacado deve ser maior do que 0");
            }
            else if (saque > saldo)
            {
                Console.WriteLine("O valor de saque não pode ser maior que o saldo atual da conta");
            }
            else
            {
                saldo -= saque;
            }
        }

        //EXERCÍCIO 6

        // Crie um método dentro da classe ContaBancaria que mostre o saldo atual da conta.

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da sua conta é de {saldo} reais");
        }
    }
}
