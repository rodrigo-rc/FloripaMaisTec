using ExerciciosSemana02;
using ExerciciosSemana02.Enums;

ContaBancaria contaBancaria = new ContaBancaria();

contaBancaria.nomeDoTitular = "Rodrigo Carlos Rodrigues";
contaBancaria.tipoDeConta = TipoContaEnum.CORRENTE;
contaBancaria.agencia = 1234;
contaBancaria.numero = 102030;

contaBancaria.Deposito(2500);


Console.WriteLine($"Titular da conta: {contaBancaria.nomeDoTitular}");

contaBancaria.ExibirSaldo();

contaBancaria.Saque(500);

contaBancaria.ExibirSaldo();
